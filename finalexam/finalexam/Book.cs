using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    //     შექმენით შემდეგი მემკვიდრე კლასები: 
//[წიგნი] (დასახელება, ავტორი, გამოცემის წელი, გამომცემლობა, გვერდების რაოდენობა);
    public class Book : Gamocema 
    {
        public string Publisher {  get; set; }
        public int Pages { get; set; }

        public Book(string name,string author, int publicationYear, string publisher,int pages)
        : base(name, author,publicationYear)
        {
            Publisher = publisher;
            Pages = pages;
        }
        public override void printDetails()
        {
            base.printDetails();
            Console.WriteLine($"Publisher:{Publisher},Pages : {Pages}");
        }
    }
}
