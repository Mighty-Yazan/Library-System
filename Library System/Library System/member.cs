using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal abstract class Member
    {
        internal string name;
        internal int ID;

        public Member(string n, int ID) // Constructor
        {
                name = n;
                this.ID = ID;
        }

        public void info()
        {
            Console.WriteLine($"Name: {name}\nID: {ID}");
        }

        public abstract void CalculateLateFee(Member m, Book book, int daysLate);
    }
}