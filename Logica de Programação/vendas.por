programa
{
	
	funcao inicio()
	{
		real jan, fev, mar, abr, media,total
		cadeia nome

		escreva("Digite seu nome: ")
		leia(nome)
		escreva("Digite o total de vendas de Janeiro: ")
		leia(jan)
		escreva("Digite o total de vendas de Fevereiro: ")
		leia(fev)
		escreva("Digite o total de vendas de Março: ")
		leia(mar)
		escreva("Digite o total de vendas de Abril: ")
		leia(abr)

		media = (jan+fev+mar+abr)/4
		total = (jan+fev+mar+abr)

		escreva (nome + " obteve um total de vendas de R$ " + total + " e sua média foi R$ " + media)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 531; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */