/*
Generare un array di numeri casuali appartenenti ad un intervallo [inf, sup],
con inf e sup dati da input. La dimensione dell'array e generata dinamicamente 
e appartiene all'intervallo [1,100]
Inserire un numero sentinella da ricercare nell'array. 
Restituire la posizione della prima occorrenza utile oppure la stringa "numero non trovato"
*/

#include <stdio.h>
#include <math.h>
#include <time.h>

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

int main(){
	
	srand(time(NULL));
	
	int inf = 1;
	int sup = 100;
	
	//dichiarazione di un array di numeri interi
	int dimensione = casuale(inf ,sup);
	int numeri[dimensione];
	
	printf("inf: ");
	scanf("%d",&inf);
	
	printf("sup: ");
	scanf("%d",&sup);
		
	int i;
	for(i=0;i<dimensione;i++)
		numeri[i]=casuale(inf ,sup);
		
	int numero;
	printf("\nInserisci un numero da ricercare: ");
	scanf("%d",&numero);
	
	/*
	int pos=-1; //numero non trovato
	for(i=0;i<dimensione;i++)
		if(numeri[i]==numero){
			pos=i;
			break;
		}
	*/
	int pos = indexOf(numeri,dimensione,numero);	
	printf("\n\n");
			
	if(pos==-1)	
		printf("numero non trovato");
	else
		printf("%d trovato in posizione: %d",numero,pos);
	
	printf("\n\nStampa dell'array generato");
	stampaArray(numeri,dimensione);
	
}
