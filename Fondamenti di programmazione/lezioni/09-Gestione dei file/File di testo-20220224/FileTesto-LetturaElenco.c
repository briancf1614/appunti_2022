/*
lettura da file di testo
*/
#include <stdio.h>

void StampaElencoCompleto(){
		//variabile che dovra ospitare il contenuto letto da file
	char nome[30];
	
	//dichiarazione della variabile che consentirà laccesso al file
	FILE *file;
	
	//accesso al file di testo in modalità lettura
	file=fopen("Studenti.csv","r");
	
	while(!feof(file)){
		//leggo una riga che vado a memorizzare nella variabile frase
		fread(nome,sizeof(nome),1,file);
		
		//stampo il risultato
		printf("%s",nome);
		
	}
	
	
	//chiudo il file
	fclose(file);
	
	
	printf("Operazione eseguita correttamente!");
	}
	
int main(){
	
	StampaElencoCompleto();
	
}

