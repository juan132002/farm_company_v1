using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farm_company_v1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Empresa empresa = new Empresa();

            Farmer f1 = new Farmer();
            f1.Name = "Juan";
            f1.Stratum = 2;
            f1.Gender = "M";
            empresa.AddFarmer(f1);


            Farmer f2 = new Farmer();
            f2.Name = "David";
            f2.Stratum = 3;
            f2.Gender = "M";
            empresa.AddFarmer(f2);

            Farmer f3 = new Farmer();
            f3.Name = "Maria";
            f3.Stratum = 1;
            f3.Gender = "F";
            empresa.AddFarmer(f3);

            Farmer f4 = new Farmer();
            f4.Name = "Sofia";
            f4.Stratum = 3;
            f4.Gender = "F";
            empresa.AddFarmer(f4);

            Farmer f5 = new Farmer();
            f5.Name = "Manuel";
            f5.Stratum = 3;
            f5.Gender = "M";
            empresa.AddFarmer(f5);

            Product p1 = new Product();
            p1.Name = "zanahoria";
            p1.UnitPrice = 5000;
            p1.UnitPerKilometer = 50;
            p1.TaxUnitPerUnitPercentage = 15;
            empresa.AddProduct(p1);


            Product p2 = new Product();
            p2.Name = "espinacas";
            p2.UnitPrice = 7000;
            p2.UnitPerKilometer = 20;
            p2.TaxUnitPerUnitPercentage = 15;
            empresa.AddProduct(p2);


            Product p3 = new Product();
            p3.Name = "tomates";
            p3.UnitPrice = 9000;
            p3.UnitPerKilometer = 70;
            p3.TaxUnitPerUnitPercentage = 15;
            empresa.AddProduct(p3);


            Product p4 = new Product();
            p4.Name = "maiz";
            p4.UnitPrice = 10000;
            p4.UnitPerKilometer = 60;
            p4.TaxUnitPerUnitPercentage = 15;
            empresa.AddProduct(p4);


            Product p5 = new Product();
            p5.Name = "papas";
            p5.UnitPrice = 6000;
            p5.UnitPerKilometer = 40;
            p5.TaxUnitPerUnitPercentage = 15;
            empresa.AddProduct(p5);


            Product p6 = new Product();
            p6.Name = "yuca";
            p6.UnitPrice = 20000;
            p6.UnitPerKilometer = 500;
            p6.TaxUnitPerUnitPercentage = 15;
            empresa.AddProduct(p6);


            Product p7 = new Product();
            p7.Name = "frijol";
            p7.UnitPrice = 3000;
            p7.UnitPerKilometer = 30;
            p7.TaxUnitPerUnitPercentage = 15;
            empresa.AddProduct(p7);

            Crop c1 = new Crop();
            c1.Farmer = f1;
            c1.Product = p7;
            c1.extension = 7;

            Crop c2 = new Crop();
            c2.Farmer = f2;
            c2.Product = p5;
            c2.extension = 5;

            Crop c3 = new Crop();
            c3.Farmer = f3;
            c3.Product = p3;
            c3.extension = 3;

            Crop c4 = new Crop();
            c4.Farmer = f4;
            c4.Product = p1;
            c4.extension = 1;

            Crop c5 = new Crop();
            c5.Farmer = f5;
            c5.Product = p4;
            c5.extension = 4;







            if (c1.Farmer.Gender.Equals("M"))
            {

                double operacion1 = 15 / 100;
                double operacion2 = operacion1 * 15;
                double operacion3 = operacion2 - 15;
                double produccion = c1.extension * c1.Product.UnitPerKilometer;
                double total = operacion3 * produccion;

                Console.WriteLine("el total de produccion es : {0}", total);


            }
            if (c2.Farmer.Gender.Equals("M"))
            {

                double operacion1 = 15 / 100;
                double operacion2 = operacion1 * 15;
                double operacion3 = operacion2 - 15;
                double produccion = c2.extension * c2.Product.UnitPerKilometer;
                double total = operacion3 * produccion;

                Console.WriteLine("el total de produccion es : {0}", total);


            }
            if (c3.Farmer.Gender.Equals("F"))
            {

                double operacion1 = 7.5 / 100;
                double operacion2 = operacion1 * 7.5;
                double operacion3 = operacion2 - 7.5;
                double produccion = c3.extension * c3.Product.UnitPerKilometer;
                double total = operacion3 * produccion;

                Console.WriteLine("el total de produccion es : {0}", total);


            }
            if (c4.Farmer.Gender.Equals("F"))
            {

                double operacion1 = 7.5 / 100;
                double operacion2 = operacion1 * 7.5;
                double operacion3 = operacion2 - 7.5;
                double produccion = c3.extension * c3.Product.UnitPerKilometer;
                double total = operacion3 * produccion;

                Console.WriteLine("el total de produccion es : {0}", total);


            }
            if (c5.Farmer.Gender.Equals("F"))
            {

                double operacion1 = 15 / 100;
                double operacion2 = operacion1 * 15;
                double operacion3 = operacion2 - 15;
                double produccion = c5.extension * c5.Product.UnitPerKilometer;
                double total = operacion3 * produccion;

                Console.WriteLine("el total de produccion es : {0}", total);


            }









            Console.ReadKey();
           
           

        }
    }
}
