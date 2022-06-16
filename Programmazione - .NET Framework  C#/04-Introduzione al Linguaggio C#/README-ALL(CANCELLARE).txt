Introduzione al Linguaggio C#
Panoramica sul linguaggio C# e sua collocazione nel .NET Framework
Elementi sintattici del linguaggio
Value types e reference types in C#
Object-oriented programming in C#
Ereditarietà e polimorfismo in C#
Ciclo di vita degli oggetti
Gestione delle exceptions
Delegates e modello di gestione degli eventi

Sintassi base

Benvenuto

Istruzione di Input e Output

Console.Write
Console.WriteLine
Console.ReadLine
 


Sequenza

Argomenti trattati:

Ambiente di sviluppo Visual Studio 2019 Community
Applicazione Console
Soluzione con uno o più progetti
Tipi di dati interi, reali
Il casting di dati
Funzione Parse per il tipo int, double
MinValue, MaxValue per int, sbyte, float e double
Le stringhe
Concatenazione di stringhe, di variabili e stringhe: segnaposto e interpolazione

 


Selezione

Argomenti trattati:

Aggiunta di Progetti esistenti ad una soluzione
Aggiunta di elementi esistenti ad un progetto
Utilizzo delle funzioni della libreria Math: Sqrt, Pow, PI
Approfondimento di formati per output: {0:P}, {0:C}, {0:#.##}
Tipi di dati: char e Console.Read()
Costrutto condizionale: la selezione
Algebra di Boole
Espressione logica semplice, composta e complessa
Operatori di confronto
Operatori logici: !, &&, ||

 


Iterazione

Argomenti trattati:

iterazione indefinita pre-condizionata mediante istruzione while
iterazione indefinita post-condizionata mediante istruzione  do while
iterazione definita mediante istruzione for
operatore ternario ? :
operatori di aggregazione su variabili di tipo numerico e di tipo stringa
concetti di incremento e decremento, sommatore, contatore

 


CollezioneDati

Argomenti trattati:

introduzione agli array o vettori
definizione di un array
operazioni sugli array: lettura e scrittura
uso del ciclo FOR per stampa completa degli elementi di un array
uso del ciclo FOREACH
operazioni sugli array: ricerca, ordinamento, max, min, stampa, caricamento con numeri casuali
array e metodi statici
modificatore di accesso public
dichiarazione di un array in modo "lineare"
dimensione di un array
le matrici bidimensionali
le matrici multidimensionali

 

Esercizi di approfondimento
Esercizio n. 1 – PrezzoQuantitaPercentualeSconto

Dati in input il prezzo e la quantità di un certo prodotto, determinare la fascia di sconto da applicare e stampare i dati inseriti, la percentuale di sconto applicata, lo sconto effettuato e il totale da pagare.

Fasce di sconto

Quantita < 3  --- percentuale di sconto 0%
3<= Quantita < 8 --- percentuale di sconto 4%
8<= Quantita < 12 --- percentuale di sconto 9%
12<= Quantita < 20 --- percentuale di sconto 13%
Quantita >= 20 --- percentuale di sconto 21%

Esercizio n. 2 – Saluto

Recuperata l’ora, stampare buongiorno, buon pomeriggio, buone sera oppure buona notte a seconda dei casi.

Es. input: 9 output: buongiorno

NOTA: Per recuperare l'ora attuale dal sistema operativo si utilizza il tipo DateTime e la sua proprietà Now da cui si recupera la proprietà Hour
Esercizio n. 3 – AnnoBisestile

Recuperato un anno da input, dire se si tratta di un anno bisestile.

Es. input: 2003 output: 2003 non è un anno bisestile

NOTA: nell'esercizio si fa riferimento all'anno gregoriano, in uso vigente. Gli anni bisestili si ritrovano ogni 4 anni. Unica eccezione sono gli anni inizio secolo: 1600, 1700, ecc... che sono bisestili ogni 400 anni. Per recuperare l'anno attuale dal sistema operativo si utilizza il tipo DateTime e la sua proprietà Now da cui si recupera la proprietà Year
Esercizio n. 4 – NomeMese

Stampare il nome del mese corrispondente al valore numerico [1-12] fornito in input.

Es. input: 7 output: Luglio


Esercizio n. 5 – IndividuaCarattere

Da tastiera digitare un tasto qualsiasi. In output il programma deve restituire uno dei seguenti messaggi: Carattere alfabetico minuscolo, carattere alfabetico maiuscolo, carattere numerico, carattere speciale.

Es. input: & output: carattere speciale

