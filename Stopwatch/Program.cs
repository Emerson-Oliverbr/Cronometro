using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Menu();
        }

        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("S = Segundos,  Exemplo => 10s ou 10S = 10 Segundos");
            Console.WriteLine("M = Minutos, Exemplo => 10m ou 10M = 10 Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");

            string? data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            Console.WriteLine(data);        
            Console.WriteLine(type); 
        }    
        static void Start(int time)
        {
            int currentTime = 0 ;
             
            while(currentTime != time)
            {
                Console.Clear();
                currentTime +=1;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            } 
            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado");      
            Thread.Sleep(1500);
        }         
    }
}