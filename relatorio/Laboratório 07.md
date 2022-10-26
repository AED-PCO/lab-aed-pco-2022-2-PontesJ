# Prova 01

## Questão 01

1\. Modele, projete e calcule a complexidade de um programa que: (20%)<br>
a. Leia as linhas de um arquivo chamado "arq1.txt".<br>
b. Peça para o usuário inserir um texto no terminal/console.<br>
c. Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos "IGUAIS" e "DIFERENTE".<br>
d. Descreva quais as operações relevantes.

### <a href="codigo\Laboratório 07\Exercício 01\Program.cs">Resolução:</a>

**Modele:** O programa irá pedir ao usuário que digite um texto, logo depois se separa as palavras do texto. Em seguida o arquivo "arq1.txt" é aberto, e sua primeira linha é lida. Depois um laço de repetição é criado até que chegue ao final do arquivo, enquanto não chega, as palavras da linha atual do arquivo são separadas e em seguida, comparadas com as palavras digitadas pelo usuário, se forem iguais, uma variável contadora recebe acréscimo, além disso, outra variável recebe a quantidade de palavras da linha atual. Logo depois, passa para a próxima linha.<br>
Ao sair do laço, o arquivo é fechado e é impresso a quantidade de termos iguais (primeira variável contadora) e a quantidade de termos diferente (segunda variável contadora – primeira variável contadora).


**<a href="/codigo/Laboratório 07/Exercício 01/Program.cs">Projete:</a>**

```
int iguais = 0, diferente = 0;
Console.Write("Digite um texto: ");
string texto = Console.ReadLine();
string[] valores = texto.Split(" ");
StreamReader ler = new StreamReader("../Arquivos/arq1.txt");
string linha = ler.ReadLine();
while (linha != null)
{
    string[] palavras = linha.Split(" ");
    for (int i = 0; i < valores.Length; i++)
        for (int j = 0; j < palavras.Length; j++)
            if (palavras[j] == valores[i])
                iguais++;
    diferente += palavras.Length;
    linha = ler.ReadLine();
}
ler.Close();
Console.WriteLine("Existem {0} termos iguais", iguais);
Console.WriteLine("Existem {0} termos diferentes", diferente - iguais);
```

**Complexidade:** A complexidade será de O(n³), já que, temos um laço para a quantidade de linhas do arquivo (n), dentro dele outro para a quantidade de termos no texto do usuário (m) e dentro dele outro para a quantidade de termos em cada linha do arquivo (l), com isso temos: $n \times m \times l$.<br>
Se considerarmos que essas variáveis podem receber os mesmos valores, temos: $n \times n \times n = n³$.

d. As operações de comparação, soma e atribuição são as mais relevantes.

---

## Questão 02

2\. Dado o código a seguir, responda: (25%)<br>
a. Quantos e quais são os casos base/condições de parada para a função funcRec1()?<br>
b. Explique com suas palavras o que a função funcRec1() calcula.<br>
c. Represente a pilha de execução para a chamada funcRec1(6).

```
Int funcRec1(int a){
    If(a<=1)
        Return 0;
    Else
        Return funcRec1((a-2)+5);
}
```

### <a href="codigo\Laboratório 07\Exercício 02\Program.cs">Resolução:</a>

a. A função irá parar quando a variável "a" for menor ou igual a 1.

b. Se a variável 'a' for maior que 1, a função funcRec1() calcula o acréscimo de 3 em 3 nela, senão apenas retorna 0.

c. funcRec1(6)funcRec1(9)funcRec1(12)funcRec1(15)...

---

## Questão 03

3\. Modele, projete e calcule a complexidade de um programa que: (20%)<br>
a. Leia a primeira linha de um arquivo chamado "entrada.txt".<br>
b. Escreva em um arquivo chamado "saida.txt" o conteúdo lido no arquivo de entrada ao contrário.<br>
c. Descreva quais as operações relevantes.

Exemplo de entrada e saída esperados:

"entrada.txt" &rarr; olá, tudo bem?

"saida.txt" &rarr; ?meb odut ,álo

