using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class StudentMember : Member, IBorrowable
    {
        public StudentMember(string n, int ID) : base(n, ID)
        {

        }

        public void BorrowBook(Book book)
        {
            book.borrow();
        }

        public void ReturnBook(Book book)
        {
            book.Return();
        }

        public override void CalculateLateFee(Member m, Book book, int daysLate)
        {
            Console.WriteLine($"{m.name} returned \"{book.getTitle()}\" {daysLate} late day/s, so your fee will be: {daysLate * 0.5}JD !");
        }
    }
}
