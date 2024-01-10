using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Objects
{
    class Member
    {
        public string name;
        public string address;
        public string phoneNo;
        public int age;
    }

    internal class Book
    {
        public string title;
        public string author;
        public int pages;
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "Jk Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Member firstMember = new Member();
            firstMember.name = "Arthur";
            firstMember.address = "Jhb 2000";
            firstMember.phoneNo = "0710255562";
            firstMember.age = 25;


            Console.WriteLine("The first member name is " + firstMember.name);
            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);
            Console.Read();
        }
    }
}
