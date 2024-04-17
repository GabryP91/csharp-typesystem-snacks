/*
 
Snack 1
L’utente inserisce due numeri in successione.
Il software stampa il maggiore.

Snack 2
L’utente inserisce due parole in successione.
Il software stampa prima la parola più corta, poi la parola più lunga.

Snack 3
Il software deve chiedere per 10 volte all’utente di inserire un numero.
Il programma stampa la somma di tutti i numeri inseriti.

Snack 4
Calcola la somma e la media dei numeri da 2 a 10.

Snack 5
Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Snack 6
In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

Snack 7
Crea un array vuoto.
Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

Snack 8
Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

Snack 9
Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

Snack 10
Fai inserire un numero, che chiameremo N, all’utente.
Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
Ogni volta che ne crei uno, stampalo a schermo.
 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //------------Primo snack--------------------
            Console.WriteLine("\nPrimo snack:");
            Console.WriteLine("\nInserire primo numero:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInserire secondo numero:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //condizione di verifica
            if(number1 > number2)
            Console.WriteLine($"\nIl numero più grande sarà: {number1} ");
            else if (number1 == number2)
            Console.WriteLine($"\nI due numeri sono uguali ");
            else
            Console.WriteLine($"\nIl numero più grande sarà: {number2} ");


            //--------Secondo snack------------------
            Console.WriteLine("\nSecondo snack:");
            Console.WriteLine("\nInserire prima parola:");
            string word1 = Console.ReadLine();
            Console.WriteLine("\nInserire seconda parola:");
            string word2 = Console.ReadLine();

            //condizione di verifica

            if (word1.Length < word2.Length)
                Console.WriteLine($"\nLa parola più corta sarà: {word1} e quella più lunga sarà: {word2}");

            else if(word1.Length == word2.Length)
                Console.WriteLine($"\nLe due parole hanno la stessa lunghezza ");

            else 
                Console.WriteLine($"\nLa parola più corta sarà: {word2} e quella più lunga sarà: {word1}");


            //--------Terzo snack------------------
            int somma=0;

            //Avvio il ciclo 10 volte
            for (int i=0; i<10;i++)
            {
                Console.WriteLine("\nInserire un numero:");

                int numberUser = Convert.ToInt32(Console.ReadLine());

                somma = somma + numberUser;

                Console.WriteLine($"\nLa somma è: {somma} ");

            }

            Console.WriteLine($"\nLa somma Totale sarà: {somma} ");


            //--------Quarto snack------------------
            somma = 0;
            int media = 0, numTot=0;
            for (int i = 2; i <= 10; i++)
            {
                somma += i; //sommo i valori

                numTot++; //incremento la variabile per tenere traccia del numero di elementi effettivi 
            }

            media = somma / numTot;

            Console.WriteLine($"\nLa somma Totale sarà: {somma} ");
            Console.WriteLine($"\nLa media sarà: {media} ");
            
            //--------Quinto snack------------------

            // Inserisco un numero
            Console.WriteLine("\nInserire un numero:");
            int numberUser = Convert.ToInt32(Console.ReadLine());

            if (numberUser % 2 == 0)
            {
                Console.WriteLine($"\nIl numero è: {numberUser} ed è pari ");
            }
            else
                Console.WriteLine($"Il numero inserito è dispari, il successivo è :{numberUser + 1}");

            //--------Sesto snack------------------
            string[] Invitati = { "pippo", "pluto", "paperino" };

            Console.WriteLine("\nInserire il tuo nome:");
            string nameUser = Console.ReadLine();

            //ciclo su tutto il mio array
            foreach (string invitatoNome in Invitati)
            {
                if (nameUser == invitatoNome)
                {
                    Console.WriteLine("\nSei dei nostri, la bamba è di la :)");
                }
            }

            //--------Settimo snack------------------

            Console.ReadKey();
        }
    }
}
