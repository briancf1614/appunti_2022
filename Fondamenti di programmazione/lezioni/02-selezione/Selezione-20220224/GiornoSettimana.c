/*
input [1-7] => Lunedì, Martedì, ... Domenica, Errore
*/
#include <stdio.h>

int main(){
	
	//input
	int n;
	printf("Inserisci un numero intero [1-7]: ");
	scanf("%d",&n);
	
	//analisi
	/*
	if(n<1 || n>7)
		printf("Errore");
	else if(n==1)
		printf("Lunedi'");
	else if(n==2)
		printf("Martedi'");
	else if(n==3)
		printf("Mercoledi'");
	else if(n==4)
		printf("Giovedi'");
	else if(n==5)
		printf("Venerdi'");
	else if(n==6)
		printf("Sabato");
	else if(n==7)
		printf("Domenica");
	*/
	
	switch(n){
		case 1:	printf("Lunedi'");break;
		case 2:	printf("Martedi'");break;
		case 3:	printf("Mercoledi'");break;
		case 4:	printf("Giovedi'");break;
		case 5:	printf("Venerdi'");break;
		case 6:	printf("Sabato");break;
		case 7:	printf("Domenica");break;
		default: printf("Errore");
	}

}

