/*
Dati i tre lati di un triangolo,
visualizzare se è di tipo equilatero
*/

#include <stdio.h>

int main(){
	
	double l1,l2,l3;
	printf("Lato1: ");
	scanf("%lf",&l1);
	printf("Lato2: ");
	scanf("%lf",&l2);
	printf("Lato3: ");
	scanf("%lf",&l3);
		
	if(l1==l2)
		if(l1==l3)
			printf("Triangolo equilatero");
		else
			printf("Triangolo non equilatero");
	else
		printf("Triangolo non equilatero");
}
