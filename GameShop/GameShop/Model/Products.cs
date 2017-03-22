using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string des { get; set; }
        public double price { get; set; }
        public int sale { get; set; }
        public DateTime publishDate { get; set; }
        public int rating { get; set; }
        public Categories categories { get; set; }
        public Suppliers suppliers { get; set; }

        public Products()
        {
            
        }

        public Products(int id, string name, string des, double price, int sale, DateTime publishDate, int rating, Categories categories, Suppliers suppliers)
        {
            this.id = id;
            this.name = name;
            this.des = des;
            this.price = price;
            this.sale = sale;
            this.publishDate = publishDate;
            this.rating = rating;
            this.categories = categories;
            this.suppliers = suppliers;
        }

    }
}
