using System.Numerics;

namespace Domain.Models;

public class Books
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public double Isbn { get; set; }

    public string Janr { get; set; }

    public DateTime Date_of_print { get; set; }

	public bool Dostup { get; set; }


}
