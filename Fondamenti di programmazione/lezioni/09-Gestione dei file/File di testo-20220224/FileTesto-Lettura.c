/*
lettura da file di testo
*/
#include <stdio.h>

int main(){
	
	//variabile che dovra ospitare il contenuto letto da file
	char frase[30];
	
	//dichiarazione della variabile che consentirà laccesso al file
	FILE *file;
	
	//accesso al file di testo in modalità lettura
	file=fopen("testo.txt","r");
	
	//leggo una riga che vado a memorizzare nella variabile frase
	fread(frase,sizeof(frase),1,file);
	
	//chiudo il file
	fclose(file);
	
	//stampo il risultato
	printf("%s",frase);
	
	
}

