/*
 
Snack 1
L’utente inserisce due numeri in successione.Il software stampa il maggiore.

Snack 2
L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga.

Snack 3
Il software deve chiedere per 10 volte all’utente di inserire un numero.Il programma stampa la somma di tutti i numeri inseriti.

Snack 4
Calcola la somma e la media dei numeri da 2 a 10.

Snack 5
Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Snack 6
In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

Snack 7
Crea un array vuoto.Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

Snack 8
Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

Snack 9
Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

Snack 10
Fai inserire un numero, che chiameremo N, all’utente.Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.
 
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

            Console.WriteLine("Digitare il numero dello snack da eseguire (da 1 a 10):");
            int scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                        //------------Primo snack--------------------
                        Console.WriteLine("\nPrimo snack: L’utente inserisce due numeri in successione.Il software stampa il maggiore.");
                        Console.WriteLine("\nInserire primo numero:");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nInserire secondo numero:");
                        int number2 = Convert.ToInt32(Console.ReadLine());

                        //condizione di verifica
                        if (number1 > number2)
                            Console.WriteLine($"\nIl numero più grande sarà: {number1} ");
                        else if (number1 == number2)
                            Console.WriteLine($"\nI due numeri sono uguali ");
                        else
                            Console.WriteLine($"\nIl numero più grande sarà: {number2} ");
                    break;

                case 2:
                        //--------Secondo snack------------------
                        Console.WriteLine("\nSecondo snack: L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga.");
                        Console.WriteLine("\nInserire prima parola:");
                        string word1 = Console.ReadLine();
                        Console.WriteLine("\nInserire seconda parola:");
                        string word2 = Console.ReadLine();

                        //condizione di verifica

                        if (word1.Length < word2.Length)
                            Console.WriteLine($"\nLa parola più corta sarà: {word1} e quella più lunga sarà: {word2}");

                        else if (word1.Length == word2.Length)
                            Console.WriteLine($"\nLe due parole hanno la stessa lunghezza ");

                        else
                            Console.WriteLine($"\nLa parola più corta sarà: {word2} e quella più lunga sarà: {word1}");

                    break;

                case 3:
                        //--------Terzo snack------------------
                        Console.WriteLine("\nTerzo snack: Il software deve chiedere per 10 volte all’utente di inserire un numero.Il programma stampa la somma di tutti i numeri inseriti.");
                        int somma = 0;

                        //Avvio il ciclo 10 volte
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("\nInserire un numero:");

                            int numberUser = Convert.ToInt32(Console.ReadLine());

                            somma = somma + numberUser;

                            Console.WriteLine($"\nLa somma è: {somma} ");

                        }

                        Console.WriteLine($"\nLa somma Totale sarà: {somma} ");

                    break;

                case 4:
                        //--------Quarto snack------------------
                        Console.WriteLine("\nQuarto snack: Calcola la somma e la media dei numeri da 2 a 10.");

                        somma = 0;
                        int media = 0, numTot = 0;
                        for (int i = 2; i <= 10; i++)
                        {
                            somma += i; //sommo i valori

                            numTot++; //incremento la variabile per tenere traccia del numero di elementi effettivi 
                        }

                        media = somma / numTot;

                        Console.WriteLine($"\nLa somma Totale sarà: {somma} ");
                        Console.WriteLine($"\nLa media sarà: {media} ");

                    break;

                case 5:
                        //--------Quinto snack------------------
                        Console.WriteLine("\nQuinto snack: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");
                        // Inserisco un numero
                        Console.WriteLine("\nInserire un numero:");
                        int numberUser2 = Convert.ToInt32(Console.ReadLine());

                        if (numberUser2 % 2 == 0)
                        {
                            Console.WriteLine($"\nIl numero è: {numberUser2} ed è pari ");
                        }
                        else
                            Console.WriteLine($"Il numero inserito è dispari, il successivo è :{numberUser2 + 1}");

                    break;

                case 6:
                        //--------Sesto snack------------------
                        Console.WriteLine("\nSesto snack: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.");
                        string[] Invitati = { "pippo", "pluto", "paperino" };
                        bool trovato = false;
                        Console.WriteLine("\nInserire il tuo nome:");
                        string nameUser = Console.ReadLine();

                        //ciclo su tutto il mio array
                        foreach (string invitatoNome in Invitati)
                        {
                            if (nameUser == invitatoNome)
                            {
                                trovato = true;
                            }
                        }
                        if(trovato == true) Console.WriteLine("\nSei dei nostri, la bamba è di la :)");

                        else Console.WriteLine("\nNon sei nella lista :(");

                    break;

                case 7:

                        //--------Settimo snack------------------
                        Console.WriteLine("\nSettimo snack: Crea un array vuoto.Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.");
                        int[] arrayDisp = new int[0];

                        int contatore = 0;

                        for (int i = 0; i < 6; i++)
                        {
                            // Inserisco un numero
                            Console.WriteLine("\nInserire un numero:");
                            int numberUser3 = Convert.ToInt32(Console.ReadLine());

                            // Verifico se il numero inserito è dispari
                            if (numberUser3 % 2 != 0)
                            {

                                // ridimensiono il mio array vuoto con una nuova posizione
                                Array.Resize(ref arrayDisp, arrayDisp.Length + 1);

                                //assegno il valore digitato dall'utente all'ultima posizione creata
                                arrayDisp[arrayDisp.Length - 1] = numberUser3;

                                contatore++; // Incremento il contatore
                            }

                        }

                        // Stampo i numeri dispari inseriti nell'array
                        Console.WriteLine("Numeri dispari inseriti:");
                        for (int i = 0; i < contatore; i++)
                        {
                            Console.WriteLine(arrayDisp[i]);
                        }

                    break;

                case 8:

                        //--------Ottavo snack------------------
                        Console.WriteLine("\nOttavo snack: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.");
                        int[] ArrayInt = new int[] { 1, 2, 3, 4, 5, 6, 88, 45, 13, 24, 11, 51, 347 };

                        int sommaValDisp = 0;

                        //modifico il ciclo for in modo tale da "beccare" solo i valori nelle posizioni dispari
                        for (int i = 1; i < ArrayInt.Length; i += 2)
                        {
                            //Sommo tranquillamente ogni valore che ottengo dall'array
                            sommaValDisp += ArrayInt[i];
                        }

                        Console.WriteLine($"\nla somma totale di tutti gli elementi in posizione dispari sarà: {sommaValDisp}");

                    break;

                case 9:
                        //--------Nono snack------------------
                        Console.WriteLine("\nNono snack: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.");
                        // Creo il mio array vuoto
                        int[] ArrayGen = new int[0];

                        // Variabile per memorizzare la somma degli elementi
                        somma = 0;

                        while (somma < 50)
                        {
                            // Inserisco un numero
                            Console.WriteLine("\nInserire un numero:");
                            int numberUser4 = Convert.ToInt32(Console.ReadLine());


                            // ridimensiono il mio array vuoto con una nuova posizione
                            Array.Resize(ref ArrayGen, ArrayGen.Length + 1);

                            //assegno il valore digitato dall'utente all'ultima posizione creata
                            ArrayGen[ArrayGen.Length - 1] = numberUser4;


                            // Aggiorna la somma degli elementi
                            somma += numberUser4;
                        }

                        Console.WriteLine($"\nla somma dei numeri inseriti è maggiore di 50");

                    break;

                case 10:
                        //--------Decimo snack------------------
                        Console.WriteLine("\nDecimo snack: Fai inserire un numero, che chiameremo N, all’utente.Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.");
                        Console.WriteLine("Digitare valore di N: ");
                        int N = Convert.ToInt32(Console.ReadLine());

                        //inizializzo un oggetto random
                        Random random = new Random();

                        for (int i = 0; i < N; i++)
                        {
                            //per N Volte genero un array di grandezza 10
                            int[] arrayN = new int[10];

                            Console.WriteLine($"array {i + 1}");

                            for (int j = 0; j < arrayN.Length; j++)
                            {
                                arrayN[j] = random.Next(1, 101);
                                Console.WriteLine($"\n valore:{arrayN[j]} ");
                            }

                            Console.WriteLine(); // Vai a capo per il prossimo array
                        }

                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
