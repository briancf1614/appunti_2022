/*
Dati i tre lati di un triangolo,
visualizzare se ? di tipo equilatero, isoscele o scaleno
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
		
	if(l1==l2 && l1==l3)
			printf("Triangolo equilatero");
	else if(l1==l2 || l1==l3 || l2==l3)
			printf("Triangolo isoscele");
	else
		printf("Triangolo scaleno");
}
