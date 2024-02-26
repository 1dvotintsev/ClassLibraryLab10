using ClassLibraryLab10;

namespace TestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Emoji e1 = new Emoji();
            Emoji e2 = new Emoji("name1", "tag1", 11);

            Assert.AreEqual(e1, e2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            SmileEmoji e1 = new SmileEmoji();
            SmileEmoji e2 = new SmileEmoji("name1", "tag1", 1, "undefined", 0);

            Assert.AreEqual(e1, e2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            FaceEmoji e1 = new FaceEmoji();
            FaceEmoji e2 = new FaceEmoji("name1", "tag1", 1, "undefined");

            Assert.AreEqual(e1, e2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            AnimalEmoji e1 = new AnimalEmoji();
            AnimalEmoji e2 = new AnimalEmoji("name1", "tag1", 1, "undefined");

            Assert.AreEqual(e1, e2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Emoji e1 = new Emoji();
            e1.RandomInit();
            e1.Name = "test";

            Assert.AreEqual(e1.Name, "test");
        }
        [TestMethod]
        public void TestMethod6()
        {
            AnimalEmoji e1 = new AnimalEmoji();
            e1.RandomInit();
            e1.Name = "test";

            Assert.AreEqual(e1.Name, "test");
        }
        [TestMethod]
        public void TestMethod7()
        {
            SmileEmoji e1 = new SmileEmoji();
            e1.RandomInit();
            e1.Name = "test";

            Assert.AreEqual(e1.Name, "test");
        }
        [TestMethod]
        public void TestMethod8()
        {
            FaceEmoji e1 = new FaceEmoji();
            e1.RandomInit();
            e1.Name = "test";

            Assert.AreEqual(e1.Name, "test");
        }
        [TestMethod]
        public void TestMethod9()
        {
            SmileEmoji e1 = new SmileEmoji("name1", "tag1", 1, "undefined", -5);
            SmileEmoji e2 = new SmileEmoji("name1", "tag1", 1, "undefined", 0);

            Assert.AreEqual(e1, e2);
        }
        [TestMethod]
        public void TestMethod10()
        {
            SmileEmoji e1 = new SmileEmoji("name1", "tag1", 1, "undefined", 100);
            SmileEmoji e2 = new SmileEmoji("name1", "tag1", 1, "undefined", 10);

            Assert.AreEqual(e1, e2);
        }
        [TestMethod]
        public void TestMethod11()
        {
            Emoji emoji = new Emoji();
            Emoji emoji2 = new Emoji();

            Assert.AreEqual(emoji.id.ToString(), "1");

            Assert.AreEqual(emoji.id, emoji2.id);
        }
        [TestMethod]
        public void TestMethod12()
        {
            Emoji[] array = new Emoji[20];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
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
            Emoji.FindBestGrade(array);
        }
        [TestMethod]
        public void TestMethod13()
        {
            Emoji[] array = new Emoji[15];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
            {
                array[i] = new FaceEmoji();
                array[i].RandomInit();
            }

            for (int i = 10; i < 15; i++)
            {
                array[i] = new AnimalEmoji();
                array[i].RandomInit();
            }          
            Emoji.FindBestGrade(array);
        }
        [TestMethod]
        public void TestMethod14()
        {
            Emoji[] array = new Emoji[20];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
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
            Emoji.FindReasonsFrom(array, 6);
        }
        [TestMethod]
        public void TestMethod15()
        {
            Emoji[] array = new Emoji[15];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
            {
                array[i] = new FaceEmoji();
                array[i].RandomInit();
            }

            for (int i = 10; i < 15; i++)
            {
                array[i] = new AnimalEmoji();
                array[i].RandomInit();
            }
            Emoji.FindReasonsFrom(array, 6);
        }
        [TestMethod]
        public void TestMethod16()
        {
            Emoji[] array = new Emoji[20];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
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
            Emoji.FindAnimalsTags(array);
        }
        [TestMethod]
        public void TestMethod17()
        {
            Emoji[] array = new Emoji[20];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
            {
                array[i] = new FaceEmoji();
                array[i].RandomInit();
            }

            for (int i = 10; i < 15; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 15; i < 20; i++)
            {
                array[i] = new SmileEmoji();
                array[i].RandomInit();
            }
            Emoji.FindAnimalsTags(array);
        }
        [TestMethod] 
        public void TestMethod18()
        {
            Emoji[] array = new Emoji[20];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
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
            Array.Sort(array);
        }
        [TestMethod]
        public void TestMethod19()
        {
            Emoji[] array = new Emoji[20];   //массив для заполнения разными классами иерархии

            for (int i = 0; i < 5; i++)
            {
                array[i] = new Emoji();
                array[i].RandomInit();
            }

            for (int i = 5; i < 10; i++)
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
            Array.Sort(array, new SortByTag());
        }
        [TestMethod]
        public void TestMethod20()
        {
            Emoji e = new Emoji();
            e.RandomInit();

            Emoji e1 = (Emoji)e.Clone();

            Assert.AreEqual(e, e1);
        }
        [TestMethod]
        public void TestMethod21()
        {
            Emoji e = new Emoji();
            e.RandomInit();

            Emoji e1 = (Emoji)e.ShallowClone();

            Assert.AreEqual(e, e1);
        }
    }
}