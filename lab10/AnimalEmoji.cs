﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class AnimalEmoji:Emoji
    {
        Random random = new Random();
        
        string[] parts = { "tail", "ears", "nose", "leg", "body" };
        protected string part;
        public string Part
        {
            get { return part; }
            set { part = value; }
        }
        public AnimalEmoji() : base()
        {
            Part = "undefined";
        }
        public AnimalEmoji(string name, string tag, int ident, string part) : base(name, tag, ident)
        {
            Part = part;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Symbols: {this.Part}");
        }

        public override void ShowVirtual()
        {
            base.ShowVirtual();
            Console.WriteLine($"Part: {this.Part}");
        }

        public override void Init()
        {
            base.Init();

            Console.WriteLine("Введите часть животного");
            string part = Console.ReadLine();
            if (part != null)
            {
                Part= part;
            }
            else
                Part = "undefined";
        }

        public override void RandomInit()
        {
            base.RandomInit();
            Part = parts[random.Next(0, parts.Length - 1)];
        }

        public override bool Equals(object obj)
        {
            AnimalEmoji emoji = obj as AnimalEmoji;
            if (emoji is AnimalEmoji e)
            {
                return emoji.Name == e.Name && emoji.Tag == e.Tag && emoji.Part == e.Part;
            }
            else
                return false;
        }
    }
}
