# Aplicação JsonAPItoXML

## Descrição
Este projeto converte dados JSON de um web service REST em arquivos XML, utilizando C# e diversos padrões de projeto.

## Padrões de Projeto
* **Singleton:** Garante uma única instância da classe `WebService`.
* **Factory Method:** Cria arquivos XML de forma genérica.
* **Abstract Factory:** Define uma interface para criar diferentes tipos de arquivos.
* **Prototype:** Cria cópias de objetos do Model.

## Funcionamento
1. **Consome dados JSON:** Faz uma requisição ao web service e obtém os dados em formato JSON.
2. **Transforma em objetos:** Mapeia os dados JSON para objetos de domínio (e.g., `Aluno`, `Disciplina`).
3. **Gera arquivos XML:** Utiliza o padrão `Factory Method` para criar arquivos XML a partir dos objetos.


## Como Executar
1. **Executar:** `dotnet run`

## Estrutura do Projeto
* **Modelos:** Classes que representam as entidades (Aluno, Disciplina, Matricula).
* **Singleton:** Classe `WebService` para gerenciar a conexão.
* **Factories:** `IArchiveFactory` e `XMLFactory` para criar arquivos.
* **Transformação:** `EntityEndpointToXML` para coordenar a conversão.
