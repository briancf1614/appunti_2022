/*
tipo enum

tipo per il semaforo (verde, arancio,rosso)
tipo boolean (false, true)
tipo giorniSettimana(Lun,mar,...)
*/
#include <stdio.h>

enum semaforo {VERDE,ARANCIO,ROSSO};
enum boolean {FALSE,TRUE};
enum giorniSettimana{LUN=1,MAR,MER,GIO,VEN,SAB,DOM};

int main(){
	
	int i;
	for(i=LUN;i<=DOM;i++)
		printf("%d\n",i);	
}
