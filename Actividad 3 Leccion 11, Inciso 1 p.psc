Algoritmo Suma_entre_dos_numeros
	Definir n1, n2, s Como Real
	Escribir "Ingrese el primer numero"
	leer n1
	Escribir "Ingrese el segundo numero"
	leer n2
	n1=n1+1
	Repetir
		Si n1<n2 Entonces
			s=s+n1
		FinSi
		n1=n1+1
	Hasta Que n1>n2
	Escribir "La suma es: ",s
FinAlgoritmo
