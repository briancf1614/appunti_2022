/*
Definire un nuovo tipo di dato strutturato persona

Una persona ha un nome, un cognome, una data di nascita, un luogo di nascita e un codice fiscale

Si richiede di creare due variabili di tipo persona, di acquisire i dati da tastiera
e di stampare i dati in dettaglio e lineare in ordine crescente per età(dato presente
nella stampa)

*/
#include <stdio.h>

//definizione della struttura di dati: data
typedef struct{
	int giorno;
	int mese;
	int anno; 
}data;

typedef struct {
	char nome[30];
	char cognome[30];
	data dataNascita;
	char luogoNascita[30];
	char codiceFiscale[16];
	
}persona;


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

int calcoloEta(data unaData){
	data oggi;
	oggi.anno=2022;
	oggi.mese=1;
	oggi.giorno=18;
	
	int eta = oggi.anno-unaData.anno;
	
	if((unaData.mese>oggi.mese) || (unaData.mese==oggi.mese && unaData.giorno>oggi.giorno))
		eta--;
		
	return eta;
}
void stampa(persona p, char separatore[3] ){
	printf("Nome: %s%s",p.nome,separatore);
	printf("Cognome: %s%s",p.cognome,separatore);
	
	printf("Data di nascita: ");
	if(isDataValida(p.dataNascita)==1)
		formatDataLineare(p.dataNascita);
	else
		printf("dati inseriti non validi");
	printf("%s",separatore);
	
	printf("Luogo di nascita: %s%s",p.luogoNascita,separatore);
	printf("Codice fiscale: %s%s",p.codiceFiscale,separatore);
	
	if(isDataValida(p.dataNascita)==1)
	printf("Eta': %d",calcoloEta(p.dataNascita));

}

void stampaDettaglio(persona p){
	stampa(p,"\n");
}

void stampaLineare(persona p){
	stampa(p,", ");
}

int main(){
	
	persona p1, p2;
	
	printf("Inserisci i dati della persona p1\n");
	printf("Nome: ");
	scanf("%s",p1.nome);
	printf("Cognome: ");
	scanf("%s",p1.cognome);
	
	printf("Data di nascita:\n");
	printf("\tgiorno: ");
	scanf("%d",&p1.dataNascita.giorno);
		printf("\tmese: ");
	scanf("%d",&p1.dataNascita.mese);
		printf("\tanno: ");
	scanf("%d",&p1.dataNascita.anno);
	
	printf("Luogo nascita: ");
	scanf("%s",p1.luogoNascita);
	printf("Codice fiscale: ");
	scanf("%s",p1.codiceFiscale);
	
	printf("Inserisci i dati della persona p21\n");
	printf("Nome: ");
	scanf("%s",p2.nome);
	printf("Cognome: ");
	scanf("%s",p2.cognome);
	
	printf("Data di nascita:\n");
	printf("\tgiorno: ");
	scanf("%d",&p2.dataNascita.giorno);
		printf("\tmese: ");
	scanf("%d",&p2.dataNascita.mese);
		printf("\tanno: ");
	scanf("%d",&p2.dataNascita.anno);
	
	printf("Luogo nascita: ");
	scanf("%s",p2.luogoNascita);
	printf("Codice fiscale: ");
	scanf("%s",p2.codiceFiscale);
	
	printf("\n\nRisultati ottenuti:\n");
	stampaLineare(p1);
	printf("\n");
	stampaLineare(p2);
	printf("\n");
	stampaDettaglio(p1);
	printf("\n");
	stampaDettaglio(p2);
}
