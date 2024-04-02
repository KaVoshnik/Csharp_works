using System;

namespace Secondwork {

    class Vars {

        static void Main() {

            int num_1 = 1, num_2 = 0;
            // uint = От 0 до 4 294 967 295
            // byte = От 0 до 255
            // short = От −32 768 до 32 767
            // long = От −9 223 372 036 854 775 808 до 9 223 372 036 854 775 807

            Console.WriteLine("Enter Number 2");

            num_2 = Convert.ToInt32(Console.ReadLine());

            float number = 4.15f;
            // double number_2 = 4.1523d;

            string word = "bad apple";

            char symbol = 'Y'; // один символ

            bool iscool = true;

            Console.WriteLine("Var1: " + num_1 + " Var2: " + num_2 + " float: " + number);
            Console.WriteLine(word + " Y/N: " + symbol);
            Console.WriteLine(iscool);

        }

    }

}