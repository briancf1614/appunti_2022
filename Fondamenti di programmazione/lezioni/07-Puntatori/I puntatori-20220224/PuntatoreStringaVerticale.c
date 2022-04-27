/*Stampare in verticale una stringa costante creata con variabile puntatore*/
#include <stdio.h>
#include <string.h>

int main(){
	
	char *p = {"Pinuccio Barbero"};
	
	int i;
	printf("%s: ",p);
	printf("\nnumero caratteri: %d",strlen(p));
	printf("\nstampa in verticale:");
	for(i=0;i<strlen(p);i++)
	{
		printf("\n%c",p[i]);
	}
}
