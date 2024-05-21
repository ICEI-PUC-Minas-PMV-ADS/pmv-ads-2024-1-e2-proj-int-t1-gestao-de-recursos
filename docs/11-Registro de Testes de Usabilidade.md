# Registro de Testes de Usabilidade

Após realizar os testes de usabilidade, obtém-se um relatório a partir das análises realizadas. O Registro de Testes de Usabilidade é um relatório que contém as evidências dos testes e relatos dos usuários participantes, baseado no Plano de Testes de Usabilidade desenvolvido para os casos de uso desta etapa.

As referências abaixo irão auxiliá-lo na geração do artefato “Registro de Testes de Usabilidade”.


| **Caso de Teste** 	| **CTU-02 – Compatibilidade com Navegadores** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-002 - O sistema deve ser compatível com os principais navegadores (Google Chrome, Firefox, Microsoft Edge). |
|Registro de evidência | <video width="320" height="240" controls> <source src="/vid\teste - compatibilidade.mp4" ></video> |
| Relatório | Aplicação é compatível com os principais navegadores (Chrome, Firefox, Edge). |

| **Caso de Teste** 	| **CTU-03 -Boas Práticas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-003 - O sistema deve ser desenvolvido seguindo boas práticas e convenções de codificação em C#. |
|Registro de evidência | Boas práticas analisadas: encapsulamento, modularidade e legibilidade. <br> <br> Evidência e código fonte analisado: <br> 1. Models <br>   <img > <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/9a9fa21e-e13b-4fd0-a8f3-5d7ac74f9e14" width="500" > <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/7108990d-5863-4226-9428-9770ba5a638a" width="500" >  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/9ee386e3-3c60-4d1f-807f-2f73cb421dd3" width="500" > <br><br>2. Controllers <br> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/aa6e4345-9338-4d4c-91a7-0b35dad8ebe7" width="500" > <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/e9fccbdb-1bea-4a06-a0d9-f26cf98f1db8" width="500" >  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/61c79d2d-2dec-4bcb-a0ee-84c701934aca" width="500" > <br><br> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/f36b29d0-6b34-4eed-b470-a03399a9405b" width="500" > <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/a241bdc8-c7ff-422b-bd31-46b91a702806" width="500" > <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/4e265aa7-120c-41ae-b9ee-862b747bb0bf" width="500" > <br><br> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/1e7505ad-c55e-4e26-aa4a-615a42322cd6" width="500" > <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/2862a40c-270c-4a0c-b262-0fa473ff9dd5" width="500" > <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/7a7fbdb7-2b89-439d-9b35-c66567923a7d" width="500" > <br> <br> | 
 | Relatório|  Encapsulamento: nos models há encapsulamento dos dados, com métodos de accesso (getters e setters), e validação de dados com notações como required nas propriedades públicas. Controllers tem acesso aos models por meio dos métodos de acesso dos mesmos.<br> Modularidade: no projeto há separação de responsabilidades através das ferramentas de criação de componentes do framework, que seguem a arquitetura MVC. Há organização de código em pastas e namesspaces baseados na estrutura da aplicação. Há baixo acoplamento entre componentes. <br> Legibilidade: o projeto mostra seguir um padrão de nomemclaturas de classes, métodos, variáveis e propriedades que são descritivas, com significado direto e claro. Consistência na formatação. Organização da estrutura MVC. Simplicidade de soluções que envolvem CRUD.   <br><br> Resolução: boas práticas estao sendo aplicadas no projeto com o auxílio das ferramentas do framework durante a implementação.  |

 | **Caso de Teste** 	| **CTU-04 – Autenticação** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-004 - O sistema deve incluir medidas básicas de segurança, como autenticação de usuários.  |
|Registro de evidência |  https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/99574248/1946607c-6169-446c-9116-1713e0183a87 |
|Relatório | Autenticação de acesso está funcionando como esperado. Usuário tem acesso concedido com login válido, e acesso negado com campos vazios ou inválidos. |






> **Links Úteis**:
> - [Ferramentas de Testes de Usabilidade]https://www.usability.gov/how-to-and-tools/resources/templates.html 