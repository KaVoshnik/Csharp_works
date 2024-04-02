using System;

namespace five {

    class massive {

        static void Main() {

            int[] nums = new int[5];
            nums[0] = 9;
            nums[1] = 5;
            nums[2] = 1;
            nums[3] = 2;
            nums[4] = 3;

            string[] words = new string[] {"penis", "vagina"};

            words[1] = "penis2";

            Console.WriteLine(words[1]);

            for(byte i = 0; i < nums.Length; i++) //nums.Length длинна массива
                Console.WriteLine("Element: " + nums[i]);

            char[,] symbols = new char[2,3];
            symbols[0, 1] = 'o';

            Console.WriteLine(symbols[0, 1]);

            int[,] numbers = {
                {3, 3, 1},
                {6, 1, 2},
                {3, 5, 2}
            };

                Console.WriteLine(numbers[2, 0]);

        }

    }
    
}