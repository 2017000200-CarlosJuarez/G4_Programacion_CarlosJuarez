Algoritmo nivel
	definir m, ma, cm Como Real
	m=0
	ma=0
	mientras ma < 350 Hacer
		Escribir "Escriba su cantidad de monedas"
		leer cm
		si cm >= 0 y  cm <= 350 Entonces	
			ma=ma+cm
			Escribir "Su cantidad de monedas acumuladas es ",ma
			si ma >= 350 Entonces
				Escribir "Usted a subido de nivel"
			FinSi
		SiNo
			Escribir "Cantidad exedida de monedas"
		Finsi
	FinMientras
	Escribir "Nivel 5 alcanzado"
FinAlgoritmo

