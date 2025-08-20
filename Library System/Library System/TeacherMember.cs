using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class TeacherMember : Member , IBorrowable
    {
        public TeacherMember(string n, int ID) : base(n, ID)
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
            Console.WriteLine($"{m.name} returned \"{book.getTitle()}\" {daysLate} late day/s, so your fee will be: {Math.Round(daysLate * 0.2, 2)}JD !"); // we put the round method 'cuz the answer is #.#000000000001
        }
    }
}
