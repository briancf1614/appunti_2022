/*
uso dei file di testo
*/

//accesso al file di testo
//scrittura => w
//lettura => r
//accesso al file
#include <stdio.h>


int main(){
	
	char frase[30] = "Oggi e' il 22 febbraio 2022";
	
	//dichiarazione di una variabile puntatore che individuerà il file di testo
	FILE *file;
	
	//accesso al file in modalità scrittura
	file = fopen("testo.txt","w");
	
	//modifica del file con l'aggiunta del contenuto della variabile frase
	fwrite(frase,sizeof(frase),1,file);
	
	//salva tutto e termina. Rilascia la risorsa
	fclose(file);
	
	printf("Operazione eseguita correttamente!");
	
	
	
}
