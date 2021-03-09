/*
 * Autore: Giovanni Marchetto
 * Data 09/03/2021
 * Consegna:
 
Facili: Insertion, selection

Medi: bubble

Difficili: merge + quick.


Il primo algoritmo è relativo a "quello che ho già fatto". Il secondo è quello da fare e da confrontare con ciò che è già stato fatto.


Selection sort --> Merge sort

Insertion sort --> Quick sort

Bubble sort --> Merge sort

Bubble sort con sentinella--> Quick sort

Quick sort --> Bubble sort con sentinella

Merge sort --> Bubble sort con sentinella

Quick+Merge --> Bubble sort con sentinella

*/
using System;

namespace Bubble_sort_con_sentinella
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempoRiordinoNumeri = new System.Diagnostics.Stopwatch();
            
            Random random = new Random(); //Inizializza la classe random
            int Quantità = 0; //Inizializzo la variabile Quantità e le do valore 0
            int Min; //Inizializzo la variabile Min
            int Max; //Inizializzo la variabile Max
            int randomNumber; //Inizializzo la variabile randomNumber
            int x = 0;
            int temp;
            int y = 0;

            Console.WriteLine("Inserisci quanti numeri devono essere riordinati"); //Chiedo all'utente la frase inserisci quanti numeri devono essere riordinati
            Quantità = Convert.ToInt32(Console.ReadLine()); //inserisco nella variabile Quantità il valore scelto dall'utente

            Console.WriteLine("Inserisci il numero minimo"); //Chiedo all'utente la frase inserisci il numero minimo
            Min = Convert.ToInt32(Console.ReadLine()); //inserisco nella variabile Min il valore scelto dall'utente

            Console.WriteLine("Inserisci il numero massimo"); //Chiedo all'utente la frase inserisci il numero massimo
            Max = Convert.ToInt32(Console.ReadLine()); //inserisco nella variabile Max il valore scelto dall'utente

            Console.WriteLine(); //A capo
            Console.WriteLine(); //A capo

            int[] numeri = new int[Quantità]; //array

            for (int i = 0; i < numeri.Length; i++) //Creo un ciclo for per creare i numeri pseudo-randomici
            {
                randomNumber = random.Next(Min, Max); //Creo un ciclo for per creare e inserire nel file i numeri pseudo-randomici
                numeri[i] = randomNumber; //Inserire nell'array il valore della variabile randomNumber
            }

            Console.WriteLine("I numeri di partenza sono: "); //Digito a schermo la seguente frase
            for (int i = 0; i < Quantità; i++) //Ciclo for per scrivere i numeri contenuti nell'array numeri
            {
                Console.WriteLine(numeri[i] + " ");
            }

            Console.WriteLine(); //A capo
            Console.WriteLine(); //A capo
            Console.WriteLine(); //A capo
            Console.WriteLine(); //A capo

            int Sentinella = numeri.Length;
            tempoRiordinoNumeri.Start();
            do
            {
                x = 0;
                for (int i = 0; i < Sentinella - 1; i++)
                {
                    if (numeri[i] > numeri[i + 1])
                    {
                        temp = numeri[i];
                        numeri[i] = numeri[i + 1];
                        numeri[i + 1] = temp;
                        x = 1;
                        y = i + 1;
                    }
                }
                Sentinella = y;
            } while (x == 1);
            tempoRiordinoNumeri.Stop();
            double temRiordNum = Convert.ToDouble(tempoRiordinoNumeri.ElapsedMilliseconds);//assegna alla variabile "tempRiordNum" il tempo che il programma ha impiegato per riordinare l'array di numeri generati

            Console.WriteLine("I numeri riordinati sono: "); //Digito a schermo la seguente frase
            for (int i = 0; i < Quantità; i++) //Ciclo for per scrivere i numeri riordinati contenuti nell'array numeri
            {
                Console.WriteLine(numeri[i] + " ");
            }
            

            Console.WriteLine(); //A capo
            Console.WriteLine(); //A capo

            //calcolo il tempo per la generazione dei numeri
            if (temRiordNum >= 1000)
            {
                if (temRiordNum >= 60000)
                {
                    temRiordNum = temRiordNum / 1000;
                    while (temRiordNum >= 60)
                    {
                        temRiordNum = temRiordNum / 60;
                    }                    
                    Console.WriteLine($"{temRiordNum.ToString()} m");
                }
                else
                {
                    temRiordNum = temRiordNum / 1000;
                    Console.WriteLine($"{temRiordNum.ToString()} s");
                }
            }
            else
            {
                Console.WriteLine($"{temRiordNum.ToString()} ms");
            }
            Console.ReadKey(); //Blocco il programma
        }
    }
}