namespace Inheritance_StringBuilder_IsA_HasA
{
    public class TechStore
    {
        public string Name;
        public NoteBook[] NoteBooks;

        public TechStore(int size, string name)
        {
            NoteBooks = new NoteBook[size];
            Name = name;
        }


        public void Add(NoteBook newNotebook)
        {
            Array.Resize(ref NoteBooks, NoteBooks.Length + 1);
            Console.WriteLine(newNotebook.Name + " " + "added");

        }

        public bool Find(string name)
        {
            bool result = false;
            foreach (var noteBook in NoteBooks)
            {
                if (name.ToLower() == noteBook.Name.ToLower())
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void ShowAll()
        {
            foreach (var item in NoteBooks)
            {

                Console.WriteLine(item.Name);
            }
        }


    }
}

