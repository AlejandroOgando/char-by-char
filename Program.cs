using System;

namespace char_by
{
    class Program
    {
        static string GetNames ()
        {
            var name = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;
                if (key == ConsoleKey.Backspace && name.Length > 0)
                {
                    Console.Write("\b \b");
                    name = name[0..^1];
                }
                else if (char.IsLetter(keyInfo.KeyChar))
                {
                   Console.Write(keyInfo.KeyChar);
                    name += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return name;
        }
        static string GetNumbers ()
        {
            var num = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && num.Length > 0)
                {
                    Console.Write("\b \b");
                    num = num[0..^1];
                }
                else if (char.IsDigit(keyInfo.KeyChar))
                {
                    Console.Write(keyInfo.KeyChar);
                    num += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return num;
        }
        
        static float GetCoin ()
        {
            var num = string.Empty;
            float coins;
            bool exist = true;
            ConsoleKey key;
            Console.Write("Ahorros: ");
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && num.Length > 0)
                {
                    Console.Write("\b \b");
                    num = num[0..^1];
                }else if ((key == ConsoleKey.OemPeriod) && exist)
                {
                    Console.Write(keyInfo.KeyChar);
                    num += keyInfo.KeyChar;
                    exist = false;
                }
                else if (char.IsDigit(keyInfo.KeyChar))
                {
                    Console.Write(keyInfo.KeyChar);
                    num += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            coins = float.Parse(num);
            return coins;
        }
        static string EncodePassword ()
        {
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return pass;
        }
        static void Password ()
        {
            string pass = "";
            string pass1 = "";
            Console.Write("Escriba su contraseña: ");
            pass = EncodePassword();
            Console.WriteLine();
            do
            {
                Console.Write("Vuelva a escribir su contraseña: ");
                pass1 = EncodePassword();
                Console.Clear();
            } while (!(pass == pass1));

            Console.WriteLine("Su contraseña coincide.");
        }
        static void Main(string[] args)
        {
            //Password();
            
            int endProg =0;
            do
            {
                int num;
                Console.WriteLine();
                Console.WriteLine("Menú Principal");
                Console.WriteLine("----------------------------------------------------------");
                Console.Write("(1). Nombres y apellido.\n");
                Console.Write("(2). Edad.\n");
                Console.Write("(3). Ahorros\n");
                Console.Write("(4). Password.\n");
                Console.Write("(5). Salir.\n");
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("Escrica el número de la opción que desea: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (num)
                {
                    case 1:
                        string name, lastName;
                        Console.Write("Nombre ");
                        name = GetNames();
                        Console.Write("\nApellidos: ");
                        lastName = GetNames();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("{0} {1}", name,lastName);
                    break;
                    case 2:
                        Read(filePath);
                        Console.WriteLine("\nPresione cualquier tecla para volver al menú.");
                        Console.ReadKey();
                    break;
                    case 3:
                        string idFinder;
                        Console.WriteLine("\nIntroduzca la cédula que desea buscar en el archivo");
                        idFinder = Console.ReadLine();
                        Console.WriteLine();
                        Search(filePath, idFinder);
                    break;
                    case 4:
                        string idFinder1;
                        Console.WriteLine("\nIntroduzca la cédula que desea borrar en el archivo");
                        idFinder1 = Console.ReadLine();
                        Console.WriteLine();
                        Delete(filePath, idFinder1);
                    break;
                    case 5:

                    break;
                    case 6:
                        endProg++; 
                    break;
                    default:
                    Console.WriteLine("No es una entrada válida.");
                    break;
                }
            } while (endProg == 0);
        }
    }
}
