using System;

namespace Kurlyk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 3; ++j)
                    Console.Write(" " + firstArray[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("########################################################################################################################");
            Console.Write("Введите количество элементов массива строк: ");
            //string buff1 = System.Console.ReadLine();
            int arrayLength1 = System.Convert.ToInt32(System.Console.ReadLine());
            //int arrayLength1 = int.Parse(buff1);
            string[] stringArray = new string[arrayLength1];
            for (int i = 0; i < arrayLength1; ++i)
            {
                stringArray[i] = "Строка" + i;
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine("Длинна массива: " + stringArray.Length);
            Console.Write("Введите номер строки, которую хотите изменить: ");
            int buffNumber = int.Parse(Console.ReadLine()) - 1;
            stringArray[buffNumber] = Console.ReadLine();
            Console.WriteLine("Изменённая " + (buffNumber + 1) + "-я строка: " + stringArray[buffNumber]);
            Console.WriteLine("########################################################################################################################");
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[4];
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < jaggedArray[i].Length; ++j)
                {
                    Console.Write("Введите значения для " + j + " элемента " + i + " поля (число): ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < jaggedArray[i].Length; ++j)
                    Console.Write(" " + jaggedArray[i][j]);
                Console.WriteLine();
            }
            var container1 = jaggedArray;
            String stringForContainer2 = "Contain me!";
            var container2 = stringForContainer2;
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("########################################################################################################################");
//ЗАДАНИЕ 3 ВЫПОЛНЕНО
            (int numb, string datas, char chs, string codes, ulong tooLong) tupleType1 = (123, "Data", 'F', "Code", 123456);
            Console.WriteLine(tupleType1);
            Console.WriteLine(tupleType1.datas + " " + tupleType1.chs + " " + tupleType1.numb);
            (int numb, string datas, char chs, string codes, ulong tooLong) tupleType2 = (123, "Data", 'H', "Code", 123456);
            Console.Write("typleType1 и 2...");
            if (tupleType1 == tupleType2)
                Console.WriteLine(" Одинаковы");
            else Console.WriteLine(" Различны");
            Console.WriteLine("########################################################################################################################");
            (int, string, char, string, ulong) anonTupleType = (1, "2", '3', "4", 5);
            tupleType2 = anonTupleType;
            Console.WriteLine(tupleType2.datas);
            int anonNumber = anonTupleType.Item1;
            Console.WriteLine(anonNumber);
            char _ = anonTupleType.Item3;
            Console.WriteLine("Значение переменной _: " + _);
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("########################################################################################################################");
//ЗАДАНИЕ 4 ВЫПОЛНЕНО
            static (int, int, int, char) localFunc1(int[] intArray, string strIn)
            {
                int min = 32000;
                int max = -32000;
                int sum = 0;
                foreach (int alpha in intArray)
                {
                    sum += alpha;
                    if (min > alpha)
                        min = alpha;
                    if (max < alpha)
                        max = alpha;
                }
                char firstCh = strIn[0];
                return (min, max, sum, firstCh);
            };
            int[] exampleArray1 = { 1, 2, -3, 4, 5, 12, -46, 0, 23, 16 };
            string exampleString1 = "Miau";
            Console.WriteLine(localFunc1(exampleArray1, exampleString1));
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("########################################################################################################################");
//ЗАДАНИЕ 5 ВЫПОЛНЕНО
            static int checkedFunc(int beta)
            {
                checked
                {
                    beta = 2147483647;
                    //beta = (int)2147483648;
                }
                return beta;
            };
            static int uncheckedFunc(int gamma)
            {
                unchecked
                {
                    gamma = (int)4295483647;
                    //gamma = 2147483647;
                }
                return gamma;
            };
            int delta = 0;
            Console.WriteLine(checkedFunc(delta));
            delta = 0;
            Console.WriteLine(uncheckedFunc(delta));
//ЗАДАНИЕ 5 ВЫПОЛНЕНО
        }
    }
}
