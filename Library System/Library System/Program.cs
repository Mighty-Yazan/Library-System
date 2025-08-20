using Library_System;

Book b1 = new Book("AntiChrist", "Ahmed Mustafa");
Book b2 = new Book("Rihlati min al Shak ela al Iman", "Mustafa Mahmoud");

StudentMember s1 = new StudentMember("Yazan", 123);
TeacherMember t1 = new TeacherMember("Jacob", 1);

b1.info();

s1.BorrowBook(b1);
t1.BorrowBook(b1); // Just to make sure that the book is taken by another person
s1.ReturnBook(b1);
t1.BorrowBook(b1); // As we see he can take the book because the first user returned it

s1.CalculateLateFee(s1, b1, 4);
t1.CalculateLateFee(t1, b1, 4);