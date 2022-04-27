#include <stdio.h>

/*
creare una funzione costante che restituisce una stringa
*/


char *stringa(){
	/*char *p="Pino dei palazzi";
	return p;*/
	
	return "Pino dei palazzi";
}

int main(){
	
	//uso la funzione puntatore per farmi restituire una stringa
	printf("%s",stringa());
		
}
