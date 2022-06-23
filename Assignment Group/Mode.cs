using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Demo.Coffee
{
    internal class Mode
    {
        SqlConnection connection = new ConnectionDb().GetConnection();
        //show all product
        public List<Product> ShowAll()
        {
            

            List<Product> listProduct = new List<Product>();

            string query = "select * from product";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                string proName = Convert.ToString(reader[1]);
                string proDesc = Convert.ToString(reader[2]);
                double price = Convert.ToDouble(reader[3]);
                listProduct.Add(new Product(id, proName, proDesc, price));
            }

            connection.Close();
            return listProduct;
            listProduct.Clear();
        }

        //Search product by id
        public void SearchProductByID(int id)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            List<Product> productList = ShowAll();
            var fint = productList.Find(p =>
            {
                return p.Id == id;
            });


            if (fint == null)
            {
                Console.WriteLine("ID {0} Not found ! ", id);
            }
            else
            {
                Console.WriteLine("Product Name : {0}\nProduct Description : {1}\nProduct Price : {2}", fint.proName, fint.proDesc, fint.price);
            }
            time.Stop();
            Console.WriteLine("----------------------- list search by id-------------------");
            Console.WriteLine("Run for : " + time.ElapsedMilliseconds + " ms");

        }


        // search product by name
        public void SearchProductByName(string name)
        {
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
    }
}
