using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productmanagement
{
    public interface Inproduct
    {
        public bool addproduct(product product);
        
        public bool updateproduct(product product);

        List<product> GetAllproduct();

        public bool deleteproduct(int id);
    }
}
