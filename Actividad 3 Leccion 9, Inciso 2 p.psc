Algoritmo primo
	definir n, i, c Como Real
	i=1
	c=0
	Escribir "Ingrese un numero"
	leer n
	
	mientras i <= n Hacer
		si n % i == 0 Entonces
			c=c+1
		FinSi
		i=i+1
	FinMientras
	si c == 2 Entonces
		Escribir "Es primo"
	SiNo
		Escribir "No es primo"
	FinSi
FinAlgoritmo 	

