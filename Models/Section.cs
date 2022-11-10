using Models.Interfaces;

namespace Models
{
    public class Section : IGenericItem<SubChapter>, IVisitee
    {
        public string Name { get; set; }
        public List<SubChapter> Items { get; }

        public Section(string name)
        {
            Name = name;
            Items = new List<SubChapter>();
        }

        public void Print()
        {
            Console.WriteLine($"Titlu capitol: {Name}\n");
            Items.ForEach(item => item.Print());
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSection(this);
            Items.ForEach(item =>
            {
                if (item is IVisitee visitee)
                {
                    visitee.Accept(visitor);
                }
            });
        }
    }
}