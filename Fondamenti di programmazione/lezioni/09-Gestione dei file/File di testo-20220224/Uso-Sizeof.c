/*
Uso della funzione sizeof
*/
#include <stdio.h>

typedef struct {
	int giorno;
	int mese;
	int anno;
}data;

int main(){
	
	//dichiarazione delle variabili
	short a =12;
	int n = 123;
	float f = 12.35;
	double d = 12.895623147;
	
	char c='c';
	
	int numeri[5]={12,23,34,45,56};
	char frase[30]="Oggi e' il 22 febbraio 2022";
	char nomi[5][30]={"Luigi","Matteo","Virginia","Antonella","Sabrina"};
	
	data oggi = {22,2,2022};
	
	printf("SIZEOF");
	printf("\nsizeof(short): %d",sizeof(a));
	printf("\nsizeof(int): %d",sizeof(n));
	printf("\nsizeof(float): %d",sizeof(f));
	printf("\nsizeof(double): %d",sizeof(d));
	printf("\nsizeof(char): %d",sizeof(c));
	printf("\nsizeof(array int): %d",sizeof(numeri));
	printf("\nsizeof(array char): %d",sizeof(frase));
	printf("\nsizeof(array di stringhe): %d",sizeof(nomi));
	printf("\nsizeof(struttura): %d",sizeof(oggi));
	
	printf("\ndimensione con sizeof(array di stringhe): %d",sizeof(nomi)/sizeof(nomi[0]));
	printf("\ndimensione con sizeof(array int): %d",sizeof(numeri)/sizeof(numeri[0]));
	
	
	
	
	
}



