using ProiectSP;

var book = new Book("My book title");
Author labMice = new Author("Lab Mice, Subject 1");

book.AddAuthor(labMice);
int indexCh1 = book.CreateChapter("First chapter, cool ..");
Chapter chapter1 = book.GetChapter(indexCh1);
int indexSbCh1 = chapter1.CreateSubChapter("Hey, here is a subchapter");
SubChapter subChapter1 = chapter1.GetSubChapter(indexSbCh1);

subChapter1.CreateNewParagraph("A loong time ago existed a paragraph");
subChapter1.CreateNewTable("Here is a table record of that happening");
subChapter1.CreateNewImage("Also a image with the new paragraph:");

book.Print();
