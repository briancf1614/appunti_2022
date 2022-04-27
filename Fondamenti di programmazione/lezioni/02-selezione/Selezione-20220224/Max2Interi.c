/*
Dato in input due numeri interi, visualizzarli in ordine crescente
*/

#include <stdio.h>

int main(){
	
	//dichiarazione delle variabili
	int n1;
	printf("Inserisci un numero intero: ");
	scanf("%d",&n1);
	int n2;
	printf("Inserisci un altro numero intero: ");
	scanf("%d",&n2);
	
	//test
	//if/else
	if(n1>n2)
		printf("Max: %d",n1);
	else
		printf("Max: %d",n2);
}
