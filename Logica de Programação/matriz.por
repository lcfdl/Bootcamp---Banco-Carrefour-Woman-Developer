
//MATRIZ ONDE AS LINHAS INICIA NO 0 ENTÃO O CONTADOR É UM A MENOS DO QUE A LINHA, TIPO 3 LINHAS, CONTADOR 2
programa
{
	
	funcao inicio()
	{
		inteiro contador
		cadeia cliente[3][3]={{"João","São Paulo","(11) 9999-5241"},{"Maria","Ribeirão Preto","(16)9999-8596"},{"Ana","Manaus","(92)9999-8574"}}
		contador=0

		faca{
			escreva("Cliente: " + cliente[contador][0] + ", Cidade: " + cliente[contador][1] + ", Telefone: " + cliente[contador][2] + "\n")
			contador ++
			
		}enquanto (contador <=2)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 511; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */