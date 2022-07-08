/*
Dati in input l'ipotenusa e un angolo ad essa adiacente di un triangolo rettangolo,
calcolare il perimetro e l'area. Visualizzare tutti i dati ottenuti.
(usare seno e cose per determinarei lati, la formula di Erone per il calciolo dell'area) 
Visualizzare i risultati
*/
#include <stdio.h>
#include <math.h>

int main(){
	
	//dichiarazione delle variabili
	double ipotenusa;
	double angolo; //angolo in gradi
	
	//input
	printf("ipotenusa: ");
	scanf("%lf",&ipotenusa);
	printf("angolo (in gradi): ");
	scanf("%lf",&angolo);
	
	//operazioni
	double radianti=angolo*M_PI/180;
		
	double lato1=ipotenusa*sin(radianti);
	double lato2=ipotenusa*cos(radianti);
	
	double perimetro= lato1+lato2+ipotenusa;
	double area = lato1*lato2/2; //il triangolo è rettangolo	
	
	//formula di Erone
	double sp = perimetro/2;
	double areaErone= sqrt(sp*(sp-lato1)*(sp-lato2)*(sp-ipotenusa));
	
	//stampa dei risultati
	printf("\nLato1: %lf",lato1);
	printf("\nLato2: %lf",lato2);
	printf("\nArea: %lf",area);
	printf("\nArea (formula di Erone): %lf",areaErone);
	printf("\nPerimetro: %lf",perimetro);
}
