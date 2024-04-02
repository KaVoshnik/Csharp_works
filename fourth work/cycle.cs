using System;

namespace fourth{

    class cycle{

        static void Main(){

            bool IsHasCar = false;
            byte o = 100;

            for(byte i = 0; i <= 10; i++) {
                if(i % 2 == 0)
                continue; // пропускает 1 элемент

                if(i > 5)
                    break; // брейк ну а че)
                Console.WriteLine("Element: " + i);
                // фигурные скобки при одной строке не прописывать
            }

            while(!IsHasCar){
                string end = Console.ReadLine();

                if(end == "end")
                IsHasCar = true;
            }

            do {
                Console.WriteLine("Element: " + o);
            } while(o < 10);

        }

    }

}