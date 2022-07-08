/*
Creo una funzione

somma

definire una funzioni

tipo identificatore(parametri){}
*/
#include <stdio.h>

int somma(int x,int y){
	int s = x+y;
	return s;
}

int sottrazione(int x,int y){
	return x-y;	
}

int main(){
	
	int a = 12;
	int b = 21;
	
	int s = somma(a,b);
	
	printf("\n%d+%d=%d",a,b,s);
	printf("\n%d-%d=%d",a,b,sottrazione(a,b));
}

