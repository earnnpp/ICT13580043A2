using System;
using System.Collections.Generic;
using System.Linq;
using ICT13580043A2.Models;
using SQLite;
namespace ICT13580043A2.Helpers
{
    public class dbhelper
    {

        SQLiteConnection db;

        public dbhelper(String dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<product>();
        }

        public int AddProuct(product product)
        {
            db.Insert(product);
            return product.Id;

        }

        public List<product> Getproduct(){

            return db.Table<product>().ToList();
        }
    
        public int UpdateProduct (product product){
            return db.Update(product);
        }
		public int DeleteProduct(product product)
		{
            return db.Delete(product);
		}
    
    }
}
