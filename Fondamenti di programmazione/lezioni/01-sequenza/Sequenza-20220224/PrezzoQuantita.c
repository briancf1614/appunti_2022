#include <stdio.h>

/*
Testo del problema
Dati in input il prezzo e la quantità di un prodotto, calcolare il totale
Visualizzare i risultati
*/

int main(){
	
	//dichiarazione delle variabili
	//input 
	float prezzo; //prezzo del prodotto
	int quantita; //quantità del prodotto
	
	printf("Inserisci il prezzo: ");
	scanf("%f",&prezzo);
	
	printf("Inserisci la quantita': ");
	scanf("%d",&quantita);
	
	//operazioni richieste
	float totale = prezzo*quantita;
		
	//visualizzare i risultati ottenuti
	printf("\nTotale: %.2f euro",totale);		
	
}
