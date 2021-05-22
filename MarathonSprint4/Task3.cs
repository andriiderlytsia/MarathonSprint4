using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonSprint4
{
    enum ColourEnum
    {
        Red, 
        Green,
        Blue
    }
    interface IColoured
    {
        ColourEnum Colour { get => ColourEnum.Red;}

    }
    interface IDocument
    {
        static string defaultText = "Lorem ipsum";
        int Pages { get => 0;set { } }
        string Name { get; set; }
        void AddPages(int n) => Pages += n;
        void Rename(string newName) => Name = newName;
    }
    class ColouredDocument : IColoured, IDocument
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public ColourEnum Colour { get; set; }
        public ColouredDocument(ColourEnum colourEnum)
        {
            Colour = colourEnum; 
        }
        public ColouredDocument()
        {

        }
    }
    class Example
    {
        static void Do()
        {
            IDocument doc1 = new ColouredDocument() { Name = "Document1" };
            Console.WriteLine(doc1.Name);
            doc1.Rename("Document2");
            Console.WriteLine(doc1.Name);

        }
    }

}
