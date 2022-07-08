#include <stdio.h>
#include <math.h>

int casuale(int inf, int sup){	
	return rand()%(sup-inf+1)+inf;
}

void stampaArray(int v[], int dimensione){
	
	int i;
	for(i=0;i<dimensione;i++)
		printf("\n[%d]: %d",i,v[i]);
}

int indexOf(int v[], int dimensione, int elemento){
	
	int i;
	for(i=0;i<dimensione;i++)
		if(v[i]==elemento)
			return i;
	return -1;
}

int fattoriale(int n){
	//n!=n*(n-1)*(n-2)*...*2*1
	//eccezioni
	//1!=1
	//0!=1
	
	int i, fatt = 1;
	for(i=n;i>1;i--)
		fatt *= i;
	return fatt;
}

int fattorialeRicorsione(int n){
	
	if(n==1 || n==0)
		return 1;	
	return n*fattorialeRicorsione(n-1);
}

float diagonaleQuadrato(float lato){
	return lato*sqrt(2);
}

