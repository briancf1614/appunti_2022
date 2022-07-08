#include <stdio.h>

/*
Testo del problema
Dati in input due numeri interi, calcolare il quoziente intero, il resto e il quoziente reale
Visualizzare i risultati
*/

int main(){
	
	//dichiarazione delle variabili
	//input 
	int a; //dividendo
	int b; //divisore
	
	printf("Inserisci il dividendo: ");
	scanf("%d",&a);
	
	printf("Inserisci il divisore: ");
	scanf("%d",&b);
	
	//operazioni richieste
	int q = a/b;
	int r = a%b;
	float qr = (float)a/b; //casting
	
	//visualizzare i risultati ottenuti
	printf("\nQuoziente intero: %d",q);
	printf("\nResto: %d",r);
	printf("\nQuoziente reale: %f",qr);
	
	
	
}
