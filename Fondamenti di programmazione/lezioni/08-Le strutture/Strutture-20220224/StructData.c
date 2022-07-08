/*
Costruire un tipo per rappresentare una data

una data è composta da giorno, mese e anno

es. 13/01/2022

*/

#include <stdio.h>

//definizione della struttura di dati: data
typedef struct{
	int giorno;
	int mese;
	int anno; 
}data;

//funzione formatDataLineare es. 13/01/2022
void formatDataLineare(data unaData){
	if(unaData.giorno<10)
		printf("0");
	printf("%d/",unaData.giorno);
	if(unaData.mese<10)
		printf("0");
	printf("%d/",unaData.mese);
	printf("%d",unaData.anno);
}

//funzione formatDataLetterale es. 13 Gennaio 2022
void formatDataLetterale(data unaData){
	
	char mesi[12][9]={"Gennaio","Febbraio","Marzo","Aprile","Maggio","Giugno","Luglio"
		,"Agosto","Settembre","Ottobre","Novembre","Dicembre"};
		
	printf("%d %s %d",unaData.giorno,mesi[unaData.mese-1],unaData.anno);
}

int isDataValida(data unaData){
	//restituisce 0 se si verifica un errore
	//restituisce 1 se non ci sono errori
	
	//cerco l'errore
	if(unaData.giorno<1 || unaData.giorno>31 || unaData.mese<1 || unaData.mese>12 || unaData.anno < 1582)
		return 0;
	else if((unaData.mese==4 || unaData.mese==6 || unaData.mese==9 || unaData.mese==11) && unaData.giorno==31)
		return 0;
	else if (unaData.mese==2 && unaData.giorno>=30)
		return 0;
	else if (unaData.mese==2 && unaData.giorno==29 && unaData.anno%4!=0)
		return 0;	
	return 1;
}

int main(){
	
	//typedef serve per definire un nuovo tipo di dato
	data oggi;
		
	printf("Inserisci un giorno: ");
	scanf("%d",&oggi.giorno);
		
	printf("Inserisci un mese: ");
	scanf("%d",&oggi.mese);
	
	printf("Inserisci un anno: ");
	scanf("%d",&oggi.anno);
	
	if(isDataValida(oggi)==0)
		printf("\n\nErrore!");
	else{
		printf("\n");
		formatDataLineare(oggi);
		printf("\n");
		formatDataLetterale(oggi);
	}
	
	
	
	
	
}
