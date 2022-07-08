/*
Data in input una sequenza oraria , in secondi, 
stampare usando il seguente format: hh:mm:ss

usare i puntatori e il passaggio di parametri by reference 

*/
#include <stdio.h>

//prototype
void calcolaSequenzaOraria(int tempoInSecondi, int *ore, int *minuti, int *secondi);

int main(){
	int tempo;
	printf("Inserisci ul tempo della sequenza orari in secondi: ");
	scanf("%d",&tempo);
	
	int h, m ,s;
	
	calcolaSequenzaOraria(tempo,&h,&m,&s);
	
	printf("%d:%d:%d",h,m,s);
}

void calcolaSequenzaOraria(int tempoInSecondi, int *ore, int *minuti, int *secondi){
	//tempoInSecondi: 4895 => ore=1; minuti=0; secondi=6
	
	*ore = tempoInSecondi/3600; //calolo le ore
	*minuti=tempoInSecondi%3600/60; //calcolo i minuti
	*secondi=tempoInSecondi%3600%60;
}


