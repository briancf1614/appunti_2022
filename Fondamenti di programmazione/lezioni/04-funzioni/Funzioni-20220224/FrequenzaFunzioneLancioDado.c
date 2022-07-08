#include <stdio.h>
#include <math.h>
#include <time.h>

//funzione dado 6 facce
int lancioDado(){
	return rand()%6+1;
}

float frequenzaLanci(int totaleUscite,int totaleLanci){
	return (float)totaleUscite/totaleLanci*100;
}

int main(){
	
	srand(time(NULL)); //mescolamento
	
	int n;
	printf("Quante volte vuoi lanciare il dado?\n");
	scanf("%d",&n);
	
	//contatori
	int conta1=0,conta2=0,conta3=0,conta4=0,conta5=0,conta6=0;
	
	//conto le uscite del dado
	int i;
	for(i=0;i<n;i++)
		switch(lancioDado()){
			case 1: conta1++;break;
			case 2: conta2++;break;
			case 3: conta3++;break;
			case 4: conta4++;break;
			case 5: conta5++;break;
			case 6: conta6++;break;
		}
		
	//stampo i risultati
	printf("\n1: %d", conta1);
	printf("\n2: %d", conta2);
	printf("\n3: %d", conta3);
	printf("\n4: %d", conta4);
	printf("\n5: %d", conta5);
	printf("\n6: %d", conta6);
	
	printf("\n\nFrequenza delle uscite (%)\n");
	printf("\n1: %.2f", frequenzaLanci(conta1,n));
	printf("\n2: %.2f", frequenzaLanci(conta2,n));
	printf("\n3: %.2f", frequenzaLanci(conta3,n));
	printf("\n4: %.2f", frequenzaLanci(conta4,n));
	printf("\n5: %.2f", frequenzaLanci(conta5,n));
	printf("\n6: %.2f", frequenzaLanci(conta6,n));
}
