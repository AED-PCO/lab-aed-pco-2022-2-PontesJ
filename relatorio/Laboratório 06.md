# <a href="/codigo/Laboratório 06/Bubble Sort/Program.cs">Bubble Sort</a>

- Algoritmo que funciona **“borbulhando”** valores maiores para posições superiores do vetor.

- Toma-se uma posição de referência e:
    - Para cada posição do início até a referência, se o valor for maior que o valor seguinte, trocam-se os valores.

- Repetir até usar todas as posições do vetor.

<a href="/codigo/Laboratório 06/Bubble Sort/Program.cs"><img src="/relatorio/img/Gr%C3%A1fico%20-%20Laborat%C3%B3rio%2006%20-%20Bubble%20Sort.png" alt="Laboratório 06 - Bubble Sort"><a>

# <a href="/codigo/Laboratório 06/Insertion Sort/Program.cs">Insertion Sort</a>

- Algoritmo que examina as posições ***anteriores*** à posição de referência, procurando o lugar correto para ***inserir*** o valor nesta posição.

- Para cada posição de referência, faça:
    - Enquanto o valor anterior for maior que o valor de referência, volte uma posição.
    - “Avançar” todos os elementos em uma posição e inserir o elemento de referência na posição correta.

<a href="/codigo/Laboratório 06/Insertion Sort/Program.cs"><img src="/relatorio/img/Gr%C3%A1fico%20-%20Laborat%C3%B3rio%2006%20-%20Insertion%20Sort.png" alt="Laboratório 06 - Insertion Sort"><a>

# <a href="/codigo/Laboratório 06/Merge Sort/Program.cs">Merge Sort</a>

Dividir para conquistar.
- Técnica de projeto de algoritmo com os passos:
    - Dividir o problema em subproblemas pequenos.
    - Resolver cada subproblema.
    - Agrupar as soluções do subproblema para a resposta.

- Algoritmo de ordenação baseado no princípio da **intercalação** (***merge***) de dados.

- Ideia básica: 
    - Divisão **recursiva** em subvetores.
    - Ordenação de cada subvetor (ordenação parcial).
    - Intercalação dos subvetores.

<a href="/codigo/Laboratório 06/Merge Sort/Program.cs"><img src="/relatorio/img/Gr%C3%A1fico%20-%20Laborat%C3%B3rio%2006%20-%20Merge%20Sort.png" alt="Laboratório 06 - Merge Sort"><a>

# <a href="/codigo/Laboratório 06/Quick Sort/Program.cs">Quick Sort</a>

- Dividir o problema da ordenação em ordenações de conjuntos menores – ***divisão e conquista.***

- Premissa do quicksort: a partir de um elemento ***pivô***, criar um conjunto de elementos maiores e outro de elementos menores que o pivô
- Algoritmo geral:
    - Escolha o início e o fim da **partição.**
    - Escolha um valor **pivô.**
    - Examine todos os valores da partição, separando maiores que o pivô à direita e menores à esquerda.
    - Repita o procedimento para as partições resultantes que sejam maiores que um elemento.

<a href="/codigo/Laboratório 06/Quick Sort/Program.cs"><img src="/relatorio/img/Gr%C3%A1fico%20-%20Laborat%C3%B3rio%2006%20-%20Quick%20Sort.png" alt="Laboratório 06 - Quick Sort"><a>

# <a href="/codigo/Laboratório 06/Selection Sort/Program.cs">Selection Sort</a>

- Algoritmo que **seleciona** o menor valor do conjunto para a próxima posição a ser ordenada.

- Para cada posição de referência, iniciando da primeira posição:
    - Selecionar o menor valor do vetor.
    - Trocar com a posição de referência.

<a href="/codigo/Laboratório 06/Selection Sort/Program.cs"><img src="/relatorio/img/Gr%C3%A1fico%20-%20Laborat%C3%B3rio%2006%20-%20Selection%20Sort.png" alt="Laboratório 06 - Selection Sort"><a>

# <a href="/codigo/Laboratório 06/Shell Sort/Program.cs">Shell Sort</a>

- Modificação da ordenação por inserção, tentando evitar muitas verificações de elementos vizinhos.
- Define-se um **salto de comparação** (***hop***) para os elementos de referência.
- Itens separados uns dos outros por este intervalo serão comparados e ordenados isoladamente.
- Aplica-se a ordenação por inserção em cada sequência de elementos.
    - Ordenação parcial.
- Diminuição progressiva do valor do hop até que seu valor chegue a 1.
    - Ordenação por inserção.

<a href="/codigo/Laboratório 06/Shell Sort/Program.cs"><img src="/relatorio/img/Gr%C3%A1fico%20-%20Laborat%C3%B3rio%2006%20-%20Shell%20Sort.png" alt="Laboratório 06 - Shell Sort"><a>
