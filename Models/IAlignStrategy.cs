namespace Models
{
    public interface IAlignStrategy
    {
        void render(Paragraph paragraph, string Context = "");
    }
}