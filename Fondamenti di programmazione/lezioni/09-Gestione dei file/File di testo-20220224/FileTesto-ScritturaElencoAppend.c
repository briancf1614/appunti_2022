/*
uso dei file di testo
*/

//accesso al file di testo
//scrittura => w
//lettura => r
//accesso al file
#include <stdio.h>
#include <string.h>


int main(){
	
	//variabile di appoggio per scrittura nomi da input
	char nome[30];
	char *fileName="elenco.txt";
	char *mode="a"; //modalità append, quindi non sovrascrive, ma agginge in coda
	
	
	//quanti nomi vuoi acquisire
	int n;
	printf("Quanti nomi vuoi salvare su file? ");
	scanf("%d",&n);
	
	//dichiarazione di una variabile puntatore che individuerà il file di testo
	FILE *file;
	
	//accesso al file in modalità scrittura
	file = fopen(fileName,mode);
	
	//itera fino a n volte
	int i;
	for(i=0;i<n;i++){
		
		//inserisci il nome
		printf("Inserisci un nome: ");
		scanf("%s",&nome);
		
		//aggiungo in coda il carattere \n
		strcat(nome,"\n");
		
		//modifica del file con l'aggiunta del contenuto della variabile frase
		fwrite(nome,strlen(nome),1,file);
		
	}
	

	
	//salva tutto e termina. Rilascia la risorsa
	fclose(file);
	
	printf("Operazione eseguita correttamente!");
	
	
	
}
