using System;

namespace Third{

    class SwitchCase{

        static void Main(){

            int number;
            Console.WriteLine("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());

            switch(number){
                case 5: 
                    Console.WriteLine("is 5");
                    break;
                case 10:
                    Console.WriteLine("is 10");
                    break;
                default:
                    Console.WriteLine("is not 5/10");
                    break;
            }

        }

    }

}