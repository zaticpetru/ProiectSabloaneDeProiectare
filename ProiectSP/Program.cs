var book = new Book("My book title");

book.createNewParagraph("Parag");
book.createNewTable("Table");
book.createNewImage("Image");

Console.WriteLine(book);

public class Book
{
    public string Title { get; set; } 
    public List<BookItem> BookItems { get; set; }

    public Book(string title)
    {
        Title = title;
        BookItems = new List<BookItem>();
    }

    public void createNewParagraph(string content)
    {
        BookItems.Add(new Paragraph(content));
    }
    public void createNewImage(string content)
    {
        BookItems.Add(new Image(content));
    }
    public void createNewTable(string content)
    {
        BookItems.Add(new Table(content));
    }
    public override string ToString()
    {
        return $"Titlu: {Title} \n{string.Join("\n", BookItems)}";
    }
}

public class BookItem
{
    public string Content { get; set; }

    public BookItem(string content)
    {
        Content = content;
    }

    public override string ToString()
    {
        return Content;
    }
}

public class Paragraph : BookItem
{
    public Paragraph(string content) : base(content)
    {
    }
}

public class Image : BookItem
{
    public Image(string content) : base(content)
    {
    }

    public override string ToString()
    {
        return Content + "* rendering *";
    }
}

public class Table : BookItem
{
    public Table(string content) : base(content)
    {
    }
}

