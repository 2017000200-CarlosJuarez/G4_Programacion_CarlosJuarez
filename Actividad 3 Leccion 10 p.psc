Algoritmo suma_de_primos
	Definir s, c, i Como Real
	s=0
	para n=1 Hasta 22 Hacer
		c=0
		para i=1 Hasta n Hacer
			si n % i == 0 Entonces
				c=c+1
			FinSi
		FinPara
		si c == 2 Entonces
			s=s+n
		FinSi
	FinPara
	Escribir "La suma de los numeros primos es: ",s
FinAlgoritmo 	

