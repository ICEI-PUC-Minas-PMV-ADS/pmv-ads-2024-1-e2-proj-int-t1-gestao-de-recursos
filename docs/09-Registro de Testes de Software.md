# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Cadastrar Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 01 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. |
|Registro de evidência |  |
| Avaliação | |

| **Caso de Teste** 	| **CT-02 – Cadastrar perfil usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - O sistema deve conter cadastro de perfis de usuário. |
|Registro de evidência | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/c7eec734-f825-4a2f-9941-c25919cffd54 |
| Avaliação | Resultados mostram a funcionalidade de cadastro de perfis funcionando como esperado. Usuário cadastra um nome e seleciona a permissão dentro da aplicação aquele perfil terá.  |

| **Caso de Teste** 	| **CT-03 – Atribuir um perfil ao usuário**|
|:---:	|:---: |
|	Requisito Associado 	| RF - 03 - O sistema deve permitir que o usuário tenha um perfil. |
|Registro de evidência | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/48f6654f-cca5-41af-af5d-3bcf357e49c5 |
| Avaliação | Resultados mostram um usuário administrador fazendo o cadastro de um novo usuário e atribuindo um perfil a ele, a senha quem atribui ao novo usuário também é o usuário administrador. Considerando que é uma aplicação interna de uma empresa, o administrador sempre terá controle sobre todas as contas e quem tem acesso, e quais acessos cada usuário tem através dos perfis. |

| **Caso de Teste** 	| **CT-04 – Cadastro de matéria prima e produto acabado** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 04 - O sistema deve permitir que cada perfil de usuario possa fazer o cadastro de matéria prima e produto acabado. |
|Registro de evidência |  |
| Avaliação | |

| **Caso de Teste** 	| **CT-05 – Relatório de estoque** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 13 - O sistema deve conter uma parte dedicada a relatório de estoque (Cruzando a saída, a entrada e a produção, para relatar quanto há de produto acabado e matéria prima em estoque) |
|Registro de evidência |  |
| Avaliação | Relatório de estoque que cruza a entrada, a saída e a produção é uma ferramenta poderosa para acompanhar e gerenciar o fluxo de produtos acabados e matéria-prima em uma operação comercial. Ele fornece uma visão abrangente do estoque, ajudando os gestores a otimizar os processos e garantir que haja sempre produtos suficientes para atender à demanda do mercado.|

| **Caso de Teste** 	| **CT-06 – Lançamento de mercadoria** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 05 -O sistema deve conter lançamentos de movimentações de mercadoria. |
|Registro de evidência |  |
| Avaliação | |


| **Caso de Teste** 	| **CT-07 – Lançamento de compras e vendas** |
|:---:	|:---:	|
|	Requisito Associado 	| RF - 06 -O sistema deve conter lançamentos de compras e vendas. |
|Registro de evidência |  |
| Avaliação | |


| **Caso de Teste** 	| **CT-08 – Acesso ao sistema** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 07 -O usuário deverá estar logado para acessar o sistema. |
|Registro de evidência | |
| Avaliação | |


| **Caso de Teste** 	| **CT-09 – Acesso de funcionalidades de perfis** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 08 -O usuário só poderá acessar as funcionalidades atribuídas ao seu perfil. |
|Registro de evidência | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/43a76eb1-3354-492d-927d-e19aab05756c |
| Avaliação | Resultados mostram um usuário com perfil de acesso apenas as áreas de Compras e Produtos, e não permite acesso a áreas restritas a outros perfis e administradores. A aplicação permite acesso ao estoque de produto a todos os perfis, mas nem todos os perfis são capazes de acessar as funcionalidades na página de produtos. Nas proxímas interações seria interessante que os usuários vejam apenas os links das páginas das quais eles tenham acesso no menu de navegação, e que adicione uma página de acesso negado ao tentar entrar em uma página na qual não tem acesso.|


| **Caso de Teste** 	| **CT-10 – Controle de usuários e perfis** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 11 - O usuário Administrador deve ter todo o controle de usuários e seus perfis. |
|Registro de evidência | 1. https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/4e448c33-5e6d-4707-8493-021f11787699 <br> 2.https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/696b7e13-92ba-4eda-b677-838666a89816|
| Avaliação | - Teste 1: Resultados mostram que o usuário administrador tem controle de criar novos perfis e adicionar novos usuários, assim como atribuir perfil aos usuários, editar e deletar usuários e perfis. Durante o teste foi deletado um perfil, e o usuário atrelado a este perfil sumiu da lista de usuários, algo a ser repensado para manter o usuário mesmo se seu perfil seja apagado. O campo de senha na página de editar também é algo a ser alterado, para ser retirado ou mostrar a senha criptografada. <br> - Teste 2: Administrador continua tendo controle das operações de perfis e usuários. Perfis deletados não deletam usuários atrelados a esse perfil, campo de senha foi retirado, o que inevitavelmente impede o usuário de editar sua senha. |


| **Caso de Teste** 	| **CT-11 – Cadastro de listas técnicas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 10 - O sistema deve conter cadastro de listas técnicas. |
|Registro de evidência | |
| Avaliação | |

| **Caso de Teste** 	| **CT-12 – Lançamento de produção** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 11 - O sistema deve ter lançamento de produção. |
|Registro de evidência |  |
| Avaliação | |

| **Caso de Teste** 	| **CT-13 – Cadastro de fornecedores** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 12 -O sistema deve ter cadastro de fornecedores. |
|Registro de evidência | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/bb0837b5-3be4-4b6c-9714-bf1afcec1552|
| Avaliação |Usuário administrador acessa as funcionalidade de cadastro, edição e exclusão de fornecedores como esperado. |

| **Caso de Teste** 	| **CT-14 – Relatório de vendas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 14 -O sistema deve conter uma parte dedicada a relatório de vendas.   |
|Registro de evidência | |
| Avaliação | |

