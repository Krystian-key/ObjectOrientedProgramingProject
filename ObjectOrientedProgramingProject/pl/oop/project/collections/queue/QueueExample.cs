/*using System;
using System.Collections;

namespace ObjectOrientedProgramingProject.pl.oop.project.collections.queue
{
    public class QueueExampl
    {
        public static void Main(string[] args)
        {
            
            Queue myQueue = new Queue();
            myQueue.Enqueue("Umiem");
            myQueue.Enqueue("w");
            myQueue.Enqueue("Kolejki");
            
            Console.WriteLine( "Liczba wywołań: {0}", myQueue.Count);
            Console.WriteLine( "3 wywołania" );
            PrintValues( myQueue );
        }

        public static void PrintValues( IEnumerable myCollection )  {
            foreach ( Object obj in myCollection )
                Console.Write( "    {0}", obj );
            Console.WriteLine();
        }
        }
    }

/*
 * Enqueue dodaje element na końcu Queue .
 * Dequeue usuwa najstarszy element od początku Queue .
 * Peek zwraca najstarszy element, który znajduje się na początku, Queue ale nie usuwa go z Queue .
 #1#*/