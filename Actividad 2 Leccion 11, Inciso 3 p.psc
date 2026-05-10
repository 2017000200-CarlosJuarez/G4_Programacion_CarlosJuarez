Algoritmo multiplos_de_4_de_dos_numeros
	Definir n1, n2 Como Real
	Escribir "Ingrese el primer numero"
	LEER n1
	Escribir "Ingrese el segundo numero"
	leer n2
	Repetir
		si n1 % 4 == 0 Entonces
			Escribir n1
		FinSi
		n1=n1+1
	Hasta Que n1 > n2
FinAlgoritmo
