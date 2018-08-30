using System;

namespace workshop01
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Char character = 'C';
            int integer = 32;
            float floatingPointNumber = 3.14f;
            double pi = Math.PI;
            byte onebyte = 1;
            bool boolean = true;
            String text = "This is text";
            

            Console.WriteLine($"text: {text}");
            Console.WriteLine($"character: {character}");
            Console.WriteLine($"integer: {integer}");
            Console.WriteLine($"floatingPointNumber: {floatingPointNumber}");
            Console.WriteLine($"pi: {pi}");
            Console.WriteLine($"bool: {boolean}");
            
            //memory sizes
            Console.WriteLine($"size of byte: {sizeof(byte)}");
            Console.WriteLine($"size of char: {sizeof(char)}");
            Console.WriteLine($"size of int: {sizeof(int)}");
            Console.WriteLine($"size of bool: {sizeof(bool)}");
            Console.WriteLine($"size of bool: {sizeof(float)}");

            //casting
            byte castedbyte = (byte)'1';
            Console.WriteLine($"byte: {castedbyte}");

            //arrays
            int[] numbers = {1,2,3,4,5,6,7};
            string[] texts = {"text1","text2","text3","text4"};
            float[] floats = {1.2f,2.3f,3.4f,4.5f};

            //string er egentlig en char[]
            char[] characters = "asbjørn".ToCharArray();

            //for loop
            int[] millionInts = new int[1000000];

            for(int i = 0;i < 1000000;i++){
                millionInts[i] = i;
            }

            //funksjonskall
            Scramble(millionInts);

            Console.WriteLine("Scrambled");
        }

        private static void Scramble(int[] array){
            Random r = new Random(3);
            
            for(int i = 0;i < array.Length; i++){
                var x = r.Next(array.Length);
                int temp = array[i];
                array[i] = array[x];
                array[x] = temp;
            }
            
        }
    }


}
