﻿namespace AnimalAdoptionCenter.Services.Repositories;
using AnimalAdoptionCenter.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public interface IRepository
{
    //Animal
    IEnumerable<Animal> GetAnimals();
    IEnumerable<Animal> GetPopularAnimals(int num);
    IEnumerable<Animal> GetPopularAnimals();
    IEnumerable<Animal> GetAdoptableAnimals();
    Animal GetAnimalById(int id);
    Animal GetAnimalByName(string name);
    void InsertAnimal(Animal animal);
    void UpdateAnimal(int id, Animal animal);
    void DeleteAnimal(Animal animal);
    //Category
    IEnumerable<Category> GetCategories();
    IEnumerable<Category> GetHomeCategories();
    Category GetCategoryById(int id);
    Category GetCategoryByName(string name);
    void InsertCategory(Category category);
    void UpdateCategory(int id, Category category);
    void DeleteCategory(Category category);
    //City
    IEnumerable<City> GetCities();
    City GetCityById(int id);
    void InsertCity(City city);
    void UpdateCity(int id, City city);
    void DeleteCity(City city);
    //Customer
    IEnumerable<Customer> GetCustomers();
    void InsertCustomer(Customer customer);
    void UpdateCustomer(int id, Customer customer);
    void DeleteCustomer(Customer customer);
    //Comment
    IEnumerable<Comment> GetComments();
    Comment GetCommentById(int id);
    void InsertComment(Comment comment, Animal animal);
    void UpdateComment(int id, Comment comment);
    void DeleteComment(Comment comment);
}
