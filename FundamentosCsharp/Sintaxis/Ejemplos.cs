using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sintaxis
{
    internal class Ejemplos
    {
        //bool continueSoftwareExecution = false;
        //// do while
        //do
        //{
        //    Console.WriteLine("Do you wish to keep the software running? write 1 if yes, 0 if no");
        //    int keepGoing = Convert.ToInt16(Console.ReadLine());
        //    if (keepGoing == 1)
        //    {
        //        Console.WriteLine("Hello World! The software will keep running");
        //        continueSoftwareExecution = true;
        //    }
        //    else if (keepGoing == 0)
        //    {
        //        Console.WriteLine("This is the last time the software is running");
        //        continueSoftwareExecution = false;
        //    }
        //    else
        //        Console.WriteLine("Invalid input, Try Again");
        //} while (continueSoftwareExecution == true);
        //// while
        ////while (true)
        ////{
        ////    Console.WriteLine("Codigo");
        ////}


        //// switch
        //Console.WriteLine("Enter the selected soda: ");
        //string caseSwitch = Console.ReadLine();
        //switch (caseSwitch)
        //{
        //    case "cola":
        //        Console.WriteLine("Cola soda - $2 USD");
        //        break;
        //    case "lime":
        //        Console.WriteLine("Lime soda - $1 USD");
        //        break;
        //    case "orange":
        //        Console.WriteLine("Orange soda - $1.5 USD");
        //        break;
        //    case "apple":
        //        Console.WriteLine("Apple soda - $1 USD");
        //        break;
        //    default:
        //        Console.WriteLine("ERROR: You did not select a soda or you entered an incorrect value.");
        //        break;
        //}


        //// listas
        //List<string> tacoShoppingList = new List<string>();
        //tacoShoppingList.Add("Cinco Tacos de suadero");
        //tacoShoppingList.Add("Cuatro Tacos de Tripa");
        //tacoShoppingList.Add("Cinco tacos de pastor");
        //tacoShoppingList.Add("Cuatro Coca Colas");
        //for (int i = 0; i < tacoShoppingList.Count; i++)
        //{
        //    Console.WriteLine(tacoShoppingList[i]);
        //}
        //tacoShoppingList.Remove("Cinco Tacos de suadero");
        ////tacoShoppingList.RemoveAt(0);
        //for (int i = 0; i < tacoShoppingList.Count; i++)
        //{
        //    Console.WriteLine(tacoShoppingList[i]);
        //}


        //// arreglos
        //string[] coffeTypes;
        //float[] coffePrices;
        //coffeTypes = new string[] { "Expresso", "Largo", "Filtrado", "Latte" }; //4
        //coffePrices = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };
        //coffeTypes[1] = "Lungo";
        //for (int i = 0; i < 4; i++)
        //    Console.WriteLine(coffeTypes[i] + "Coffe $" + coffePrices[i]);


        //// operadores relacionales == != > < >= <=
        //int value1 = 3;
        //int value2 = 18;
        //bool result0 = value1 == value2;
        //Console.WriteLine("The result of value1 == value2 is: " + result0);
        //bool result1 = value1 != value2;
        //Console.WriteLine("The result of value1 != value2 is: " + result1);
        //bool result2 = value1 > value2;
        //Console.WriteLine("The result of value1 > value2 is: " + result2);
        //bool result3 = value1 < value2;
        //Console.WriteLine("The result of value1 < value2 is: " + result3);
        //bool result4 = value1 >= value2;
        //Console.WriteLine("The result of value1 >= value2 is: " + result4);
        //bool result5 = value1 <= value2;
        //Console.WriteLine("The result of value1 <= value2 is: " + result5);


        //// operadores logicos && , ||, !
        //bool value1 = true;
        //bool value2 = true;
        //bool value3 = false;
        //bool result = value1 && value2 && value3;
        //Console.WriteLine("The result of the logical AND is: " + result);
        //bool result2 = value1 || value2 || value3;
        //Console.WriteLine("The result of the logical OR is: " + result2);
        //bool result3 = !value1;
        //Console.WriteLine("The result of the logical ! is: " + result3);


        ////tipos de datos
        //bool siOno = false;
        //// va del 0 al 255
        //byte bytesPositivos = 255;
        //// sbyte va del -128 al 127
        //sbyte bytesNegativo = -128;
        //int enterosMasMenos = -20;
        //uint enterosMas = 30;
        //long enterosLargos = 2002020202020;
        //float flotante = 23.2f;
        //double flotanteMaslargo = 23.42423234d;
        //decimal numeroDecimal = 32.23424m;
        //char caracter = 'A';
        //string cadena = "Cadena de texto";
        //DateTime date = DateTime.Now;



        ////Area de un rectangulo.
        ////a las variables de tipo flotante se les agrega una f al final
        //float sideA = 10.0f;
        //int sideB = 1;
        //sideB++;
        //sideB++;
        //sideB++;
        //sideB--;
        //// operadores aritmeticos + - / * %(modulo) ++ --
        //float area = sideA * sideB;
        //Console.WriteLine("The rectangle area: " + area);


        //Console.WriteLine("Hello Platzi!");
        //int height = 170;
        //int age = 20;
        //string name = "Ricardo Celis";
        //string information = "the requested info is: \n User name " + name + "\n user age "
        //    + age + " \n user height " + height;
        //Console.WriteLine(information);


        //Console.WriteLine("Name: ");
        //string fullName = Console.ReadLine();
        //Console.WriteLine("Hola " + fullName );
        //Console.WriteLine("Age: ");
        //int age2 = Convert.ToInt32(Console.ReadLine());
        //if (age2 < 18)
        //{
        //    Console.WriteLine("Toma refresco");
        //}
        //else {
        //    Console.WriteLine("Toma cerveza");
        //}
    }
}
