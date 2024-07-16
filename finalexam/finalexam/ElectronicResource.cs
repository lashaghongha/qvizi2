using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    // შექმენით შემდეგი მემკვიდრე კლასები: 
//[ელექტრონული რესურსი] (დასახელება, ავტორი, ბმული, ანოტაცია).
    public class ElectronicResource : Gamocema
    {
        public string Link {  get; set; }
        public string Annotation { get; set; }

        public ElectronicResource(string name,string author, string link,string annotation) : base(name,author, DateTime.Now.Year)
        {
            Link = link;
            Annotation = annotation;
        }
        public override void printDetails()
        {
            base.printDetails();
            Console.WriteLine($"Link {Link},Annotation: {Annotation}");
        }
    }
}
