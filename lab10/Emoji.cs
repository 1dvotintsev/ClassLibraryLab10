using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class IdNumber
    {
        public int number;
        public IdNumber(int n) 
        {
            this.number = n;
        }
        public override string ToString()
        {
            return number.ToString();
        }
        public override bool Equals(object? obj)
        {
            if (obj is IdNumber em)
                return this.number == em.number;
            return false;
        }
    }

    public class Emoji: IInit, IComparable, ICloneable
    {
        string[] names = { "Улыбашка", "Смайлик", "Смешинка", "Весельчак", "Радость", "Смайл", "Улыбка", "Смехотун", "Улыбашка" };
        string[] tags = { "smile", "sad", "clown", "depressed", "cry", "animal", "monkey" };
        Random random = new Random();

        protected string name;
        protected string tag;
        protected static int count = 0;

        public IdNumber id;
        
        public string Name
        {
            get 
            { 
                return name; 
            }
            set
            {
                name = value;
            }
        }

        public string Tag
        {
            get
            {
                return tag;
            }
            set
            {
                tag = value;
            }
        }

        public Emoji() 
        {
            count++;;
            Name = $"name{count}";
            Tag = $"tag{count}";
            id = new IdNumber(1);
        }

        public Emoji(string name, string tag, int ident)
        {
            count++;
            Name = name;
            Tag = tag;
            id = new IdNumber(ident);

        }

        public void Show()
        {
            Console.WriteLine($"\nName: {this.Name}\nTag: {this.Tag}");
        }

        public virtual void ShowVirtual()
        {
            Console.WriteLine($"\nID: {this.id}\nName: {this.Name}\nTag: {this.Tag}");
        }

        public virtual void Init()
        {
            Console.WriteLine("Введите ID:");
            id.number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя Эмоджи:");
            string name = Console.ReadLine();
            if (name != null)
            {
                Name = name;
            }
            else
                Name = "No name";

            Console.WriteLine("Введите тэг:");
            string tag = Console.ReadLine();
            if (tag != null)
            {
                Tag = tag;
            }
            else
                Tag = "No tag";

        }

        public virtual void RandomInit()
        {
            Name = names[random.Next(0, names.Length - 1)];
            Tag = tags[random.Next(0, tags.Length - 1)];
            id.number = random.Next(0,100);
        }

        public override bool Equals(object obj)
        {
            Emoji emoji = obj as Emoji;
            if (emoji != null)
            {
                return emoji.Name==this.Name && emoji.Tag==this.Tag;
            }
            else
                return false;
        }

        //поиск самого сильного эмоджи
        public static void FindBestGrade(Emoji[] array)
        {
            int count = 0;
            SmileEmoji emoji = new SmileEmoji();

            foreach (Emoji e in array)
            {
                if(e is SmileEmoji smile)
                {
                    count++;

                    if(smile.Grade >= emoji.Grade )
                        emoji = smile;
                }
            }

            if (count != 0)
            {
                Console.WriteLine("\nСамое сильное эмоджи:");
                emoji.ShowVirtual();
            }
            else
                Console.WriteLine("\nВ массиве нет эмоджи, обладающих силой");
        }

        //причины улыбающихся с силой не меньше
        public static void FindReasonsFrom(Emoji[] array, int minGrade)
        {
            string result = $"\nПричины всех улыбающихся эмоджи силой больше {minGrade}: ";
            int count = 0;

            foreach (Emoji e in array)
            {
                if (e is SmileEmoji smile && smile.Grade >= minGrade)
                {
                    count++;
                    result += smile.Reason + ", ";
                }
            }
            if (count > 0)
            {
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("\nВ массиве нет улыбающихся эмоджи.");
        }

        //тэги всех эмоджи-животных
        public static void FindAnimalsTags(Emoji[] array)
        {
            int count = 0;
            string result = "\nТэги всех животных-эмоджи в массиве: ";

            foreach (Emoji e in array)
            {
                if (e is AnimalEmoji animal)
                {
                    count++;
                    result += animal.Tag + ", ";
                }
            }

            if (count != 0)
            {
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("\nВ массиве нет животных-эмоджи");
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return -1;
            if (obj is not Emoji) return -1;
            Emoji emoji = obj as Emoji;
            return string.Compare(this.Name, emoji.Name);
        }

        public object Clone()
        {
            return new Emoji(Name, Tag, id.number);
        }

        public object ShallowClone()
        {
            return this.MemberwiseClone();
        }
    }
}
