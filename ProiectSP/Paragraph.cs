namespace ProiectSP
{
    public class Paragraph : BookItem
    {
        public Paragraph(string content) : base(content) { }

        public override void Print()
        {
            if(AlignStrategy != null)
            {
                AlignStrategy.render(this);
            } else
            {
                base.Print();
            }
        }
    }
}