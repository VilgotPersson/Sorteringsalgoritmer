using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Insertionsort(List<int> minlista)
        {
            int i, n;
            int length = minlista.Count;
            if (length < 2) return;
            int temp;
            for (n = 1; n < length; n++)
            {
                temp = minlista[n];
                i = n - 1;
                while(i>=0 && minlista[i]>temp)
                {
                    minlista[i + 1] = minlista[i];
                    i--;
                }
                minlista[i + 1] = temp;
            }
        }
        static void Bubbelsort(List<int> minLista)
        {
            for(int i = 0; i < minLista.Count; i++)
            {
                for(int j=0; j < minLista.Count-1; j++)
                {
                    if(minLista[j] > minLista[j+1])
                    {
                        int tempo = minLista[j];
                        minLista[j] = minLista[j + 1];
                        minLista[j + 1] = tempo;
                    }
                }
            }
                
        }
        
        static void Main(string[] args)
        {


            var tallista = new List<int>();
            Random slump = new Random();
            for(int i = 0; i < 100000; i++)
            {
                tallista.Add(slump.Next(100000));
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Insertionsort(tallista);
            stopWatch.Stop();
            Console.WriteLine("Listan är sorterad!");
            Console.WriteLine("Tiden: " + stopWatch.Elapsed);
            }

        }
    }
