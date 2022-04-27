/*
Costruire una struttura di dati per rappresentare un prodotto

un prodotto è composto da:
un codice di tipo numerico
un nome che ha come lunghezza massima 50 caratteri
un prezzo
una giacenza, ossia la disponibilità a magazzino

Creare una variabile di tipo prodotto e stampare il risultato.

*/

#include <stdio.h>
#include <string.h>

typedef struct {
	int codice;
	char nome[50];
	float prezzo;
	int giacenza;
}prodotto;

int main(){
	
	prodotto p;
	
	p.codice=1;
	strcpy(p.nome,"Prodotto1"); //strcpy => consente di copiare una stringa in una variabile
	p.prezzo=12.50;
	p.giacenza=25;
	
	printf("Dati del prodotto\n");
	printf("Codice: %d\n",p.codice);
	printf("Nome: %s\n",p.nome);
	printf("Prezzo: %.2f\n",p.prezzo);
	printf("Giacenza: %d\n",p.giacenza);
}









