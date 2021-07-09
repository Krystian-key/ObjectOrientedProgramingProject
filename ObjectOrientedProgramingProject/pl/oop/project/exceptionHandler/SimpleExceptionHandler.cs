/*using System;

namespace ObjectOrientedProgramingProject.pl.oop.project.exceptionHandler
{
    public class ExceptionHandler
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Proszę podać numer");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Proszę podać drugi numer w celu wykoniania dzielenia");
                int secondNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("wynik dzielenia " + num / secondNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Podaj numer, nie literę :)");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(
                    "Mistrzy matemtyczny kiedyś do swego ucznia powiedział - 'pamiętaj cholero, nigdy nie dziel przez zero.' ");
            }
            finally
            {
                Console.WriteLine("Zawsze sie wykonuje, niezależnie od rezultatu!");
            }
        }
    }
}*/