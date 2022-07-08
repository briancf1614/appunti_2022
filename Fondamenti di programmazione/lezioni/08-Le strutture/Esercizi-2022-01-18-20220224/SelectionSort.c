/*

12 3 4 1

ordinare in senso crescente

primo giro
1 12 4 3

secondo giro
1 3 12 4

terzo giro
1 3 4 12

*/
#include <stdio.h>
#define LENGTH 4

void scambio(int *x,int *y){
	int tmp=*x;
	*x=*y;
	*y=tmp;
}

void stampaArray(int v[],int dimensione){
	int i;
	for(i=0;i<dimensione;i++)
		printf("%d ",v[i]);
}

int main(){
	
	int numeri[LENGTH] ={12,3,4,1};
	
	printf("Array non ordinato\n");
	stampaArray(numeri,LENGTH);	
	
	int i,j; //i 
	for(i=0;i<LENGTH-1;i++)
	for(j=i+1;j<LENGTH;j++)
		if(numeri[i]>numeri[j])
			scambio(&numeri[i],&numeri[j]);
		
	printf("\n\nArray ordinato crescente\n");	
	stampaArray(numeri,LENGTH);	
}







