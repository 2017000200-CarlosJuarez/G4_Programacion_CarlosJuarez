Algoritmo Suma_De_primos
	Definir n, i, c, s, d como real
	c=0
	s=0
	para n=1 Hasta 100 Hacer
		d=0
		para i=1 hasta n Hacer
			si n % i == 0 Entonces
				d=d+1
			FinSi
		FinPara
	si d == 2 Entonces
		Escribir n
		c=c+1
		s = s + n
	FinSi
	FinPara
	
	
	Escribir "Cantidad de primos: ", c
	Escribir "Suma de primos: ", s
FinAlgoritmo
