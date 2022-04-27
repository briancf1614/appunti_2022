/*
Estrazione dei numeri di una ruota del lotto

es. 50 65 2 6 9

*/
#include <stdio.h>
#include <math.h>
#include <time.h>

int estrazione(){
	return rand()%90+1;
}

int main(){
	
	srand(time(NULL));
	
	int e1, e2, e3, e4, e5;
	
	e1 = estrazione();
	
	do{
		e2 = estrazione();
	}while(e1==e2);
	
	do{
		e3 = estrazione();
	}while(e1==e3 || e2==e3);
	
	do{
		e4 = estrazione();
	}while(e1==e4 || e2==e4 || e3==e4);
	
	do{
		e5 = estrazione();
	}while(e1==e5 || e2==e5 || e3==e5 || e4==e5);
	
	printf("Estrazione: %d %d %d %d %d",e1,e2,e3,e4,e5);
}
