
# Exerciocios Realizados na disciplina de AED's (Algoritimo e Estrutura de Dados).

Os exercicios ja possuem uma entrada estabelecida e uma saida esperada(gabarito), pois foram corrigidos por uma plataforma automatizada, dessa forma não possuem interação direta com o usuario.



# Como Funcionou ?

O professor disponibilizava um arquivocompactado (tipo .zip) com tres arquivos, o pub.in; pub.out; Enunciado.pdf que respctivamente são os dados de entrada, a saida esperada (gabarito) e o que o aluno (eu) deve fazer para chegar ao resultado esperado.


## Aprendizados

O intuito desta disciplina foi trabalhar melhor a logica de programação. 

Aprendemos algoritmos de Ordenação interna como:
- Seleção (SelectSort);
- Inserção (InsertionSort);
- MergeSort;
- QuickSort;
- HeapSort;

Alem disso, aprendemos sobre TADs (Tipos Abstrato de Dados) lineares e flexiveis:

- Fila;
- Pilha;
- Lista;
- Arvore Binaria;

Aprendemos tambem sobre:

- POO (Programação Orientada a Objeto);
- Colections C# (ArrayList; List; Queue;)

## Screenshots
<p aling:center>
 <img src="/assets/ExemploRepositorio.jpeg" alt="Minha Figura"></p>

## Rodando localmente

Para rodar localmente siga os passos abaixo:
- Crie uma pasta, inicie com uma IDE;
(recomendado: Visual Studio Code + SDK 6.0 + extenção: Microsoft C#);
- Execute o comando abaixo no terminal (ctrl+j): 
```
dotnet new console
```
- Copie o algoritimo .cs do repositorio GitHub e cole no arquivo program.cs;
- Copie o arquivo pub.in para a pasta criada.
- No terminal execute:
```
cat pub.in | dotnet run > minhaSaida.out
```
(o comando coleta os dados de "pub.in" e processa em "program.cs")

O retorno final é um arquivo "minhaSaida.out" igual ao do repositorio GitHub.


## Relacionados

Segue alguns projetos relacionados

[Projetos em C#](https://github.com/Davi-OS/CSharp/tree/main)

