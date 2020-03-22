using System;

namespace OpetationWithVariable.cs
{
    class Program
    {
        static void Main(string[] args)
        {


            int result;
            ClassObject classObject = new ClassObject();
            int a = Convert.ToInt32( Math.PI);
            int b = Convert.ToInt32(Console.ReadLine());
            int v = classObject.findMax(a, b);
            result = v;
            Console.WriteLine(result);







            // int a = 15;
            // sbyte v = (sbyte)a;
            // Console.WriteLine(v);

            // byte agr = 1;
            // int changAgr = agr - 2;
            //agr = (byte)changAgr;
            //Console.WriteLine(agr); приведение типов

            //Console.WriteLine("Введите число");
            // string years = Console.ReadLine();
            // int srt = Convert.ToInt32(years);







            // if
            //    (srt > 16)
            //  {
            //   Console.WriteLine("норм");
            //   }
            //   else
            //   {
            //       Console.WriteLine("тебе пеизда");
            //   }


            //var result = 10 > srt ? "привет" : "пока";
            //Console.WriteLine(result);// тернарный оператор 


            // switch(srt)
            //{
            //    
            //    case 18: Console.WriteLine("привет");
            //        break; //break обязательно
            //    case 19:
            //        const string Value = "привет Петя";
            //        Console.WriteLine(Value);
            //       break;
            //   case 20:
            //       goto case 19;
            //   

            // }

            // string result = null;
            // string rrr = "даров";
            // string text = "хай";
            // result = rrr = text ?? "hfc[jlbflkflkflkflkflkfklf";
            // Console.WriteLine(rrr);


            //for (int i = 0; i<100; i++)
            // {
            //    Console.WriteLine("Cаня хуй саси")
            //



            // int lenght=Convert.ToInt32(Console.ReadLine());
            // int[] array = new int[lenght];
            //for (int i = 0; i < lenght; i++)
            //{
            //    Console.WriteLine("Хай");
            // }

            //ClassObject classobject = new ClassObject();

          }

    }
        
    }

