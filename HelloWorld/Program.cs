namespace HelloWorld
{
    class Program
    {

        struct Foo
        {
            public int x;
        };

        static void Main(string[] args) {
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
