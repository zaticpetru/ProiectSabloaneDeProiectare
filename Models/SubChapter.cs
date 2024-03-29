﻿using Models.Interfaces;

namespace Models
{
    public class SubChapter : IGenericItem<BookItem>, IVisitee
    {
        public string Name { get; set; }
        public List<BookItem> Items { get; }

        public SubChapter(string name)
        {
            Name = name;
            Items = new List<BookItem>();
        }
        public void Print()
        {
            Console.WriteLine($"Titlu subcapitol: {Name}\n");
            Items.ForEach(item => item.Print());
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSubChapter(this);
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