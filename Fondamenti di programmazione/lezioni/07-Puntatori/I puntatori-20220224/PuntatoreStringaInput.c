/* Dato in input un nome, stampare la sua lunghezza */
#include <stdio.h>
#include <string.h>

int main(){

	char *p;
	
	printf("Inserisci un nome: ");
	scanf("%s",p);
	
	printf("\nNome: %s, lunghezza: %d",p,strlen(p));
	
	
}

