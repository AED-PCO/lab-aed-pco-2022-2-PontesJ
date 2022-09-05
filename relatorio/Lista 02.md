# Exercício 01

Escreva um método recursivo que retorne o fatorial de um número.

<sup>**Explicação:** O programa pede ao usuário para digitar um número para descobrir seu fatorial, em seguida o programa imprime o fatorial do número, chamando a função. Na função se compara o número recebi com 2, se forem iguais retorna o número 2, se não uma variável recebe o número informado multiplicado pela função do número menos 1.</sup>

## <a href="/codigo\Lista 02\Exercício 01\Program.cs">Resolução</a>

![Lista 02 - Exercício 01](/relatorio/img/Lista%2002%20-%20Exerc%C3%ADcio%2001.png)

# Exercício 02

Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.

<sup>**Explicação:** O programa pede ao usuário para digitar dois números para descobrir a multiplicação entre ambos, em seguida o programa imprime essa multiplicação dos números, chamando a função. Na função se compara o segundo número recebido com 0, se forem iguais retorna o número 0, logo depois se o número é menor que 0, e se for, uma variável auxiliar receberá o primeiro número multiplicado por -1 e logo depois somado pela função enviando o primeiro número e o segundo número mais 1. Se o número for maior que 0, uma variável recebera o primeiro número somado pela função enviando o primeiro número e o segundo número menos 1.<sup>

## <a href="/codigo\Lista 02\Exercício 02\Program.cs">Resolução</a>

![Lista 02 - Exercício 02](/relatorio/img/Lista%2002%20-%20Exerc%C3%ADcio%2002.png)

# Exercício 03

Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A^B.

<sup>**Explicação:** O programa pede ao usuário para digitar dois números, um sendo a base e o outro o expoente, em seguida o programa imprime a operação, chamando a função. Na função se compara o segundo número com 1, e se forem iguais retorna o primeiro número, se não uma variável auxiliar receberá o primeiro número multiplicado pela chamada da função enviando o primeiro número e o segundo menos 1. E por fim, retorna a variável auxiliar.</sup>

## <a href="/codigo\Lista 02\Exercício 03\Program.cs">Resolução</a>

![Lista 02 - Exercício 03](/relatorio/img/Lista%2002%20-%20Exerc%C3%ADcio%2003.png)

# Exercício 04

Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

<sup>**Explicação:** O programa principal pede ao usuário que digite uma palavra e uma letra, logo depois ele imprime a quantidade de vezes que a letra aparece na palavra chamando a função. Na função se compara a frase com o uma string vazia, e se for retorna 0. Se não a função compara a primeira letra da frase com a letra pedida e se forem iguais a função retorna 1 mais a chamada da função enviando a frase menos a primeira letra.</sup>

## <a href="/codigo\Lista 02\Exercício 04\Program.cs">Resolução</a>

![Lista 02 - Exercício 04](/relatorio/img/Lista%2002%20-%20Exerc%C3%ADcio%2004.png)

# Exercício 05

Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.

<sup>**Explicação:** O programa imprime a soma dos números pares de um vetor chamando uma função, enviando o vetor e seu tamanho. Na função se compara o tamanho do vetor com 0 e se forem iguais a função retorna 0. Logo depois a função procura se o ultimo valor do vetor é divisível por 2, se for retorna o número mais a chamada da função enviando o vetor com seu tamanho reduzido em 1. Por fim retorna a chamada da função enviando o vetor com seu tamanho reduzido em 1. </sup>

## <a href="/codigo\Lista 02\Exercício 05\Program.cs">Resolução</a>

![Lista 02 - Exercício 05](/relatorio/img/Lista%2002%20-%20Exerc%C3%ADcio%2005.png)

# Exercício 06

Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal. 

<sup>**Explicação:** O programa pede ao usuário que digite uma palavra, logo depois ele imprime a palavra sem as vogais chamando a função. Na função compara a frase com uma string vazia, e se for retorna uma string vazia, logo depois compara a última letra da frase com as vogais, e se for, retorna a chamada da função enviando a frase menos a última letra. E se não for vogal a função retorna a chamada da função enviando a frase menos a última letra, mais a última letra.</sup>

## <a href="/codigo\Lista 02\Exercício 06\Program.cs">Resolução</a>

![Lista 02 - Exercício 06](/relatorio/img/Lista%2002%20-%20Exerc%C3%ADcio%2006.png)

# Exercício Extra

Escreva um método recursivo que encontre uma determinada posição na sequência de Fibonacci.

<sup>**Explicação:** O programa pede ao usuário que digite a posição que deseja encontrar, logo depois imprime o número correspondente chamando a função. Na função se compara o número com igual ou menor que 0, e se for retorna 0. Logo depois compara o número com 1, e se forem iguais retorna 1. Por fim, retorna a chamada da função enviando o número menos 1 mais, a chamada da função enviando o número menos 2. </sup>

## <a href="/codigo\Lista 02\Exercício Extra\Program.cs">Resolução</a>

![Lista 02 - Exercício Extra](/relatorio/img/Lista%2002%20-%20Exerc%C3%ADcio%20Extra.png)