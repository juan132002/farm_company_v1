using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farm_company_v1
{
    public class Empresa
    {
        public Farmer[] Farmers = new Farmer[20];
        int farmerCount = 0;

        public Product[] Products = new Product[20];
        int productCount = 0;

        


        public void AddFarmer(Farmer farmer)
        {
            Farmers[farmerCount] = farmer;
            farmerCount++;
        }

        public void AddProduct(Product product)
        {
            Products[productCount] = product;
            productCount++;
        }


     




    }
}
