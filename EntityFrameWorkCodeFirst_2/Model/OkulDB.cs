using EntityFrameWorkCodeFirst_2.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameWorkCodeFirst_2.Model
{
    public class OkulDB : DbContext
    {
        // Your context has been configured to use a 'OkulDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityFrameWorkCodeFirst_2.Model.OkulDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OkulDB' 
        // connection string in the application configuration file.
        public OkulDB(): base("name=OkulDB")
        {
        }

        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Ogretmen> Ogretmenler { get; set; }
        public virtual DbSet<Ders> Dersler { get; set; }
        public virtual DbSet<Veli> Veliler { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}