# Exercício 01

Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 

Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

<sup>**Explicação:** O programa separa todos os números de 1000 até 9999, logo depois divide ele ao meio e eleva ao quadrado a soma das duas partes, se o resultado for igual ao número inicial, esse número é impresso.</sup>

## <a href="/codigo\Lista 01\Exercício 01\Program.cs">Resolução</a>

![Lista 01 - Exercício 01](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2001.png)

# Exercício 02

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras palavras, um Número Primo possui dois divisores de 1 até ele.

Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é Primo.

Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.

Faça um programa que liste os números perfeitos de 1 a 1000.

<sup>**Explicação:** O programa pergunta qual questão quer ser respondida, se o resultado for 1 ele vai para o primeiro exercício. Nele o programa irá pedir para o usuário informar um número, logo depois o programa irá dividir esse número por todos os seus antecessores, e se encontrar mais de dois números que dividido pelo número informado o resto da divisão der zero, imprimirá que o número não é primo, senão imprimirá que é primo.
Já se o usuário digitar 2, o programa irá dividir todos os números de 1 a 1000 por seus antecessores, durante essa divisão irá armazenar os divisores em uma variável que após acabar a divisão irá comparar se a soma dos divisores é igual ao número original, se for, irá imprimi-lo.
Por fim, se digitar 3, o programa irá dividir todos os números de 1 a 1000 por seus antecessores, e se encontrar apenas dois números que sejam divisíveis pelo número atual, irá imprimi-lo.</sup>

## <a href="/codigo\Lista 01\Exercício 02\Program.cs">Resolução</a>

![Lista 01 - Exercício 02 - Parte 01](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2002%20-%20Parte%2001.png)
![Lista 01 - Exercício 02 - Parte 01](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2002%20-%20Parte%2002.png)
![Lista 01 - Exercício 02 - Parte 01](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2002%20-%20Parte%2003.png)

# Exercício 03

Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. Considere que nenhum dos vetores possui elementos repetidos.

Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

<sup>**Explicação:** O programa percorre dois vetores e busca os elementos em comum entre eles, e os armazenam em outro vetor, além disso busca os elementos diferentes entre eles, e os armazenam em outro vetor. No fim imprimi os dois novos vetores indicando quais são os elementos em comum e os elementos diferentes.</sup>

## <a href="/codigo\Lista 01\Exercício 03\Program.cs">Resolução</a>

![Lista 01 - Exercício 03](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2003.png)

# Exercício 04

Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 

Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

<sup>**Explicação:** O programa percorre cada linha da matriz somando seus valores e imprimindo a soma de cada linha. Por fim o programa percorre cada coluna da matriz somando seus valores e imprimindo a soma de cada coluna.</sup>

## <a href="/codigo\Lista 01\Exercício 04\Program.cs">Resolução</a>

![Lista 01 - Exercício 03](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2004.png)

# Exercício 05

Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

<sup>**Explicação:** O programa pede para que o usuário informe um número para calcular seu fatorial, logo depois o programa chama a função de calcular fatorial, informando o número que deseja calcular o fatorial. Na função ele faz uma comparação para saber se o número é positivo ou negativo, se for negativo imprimirá uma mensagem dizendo que não é possível calcular o fatorial de números negativos, caso não seja negativo irá em outra comparação para saber se o número é 0, se for, será informado que o fatorial de 0 é 1. Contudo se o número for diferente de 0 a função irá multiplicar o número informado por todos os seus antecessores maiores que 1. Por fim a função imprime o resultado da operação.</sup>

## <a href="/codigo\Lista 01\Exercício 05\Program.cs">Resolução</a>

![Lista 01 - Exercício 05](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2005.png)

# Exercício 06

Faça um programa que chame uma função capaz de calcular 𝑥^𝑦 , sendo 𝑥 e 𝑦 inteiros. 
Utilize passagem de parâmetros por referência. 

<sup>**Explicação:** O programa pede ao usuário para inserir o número que deseja saber seu exponencial, e o número que será o expoente. Logo depois, o programa chama uma função, enviando os dois números informados por referência, e logo depois multiplica o primeiro número por ele mesmo, o número de vezes informado pelo segundo número. Por fim, o programa principal imprime o resultado.</sup>

## <a href="/codigo\Lista 01\Exercício 06\Program.cs">Resolução</a>

![Lista 01 - Exercício 06](/relatorio/img/Lista%2001%20-%20Exerc%C3%ADcio%2006.png)