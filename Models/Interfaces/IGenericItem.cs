namespace Models.Interfaces
{
    public interface IGenericItem<T>
    {
        List<T> Items { get; }
        T GetItem(int index) => Items[index];
        int AddItem(T item)
        {
            Items.Add(item);
            return Items.IndexOf(item);
        }
        bool RemoveItem(T item) => Items.Remove(item);
        void Print();
    }
}