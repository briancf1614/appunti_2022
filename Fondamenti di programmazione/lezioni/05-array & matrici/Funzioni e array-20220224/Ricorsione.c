#include <stdio.h>
#include "mylibrary.h"

int main(){
	int numero = 4;
	printf("\nMetodo classico: %d!=%d",numero,fattoriale(numero));
	printf("\nMetodo con ricorsione: %d!=%d",numero,fattorialeRicorsione(numero));
}
