﻿using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services.GeneralServices;
using Microsoft.AspNetCore.Mvc;
using static System.Linq.IQueryable;

namespace AnimalAdoptionCenter.Controllers
{
    public class CatalogController : Controller
    {
        IRepository data;
        ISearchService search;
        public CatalogController(IRepository data, ISearchService search)
        {
            this.data = data;
            this.search = search;
        }
        public IActionResult Index()
        {
            return View(GetAnimals());
        }

        [HttpGet]
        public IActionResult Index(string userSearching)
        {
            ViewBag.UserSearching = userSearching;
            IEnumerable<Animal> list;
            if (IsValid(userSearching))
                list = SearchAnimals(userSearching).AsParallel();
            else
                list = GetAnimals();
            return View(list);
        }

        ///////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        bool IsValid(string str) => !String.IsNullOrEmpty(str);
        IEnumerable<Animal> GetAnimals() => data.GetAnimals();
        IEnumerable<Animal> SearchAnimals(string searchInput) => search.GetAll(searchInput);

    }
}