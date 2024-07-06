# Desafio da DIO, feito pelo [Leonardo](https://github.com/leonardo-buta).

## Descrição do Desafio

O desafio consiste em criar abstrair uma classe com POO de hospedaria em C#, utilizando três classes principais: `Smartphone`, `Nokia` e `Iphone`.

# Projeto de Exemplo: Sistema de Smartphones

Este projeto em C# demonstra a hierarquia de classes para smartphones utilizando herança e uma classe abstrata.

## Estrutura de Classes

### Classe Abstrata: Smartphone

A classe `Smartphone` é a classe base abstrata para todos os smartphones neste sistema.

#### Construtor:

- `Smartphone(string modelo, string imei, int memoria)`: Construtor que inicializa o modelo, IMEI e capacidade de memória do smartphone.

#### Propriedades:

- `Numero`: Número do smartphone.
- `Modelo`: Modelo do smartphone.
- `Imei`: IMEI do smartphone.
- `Memoria`: Capacidade de memória do smartphone.

#### Métodos:

- `Infos()`: Exibe informações detalhadas do smartphone.
- `Ligar()`: Liga para o numero do smartphone.
- `RecebendoLigacao()`: Simula o recebimento de uma ligação.
- `abstract void InstalarApp(string nome)`: Método abstrato para instalar um aplicativo, a ser implementado pelas classes derivadas.
