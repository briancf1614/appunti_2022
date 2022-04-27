#include <stdio.h>

/*
dato in input un carattere, 
visualizzare il suo codice numerico su alfabeto ASCII

*/

int main(){
	char carattere;
	printf("Inserisci un carattere: ");
	scanf("%c",&carattere);
	
	int posizione = (int)carattere; //posizione del carattere in alfabeto ASCII
	
	printf("\nCarattere: %c",carattere);
	printf("\nPosizione ASCII: %d",posizione);
}
