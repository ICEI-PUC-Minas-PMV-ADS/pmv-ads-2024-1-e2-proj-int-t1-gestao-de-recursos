# Plano de Testes de Usabilidade

O planejamento dos testes de usabilidade a serem realizados com usuários são descritos na tabela a seguir:

| **Caso de Teste** 	| **CTU-01 – Arquitetura MVC** 	|
| :---:	| :---:	|
| Requisito Associado | RNF-001 - O sistema deve ser desenvolvido usando uma arquitetura MVC. |
| Objetivo do Teste 	| Verificar se o sistema foi implementado utilizando a arquitetura MVC conforme especificado no requisito. |
| Passos 	| 1. Analisar a estrutura do código-fonte do sistema para identificar os componentes do modelo, visão e controle.<br>2. Verificar se há uma clara separação de responsabilidades entre os componentes do modelo, visão e controle. |
| Critério de Êxito | O sistema deve apresentar uma estrutura clara e organizada, onde os componentes do modelo, visão e controle estejam devidamente separados e funcionando conforme a arquitetura MVC. |
|  	|  	|
| **Caso de Teste** 	| **CTU-02 – Terceirização Proibida** 	|
| Requisito Associado | RNF-002 - Não é permitido à equipe terceirizar o desenvolvimento do trabalho. |
| Objetivo do Teste 	| Verificar se a equipe responsável pelo desenvolvimento do sistema não terceirizou nenhuma parte do trabalho. |
| Passos 	| 1. Verificar os registros de contratações e acordos de trabalho para garantir que nenhum serviço foi terceirizado.<br> 2. Analisar a origem do código-fonte e recursos do sistema para identificar qualquer evidência de terceirização. |
| Critério de Êxito | Não deve haver registros de terceirização de serviços relacionados ao desenvolvimento do sistema, e nenhum componente do sistema deve indicar que foi desenvolvido por terceiros. |
|  	|  	|
| **Caso de Teste** 	| **CTU-03 - Design do Site** 	|
| Requisito Associado | RNF-003 - O design do site deve seguir as diretrizes e requisitos estabelecidos, como o uso de cores específicas, logotipos e estilo de fonte. |
| Objetivo do Teste 	| Verificar se o design do site segue as diretrizes e requisitos estabelecidos. |
| Passos 	| 1. Comparar o design do site com as diretrizes de cores específicas, logotipos e estilo de fonte definidos.<br> 2. Verificar a consistência do design em diferentes páginas e dispositivos. |
| Critério de Êxito | O design do site deve estar em conformidade com as diretrizes estabelecidas, apresentando as cores corretas, logotipos e estilo de fonte consistentes em todas as páginas e dispositivos. 
|  	|  	|
| **Caso de Teste** 	| **CTU-04 – Autenticação** 	|
| Requisito Associado | RNF-004 - O sistema deve incluir medidas básicas de segurança, como autenticação de usuários. |
| Objetivo do Teste 	| Verificar se a autenticação permite acesso com as informações de login corretas. |
| Passos 	| 1.Acesse a página de login, complete os campos com informações de um usuário legítimo do sistema.  <br>2. Ao fazer login na aplicação, verifique se foi redirecionado e possui acesso ao sistema.    |
| Critério de Êxito | 1. Entrar com sucesso no sistema com as informações corretas de login. <br> 2. Não conseguir entrar com as informações incorretas ou vazias de login. |
|  	|  	|
| **Caso de Teste** 	| **CTU-05 – Responsividade** 	|
| Requisito Associado | RNF-005 - sistema deve ser responsivo e se adaptar a diferentes tamanhos de tela (desktop, celular, tablet). |
| Objetivo do Teste 	| Verificar se o sistema possa ser utilizado em diferentes tamanhos de tela sem comprometer sua usabilidade. |
| Passos 	| 1. Acesse as diferentes páginas do sistema. <br>2. Altere o tamanho da janela do navegador, de modo a testar tamanhos de tela similares a mobile, tablet e desktop. <br> 3. Verifique se os componentes da página se adaptam as mudanças de tamanho de tela a usabilidade do sistema se mantêm. |
| Critério de Êxito | A interface deve se  adaptar a diferentes tamanhos de tela, de forma que os elementos continuem visíveis e utilizáveis. |
|  	|  	|
| **Caso de Teste** 	| **CTU-06 – Modularização** 	|
| Requisito Associado | RNF-006 - O sistema deve ser desenvolvido de forma modular. |
| Objetivo do Teste 	| Verificar se os módulos do sistema possui funcionalidade bem definida, coesa e com baixo acoplamento. |
| Passos 	| 1. Para cada módulo, verifique o alinhamento de sua funcionalidade e os requisitos relacionados ao módulo. <br>2. Teste a funcionalidade dos módulos, verifique se realiza a funcionalidade esperada de forma eficaz.<br> 3. Verifique se as operações do módulo estão trabalhando para um objetivo comum. <br> 4. Verifique o nível de acoplamento entre os módulos, se o módulo depende de outros módulos para exercer sua funcionalidade. |
| Critério de Êxito | 1. O módulo deve realizar a funcionalidade esperada de forma eficaz. <br> 2. Todas as operações dentro do módulo devem trabalhar para um objetivo comum (não conter operações que não estão sendo usadas, ou que não estão relacionadas com a sua funcionalidade principal).<br> 3. Possuir baixo acoplamento, de modo que alterações em um módulo não deve afetar significativamente outros módulos. <br>  |
