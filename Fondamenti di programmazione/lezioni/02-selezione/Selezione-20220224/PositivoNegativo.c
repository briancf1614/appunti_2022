/*
Dato in input un numero intero, verificare se positivo o negativo
*/

#include <stdio.h>

int main(){
	
	//dichiarazione delle variabili
	int n;
	printf("Inserisci un numero intero: ");
	scanf("%d",&n);
	
	//test
	//if/else
	if(n>=0)
		printf("%d e' POSITIVO",n);
	else
		printf("%d e' NEGATIVO",n);
}
