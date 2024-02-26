using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class FaceEmoji:Emoji
    {
        Random random = new Random();

        string[] symbs = { ":)", ":(", ":|", "XD" };
        protected string symbols;
        public string Symbols
        {
            get { return symbols; }
            set { symbols = value; }
        }
        public FaceEmoji() : base() 
        {
            Symbols = "undefined";
        }
        public FaceEmoji(string name, string tag, int ident, string symbols) : base(name, tag, ident) 
        {
            Symbols = symbols;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Symbols: {this.Symbols}");
        }

        public override void ShowVirtual()
        {
            base.ShowVirtual();
            Console.WriteLine($"Symbols: {this.Symbols}");
        }

        public override void Init()
        {
            base.Init();

            Console.WriteLine("Введите символьную запись:");
            string symbols = Console.ReadLine();
            if ( symbols != null )
            {
                Symbols = symbols;
            }
            else
                Symbols = "undefined";
        }

        public override void RandomInit()
        {
            base.RandomInit();

            Symbols = symbs[random.Next(0, symbs.Length - 1)];
        }

        public override bool Equals(object obj)
        {
            FaceEmoji emoji = obj as FaceEmoji;
            if (emoji is FaceEmoji e)
            {
                return emoji.Name == e.Name && emoji.Tag == e.Tag && emoji.Symbols==e.Symbols;
            }
            else
                return false;
        }
    }
}
