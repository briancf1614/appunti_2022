/*
es. x=12, y=-3

	x=-3, y=12
	
	scambio
*/

#include <stdio.h>

//passaggio di paramentri by reference
void scambio(int *x,int *y){
	int tmp=*x;
	*x=*y;
	*y=tmp;
}

int main(){
	
	int a = 12;
	int b = -3;
	
	printf("\n\nprima -> a: %d, b: %d",a,b);
	
	scambio(&a,&b);
	
	printf("\n\ndopo -> a: %d, b: %d",a,b);
}




