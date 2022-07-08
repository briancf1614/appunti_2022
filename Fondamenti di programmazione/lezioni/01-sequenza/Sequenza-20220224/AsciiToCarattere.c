#include <stdio.h>

/*
dato in input la posizione di un carattere, 
visualizzare il carattere corrispondente su alfabeto ASCII

*/

int main(){
	int posizione;
	printf("Inserisci la posizione di un carattere: ");
	scanf("%d",&posizione);
	
	char carattere = (char)posizione; //posizione del carattere in alfabeto ASCII
	
	printf("\nCarattere: %c",carattere);
}
