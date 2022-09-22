# Exercício 01

Escreva um método recursivo realizando a ordenação binária usando posição.

<sup>**Explicação:** </sup>

## <a href="/codigo\Laboratório 03\Exercício 01\Program.cs">Resolução</a>

![Laboratório 03 - Exercício 01](/relatorio/img/Laboratório%2003%20-%20Exerc%C3%ADcio%2001.png)

# Exercício 02

Escreva um método recursivo realizando a ordenação binária sem usar posição.

<sup>**Explicação:** </sup>

## <a href="/codigo\Laboratório 03\Exercício 02\Program.cs">Resolução</a>

![Laboratório 03 - Exercício 02](/relatorio/img/Laboratório%2003%20-%20Exerc%C3%ADcio%2002.png)

# Exercício 03

Escreva um método recursivo que realize a pesquisa binária usando posição.

<sup>**Explicação:** O programa pede ao usuário para que informe o número que deseja pesquisar no vetor, logo depois imprime onde o número se encontra no vetor, chamando a função, enviando o vetor seu inicio, tamanho, número procurado e uma variável de posição. Na função se compara o inicio da função com seu tamanho, e se, o inicio da função for menor ou igual ao tamanho, uma variável auxiliar receberá a metade do vetor. Logo depois, se faz uma comparação com o número que representa a metade do vetor com o número buscado, se coincidir retorna a variável de posição, se não realiza outra comparação, onde se pergunta se o número buscado é menor que o número na metade do vetor, se for, retorna a chamada da função enviando o vetor, seu inicio, a metade do vetor menos 1 e o número buscado. Se não entrar na última comparação a função retornará a chamada da função enviando o vetor, a metade do vetor mais 1, seu tamanho e o numero buscado.
Por fim, se não entrar na primeira comparação ou após completar os comandos, a variável de posição recebe -1, e logo depois, é retornada.</sup>

## <a href="/codigo\Laboratório 03\Exercício 03\Program.cs">Resolução</a>

![Laboratório 03 - Exercício 03](/relatorio/img/Laboratório%2003%20-%20Exerc%C3%ADcio%2003.png)

# Exercício 04

Escreva um método recursivo que realize a pesquisa binária sem usar posição.

<sup>**Explicação:** O programa pede ao usuário para que informe o número que deseja pesquisar no vetor, logo depois imprime onde o número se encontra no vetor, chamando a função, enviando o vetor seu inicio, tamanho e número procurado. Na função se compara o inicio da função com seu tamanho, e se, o inicio da função for menor ou igual ao tamanho, uma variável auxiliar receberá a metade do vetor. Logo depois, se faz uma comparação com o número que representa a metade do vetor com o número buscado, se coincidir retorna a posição, se não realiza outra comparação, onde se pergunta se o número buscado é menor que o número na metade do vetor, se for, retorna a chamada da função enviando o vetor, seu inicio, a metade do vetor menos 1 e o número buscado. Se não entrar na última comparação a função retornará a chamada da função enviando o vetor, a metade do vetor mais 1, seu tamanho e o numero buscado.
Por fim, se não entrar na primeira comparação ou após completar os comandos, retorna -1.</sup>

## <a href="/codigo\Laboratório 03\Exercício 04\Program.cs">Resolução</a>

![Laboratório 03 - Exercício 04](/relatorio/img/Laboratório%2003%20-%20Exerc%C3%ADcio%2004.png)