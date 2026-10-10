using System;

class Book
{
    string _title;
    string _author;
    string _pages;

     void DisplayInfo()
    {
        Console.WriteLine($"{_title} {_author} {_pages}");
    }

}