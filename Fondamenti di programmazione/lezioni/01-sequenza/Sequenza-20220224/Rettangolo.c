/*
Dati in input i lati di un rettangolo, calcolare il perimetro, l'area e la diagonale. 
Visualizzare i risultati
*/
#include <stdio.h>
#include <math.h>

int main(){
	
	//dichiarazione delle variabili
	double base, altezza;
	
	//input
	printf("base: ");
	scanf("%lf",&base);
	
	printf("altezza: ");
	scanf("%lf",&altezza);
	
	//operazioni
	double perimetro=2*(base+altezza);
	double area = base*altezza;
	double diagonale = sqrt(base*base+altezza*altezza);
	
	//stampa dei risultati
	printf("\nPerimetro: %lf",perimetro);
	printf("\nArea: %lf",area);
	printf("\nDiagonale: %lf",diagonale);
}

