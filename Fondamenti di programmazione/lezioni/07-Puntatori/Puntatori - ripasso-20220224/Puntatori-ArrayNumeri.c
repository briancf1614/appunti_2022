/*
Dato un array di numeri interi di dimensione 5,
stampare l'array

NB: usare una funzione con uso puntatori
*/
#include <stdio.h>

void stampaArray(int *array,int dimensione){

int i;
for(i=0;i<dimensione;i++){
	printf("%d, ",*array);
	array++;
}

}

int main(){
	
	int numeri[5]={12,23,34,45,56};
	
	stampaArray(&numeri[0],5);
	
}


