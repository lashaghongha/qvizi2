using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    //    შექმენით შემდეგი მემკვიდრე კლასები: 
//[სტატია] (დასახელება, ავტორი, ჟურნალის დასახელება, ნომერი და გამოცემის წელი, გვერდების რაოდენობა);
    public class Article : Gamocema  //statia
    {
        public string JournalName { get; set; }
        public int IssueNumber {  get; set; }
        public int Pages {  get; set; }


        public Article(string name,string author,string journalName, int issueNumber,int publicationYear,int pages )
        :  base(name,author,publicationYear)
        {
            JournalName = journalName;
            IssueNumber = issueNumber;
            Pages = pages;
        }
        public override void printDetails()
        {
            base.printDetails();
            Console.WriteLine($"Journal:{JournalName}, IssueNumber:{IssueNumber}, Pages:{Pages}");
        }
    }
}
