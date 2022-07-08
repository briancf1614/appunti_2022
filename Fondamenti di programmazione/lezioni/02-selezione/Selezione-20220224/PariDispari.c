/*
Dato in input due numeri interi, verificare se pari o dispari
*/

#include <stdio.h>

int main(){
	
	//dichiarazione delle variabili
	int n;
	printf("Inserisci un numero intero: ");
	scanf("%d",&n);
	
	int resto = n%2;
	//test
	//if/else
	if(resto==0)
		printf("%d e' PARI",n);
	else
		printf("%d e' DISPARI",n);
}
