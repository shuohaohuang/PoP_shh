using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const int One = 1;
        int dia=One,
         mes = One,
         any = One;

        bool validat;
        Console.WriteLine("Introdueix el dia");
        dia=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdueix el mes");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdueix l'any");
        any = Convert.ToInt32(Console.ReadLine());

        validat = valida(dia, mes, any);
        if(!validat)
        {
            Console.WriteLine("La data {0}/{1}/{2} no és correcta", dia, mes, any);

        }
        else
        {
            Console.WriteLine("La data {0}/{1}/{2} és correcta {3}",dia,mes,any,validat);

        }
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
}