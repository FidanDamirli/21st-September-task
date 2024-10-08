namespace Inheritance_StringBuilder_IsA_HasA
{
    public class NoteBook : Product3
    {
        public int Storage;
        public NoteBook(string name, double price, int storage) : base(name, price)
        {
            Storage = storage;
        }

    }
}
