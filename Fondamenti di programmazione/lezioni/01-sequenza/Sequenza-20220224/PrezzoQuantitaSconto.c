#include <stdio.h>

/*
Testo del problema
Dati in input il prezzo, la quantità  e la percentuale di sconto di un prodotto,
calcolare il totale, lo sconto effettuato e il totale scontato
Visualizzare i risultati
*/

int main(){
	
	//dichiarazione delle variabili
	//input 
	float prezzo; //prezzo del prodotto
	int quantita; //quantità del prodotto
	int percentualeSconto; //percentuale di sconto del prodotto es. 30% => 30
	
	printf("Inserisci il prezzo: ");
	scanf("%f",&prezzo);
	
	printf("Inserisci la quantita': ");
	scanf("%d",&quantita);
	
	printf("Inserisci la percentuale di sconto: ");
	scanf("%d",&percentualeSconto);
	
	//operazioni richieste
	float totale = prezzo*quantita;
	float sconto = totale*percentualeSconto/100;
	float totaleScontato = totale-sconto;
		
	//visualizzare i risultati ottenuti
	printf("\nTotale: %.2f euro",totale);
	printf("\nSconto effettuato: %.2f euro",sconto);	
	printf("\nTotale scontato: %.2f euro",totaleScontato);			
	
}
