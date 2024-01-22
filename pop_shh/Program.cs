using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const int One = 1;

        const string MenuMsg = "A. Saltar\r\nB. Córrer\r\nC. Ajupir-se\r\nD. Amagar-se";

        int dia=One,
         mes = One,
         any = One;

        bool validat, valitInput;
        string input;

        Console.WriteLine("Introdueix el dia");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdueix el mes");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdueix l'any");
        any = Convert.ToInt32(Console.ReadLine());

        validat = valida(dia, mes, any);
        if (!validat)
        {
            Console.WriteLine("La data {0}/{1}/{2} no és correcta", dia, mes, any);

        }
        else
        {
            Console.WriteLine("La data {0}/{1}/{2} és correcta {3}", dia, mes, any, validat);

        }
       

        do
        {
            Console.WriteLine(MenuMsg);
            input = Console.ReadLine()??"";
            valitInput=CheckInput(input);
            Action(input);
        }while(!valitInput);

    }

    public static bool valida(int day, int month, int year)
    {

        const int One = 1, ThirtyOneDays = 31, ThirtyDays = 30, TweentyEightDays = 28, TweentyNineDays = 29,
                  Zero = 0,FourYears=4, FourHundredYears = 400, HundredYears = 100, TwelveMonths = 12;

        if (day < One || day > ThirtyOneDays)

            return false;

        if (month < One || month > TwelveMonths)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = Zero;

        switch (month)
        {
            case 1:

            case 3:

            case 5:

            case 7:

            case 8:

            case 10:

            case 12: totalDaysMonth = ThirtyOneDays; break;

            case 4:

            case 6:

            case 9:

            case 11: totalDaysMonth = ThirtyDays; break;

            case 2: // verifica l'any de traspàs

                if ((year % FourHundredYears == Zero) ||

                ((year % FourYears == Zero) && (year % HundredYears != Zero)))
                    totalDaysMonth = TweentyNineDays;

                else totalDaysMonth = TweentyEightDays;

                break;

        }

        if (day > totalDaysMonth)

            return false;

        else return true;

    }

    public static void Action(string action)
    {
        const string Jump = "Salt0", Run = "Córr0", Squat = "M'ajupo", Hide = "M'amago", Error = "acció no valida"; 
        action=action.ToUpper();
        switch (action)
        {
            case "A":
                Console.WriteLine(Jump);
                break;
            case "B":
                Console.WriteLine(Run);
                break;
            case "C":
                Console.WriteLine(Squat);
                break;
            case "D":
                Console.WriteLine(Hide);
                break;
            default:
                Console.WriteLine(Error);
                break;

        }
    }
    public static bool CheckInput(string input)
    {

        const string CorrectInput= "ABCD";
        input= input.ToUpper();


        for (int i = 0; i < CorrectInput.Length; i++)
        {
            if (input.Equals(CorrectInput[i].ToString()))
                return true;
        }
        return false;
    }

}