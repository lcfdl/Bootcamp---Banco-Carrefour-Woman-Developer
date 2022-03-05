//laço de repetição
programa
{
	
	funcao inicio()
	{
		inteiro tabuada,contador,limite,resultado
		contador=0

		escreva("Informe a tabuada que deseja ser fatorada: ")
		leia(tabuada)

		escreva("Informe o limite que deseja: ")
		leia(limite)

		faca{
			resultado = tabuada * contador
			escreva(tabuada + " x " + contador + " = " + resultado + "\n")
			contador++
		}enquanto (contador <=limite)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 409; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */