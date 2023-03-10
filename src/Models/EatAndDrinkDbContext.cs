﻿using Microsoft.EntityFrameworkCore;

namespace EatAndDrink.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class EatAndDrinkDbContext : DbContext
    {
        // TODO: Нужно обновить строку подключения
        // Вместо <сервер> указываем имя сервера SQL Server Expres
        // Вместо <пароль> указываем пароль созданный при установке SQL Server Expres
        private readonly String _connectionString = "Data Source=LAPTOP-J753BN4M\\SQLEXPRESS;Initial Catalog=EatAndDrinkDB;Persist Security Info=True;TrustServerCertificate=True;Encrypt=False;User ID = sa;Password=123;";
        public DbSet<Person> Persons { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restorant> Restorants { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(_connectionString);
    }
}
