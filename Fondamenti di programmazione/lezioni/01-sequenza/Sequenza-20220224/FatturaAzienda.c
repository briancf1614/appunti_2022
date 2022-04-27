#include <stdio.h>

//definizione di una costante
#define ALIQUOTAIVA 22

/*
Testo del problema
Dato in input l'imponibile, calcolare l'iva e il totale da pagare.
Visualizzare i risultati
*/

int main(){
	
	//dichiarazione delle variabili
	//input 
	double imponibile; 
	//int aliquotaIva=22; //percentuale dell'iva 22% - valore costante
	
	printf("Inserisci l'imponibile: ");
	scanf("%lf",&imponibile);
	
	//operazioni richieste
	double iva = imponibile*ALIQUOTAIVA/100;
	double totale = imponibile+iva;
		
	//visualizzare i risultati ottenuti
	printf("\nIva: %.2lf euro",iva);	
	printf("\nTotale: %.2lf euro",totale);	
}
