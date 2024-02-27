namespace Infrastructure.Services;
using Domain.Models;
using Npgsql;
using Dapper;

public class BookServices
{

    private string connect = "Host=localhost;Port=5432;Database=LibraryDb; User id=postgres;Password=sabriddin2004";


    public List<Books> GetBooks()
    {
        using var connected = new NpgsqlConnection(connect);
        return connected.Query<Books>("select * from  Books").ToList();
    }

    public void AddBook(Books book)
    {

        using var connected = new NpgsqlConnection(connect);
        connected.Execute("insert into Books(Title,Author,Isbn,Janr,Date_of_print,Dostup)values(@title,@author,@Isbn,@Janr,@Date_of_print,@Dostup)", book);

    }
    public void UpdateBook(Books book)
    {
        using var connected = new NpgsqlConnection(connect);
        connected.Execute("Update Books set title=@title,Author=@author,Isbn=@Isbn,Janr=@Janr,Date_of_print=@Date_of_print,Dostup=@Dostup where id=@id", book);
    }

    public void DeleteBook(int Id)
    {
        using var connected = new NpgsqlConnection(connect);
        connected.Execute("delete from Books where id=@id ", new { id = Id });
    }

    public List<Books> SearchToAuthor(string author)
    {
        using var connected = new NpgsqlConnection(connect);
        return connected.Query<Books>("select * from Books where author=@author", new { author = author }).ToList();

    }


}
