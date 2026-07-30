# POO SCTEC

Exercícios e desafios desenvolvidos durante o curso de POO (Programação Orientada a Objetos) .NET.

## Estrutura do projeto

O repositório está organizado em pastas separadas, com um projeto por exercício.

## Exercícios

| Projeto | Tema | Apontamento |
| --- | --- | --- |
| `exercicio01` | Classe Personagem (RPG) | Criar uma classe com atributos (nome, raça, classe, nível, vida, força) e métodos (atacar, tomar dano, andar, subir nível) |

## Desafios

| Projeto | Tema | Conceitos POO |
| --- | --- | --- |
| `DesafioBank` | Sistema Bancário | Abstração, Encapsulamento, Herança, Polimorfismo |

### DesafioBank - Etapas

| Etapa | Descrição | Conceitos |
| --- | --- | --- |
| 1 | Criar classes Account e Transaction | Abstração, Encapsulamento |
| 2 | Criar classe Customer com validação de CPF e email | Encapsulamento |
| 3 | Criar classe abstrata User e classes Customer/Employee com herança | Herança |

## Como executar

Execute qualquer exercício individualmente com:

```bash
dotnet run --project exercicioXX
```

Troque `exercicioXX` pelo diretório desejado, por exemplo `exercicio01` ou `DesafioBank`.
