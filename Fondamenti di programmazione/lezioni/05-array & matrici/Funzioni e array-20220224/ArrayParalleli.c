/*
Dati in input n prodotti di cui si conosce il nome, il prezzo e la giacenza,
stampare i prodotti in scorta, quelli esauriti, il prodotto con prezzo max

NOTA: si faccia uso degli array paralleli (stessa dimensione)
*/
#include <stdio.h>

#define LENGTH 30

int main(){
	
	int n;
	printf("Inserisci il numero di prodotti: ");
	scanf("%d",&n);
	
	
	//array paralleli
	char prodotti[n][LENGTH];
	float prezzi[n];
	int giacenze[n];
	
	int i;
	for(i=0;i<n;i++){
		printf("Prodotto: ");
		scanf("%s",&prodotti[i]);
		
		printf("Prezzo: ");
		scanf("%f",&prezzi[i]);
		
		printf("Giacenza: ");
		scanf("%d",&giacenze[i]);		
	}
	
	//prodotti in scorta
	//prodotto in scorta quando la giacenza è [1,9]
	printf("\n\nProdotti in scorta");
	for(i=0;i<n;i++){
		if(giacenze[i]>=1 && giacenze[i]<=9)
		{
			printf("\nProdotto: %s, Prezzo: %.2f, Giacenza: %d",prodotti[i],prezzi[i],giacenze[i]);
		}
	}
	
	//prodotto esaurito quando la giacenza è zero
	printf("\n\nProdotti esauriti");
	for(i=0;i<n;i++){
		if(giacenze[i]==0)
		{
			printf("\nProdotto: %s, Prezzo: %.2f, Giacenza: %d",prodotti[i],prezzi[i],giacenze[i]);
		}
	}
	
	//prodotto con prezzo max
	printf("\n\nProdotto con prezzo max");
	float max=prezzi[0];
	int posMax=0;
	for(i=1;i<n;i++){
		if(prezzi[i]>max){
		posMax=i;
		max=prezzi[i];			
		}
	}
	printf("\nProdotto: %s, Prezzo: %.2f, Giacenza: %d",prodotti[posMax],prezzi[posMax],giacenze[posMax]);
}

