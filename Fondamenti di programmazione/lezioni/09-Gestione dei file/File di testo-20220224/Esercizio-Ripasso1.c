/*
Salvare su file di testo le date con format letterale in modalità append

In input inserire i dati in forma numerica

Usare le strutture di dati, i puntatori, le funzioni

*/

#include <stdio.h>
#include <string.h>

//definizione della struttura di dati: data
typedef struct{
	int giorno;
	int mese;
	int anno; 
}data;

//funzione formatDataLineare es. 13/01/2022
void formatDataLineare(data *unaData){
	if(unaData->giorno<10)
		printf("0");
	printf("%d/",unaData->giorno);
	if(unaData->mese<10)
		printf("0");
	printf("%d/",unaData->mese);
	printf("%d",unaData->anno);
}

//funzione formatDataLetterale es. 13 Gennaio 2022
void formatDataLetterale(data *unaData){
	
	char mesi[12][9]={"Gennaio","Febbraio","Marzo","Aprile","Maggio","Giugno","Luglio"
		,"Agosto","Settembre","Ottobre","Novembre","Dicembre"};
		
	printf("%d %s %d",unaData->giorno,mesi[unaData->mese-1],unaData->anno);
}

int isDataValida(data *unaData){
	//restituisce 0 se si verifica un errore
	//restituisce 1 se non ci sono errori
	
	//cerco l'errore
	if(unaData->giorno<1 || unaData->giorno>31 || unaData->mese<1 || unaData->mese>12 || unaData->anno < 1582)
		return 0;
	else if((unaData->mese==4 || unaData->mese==6 || unaData->mese==9 || unaData->mese==11) && unaData->giorno==31)
		return 0;
	else if (unaData->mese==2 && unaData->giorno>=30)
		return 0;
	else if (unaData->mese==2 && unaData->giorno==29 && unaData->anno%4!=0)
		return 0;	
	return 1;
}


int main(){
	
	//variabile di appoggio per scrittura nomi da input
	data d;
	char *fileName="elenco_date.txt";
	char *mode="a"; //modalità append, quindi non sovrascrive, ma agginge in coda
	
	
	//quanti nomi vuoi acquisire
	int n;
	printf("Quante date vuoi salvare su file? ");
	scanf("%d",&n);
	
	//dichiarazione di una variabile puntatore che individuerà il file di testo
	FILE *file;
	
	//accesso al file in modalità scrittura
	file = fopen(fileName,mode);
	
	//itera fino a n volte
	int i;
	for(i=0;i<n;i++){
		
		//inserisci il nome
		printf("Inserisci il giorno: ");
		scanf("%s",&d.giorno);
		
		printf("Inserisci il mese: ");
		scanf("%s",&d.mese);
		
		printf("Inserisci l'anno: ");
		scanf("%s",&d.anno);
		
		//aggiungo in coda il carattere \n
		strcat(nome,"\n");
		
		//modifica del file con l'aggiunta del contenuto della variabile frase
		fwrite(nome,strlen(nome),1,file);
		
	}
	

	
	//salva tutto e termina. Rilascia la risorsa
	fclose(file);
	
	printf("Operazione eseguita correttamente!");
	
	
	
}
