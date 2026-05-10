Algoritmo manzanas
	Definir pa,pm,m Como Real
    pa=0
    m=0
	
    Mientras (pa<1000) Hacer
        Escribir "Ingrese el peso de la manzana en gramos (solo puede comprar manzanas de 100-300)"
        Leer pm
        Si pm>=100 y pm<=300 Entonces
            pa=pa+pm
            Escribir "El peso acumulado es ",pa
            m=m+1
            Escribir "Lleva ",m," manzanas"
        SiNo
            Escribir "ERROR, Esa manzana no cumple con el peso solicitado"
        FinSi
    FinMientras
	
    Escribir "Meta alcanzada, ya tiene ",pa/1000," kg en la bolsa"
    Escribir "Su total de manzanas fue ",m
FinAlgoritmo 	

