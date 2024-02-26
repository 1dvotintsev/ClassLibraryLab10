using ClassLibraryLab10;

namespace labr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emoji[] array = new Emoji[20];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10 ;i++)
            {
                array[i] = new FaceEmoji();
                array[i].RandomInit();
            }

            for (int i = 10; i < 15; i++)
            {
                array[i] = new AnimalEmoji();
                array[i].RandomInit();
            }

            for (int i = 15; i < 20; i++)
            {
                array[i] = new SmileEmoji();
                array[i].RandomInit();
            }

            //вывод с помощью виртуального метода
            foreach (var e in array)
            {
                e.ShowVirtual();
            }

            Console.WriteLine("----------------------------------------");

            //вывод массива без виртуальных методов
            foreach (var e in array) 
            { 
                if(e is FaceEmoji f)
                {
                    f.Show();
                }
                else
                {
                    if (e is AnimalEmoji an) 
                    { 
                        an.Show();
                    }
                    else
                    {
                        if(e is SmileEmoji smile)
                        {
                            smile.Show();
                        }
                        else
                        {
                            e.Show();
                        }
                    }
                }
            }

            Console.WriteLine("--------------------------------------");

            Emoji.FindBestGrade(array);       //тест нахождения самой сильной эмоджи
             
            Emoji.FindAnimalsTags(array);     //тест вывода всех тэгов животных

            Emoji.FindReasonsFrom(array, 3);  //тест нахождения причин у эмоджи силой >= 3

            Console.WriteLine("----------------------------");

            IInit[] array1 = new IInit[25];

            //поверхностное копирование из предыдущего задания
            for (int i = 0; i < 20; ++i) 
            {
                array1[i] = array[i];
            }
            //заполнение объектами из 9 лабораторной
            for(int i = 20;i < 25; ++i)
            {
                array1[i] = new Pockemon();
                array1[i].RandomInit();
            }

            //вывод элементов массива, состоящих из разных объектов
            foreach(var e in array1)
            {
                e.ShowVirtual();
            }

            Console.WriteLine("---------------------");

            //Сортировка и поиск в массиве классов иерархии
            Array.Sort(array);
            foreach (var e in array)
            {
                e.ShowVirtual();
            }

            //Бинарный поиск по имени
            int pos = Array.BinarySearch(array, new Emoji("Улыбка","смайл",6));
            if (pos < 0)
                Console.WriteLine("Элемент не найден");
            else
                Console.WriteLine($"Элемент найден на позиции: {pos + 1}");

            Console.WriteLine("------------------------------");

            //сортировка по тэгу и вывод
            Array.Sort(array, new SortByTag());
            foreach (var e in array)
            {
                e.ShowVirtual();
            }
            //поск по тэгу
            int pos1 = Array.BinarySearch(array, new Emoji("Улыбка", "sad", 6), new SortByTag());
            if (pos1 < 0)
                Console.WriteLine("Элемент не найден");
            else
                Console.WriteLine($"Элемент найден на позиции: {pos1 + 1}");

            Console.WriteLine("-------------------");

            //демонстрация поверностного и глубокого копирования
            Emoji example = new Emoji();
            example.RandomInit();
            example.ShowVirtual();

            Emoji copy = (Emoji)example.ShallowClone();
            copy.ShowVirtual();

            Emoji clone = (Emoji)example.Clone();
            clone.ShowVirtual();

            Console.WriteLine("\nПосле изменений:");

            copy.Name = example.Name + "copy";
            copy.id.number = 100;

            clone.Name = example.Name + "clone";
            copy.id.number = 200;

            //вывод результата изменений
            example.ShowVirtual();
            copy.ShowVirtual();
            clone.ShowVirtual();
        }
    }
}
