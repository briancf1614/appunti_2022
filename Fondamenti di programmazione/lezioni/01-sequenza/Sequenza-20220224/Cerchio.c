/*
Dati in input il raggio di un cerchio, calcolare il diametro, la circonferenza e l'area. 
Visualizzare i risultati
*/
#include <stdio.h>
#include <math.h>

int main(){
	
	//dichiarazione delle variabili
	double raggio;
	
	//input
	printf("raggio: ");
	scanf("%lf",&raggio);
	
	//operazioni
	double diametro=2*raggio;
	double area = raggio*raggio*M_PI; //M_PI => pigreco
	double circonferenza = 2*M_PI*raggio;
	
	//stampa dei risultati
	printf("\nDiametro: %lf",diametro);
	printf("\nArea: %lf",area);
	printf("\nCirconferenza: %lf",circonferenza);
}

