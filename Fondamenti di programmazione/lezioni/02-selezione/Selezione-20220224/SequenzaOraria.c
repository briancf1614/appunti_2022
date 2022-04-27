/*
Dati in input ora, minuti e secondi,
visualizzare la sequenza oraria ottenuta oppure il messaggio Sequenza Oraria Errata

es. 12,45,32 => 12:45:32
es. 25,45,32 => Sequenza Oraria Errata

h [0-23]
m [0-59]
s [0-59]

*/

#include <stdio.h>

int main(){
	
	int h,m,s;
	printf("Ora: ");
	scanf("%d",&h);
	printf("Minuti: ");
	scanf("%d",&m);
	printf("Secondi: ");
	scanf("%d",&s);
	
	//verifico se i dati sono corretti	
	if(h>=0 && h<=23 && m>=0 && m<=59 && s>=0 && s<=59)
			printf("%d:%d:%d",h,m,s);
	else 
		printf("Sequenza Oraria Errata");

}
