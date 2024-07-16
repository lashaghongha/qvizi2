using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    //3.     მთავარ პროგრამაში შექმენით მშობელი კლასის ობიექტების n ელემენტებიანი მასივი. შეავსეთ ინფორმაცია.
    public class Program
    {
        public static void Main()
        {
            List<Gamocema> gamocemebi = new List<Gamocema>
            {
                new Book("c# PRograming","John Doe", 2021,"Tech Books",500),
                new Article("AI Research","Jane Smith","Tech Journal", 12,2024,15),
                new ElectronicResource("Learning C#", "Mark Johnson", "https://example.com", "A comprehensive guide to C# programming.")
            };

            // 4. გამოიტანეთ ეკრანზე ინფორმაცია ყველა გამოცემის შესახებ
            Console.WriteLine("All Gamomcemebi:");
            foreach (var gamocema in gamocemebi)
            {
                gamocema.printDetails();
                Console.WriteLine();
            }


            // 5. ძიების მექანიზმი მიმდინარე წლის გამოცემების შესახებ
            //5.     აამუშავეთ ძიების მექანიზმი ისე, რომ ეკრანზე გამოვიდეს ინფორმაცია მიმდინარე წელს გამოქვეყნებული გამოცემების შესახებ.
            int currentYear = DateTime.Now.Year;
            Console.WriteLine($"gamocemebi from tghe current year({currentYear}):");
            foreach (var gamocema in gamocemebi)
            {
                if(gamocema.SearchByYear(currentYear))
                {
                    gamocema.printDetails();
                    Console.WriteLine();
                }
            }

        }

    }
}



//პრაქტიკული სამუშაო:
//1.შექმენით მშობელი კლასი[გამოცემა] შემდეგი ველებითა და მეთოდებით:
//ველები: დასახელება, ავტორი, გამოცემის წელი;
//მეთოდები: დეტალური ინფორმაციის ბეჭდვის ფუნქცია; ძებნა თარიღით;
//2.შექმენით შემდეგი მემკვიდრე კლასები: 
//[წიგნი] (დასახელება, ავტორი, გამოცემის წელი, გამომცემლობა, გვერდების რაოდენობა);
//[სტატია] (დასახელება, ავტორი, ჟურნალის დასახელება, ნომერი და გამოცემის წელი, გვერდების რაოდენობა);
//[ელექტრონული რესურსი] (დასახელება, ავტორი, ბმული, ანოტაცია).
//3.მთავარ პროგრამაში შექმენით მშობელი კლასის ობიექტების n ელემენტებიანი მასივი. შეავსეთ ინფორმაცია.
//4.     გამოიტანეთ ეკრანზე ინფორმაცია ყველა გამოცემის შესახებ;
//5.აამუშავეთ ძიების მექანიზმი ისე, რომ ეკრანზე გამოვიდეს ინფორმაცია მიმდინარე წელს გამოქვეყნებული გამოცემების შესახებ.
