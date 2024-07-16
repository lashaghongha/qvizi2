using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    public class Gamocema
//შექმენით მშობელი კლასი[გამოცემა] შემდეგი ველებითა და მეთოდებით:
//ველები: დასახელება, ავტორი, გამოცემის წელი;
//მეთოდები: დეტალური ინფორმაციის ბეჭდვის ფუნქცია; ძებნა თარიღით;
    {
       public string Name { get; set; }

       public string Author {  get; set; }

       public int PublicationYear {  get; set; }


        public Gamocema(string name, string author, int publicationYear)
        {
            Name = name;
            Author = author;
            PublicationYear = publicationYear;
        }

        public virtual void printDetails()
        {
            Console.WriteLine($"Name:{Name}, Author:{Author}, PublicationYear:{PublicationYear}");
        }
        public virtual bool SearchByYear(int year)
        {
            return PublicationYear == year;
        }
    }

}
