/*Stampare in verticale una stringa costante creata con variabile puntatore*/
#include <stdio.h>
#include <string.h>

void maiuscolo(char *parola){
	
	char *p = parola;
	
	while(p!="\0")
	{
		printf("%c",toupper((int)p));
		p++;
	}
}


int main(){
	
	char *nome = "Pinuccio Barbero";
		
	printf("\nstampa originale: %s",nome);
	printf("\nstampa MAIUSCOLO: ");
	maiuscolo(nome);
	
}
