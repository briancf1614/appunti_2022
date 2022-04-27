#include <stdio.h>
#include <math.h>
#include <time.h>

//funzione dado 6 facce
int lancioDado(){
	return rand()%6+1;
}


int main(){
	
	srand(time(NULL)); //mescolamento
	
	int i;
	for(i=0;i<10;i++)
		printf("\nlancio del Dado: %d", lancioDado());
	
}
