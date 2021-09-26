//примитивные типы данных
namespace PDT
{
    class Example
    {
        static void Main()
        {
            bool boolPDT = false;
            byte bitePDT = 123;
            sbyte sbitePDT = -128;
            short shortPDT = -30000;
            ushort ushortPDT = 1;
            int intPDT = 21568;
            int uintPDT = 1147483647;
            long londPDT = 9223372036854775800;
            ulong ulongPDT = 0;
            System.Single floatPDT = 12.3f;
            System.Double doublePDT = 12345.135445;
            System.Decimal decimalPDT = 0.21891815548165m;
            char charPDR = 'r';
            System.String hello = "Hello, World!";
            System.Object objectPDT = 8;
            System.Console.WriteLine($"Примитивные типы данных:\nBOOL: {boolPDT}\n BYTE: {bitePDT}\n  SIGNED BYTE: {sbitePDT}\n   SHORT: {shortPDT}\n    UNSIGNED SHORT: {ushortPDT}\n     INTEGER: {intPDT}\n      UNSIGNED INTEGER: {uintPDT}\n       LONG: {londPDT}\n        UNSIGNED LONG: {ulongPDT}\n         FLOAT: {floatPDT}\n          DOUBLE: {doublePDT}\n           DECIMAL: {decimalPDT}\n            CHARACTER: {charPDR}\n             STRING: {hello}\n              OBJECT: {objectPDT}");
            System.Console.WriteLine("########################################################################################################################");
            System.Console.WriteLine("Ввод данных:");
            System.String buff;
            System.Console.Write("bool: ");
            buff = System.Console.ReadLine();
            //bool yourBool = bool.Parse(buff);
            bool yourBool = System.Convert.ToBoolean(buff);
            System.Console.WriteLine(yourBool);
            System.Console.Write("int: ");
            buff = System.Console.ReadLine();
            int yourInt = int.Parse(buff);
            System.Console.WriteLine(yourInt);
            System.Console.Write("double: ");
            buff = System.Console.ReadLine();
            double yourDouble = System.Convert.ToDouble(buff);
            System.Console.WriteLine(yourDouble);
            System.Console.Write("float: ");
            buff = System.Console.ReadLine();
            float yourFloat = float.Parse(buff);
            System.Console.WriteLine(yourFloat);
            System.Console.Write("char: ");
            char yourChar = (char)System.Console.Read();
            System.Console.WriteLine(yourChar);
            System.Console.WriteLine("########################################################################################################################");
            System.Console.WriteLine("Приведение типов:\n");
            int a_int = 258;
            byte b_byte = (byte)a_int; // явное приведение, а по факту ещё и сужающее
            System.Console.WriteLine("Narrowing int " + a_int + " -> byte " + b_byte);
            short c_short = 32000;
            double d_double = c_short; // неявное приведение, а по факту ещё и расширяющее
            System.Console.WriteLine("Widening short " + c_short + " -> double " + d_double);
            System.Console.WriteLine("########################################################################################################################");
            System.Int32 x = 123;
            System.Object x_boxed = x;
            char x_char = (char)(int)x_boxed;
            System.Console.WriteLine("До упаковки был int " + x + ", а после распаковки преобразовал до char '" + x_char + "'");
            var y = 'c';
            System.Console.WriteLine("Тип неявно типизированной переменной: " + y.GetType());
            //y = 12.34;
            int? z_int1 = null;
            System.Nullable<int> z_int2 = null;
            System.Console.WriteLine("Значения переменных z_int1 и z_int2 равны" + z_int1 + " " + z_int2 + "соответственно");
            System.Console.WriteLine("########################################################################################################################");
            System.Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("########################################################################################################################");
//ЗАДАНИЕ 1 ЗАВЕРШЕНО
            System.String string1 = "Mother";
            System.String string2 = "Father";
                System.Console.Write("1) Равны ли строки: "); System.Console.WriteLine(string1 == string2 ? "Да" : "Нет");
            System.String string3 = "Uncle";
                System.Console.WriteLine($"Первая строка: {string1}\nВторая строка: {string2}\nТретья строка: {string3}");
            string3 = string3 + string1;
            System.String emptyString = "";
            emptyString = string2;
                System.Console.WriteLine($"Конкатенация: {string3}\nПустая строка после копирования в неё второй строки: {emptyString}");
                System.Console.WriteLine("Подстрока из "+string3+": " + string3.Substring(3,6));
            System.String stringWithSpaces = "Очень длинная строка";
            System.String[] words = stringWithSpaces.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                System.Console.WriteLine("Слова из строки '"+stringWithSpaces+"':");
            foreach (string word in words)
                System.Console.WriteLine(word);
                System.Console.WriteLine("Вставка второй строки в первую: " + string1.Insert(3,string2));
            string3 = string3.Substring(0, 4);
                System.Console.WriteLine($"Обрезанная конкатенированная строка: {string3}");
            string nullString = "";
                System.Console.Write("Строка nullString пустая: "); System.Console.WriteLine(System.String.IsNullOrEmpty(nullString)? "Да":"Нет");
            System.Text.StringBuilder sringBuildedString = new System.Text.StringBuilder("Привет!", 50);
            sringBuildedString.Remove(3,2);
                System.Console.WriteLine("Созданная в стрингбилдере строка без 4 и 5 символов: "+sringBuildedString);
            System.Text.StringBuilder buffing = new System.Text.StringBuilder();
            buffing.Append('<');
            buffing.Append(sringBuildedString);
            buffing.Append('>');
            sringBuildedString = buffing;
            System.Console.WriteLine("Добавление спереди и сзади по символу: " + sringBuildedString);
            System.Console.WriteLine("########################################################################################################################");
            System.Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("########################################################################################################################");
//ЗАДАНИЕ 2 ЗАВЕРШЕНО
        }
    }
}