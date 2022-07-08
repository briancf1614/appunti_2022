//m(2x3)

//visualizzare la matrice 2x3 di numeri interi
#include <stdio.h>

int main(){
	//2 righe
	//3 colonne
	int m[2][3];
	
	//caricamento dei dati
	m[0][0]=12;
	m[0][1]=-5;
	m[0][2]=1;
	
	m[1][0]=-1;
	m[1][1]=45;
	m[1][2]=-3;
	
	//stampare un elemento della matrice
	//printf("m[1][1]: %d",m[1][1]);
	
	int i, j;
	for(i=0;i<2;i++){
		for(j=0;j<3;j++)
			printf("\t%d",m[i][j]);
		printf("\n");
	}
}
