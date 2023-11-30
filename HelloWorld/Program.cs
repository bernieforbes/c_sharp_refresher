using System;
using System.Collections;

namespace HelloWorld
{
    class Program {

        struct Foo {
            public int x;
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Box box = new Box();
            box.SetLength(5);
            box.Height = 10;

            Foo foo1 = new Foo();
            foo1.x = 10;

            Foo foo2 = foo1 with { x = 5 };

            Console.WriteLine("{0} {1}", foo1.x, foo2.x);

            Console.WriteLine("{0}", box.GetLength());
            Console.WriteLine("{0}", box.Height);
            Console.WriteLine("{0}", box.GetVolume());

            string[,,] foo = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"}
                } ,
                {
                    {"100", "101"},
                    {"110", "111"},
                }
            };

            Console.WriteLine("The value is {0}", foo[1, 1, 0]);
            Console.ReadKey();

            string[] bar = {"a", "b"};
            Console.WriteLine("The value is {0}", bar[1]);
            Console.ReadKey();

            int[][] jaggedArray = new int[][]
            {
                new int[] {2, 3, 5, 7, 11 },
                new int[] {1, 2, 3}
            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray[0][2]);

            for(int i = 0; i < jaggedArray.Length; i++) {
                Console.WriteLine("Element {0}", i);
                for(int j = 0; j < jaggedArray[i].Length; j++) {
                    Console.WriteLine("{0}", jaggedArray[i][j]);
                }
            }

            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList();

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // delete element with specific value from arrayList
            myArrayList.Remove(13);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList) {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

    class Box {
        private int length = 3;
        private int height = 5;
        public int width = 2;

        public int GetLength() { return length; }
        public void SetLength(int length)
        {
            if (length < 0) {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;

        }
        
        public int Height {
            get { return this.height; }
            set {
                if (height < 0) {
                    height = -value;
                } else {

                    height = value;
                }
            }
        }

        public int Foo { get; set; }

    }
}
