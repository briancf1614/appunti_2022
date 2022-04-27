#include <stdio.h>

int main(){
	
	
	printf("Nomi in elenco");
	
	char nomi[5][20] = {"Pino","Lino","Gina","Rina","Tina"};
	
	int i;
	for(i=0;i<5;i++)
		printf("\n%s",nomi[i]);
	
	
}
