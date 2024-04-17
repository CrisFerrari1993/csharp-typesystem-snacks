﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Snack 1 L’utente inserisce due numeri in successione. Il software stampa il maggiore.

            //prendo primo numero
            Console.WriteLine("Inserisci un numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //prendo secondo numero
            Console.WriteLine("Inserisci un altro numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //stampo a schermo il maggiore
            if(num1 == num2) 
            {
                Console.WriteLine("I numeri sono pari");
            }
            else
            {
                Console.WriteLine($"Il numero più grande fra i due è: {Math.Max(num1, num2)}");
            }

            //Snack 2 L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

            //prendo prima parola
            Console.WriteLine("Inserisci una frase o parola");
            string frase1 = Console.ReadLine();

            //prendo la seconda parola
            Console.WriteLine("Inserisci un'altra frase o parola");
            string frase2 = Console.ReadLine();

            //stampo a console il risultato
            if( frase1.Length > frase2.Length)
            {
                Console.WriteLine($"Frase corta: {frase2}, frase lunga: {frase1}");
            }
            else
            {
                Console.WriteLine($"Frase corta: {frase1}, frase lunga: {frase2}");
            }

            // Snack 3 Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
            // inizializzo a 0 la somma dei numeri
            int sum = 0;
            //ciclo per 10 volte la richesta di inserimento di una cifra
            for(int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"Inserisci il {i}° numero");
                //converto l'input in un numero
                int num = Convert.ToInt32(Console.ReadLine());
                // sommo sum a il numero inserito (*10 volte)
                sum += num;
            }
            //stampo il risultato a console
            Console.WriteLine($"La somma dei numeri inseriti è: {sum}");


            //Snack 4 Calcola la somma e la media dei numeri da 2 a 10
            //inizializzo array di numeri
            int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //inizializzo la somma a 0
            int somma = 0;
            //per ogni numero nella collezione di numeri, sommalo alla somma
            foreach(int numero in numeri)
            {
                somma += numero;
            }
            //stampo la somma
            Console.WriteLine($"La somma dei numeri è: {somma}");
            //stampo la media
            Console.WriteLine($"La media dei numeri è: {somma / numeri.Length}");

            //Snack 5 Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            //chiedo all'user il numero
            Console.WriteLine("Inserisci un numero casuale");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // se il numero è pari, stampo lo stesso(numero)
            if(userNum % 2 == 0 ) 
            {
                Console.WriteLine($"Il numero inserito è pari: {userNum}");
            }
            //se dispari stampa quello successivo
            else
            {
                Console.WriteLine($"Il numero inserito è dispari, quello successivo a quello inserito è:{userNum + 1}");
            }

            //Snack 6 In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

            string[] gatsbyPartyGuest = { "Jack", "John", "Mary", "Marilyn", "George", "Christopher" };

            Console.WriteLine("Inserisci il tuo nome e ti dirò se sei invitato alla festa...");
            string userName = Console.ReadLine();
            if (gatsbyPartyGuest.Contains(userName))
            {
                Console.WriteLine("Sei invitato alla festa");
            } else
            {
                Console.WriteLine("Mi spiace, sarà per la prossima");
            }

            //Snack 7 Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
            //creo array vuoto
            int[] dispari;

        }
    }
}
