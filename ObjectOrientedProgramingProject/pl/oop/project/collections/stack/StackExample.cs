/*using System;
using System.Collections;

namespace ObjectOrientedProgramingProject.pl.oop.project.collections.stack
{
    public class StackExample
    {
        public static void Main()  {
            
            Stack myStackExample = new Stack();
            myStackExample.Push("Umiem ");  // wpuszowywuje na stack obiekt
            myStackExample.Push("W ");
            myStackExample.Push("Stacki ");
            
            Console.WriteLine( "wyswietl moj stack" );
            Console.WriteLine( "Count: {0}", myStackExample.Count);
            Console.WriteLine( "Values:" );
            PrintValues( myStackExample );
        }
        public static void PrintValues( IEnumerable myStockCollection )  {                 // uzycie interfejsu implementacja w kocsach c#
            foreach ( Object stacku in myStockCollection )
                Console.Write( "{0}", stacku );
             
        }
    }
}

/*
 *Jeśli Count jest mniejsza niż pojemność stosu, Push jest O(1) operacją.
 * Jeśli pojemność musi być zwiększona w celu uwzględnienia nowego elementu, to Push O(n) operacja, gdzie n is Count . Pop jest O(1) operacją.
Stack akceptuje null jako prawidłową wartość i umożliwia duplikowanie elementów.
 *
 * 
 #1#*/