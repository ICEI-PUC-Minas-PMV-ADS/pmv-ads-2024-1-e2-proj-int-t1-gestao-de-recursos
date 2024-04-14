# Plano de Testes de Software

Os testes funcionais a serem ralizados no aplicativo são descritos a seguir:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 01 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. |
| Objetivo do Teste 	| Verificar se é possível cadastra usuário e realizar login na aplicação. |
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7. Informar usuário valido e senha válida |
|Critério de Êxito | Cadastro realizado com sucesso e login efetuado |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Cadastrar Perfil de Usuário** 	|
|	Requisito Associado 	| RF - 02 - O sistema deve permitir o cadastro de perfis de usuários.|
| Objetivo do Teste 	| Verificar se é possível fazer o cadastra do perfil de usuário. |
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7. Informar usuário valido e senha válida <br> 8. Clicar na aba Perfis de Usuário <br> 9. Clicar em adicionar usuário  |
|Critério de Êxito | Perfil de usuário cadastrado com sucesso |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Atribuir um perfil ao usuário** 	|
|	Requisito Associado 	| RF - 03 - O sistema deve permitir que o usuário tenha um perfil.|
| Objetivo do Teste 	| Verificar se é possível atribuir um perfil ao usuário. |
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7. Informar usuário valido e senha válida <br> 8. Clicar na aba Perfis de Usuário <br> 9. Clicar em adicionar usuário <br> 10. Adicionar o perfil ao usuário (Administrador, Compras, Vendas, Produção)  |
|Critério de Êxito | Perfil de usuário atribuido com sucesso |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Cadastro de matéria prima e produto acabado** 	|
|	Requisito Associado 	| RF - 04 - O sistema deve permitir que cada perfil de usuario possa fazer o cadastro de matéria prima e produto acabado.|
| Objetivo do Teste 	| Verificar se é possível que cada perfil de usuario façaa o cadastro de matéria prima e produto acabado . |
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7. Informar usuário valido e senha válida <br> 8. Clicar na aba Perfis de Usuário <br> 9. Clicar em adicionar usuário <br> 10. Adicionar o perfil ao usuário (Administrador, Compras, Vendas, Produção) <br> 11. Clicar na aba Produtos <br> 12. Clicar em produção <br> 13. Clicar em Produto acabado ou Matéria príma|
|Critério de Êxito | Cadastro de matéria prima e produto acabado adicionado com sucesso |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – O sistema deve conter lançamentos de movimentações de mercadoria.** 	|
|	Requisito Associado 	| RF - 05 -O sistema deve conter lançamentos de movimentações de mercadoria.|
| Objetivo do Teste 	| Verificar se o sistema está registrando corretamente as movimentações de mercadoria, incluindo detalhes como tipo de movimentação (entrada, saída), quantidade de mercadoria movimentada, data e hora da movimentação, etc. |
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7. Faça login no sistema com um usuário válido que tenha permissões para realizar lançamentos de movimentações de mercadoria. <br> 8.Navegue até a seção de lançamentos de movimentações de mercadoria no menu principal ou painel de controle. <br> 9. Clique no botão ou link para criar um novo lançamento de movimentação de mercadoria.<br> 10. Preencha os detalhes da movimentação, como tipo de movimentação (entrada, saída), quantidade de mercadoria movimentada, data e hora da movimentação, etc.<br> 11. Clique no botão para salvar o lançamento de movimentação de mercadoria. |
|Critério de Êxito | 1. O sistema deve registrar corretamente a movimentação de mercadoria, incluindo detalhes como tipo de movimentação (entrada, saída), quantidade de mercadoria movimentada, data e hora da movimentação, etc.<br> 2. O lançamento de movimentação de mercadoria deve ser salvo no sistema e deve ser visível na lista de lançamentos de movimentações de mercadoria.<br> 3. O usuário deve ser capaz de visualizar, editar e excluir o lançamento de movimentação de mercadoria. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – O sistema deve conter lançamentos de compras e vendas.** 	|
|	Requisito Associado 	| RF - 06 -O sistema deve conter lançamentos de compras e vendas.|
| Objetivo do Teste 	| Verificar se o sistema está registrando corretamente as compras e vendas, incluindo detalhes como tipo de transação (compra, venda), quantidade de mercadoria, data e hora da transação, etc.|
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7. Faça login no sistema com um usuário válido que tenha permissões para realizar lançamentos de compras e vendas. <br> 8.Navegue até a seção de lançamentos de compras e vendas no menu principal ou painel de controle. <br> 9. Clique no botão  para criar um novo lançamento de compra ou venda.<br> 10.  Preencha os detalhes da transação, como tipo de transação (compra, venda), quantidade de mercadoria, data e hora da transação, etc.<br> 11. Clique no botão para salvar o lançamento de compra ou venda. |
|Critério de Êxito | 1. O sistema deve registrar corretamente a transação, incluindo detalhes como tipo de transação (compra, venda), quantidade de mercadoria, data e hora da transação, etc. <br> 2. O lançamento de compra ou venda deve ser salvo no sistema e deve ser visível na lista de lançamentos de compras e vendas. <br> 3. O usuário deve ser capaz de visualizar, editar e excluir o lançamento de compra ou venda.  |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – O usuário deverá estar logado para acessar o sistema.** 	|
|	Requisito Associado 	| RF - 07 -O usuário deverá estar logado para acessar o sistema.|
| Objetivo do Teste 	| Verificar se o sistema está permitindo que apenas usuários autenticados acessem o sistema.|
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7.Tente acessar uma funcionalidade do sistema que requer autenticação.  |
|Critério de Êxito | 1. O sistema deve autenticar corretamente o usuário com base no nome de usuário e senha fornecidos. <br> 2. Após o login bem-sucedido, o usuário deve ser redirecionado para a página inicial ou painel do sistema. <br> 3. O usuário deve ser capaz de acessar funcionalidades do sistema que requerem autenticação. <br> 4. Se o usuário tentar acessar uma funcionalidade do sistema sem estar logado, o sistema deve redirecioná-lo para a página de login.  |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – O usuário deverá estar logado para acessar o sistema.** 	|
|	Requisito Associado 	| RF - 07 -O usuário deverá estar logado para acessar o sistema.|
| Objetivo do Teste 	| Verificar se o sistema está permitindo que apenas usuários autenticados acessem o sistema.|
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7.Tente acessar uma funcionalidade do sistema que requer autenticação.  |
|Critério de Êxito | 1. O sistema deve autenticar corretamente o usuário com base no nome de usuário e senha fornecidos. <br> 2. Após o login bem-sucedido, o usuário deve ser redirecionado para a página inicial ou painel do sistema. <br> 3. O usuário deve ser capaz de acessar funcionalidades do sistema que requerem autenticação. <br> 4. Se o usuário tentar acessar uma funcionalidade do sistema sem estar logado, o sistema deve redirecioná-lo para a página de login.  |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – O usuário só poderá acessar as funcionalidades atribuídas ao seu perfil.** 	|
|	Requisito Associado 	| RF - 08 -O usuário só poderá acessar as funcionalidades atribuídas ao seu perfil.|
| Objetivo do Teste 	| Verificar se o sistema está permitindo que os usuários acessem apenas as funcionalidades que foram atribuídas ao seu perfil.|
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7.Faça login no sistema com um usuário que tenha um perfil específico (por exemplo, "Administrador", "Gerente", "Funcionário", etc.). <br> 8. Tente acessar uma funcionalidade que esteja dentro das permissões do perfil do usuário.<br> 9.Registre se o acesso foi concedido.<br> 10. Tente acessar uma funcionalidade que esteja fora das permissões do perfil do usuário.<br> 11. Registre se o acesso foi negado.  |
|Critério de Êxito | 1. O sistema deve permitir que o usuário acesse as funcionalidades que estão dentro das permissões do seu perfil. <br> 2. O sistema deve negar o acesso às funcionalidades que estão fora das permissões do perfil do usuário. <br> 3. Se o acesso for negado, o sistema deve fornecer uma mensagem de erro apropriada informando ao usuário que ele não tem permissão para acessar a funcionalidade solicitada. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – O sistema deve conter uma parte dedicada a relatório de estoque (Cruzando a saída, a entrada e a produção, para relatar quanto há de produto acabado e matéria prima em estoque)** 	|
|	Requisito Associado 	| RF - 13 -O sistema deve conter uma parte dedicada a relatório de estoque (Cruzando a saída, a entrada e a produção, para relatar quanto há de produto acabado e matéria prima em estoque).|
| Objetivo do Teste 	| Verificar se o sistema está gerando corretamente o relatório de estoque, considerando as entradas, saídas e produção. . |
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7. Informar usuário valido e senha válida <br> 8.Navegue até a seção de relatórios de estoque. <br> 9. Solicite o relatório de estoque.|
|Critério de Êxito | O sistema deve calcular corretamente a quantidade de produto acabado e matéria-prima em estoque, cruzando os dados de entrada, saída e produção. O relatório de estoque deve ser exibido para o usuário, mostrando a quantidade atual de produto acabado e matéria-prima em estoque. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – O sistema deve conter uma parte dedicada a relatório de vendas.** 	|
|	Requisito Associado 	| RF - 14 -O sistema deve conter uma parte dedicada a relatório de vendas.   .|
| Objetivo do Teste 	| Verificar se o sistema está gerando corretamente o relatório de vendas, incluindo detalhes como total de vendas, vendas por produto, vendas por região, etc.. |
| Passos 	| 1. Acessar o navegador <br> 2. Informar o endereço da aplicação <br> 3. Acessar a área de cadastro de usuário <br> 4. Preencher os dados necessários (nome, email e senha) <br> 5. Salvar cadastro <br> 6. Clicar em "Login" <br> 7.Faça login no sistema com um usuário válido que tenha permissões para acessar relatórios de vendas.  <br> 8.Navegue até a seção de relatórios de vendas. <br> 9. Clique no botão ou link para gerar um novo relatório de vendas. <br> 10. Selecione os parâmetros do relatório, como o intervalo de datas para o qual o relatório deve ser gerado. <br> 11. Clique no botão para gerar o relatório com base nos parâmetros selecionados.|
|Critério de Êxito | 1. O sistema deve calcular corretamente as vendas realizadas, incluindo detalhes como total de vendas, vendas por produto, vendas por região, etc. <br> 2. O relatório de vendas deve ser exibido para o usuário em um formato fácil de entender, como um gráfico ou tabela. <br> 3. O relatório de vendas deve ser preciso e refletir as vendas reais realizadas durante o intervalo de datas selecionado. <br> 4.  O usuário deve ser capaz de exportar o relatório de vendas para um formato de arquivo comum, como PDF ou CSV.   |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
