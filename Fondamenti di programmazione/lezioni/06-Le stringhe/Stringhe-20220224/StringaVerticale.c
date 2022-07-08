/*
Data in input una stringa, 
stamparla in verticale

es. Ciao!
C
i
a
o
!
*/

#include <stdio.h>

int main(){
	
	char stringa[15];
	
	printf("frase: ");
	scanf("%s",&stringa);
	
	//Ciao!\0
		
	int i;
	for(i=0;i<15;i++)
		if(stringa[i]=='\0')
			break;
		else
			printf("\n%c",stringa[i]);
}
