# SOLID em C#

Este repositorio foi criado para suportar o treinamento sobre princípios de SOLID em C#.

O **SOLID** é um conjunto de princípios e boas práticas para desenvolvimento em Linguagens Orientadas a Objetos.
Os princípios foram criados em 2000 por [Robert C. Martin](https://www.google.com/search?q=Robert+C.+Martin&oq=Robert+C.+Martin&aqs=chrome..69i57.526j0j1&sourceid=chrome&ie=UTF-8), enquanto que o acrônimo **SOLID** foi criado por [Michael Feathers](https://www.google.com/search?q=Michael+Feathers&ei=VGwAYu2II4Cw5OUP_tCNuAE&ved=0ahUKEwjtgvanr-z1AhUAGLkGHX5oAxcQ4dUDCA4&uact=5&oq=Michael+Feathers&gs_lcp=Cgdnd3Mtd2l6EAMyBQguEIAEMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB5KBAhBGABKBAhGGABQAFgAYLkBaABwAHgAgAF2iAF2kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz).

Os principios do SOLID são:

| . | Nome do Principio               | Abr. | Descrição                                                                                                      |
|---|---------------------------------|------|----------------------------------------------------------------------------------------------------------------|
| S | Single Responsibility Principle | SRP  | Cada Classe ou modulo deve ter apenas uma razão para mudar                                                     |
| O | Open/Closed Principle           | OCP  | Entidades de Software (classes, módulos, funções), devem ser abertas a extensão, mas fechadas para modificação |
| L | [Liskov](https://www.google.com/search?q=barbara+liskov&oq=barbara+liskov&aqs=chrome..69i57.4378j0j1&sourceid=chrome&ie=UTF-8) Substitution Principle   | LSP  | Classes bases devem ser substituíveis pelas classes derivadas                                                  |
| I | Interface Segregation Principle | ISP  | Faça interfaces com alta granularidade, para cada cliente                                                      |
| D | Dependency Inversion Principle  | DIP  | Dependa de Abstrações, não de classes concretas                                                                |

O projeto aqui mostrado é um serviço REST, que, no commit inicial. viola estes princípios. Em cada Commit, ataco um dos princípios, corrigindo sua implementação.

A descrição das mudanças se encontra nos links abaixo:

* [1 - SRP - Principio da responsabilidade única](1-SRP.md) - Commit: [381db53](https://github.com/leonardev/cSharpSolid/commit/381db5349656fb699d88828495c0e43bf6f086e2)
* [2 - OCP - Principio Aberto/Fechado.md](2-OCP.md)  - Commit: [45e3a43](https://github.com/leonardev/cSharpSolid/commit/45e3a4380a13b76dee5cc6d4323e50e4d9aaceba)
* [3 - LSP - Principio da Substituição de Liskov](3-LSP.md) - Commit: [284209e](https://github.com/leonardev/cSharpSolid/commit/284209e62e0f801d3e223da19ecfc30151653be6)
* [4 - ISP - Principio de Segregação de Interfaces](4-ISP.md) - Commit: [add95ff](https://github.com/leonardev/cSharpSolid/commit/add95ffec4182dc220c2b2186a60c29dfed7726b)
<!-- * [5 - DIP - Principio da Inversão de Dependencia](5-DIP.md) - Commit [](https://github.com/leonardev/cSharpSolid/commit/) -->

#### Request/Response:
<p align="center"><img src='./Assets/Insomnia – CreateUser.png'><br>
    <q align="center">Criar Usuário</q>
</p>
<br>

<p align="center"><img src='./Assets/Insomnia - Login.png'><br>
    <q align="center">Login</q>
</p>
<br>

<p align="center"><img src='./Assets/Insomnia - ProductReport-1.png'><br>
    <q align="center">Relatório de Produtos em CSV</q>
</p>
<br>

<p align="center"><img src='./Assets/Insomnia - ProductReport-2.png'><br>
    <q align="center">Relatório de Produtos em HTML</q>
</p>


#### Referências:
- [O que é SOLID: O guia completo para você entender os 5 princípios da POO](https://medium.com/desenvolvendo-com-paixao/o-que-%C3%A9-solid-o-guia-completo-para-voc%C3%AA-entender-os-5-princ%C3%ADpios-da-poo-2b937b3fc530)
