using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.IO;

namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
           
          

            JsonSerializerOptions options = new JsonSerializerOptions

            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
              WriteIndented = true

            };
            string[,] product = new string[5, 3];

            Console.WriteLine("Введите наименование товара");
            product[0, 0] = Console.ReadLine();
            Console.WriteLine("Введите код товара");
            product[0, 1] = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            product[0, 2] = Console.ReadLine();
            Console.WriteLine("Введите наименование второго товара");
            product[1, 0] = Console.ReadLine();
            Console.WriteLine("Введите код второго товара");
            product[1, 1] = Console.ReadLine();
            Console.WriteLine("Введите цену второго товара");
            product[1, 2] = Console.ReadLine();
            Console.WriteLine("Введите наименование третьего товара");
            product[2, 0] = Console.ReadLine();
            Console.WriteLine("Введите код третьего товара");
            product[2, 1] = Console.ReadLine();
            Console.WriteLine("Введите цену третьего товара");
            product[2, 2] = Console.ReadLine();
            Console.WriteLine("Введите наименование четвертого товара");
            product[3, 0] = Console.ReadLine();
            Console.WriteLine("Введите код четвертого товара");
            product[3, 1] = Console.ReadLine();
            Console.WriteLine("Введите цену четвертого товара");
            product[3, 2] = Console.ReadLine();
            Console.WriteLine("Введите наименование пятого товара");
            product[4, 0] = Console.ReadLine();
            Console.WriteLine("Введите код пятого товара");
            product[4, 1] = Console.ReadLine();
            Console.WriteLine("Введите цену пятого товара");
            product[4, 2] = Console.ReadLine();

         

                Product product1 = new Product()
                 {
                    NameProduct = product[0, 0],
                    CodeProduct = Convert.ToInt32(product[0, 1]),
                    PriceProduct = Convert.ToDouble(product[0, 2])


                };

            string jsonString1 = JsonSerializer.Serialize(product1, options);
            Console.WriteLine(jsonString1);
            Console.ReadKey();
            Product product2 = new Product()
            {
                NameProduct = product[1, 0],
                CodeProduct = Convert.ToInt32(product[1, 1]),
                PriceProduct = Convert.ToDouble(product[1, 2])


            };
            string jsonString2 = JsonSerializer.Serialize(product2, options);
            Console.WriteLine(jsonString2);
            Console.ReadKey();

            Product product3 = new Product()
            {
                NameProduct = product[2, 0],
                CodeProduct = Convert.ToInt32(product[2, 1]),
                PriceProduct = Convert.ToDouble(product[2, 2])


            };

            string jsonString3 = JsonSerializer.Serialize(product3, options);
            Console.WriteLine(jsonString3);
            Console.ReadKey();
            Product product4 = new Product()
            {
                NameProduct = product[3, 0],
                CodeProduct = Convert.ToInt32(product[3, 1]),
                PriceProduct = Convert.ToDouble(product[3, 2])


            };

            string jsonString4 = JsonSerializer.Serialize(product4, options);
            Console.WriteLine(jsonString4);
            Console.ReadKey();

            Product product5 = new Product()
            {
                NameProduct = product[4, 0],
                CodeProduct = Convert.ToInt32(product[4, 1]),
                PriceProduct = Convert.ToDouble(product[4, 2])


            };

            string jsonString5 = JsonSerializer.Serialize(product5, options);
            Console.WriteLine(jsonString5);
            Console.ReadKey();

            string path = "Json";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string path2 = "Json/Products.json";
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                sw.WriteLine(jsonString1);
            }
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                sw.WriteLine(jsonString2);
            }
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                sw.WriteLine(jsonString3);
            }
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                sw.WriteLine(jsonString4);
            }
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                sw.WriteLine(jsonString5);
            }

            Product jsonproduct1 = JsonSerializer.Deserialize<Product>(jsonString1);
            Product jsonproduct2 = JsonSerializer.Deserialize<Product>(jsonString2);
            Product jsonproduct3 = JsonSerializer.Deserialize<Product>(jsonString3);
            Product jsonproduct4 = JsonSerializer.Deserialize<Product>(jsonString4);
            Product jsonproduct5 = JsonSerializer.Deserialize<Product>(jsonString5);


            Console.ReadKey();
         
           



        }

    }

    class Product
    {
        
        [JsonPropertyName("codeProduct")]
        public int CodeProduct { get; set; }
      
        [JsonPropertyName("nameProduct")]

        public string NameProduct { get; set; }
       
        [JsonPropertyName("priceProduct")]

        public double PriceProduct { get; set; }

       
    }
}
