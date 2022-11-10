namespace Models.Interfaces
{
    public interface IAlignStrategy
    {
        void render(Paragraph paragraph, string Context = "");
    }
}