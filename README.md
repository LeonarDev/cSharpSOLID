# SOLID em C#

Este repositorio foi criado para suportar o treinamento sobre princípios de SOLID em C#.

**SOLID** é um conjunto de princípios e boas práticas para desenvolvimento em Linguagens Orientadas a Objetos.
Os princípios foram criados em 2000 por [Robert C. Martin](https://www.google.com/search?q=Robert+C.+Martin&oq=Robert+C.+Martin&aqs=chrome..69i57.526j0j1&sourceid=chrome&ie=UTF-8), enquanto que o acrônimo **SOLID** foi criado por [Michael Feathers](https://www.google.com/search?q=Michael+Feathers&ei=VGwAYu2II4Cw5OUP_tCNuAE&ved=0ahUKEwjtgvanr-z1AhUAGLkGHX5oAxcQ4dUDCA4&uact=5&oq=Michael+Feathers&gs_lcp=Cgdnd3Mtd2l6EAMyBQguEIAEMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB5KBAhBGABKBAhGGABQAFgAYLkBaABwAHgAgAF2iAF2kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz).

Os principios do SOLID são:

| . | Nome do Principio               | Abr. | Descrição                                                                                                      |
|---|---------------------------------|------|----------------------------------------------------------------------------------------------------------------|
| S | Single Responsibility Principle | SRP  | Cada Classe ou modulo deve ter apenas uma razão para mudar                                                     |
| O | Open/Closed Principle           | OCP  | Entidades de Software (classes, módulos, funções), devem ser abertas a extensão, mas fechadas para modificação |
| L | Liskov Substitution Principle   | LSP  | Classes bases devem ser substituíveis pelas classes derivadas                                                  |
| I | Interface Segregation Principle | ISP  | Faça interfaces com alta granularidade, para cada cliente                                                      |
| D | Dependency Inversion Principle  | DIP  | Dependa de Abstrações, não de classes concretas                                                                |

O projeto aqui mostrado é um serviço REST, que, no commit inicial. viola estes princípios. Em cada Commit, ataco um dos princípios, corrigindo sua implementação.


A descrição das mudanças se encontra nos links abaixo:

* [1 - SRP - Principio da responsabilidade única](1-SRP.md) - Commit: [381db53](https://github.com/leonardev/cSharpSolid/commit/381db5349656fb699d88828495c0e43bf6f086e2)
* [2 - OCP - Principio Aberto/Fechado.md](2-OCP.md)<!--  - Commit: [](https://github.com/leonardev/cSharpSolid/commit/) -->
> [3 - LSP - Principio da Substituição de Liskov](3-LSP.md)<!-- - Commit: [](https://github.com/leonardev/cSharpSolid/commit/) -->
> [4 - ISP - Principio de Segregação de Interfaces](4-ISP.md)<!-- - Commit: [](https://github.com/leonardev/cSharpSolid/commit/) -->
> [5 - DIP - Principio da Inversão de Dependencia](5-DIP.md)<!-- - Commit [](https://github.com/leonardev/cSharpSolid/commit/) -->

#### Request/Response:
<div style="text-align:center">
    <img src='./Assets/Insomnia – CreateUser.png'>
    <q>Criar Usuário</q>
</div>
<div style="text-align:center">
    <img src='./Assets/Insomnia - Login.png'>
    <q>Login</q>
</div>
<div style="text-align:center">
    <img src='./Assets/Insomnia - ProductReport-1.png'>
    <q>Relatório de Produtos em CSV</q>
</div>
<div style="text-align:center">
    <img src='./Assets/Insomnia - ProductReport-2.png'>
    <q>Relatório de Produtos em HTML</q>
</div>

#### Referências:
- [O que é SOLID: O guia completo para você entender os 5 princípios da POO](https://medium.com/desenvolvendo-com-paixao/o-que-%C3%A9-solid-o-guia-completo-para-voc%C3%AA-entender-os-5-princ%C3%ADpios-da-poo-2b937b3fc530)