Observações: considere que o arquivo "entrada.txt" contenha no mínimo uma linha de conteúdo.

### <a href="codigo\Laboratório 07\Exercício 03\Program.cs">Resolução:</a>

**Modele:** O programa irá abrir os arquivos "entrada.txt" e "saida.txt", logo depois a primeira linha do arquivo é lida, enquanto não se chega no final do arquivo um laço irá ocorrer. Nesse laço uma variável receberá os caracteres da linha atual ao contrário, em seguida, os adiciona no arquivo de "saida.txt". Logo depois, passa para a próxima linha.
Por fim, ao sair do laço, ambos arquivos são fechados.


**<a href="/codigo/Laboratório 07/Exercício 03/Program.cs">Projete:</a>**

```
StreamReader ler = new StreamReader("../Arquivos/entrada.txt");
StreamWriter escrever = new StreamWriter("../Arquivos/saida.txt");
string linha = ler.ReadLine();
while (linha != null)
{
    char[] vetor = new char[linha.Length];
    for (int i = 0, j = linha.Length - 1; i < linha.Length; i++, j--)
        vetor[j] = linha[i];
    for (int i = 0; i < vetor.Length; i++)
        escrever.Write(vetor[i]);
    escrever.WriteLine();
    linha = ler.ReadLine();
}
escrever.Close();
ler.Close();
```

**Complexidade:** A complexidade será de O(n²), já que, temos um laço para a quantidade de linhas do arquivo (n) e dentro dele, outros dois para a quantidade de termos em cada linha do arquivo (2m), com isso temos: $n \times 2m$.<br>
Considerando que essas variáveis podem receber os mesmos valores, temos: $n \times 2n = 2n²$.


c. As operações de atribuição e de comparação são as mais relevantes.

---

## Questão 04

4\. Um banco famoso enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerência está a localização das contas dos seus titulares nas listagens e nos relatórios impressos em diferentes situações. Um especialista de TI sugeriu ordenar as contas por meio dos CPF dos seus n titulares antes das impressões. Dentre alguns algoritmos pré-selecionados para essa ordenação, o especialista escolheu o algoritmo de ordenação por inserção. Se você fosse o especialista, responda: (20%)<br>
a. O especialista escolheu um bom algoritmo? Justifique.<br>
b. Qual algoritmo de ordenação utilizaria? Justifique.<br>
c. Descreva quais as operações relevantes.<br>
d. Demonstre a viabilidade da sua solução para 10 registros.

### <a href="codigo\Laboratório 07\Exercício 04\Program.cs">Resolução:</a>

a. O especialista escolheu um bom algoritmo, já que, ele é estável e apresenta uma boa complexidade. Contudo, não é o melhor.

b. Eu utilizaria o método de ordenação Merge Sort, já que, ele possui uma complexidade menor que o Insertion Sort.

c. As operações relevantes seriam as comparações e as trocas.

d. <a href="/codigo/Laboratório 07/Exercício 04/Program.cs"><img src="/relatorio/img/Laboratório%2007%20-%20Exerc%C3%ADcio%2004.png" alt="Laboratório 07 - Exercício 04"></a>

---

## Questão 05

5\. O código a seguir implementa uma função recursiva. Analise-o e indique o que será retornado pela função, caso os parâmetros possuam os seguintes dados: v = {10, 5, 7, 15, 22, 9, 30} e a = 6. (15%)

```
int funcao (int a, int v[7])
{
    if (a == 1)
        return v[0];
    else {
        int x;
        x = funcao (a-1, v);

        if (x > v[a-1])
            return x;
        
        else
            return v[a-1];
    }
}
```

### <a href="codigo\Laboratório 07\Exercício 05\Program.cs">Resolução:</a>

a | Ação
-|-
a = 6 | x = funcao(5, v)
a = 5 | x = funcao(4, v)
a = 4 | x = funcao(3, v)
a = 3 | x = funcao(2, v)
a = 2 | x = funcao(1, v)
a = 1 | return 10
a = 2 | return 10
a = 3 | return 10
a = 4 | return 15
a = 5 | return 22
a = 6 | return 22

A função retornará o valor 22.