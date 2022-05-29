using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public class B_Product
    {
        public static List<Products> products()
        {
            using (var db = new ProjectContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(Products oProduct)
        {
            using (var db = new ProjectContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }
        public static void UpdateProduct(Products oProduct)
        {
            using(var db = new ProjectContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
