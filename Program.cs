using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Group_asm;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.menu();

        }
        public void menu()
        {
            while (true)
            {
                Console.WriteLine("==========Nhap so============");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Edit Product");
                Console.WriteLine("3.Delete Product");
                Console.WriteLine("4.View All Product");
                Console.WriteLine("5.Seach Product By ID");
                Console.WriteLine("6.Seach product By Name");
                Console.WriteLine("7.The End");
            }
            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        Addproduct();
                        break;
                    case 2:
                        UpdateProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        ViewAllProduct();
                        break;
                    case 5:
                        SearchProductByID();
                        break;
                    case 6:
                        SearchProductByName();
                        break;
                    case 7:
                        TheEnd();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("vui long nhap lai" + ex.Message);
            }
        }

        public void DeleteProduct()
        {
            Console.WriteLine("----------------- Delete Product ------------------");
            Console.WriteLine("Enter product id : ");
            int id = int.Parse(Console.ReadLine());
            model.DeleteProduct(id);
        }
        public void ViewAllProduct()
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            List<Product> products = model.ShowAll();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0}  :  {1}  :    {2}", products[i].proName, products[i].proDesc, products[i].price);
            }
            time.Stop();
            Console.WriteLine("------------------- Show ALL With List --------------------------");
            Console.WriteLine("Run For : " + time.ElapsedMilliseconds + " ms");
        }
       
    }
    
}