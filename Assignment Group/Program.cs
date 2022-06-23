using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Demo.Coffee
{
    internal class Program
    {
        ConnectionDb connectionDb = new ConnectionDb();
        private static string name;

        public static int Id { get; private set; }

        public static void Main(string[] args)
        {

            while (true)
            {
                Menu();

                Console.WriteLine(":");
                string s = Console.ReadLine();
                if (s == "N")
                    break;

            }
            Console.WriteLine("Exit!");
            Console.ReadLine();
        }



        static void Menu()
        {
            Console.WriteLine("\t\t\t------------------Actions--------------------\n\n");
            Console.WriteLine("1: AddProduct");
            Console.WriteLine("2: EditProduct");
            Console.WriteLine("3: DeleteProduct");
            Console.WriteLine("4: ViewAllProduct");
            Console.WriteLine("5: SearchProductById");
            Console.WriteLine("6: SearchProductByName");
            Console.WriteLine("7: End");

            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        ViewAllProduct();
                        break;
                    case 5:
                        SearchProductById();
                        break;
                    case 6:
                        SearchProductByName();
                        break;
                    case 7:
                        End();
                        break;
                    default:
                        Console.WriteLine("thanh cong");
                        break;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("vui long chon lai : " + ex.Message);
            }
        }


        private static void GetData()
        {
            throw new NotImplementedException();
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "SELECT * FROM product";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Product name: " + reader[1] + "desc:" + reader[2]);
            }
            conn.Close();
        }

        private static void AddProduct()
        {
            throw new NotImplementedException();

        }

        private static void EditProduct()
        {
            throw new NotImplementedException();

        }

        private static void DeleteProduct()
        {
            throw new NotImplementedException();

        }
        private static void SearchProductById()
        {
            throw new NotImplementedException();
            Stopwatch time = new Stopwatch();
            time.Start();
            List<Product> productList = ShowAll();
            var fint = productList.Find(p =>
            {
                return p.Id == Id;
            });


            if (fint == null)
            {
                Console.WriteLine("ID {0} Not found ! ", Id);
            }
            else
            {
                Console.WriteLine("Product Name : {0}\nProduct Description : {1}\nProduct Price : {2}", fint.proName, fint.proDesc, fint.price);
            }
            time.Stop();
            Console.WriteLine("----------------------- list search by id-------------------");
            Console.WriteLine("Run for : " + time.ElapsedMilliseconds + " ms");

        }

    

        private static void SearchProductByName()
        {
            throw new NotImplementedException();
            Stopwatch time = new Stopwatch();
            time.Start();
            List<Product> productList = ShowAll();
            var findAll = productList.FindAll(p =>
            {
                return p.proName == name;
            });


            if (findAll == null)
            {
                Console.WriteLine("Name {0} Not found ! ", name);
            }
            else
            {
                int count = 0;
                foreach (var item in findAll)
                {
                    Console.WriteLine("-------------------------------- index : {0} --------------------------------", count++);
                    Console.WriteLine("Product Name : {0}\nProduct Description : {1}\nProduct Price : {2}", item.proName, item.proDesc, item.price);

                }

            }
            time.Stop();

            Console.WriteLine("run for : " + time.ElapsedMilliseconds + " ms");

        }

        private static List<Product> ShowAll()
        {
            throw new NotImplementedException();
        }

        private static void End()
        {
            throw new NotImplementedException();
        }

        private static void ViewAllProduct()
        {
            throw new NotImplementedException();
        }
    }
}
