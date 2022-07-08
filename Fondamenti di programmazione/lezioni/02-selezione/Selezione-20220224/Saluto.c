/*
Dato in input l'ora, restituire il messaggio di saluto
(Buongiorno, Buon pomeriggio, Buona sera, Buona notte)
in caso di errore segnalarlo
*/

#include <stdio.h>

int main(){
	
	int h;
	printf("Inserisci l'ora: ");
	scanf("%d",&h);
	
	//if/else
	if(h<0)
		printf("Errore");
	else if(h>23)
		printf("Errore");
	else if(h<6)
		printf("Buona notte");
	else if(h<14)
		printf("Buongiorno");
	else if(h<18)
		printf("Buon pomeriggio");
	else if(h<22)
		printf("Buona sera");
	else
		printf("Buona notte");
}
