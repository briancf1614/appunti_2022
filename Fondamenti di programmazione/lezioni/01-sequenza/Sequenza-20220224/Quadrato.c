/*
Dato in input il lato di un quadrato, calcolare il perimetro, l'area e la diagonale.

Visualizzare i risultati

*/
//libreria per le operazioni di input/output es. printf, scanf, 
#include <stdio.h>

//libreria per le funzioni matematiche, es. radice quadrata, seno, coseno, ecc...
#include <math.h>

int main(){
	
	//richiesta dei dati in input
	double lato;
	printf("Lato: ");
	scanf("%lf",&lato);
	
	//operazioni da eseguire
	double perimetro = lato*4;
	double area = lato*lato;
	double diagonale = lato*sqrt(2); //sqrt(double x) => radice quadrato di x  
	
	//visualizzo i risultati
	printf("\nPerimetro: %lf",perimetro);
	printf("\nArea: %lf",area);
	printf("\nDiagonale: %lf",diagonale);
	
}
