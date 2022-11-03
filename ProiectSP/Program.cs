using ProiectSP;

var book = new Book("My book title");
var bookAsGenericItem = book as IGenericItem<Chapter>;
Author labMice = new Author("Lab Mice, Subject 1");

book.AddAuthor(labMice);



int indexCh1 = bookAsGenericItem.AddItem(new Chapter("First chapter, cool .."));
IGenericItem<SubChapter> chapter1 = bookAsGenericItem.GetItem(indexCh1);
int indexSbCh1 = chapter1.AddItem(new SubChapter("Hey, here is a subchapter"));
IGenericItem<BookItem> subChapter1 = chapter1.GetItem(indexSbCh1);

var prg1 = subChapter1.AddItem(new Paragraph("A loong time ago existed a paragraph"));
var prg2 = subChapter1.AddItem(new Paragraph("A loong time ago existed a second paragraph"));
var prg3 = subChapter1.AddItem(new Paragraph("A loong time ago existed another paragraph"));
subChapter1.AddItem(new Table("Here is a table record of that happening"));
subChapter1.AddItem(new Image("Also a image with the new paragraph:"));

subChapter1.GetItem(prg1).AlignStrategy = new AlignRight();
subChapter1.GetItem(prg2).AlignStrategy = new AlignLeft();
subChapter1.GetItem(prg3).AlignStrategy = new AlignCenter();

book.Print();

public class AlignLeft : IAlignStrategy
{
    public void render(Paragraph paragraph, string Context = "")
    {
        Console.WriteLine(paragraph.Content);
    }
}

public class AlignRight : IAlignStrategy
{
    public void render(Paragraph paragraph, string Context = "")
    {
        Console.CursorLeft = Console.BufferWidth - paragraph.Content.Length;
        Console.WriteLine(paragraph.Content);
    }
}

public class AlignCenter : IAlignStrategy
{
    public void render(Paragraph paragraph, string Context = "")
    {
        Console.CursorLeft = (Console.BufferWidth - paragraph.Content.Length) / 2;
        Console.WriteLine(paragraph.Content);
    }
}