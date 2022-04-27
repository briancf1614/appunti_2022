/*
Dati in input le età di tre studenti, calcolare l'età media.

Visualizzare il risultato

*/
//libreria per le operazioni di input/output es. printf, scanf, 
#include <stdio.h>


int main(){
	
	//richiesta dei dati in input - es. 21,24,27
	int eta1, eta2, eta3;
	printf("eta1: ");
	scanf("%d",&eta1);
	
	printf("eta2: ");
	scanf("%d",&eta2);
	
	printf("eta3: ");
	scanf("%d",&eta3);
	
	//operazioni da eseguire
	double media = (double)(eta1+eta2+eta3)/3;
	
	//visualizzo i risultati
	printf("\nEta' media: %lf",media);	
	
}
