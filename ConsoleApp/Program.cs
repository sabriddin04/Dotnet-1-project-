
using System.Net;
using System.Runtime.InteropServices;
using Domain.Models;
using Infrastructure.Services;

var BookServices = new BookServices();
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>||<S>|<S>|<S>|<S>|<S>||<S>|<S>|<S>|<S>| Enter yours instructions : |<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>||<S>|<S>|<S>|<S>|<S>|<S>|<S>|");
System.Console.WriteLine("|<--------------------> Display");
System.Console.WriteLine("|<--------------------> Delete");
System.Console.WriteLine("|<--------------------> Update");
System.Console.WriteLine("|<--------------------> Add");
System.Console.WriteLine("|<--------------------> Exist");
System.Console.WriteLine("|<--------------------> SearchtoAuthor");

while (true)
{
    System.Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    string a = Console.ReadLine();

    switch (a)
    {

        case "SearchtoAuthor":
        case "searchtoauthor":

            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            System.Console.WriteLine("ENTER BOOK'S Author which you want to find:");
            string author = Console.ReadLine();

            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("|–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––|");
            System.Console.WriteLine("|                                                             TABLE OF BOOKS                                                              |");
            System.Console.WriteLine("|–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––|");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("|  id  | \t\ttitle\t\t\t  |     author\t\t  |    ISBN    |    Date Of Print   |       Janr      |  Dostup   |");
            foreach (var item in BookServices.SearchToAuthor(author))
            {
                System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                if (item.Id <= 9) System.Console.Write($"|   {item.Id}  |");
                else if (item.Id > 9 && item.Id < 100) System.Console.Write($"|  {item.Id}  |");
                else System.Console.Write($"| {item.Id}  |");
                System.Console.Write($" {item.Title}");
                for (int i = item.Title.Count(); i < 41; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");

                System.Console.Write($" {item.Author}");
                for (int i = item.Author.Count(); i < 22; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");
                System.Console.Write($" {item.Isbn}  |");
                System.Console.Write($" {item.Date_of_print} |");

                System.Console.Write($" {item.Janr}");
                for (int i = item.Janr.Count(); i < 16; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");

                if (item.Dostup == true)
                { System.Console.Write($"  {item.Dostup}     |\n"); }
                else if (item.Dostup == false)
                { System.Console.Write($"  {item.Dostup}    |\n"); }
            }
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            break;

        case "display":
        case "Display":
        case "DISPLAY":
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("|–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––|");
            System.Console.WriteLine("|                                                             TABLE OF BOOKS                                                              |");
            System.Console.WriteLine("|–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––|");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("|  id  | \t\ttitle\t\t\t  |     author\t\t  |    ISBN    |    Date Of Print   |       Janr      |  Dostup   |");
            foreach (var item in BookServices.GetBooks())
            {
                System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                if (item.Id <= 9) System.Console.Write($"|   {item.Id}  |");
                else if (item.Id > 9 && item.Id < 100) System.Console.Write($"|  {item.Id}  |");
                else System.Console.Write($"| {item.Id}  |");
                System.Console.Write($" {item.Title}");
                for (int i = item.Title.Count(); i < 41; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");

                System.Console.Write($" {item.Author}");
                for (int i = item.Author.Count(); i < 22; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");
                System.Console.Write($" {item.Isbn}  |");
                System.Console.Write($" {item.Date_of_print} |");

                System.Console.Write($" {item.Janr}");
                for (int i = item.Janr.Count(); i < 16; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");

                if (item.Dostup == true)
                { System.Console.Write($"  {item.Dostup}     |\n"); }
                else if (item.Dostup == false)
                { System.Console.Write($"  {item.Dostup}    |\n"); }
            }
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            break;
        case "Delete":
        case "delete":
        case "DELETE":
            System.Console.WriteLine("Enter Book's id for delete :");
            int n = Convert.ToInt32(Console.ReadLine());
            string koftan = "naeft";
            foreach (var item in BookServices.GetBooks())
            {
                if (item.Id == n)
                {
                    koftan = "yoft";
                    System.Console.WriteLine("---------------------------ARE YOU SURE WANT TO DELETE?-----------------------------");

                    System.Console.WriteLine($" TITLE OF BOOK : {item.Title} ");
                    System.Console.WriteLine($" Author OF BOOK : {item.Author} ");
                    System.Console.WriteLine($" ISBN OF BOOK : {item.Isbn} ");
                    System.Console.WriteLine($" Date_of_print OF BOOK : {item.Date_of_print} ");
                    System.Console.WriteLine($" Janr OF BOOK : {item.Janr} ");
                    System.Console.WriteLine($" Dostup OF BOOK : {item.Dostup} ");
                    System.Console.WriteLine("____________________________ENTER YOUR ANSWER YES OR NO_________________________________");
                    string ot = Console.ReadLine();
                    if (ot == "yes" || ot == "YES") { System.Console.WriteLine("This BOOK succesfully deleted from BOOKS !!!"); BookServices.DeleteBook(n); }
                    else break;
                }

            }
            if (koftan == "naeft") System.Console.WriteLine("Not Founded BOOK with this Id !!!");
            break;

        case "Update":
        case "update":
        case "UPDATE":

            var book = new Books();
            System.Console.WriteLine("Enter BOOK'S Id which you want update:");
            int k = Convert.ToInt32(Console.ReadLine());
            book.Id = k;

            string koftan1 = "naeft";
            foreach (var item in BookServices.GetBooks())
            {
                if (item.Id == k)
                {
                    koftan1 = "yoft";
                    System.Console.WriteLine("---------------------------ARE YOU SURE WANT TO Update this Book?-----------------------------");
                    System.Console.WriteLine("____________________________ENTER YOUR ANSWER YES OR NO_________________________________");
                    string ot = Console.ReadLine();

                    if (ot == "yes" || ot == "YES")
                    {
                        System.Console.WriteLine($" His Past TITLE OF BOOK : {item.Title} ");
                        System.Console.WriteLine("Enter his new title :");
                        book.Title = Console.ReadLine();

                        System.Console.WriteLine($" His Past Author OF BOOK : {item.Author} ");
                        System.Console.WriteLine("Enter his new Author :");
                        book.Author = Console.ReadLine();
                        System.Console.WriteLine($" His Past ISBN OF BOOK : {item.Isbn} ");
                        System.Console.WriteLine("Enter his new ISBN :");
                        book.Isbn = Convert.ToInt64(Console.ReadLine());
                        System.Console.WriteLine($" His Past Date_of_print OF BOOK : {item.Date_of_print} ");
                        System.Console.WriteLine("Enter his new Date_of_print :");
                        book.Date_of_print = Convert.ToDateTime(Console.ReadLine());
                        System.Console.WriteLine($" His Past Janr OF BOOK : {item.Janr} ");
                        System.Console.WriteLine("Enter his new Janr :");
                        book.Janr = Console.ReadLine();
                        System.Console.WriteLine($" His Past Dostup OF BOOK : {item.Dostup} ");
                        System.Console.WriteLine("Enter his new Dostup :");
                        book.Dostup = Convert.ToBoolean(Console.ReadLine());
                        System.Console.WriteLine("-------------------------------------------------");
                        System.Console.WriteLine("This BOOK succesfully updated from BOOKS !!!");
                        System.Console.WriteLine("-------------------------------------------------");
                        BookServices.UpdateBook(book);
                    }
                    else break;
                }
            }
            if (koftan1 == "naeft") System.Console.WriteLine("Not Founded BOOK with this Id !!!");

            break;

        case "ADD":
        case "Add":
        case "add":
            var book1 = new Books();
            System.Console.WriteLine("Enter BOOK'S Title which you want add:");
            book1.Title = Console.ReadLine();
            System.Console.WriteLine("Enter BOOK'S Author which you want add:");
            book1.Author = Console.ReadLine();
            System.Console.WriteLine("Enter BOOK'S ISBN which you want add:");
            book1.Isbn = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter BOOK'S Date_of_print which you want add:");
            book1.Date_of_print = Convert.ToDateTime(Console.ReadLine());
            System.Console.WriteLine("Enter BOOK'S  JANR which you want add:");
            book1.Janr = Console.ReadLine();
            System.Console.WriteLine("Enter BOOK'S Dostup which you want add:");
            book1.Dostup = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine("This Book succesfully aded for tables of BOOKS");
            BookServices.AddBook(book1);
            break;
        case "Exist":
        case "exist":
        case "EXIST":
            return 0;
    }
}