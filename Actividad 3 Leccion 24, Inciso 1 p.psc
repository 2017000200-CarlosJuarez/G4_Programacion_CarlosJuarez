Algoritmo suma_numeros_primos
	Definir s, d, n, i como real
	s=0
	para n=1  hasta 50 Hacer
		d=0
		para i=1 hasta n Hacer
			si n % i == 0 Entonces
				d=d+1
			FinSi
		FinPara
	si d == 2 Entonces
		s = s + n
	FinSi
FinPara
Escribir "La suma de los numeros primos es: ", s
FinAlgoritmo
