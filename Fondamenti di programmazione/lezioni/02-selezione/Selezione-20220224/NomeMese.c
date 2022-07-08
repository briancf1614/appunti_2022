/* Dato in input un numero intero appartenente al'intervallo [1,12]
stampare il nome del mese corrispondente, ovvero Errore altrimenti
In caso di Errore, richiedere nuovamente l'inserimento dei dati
 */
#include <stdio.h>

int main(){
	
	int n;
	int flag; //stato dell'errore
	do{	
		flag = 0; //non ci sono errori
		printf("Inserisci un numero intero [1,12]: ");
		scanf("%d",&n);
	
		if(n<1 || n>12){
			printf("\nErrore\n\n");
			flag=1; //si è verificato un errore
		}
			
	}while(flag==1);


	switch(n){
		case 1: printf("Gennaio");break;
		case 2: printf("Febbraio");break;
		case 3: printf("Marzo");break;
		case 4: printf("Aprile");break;
		case 5: printf("Maggio");break;
		case 6: printf("Giugno");break;
		case 7: printf("Luglio");break;
		case 8: printf("Agosto");break;
		case 9: printf("Settembre");break;
		case 10: printf("Ottobre");break;
		case 11: printf("Novembre");break;
		case 12: printf("Dicembre");break;
	}
	
			
}
