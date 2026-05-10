Algoritmo Boletos
	definir op, ca, cn, da, t como real
	ca=0
	cn=0
	da=0
	Repetir
		Escribir "1- Adulto Q15"
		Escribir "2- Niño Q10"
		Escribir "3- Salir"
		leer op
		
		Si op == 1 Entonces
			ca=ca+1
			da=da+15
		FinSi
		si op == 2 Entonces
			cn=cn+1
			da=da+10
		FinSi
	Hasta Que op = 3
	t=ca+cn
	Escribir "Boletos adultos: ", ca
	Escribir "Boletos niños: ", cn
	Escribir "Total de boletos: ", t
	Escribir "Total de dinero: Q", da
FinAlgoritmo
