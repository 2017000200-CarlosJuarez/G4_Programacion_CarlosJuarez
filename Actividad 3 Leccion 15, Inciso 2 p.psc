Algoritmo cuenta_regresiva
	Definir c, s,  d, n, i Como Real
	c=0
	s=0
	para n = 300 Hasta 1 Hacer
		Escribir n
		d=0
		para i=1 Hasta n Hacer
			si n % i == 0 Entonces
				d=d+1;
			FinSi
		FinPara
	si d == 2 Entonces
		c=c+1
	FinSi
	si n % 2 == 0 Entonces
		s = s + n
	FinSi
	FinPara
	Escribir "Cantidad de numeros primos: ", c
	Escribir "Suma de numeros pares: ", s
FinAlgoritmo
