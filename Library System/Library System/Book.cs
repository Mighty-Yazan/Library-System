using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class Book
    {
        private string title;
        private string author;
        private bool isBorrowed;

        public void setTitle(string t)
        {
            title = t;
        }
        public string getTitle()
        {
            return title;
        }
        public void setAuthor(string a)
        {
            author = a;
        }
        public string getAuthor()
        {
            return author;
        }
        public bool getIsBoolean() // There is no setIsBoolean() because it's read-only
        { 
            return isBorrowed; 
        }

        public void borrow()
        {
            if (isBorrowed)
            {
                Console.WriteLine($"\"{title}\" is already taken!");
            }
            else
            {
                Console.WriteLine($"You have borrowed \"{title}\"!");
                isBorrowed = true;
            }
        }
        public void Return() 
        {
            if (isBorrowed)
            {
                Console.WriteLine($"You have returned \"{title}\"!");
                isBorrowed = false;
            }
            else
            {
                Console.WriteLine($"You don't even have \"{getTitle()}\" yet");
            }
        }

        public Book (String t, string a) // Constructor
        {
            title = t;
            author = a;
            isBorrowed = false;
        }

        public void info()
        {
            Console.WriteLine($"{getTitle()} written by: {getAuthor()}");
        }
    }
}
