# Plano de Testes de Usabilidade

O planejamento dos testes de usabilidade a serem realizados com usuários são descritos na tabela a seguir:

| **Caso de Teste** 	| **CTU-01 – Interface intuitiva e clara** 	|
| :---:	| :---:	|
| Requisito Associado | RNF-001 - O sistema deve ter interface de usuário intuitiva e clara. |
| Objetivo do Teste 	| Verificar se a interface do sistema é fácil de entender e usar para os usuários. |
| Passos 	| 1. Observar a disposição dos elementos na tela.<br>2. Interagir com os botões e menus para realizar tarefas comuns. |
| Critério de Êxito | Os usuários devem ser capazes de completar as tarefas designadas sem dificuldades significativas, demonstrando compreensão e eficiência na navegação. |
|  	|  	|
| **Caso de Teste** 	| **CTU-02 – Compatibilidade com Navegadores** 	|
| Requisito Associado | RNF-002 - O sistema deve ser compatível com os principais navegadores (Google Chrome, Firefox, Microsoft Edge). |
| Objetivo do Teste 	| Verificar se o sistema é compatível com os navegadores especificados sem comprometer sua funcionalidade. |
| Passos 	| 1. Acessar o sistema utilizando Google Chrome, Firefox e Microsoft Edge.<br>2. Verificar se todas as funcionalidades do sistema estão disponíveis e operam corretamente em cada navegador. |
| Critério de Êxito | Todas as funcionalidades do sistema devem estar disponíveis e funcionar corretamente nos navegadores Google Chrome, Firefox e Microsoft Edge, sem apresentar problemas de compatibilidade. |
|  	|  	|
| **Caso de Teste** 	| **CTU-03 -Boas Práticas** 	|
| Requisito Associado | RNF-003 - O sistema deve ser desenvolvido seguindo boas práticas e convenções de codificação em C#. |
| Objetivo do Teste 	| Verificar se o código-fonte do sistema adere às boas práticas e convenções de codificação em C#. |
| Passos 	| 1. Revisar o código-fonte em busca de padrões de codificação consistentes e legíveis.<br>2. Verificar se foram aplicadas boas práticas de programação, como encapsulamento, modularidade e legibilidade. |
| Critério de Êxito | O código-fonte deve seguir as boas práticas e convenções de codificação em C#, demonstrando consistência, legibilidade e conformidade com os padrões estabelecidos.
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
