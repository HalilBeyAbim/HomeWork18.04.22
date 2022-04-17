 using System;

namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ") ;
            int naturalNumber = Convert.ToInt32(Console.ReadLine());//burada secdiyimiz bir eded daxil edirik
            Console.Write("Daxil etdiyiniz ededin uzerine 3 reqemini elave etdik ve alinan reqem qarsinizda: ");
            convert( naturalNumber);
        }
        public static void convert(int naturalNumber ) 
        {
            int number = naturalNumber; //yeni reqem yaradiriq ve reqemi secdiyimiz reqeme beraberlesdirirk
            int counter = 0; //reqemlerin nece ededli oldugunu saymaq ucun bir counter yaradiriq
            while (number != 0) //secdiyimiz reqem 0 olana dek boluruk
            {
                number = number / 10;
                counter++; //yazdigimiz regem nece ededli oldugunu orgenmek ucun bu metodu yaziriq
            }
            int factor = 1;//reqmin 0'larini saymaq ucun factor'umuzu 1 ile basladiriq sebeb 0'a vuesaq aldigimiz reqem hep 0 alinar
            int i;
            for (i = 0; i < counter; i++)
            {
                factor *= 10;
            }
            int newNumber = naturalNumber + 3 * factor; //elave etdiyimiz reqem one cikmasi ucun bu islemi goruruk
            Console.WriteLine(newNumber);

            //Daxil etdiyimiz kod'da deyerin sayisi geder 10'a boluruk ve sonuncu bolmeden sonra evveline secdiyimiz reqemi atiriq



        }
    }
}
