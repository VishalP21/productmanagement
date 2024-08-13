using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productmanagement
{
    public class productmath : Inproduct
    {
        productdatabase productdatabase = new productdatabase();
        public bool addproduct(product product)
        {
           productdatabase.products.Add(product);
            int v = productdatabase.SaveChanges();
            if (v > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool deleteproduct(int id)
        {
           var m =  productdatabase.products.Where(y => y.id == id).FirstOrDefault();
            productdatabase.products.Remove(m);
            int d = productdatabase.SaveChanges();
            if (d > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<product> GetAllproduct()
        {
            var products = productdatabase.products.ToList();
            return products;
        }

        public bool updateproduct(product product) 
        {
            var n = productdatabase.products.Where(y => y.id == product.id).FirstOrDefault();
            n.productname = product.productname;
            n.price = product.price;
            int v = productdatabase.SaveChanges();
            if (v > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
