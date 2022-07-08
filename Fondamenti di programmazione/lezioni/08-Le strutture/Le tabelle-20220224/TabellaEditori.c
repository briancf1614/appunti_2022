/*
Definire un nuovo tipo di dato per l'editore

Dell'editore si conosce:
codice int
ragione sociale stringa
indirizzo stringa
email stringa
sito web stringa
numero di telefono stringa
*/
#include <string.h>
#include <stdio.h>


#define LENGTH 10

typedef struct {
	int codice;
	char ragioneSociale[50];
	char indirizzo[100];
	char email[30];
	char sitoWeb[50];
	char telefono[20];
}editore;

void stampa(editore e){
	printf("Codice: %d",e.codice);
	printf(", Ragione sociale: %s",e.ragioneSociale);
	printf(", Indirizzo: %s",e.indirizzo);
	printf(", email: %s",e.email);
	printf(", Sito web: %s",e.sitoWeb);
	printf(", Telefono %s",e.telefono);
}

void stampaCSV(editore e){
	printf("%d",e.codice);
	printf(";%s",e.ragioneSociale);
	printf(";%s",e.indirizzo);
	printf(";%s",e.email);
	printf(";%s",e.sitoWeb);
	printf(";%s",e.telefono);
}

int main(){
	
	editore elenco[LENGTH] = {
	{1,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{2,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{3,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{4,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{5,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{6,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{7,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{8,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{9,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"},
	{10,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"}
	};
	
	int i;
	printf("Elenco editori: ");
	for(i=0;i<LENGTH;i++)
	{
		printf("\n");
		stampa(elenco[i]);
	}
	
	printf("\n");printf("\n");
	printf("Elenco editori(CSV): ");
	for(i=0;i<LENGTH;i++)
	{
		printf("\n");
		stampaCSV(elenco[i]);
	}
	
	/*
	editore e1;
	
	e1.codice=1;
	strcpy(e1.ragioneSociale,"Hoepli");
	strcpy(e1.indirizzo,"Via dei Mille, 101 - 10100 Torino (TO)");
	strcpy(e1.email,"info@hoepli.it");
	strcpy(e1.sitoWeb,"https://www.hoepli.it");
	strcpy(e1.telefono,"0039022345678912");
	
	editore e2 ={2,"Atlas","Via Durandi, 6 10143 Torino (TO)","info@atlas.it","https://www.atlas.it","00390112547896"};
	
	stampa(e1);
	printf("\n");
	stampa(e2);
	*/
}



