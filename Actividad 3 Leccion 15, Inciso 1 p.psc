Algoritmo multiplos_del_7
	Definir m, s, c Como Real
	s=0
	c=0
	para i=1 Hasta 20 Con Paso 1 Hacer
		m=i*7
		s=s+m
		si m%2 == 0 Entonces
			c=c+1
		FinSi
	FinPara
	Escribir "Suma de los multiplos: ",s 
	Escribir "Cantidad de multiplos pares: ", c
FinAlgoritmo
