# Especificações do Projeto


**Introdução: Modernizando o Gerenciamento Empresarial**

No contexto empresarial atual, a eficiência operacional é crucial para manter a competitividade e alcançar o sucesso. No entanto, muitas empresas enfrentam desafios significativos devido à falta de um sistema integrado capaz de gerenciar de forma eficiente suas atividades fundamentais, desde o recebimento até a produção e venda de produtos.

A ausência de um sistema robusto resulta em processos manuais propensos a erros, ineficiências na gestão de estoque e vendas, além de dificuldades na tomada de decisões estratégicas. Para superar esses obstáculos e impulsionar a eficiência empresarial, propõe-se o desenvolvimento de um sistema de gerenciamento empresarial personalizado.

**Ideia de Solução: Desenvolvendo um Sistema Sob Medida**

A solução proposta visa criar um sistema de gerenciamento empresarial personalizado, adaptado às necessidades específicas de cada usuário dentro da empresa. Esse sistema deve oferecer funcionalidades que permitam aos usuários realizar suas tarefas de forma eficiente, garantindo a precisão dos dados e otimizando os processos de negócios.

**Visão Geral das Especificações do Projeto: Abordagem Estruturada para o Sucesso**

Para garantir o sucesso do projeto, serão empregadas técnicas e ferramentas específicas:

- **Diagrama de Personas:** Criaremos um diagrama representando as diferentes personas e suas relações com as funcionalidades do sistema, garantindo que todas as necessidades sejam contempladas.
  
- **Histórias de Usuários:** Desenvolveremos histórias detalhadas para cada persona, destacando suas necessidades específicas e como o sistema irá atendê-las de forma eficaz.
  
- **Requisitos Funcionais e Não Funcionais:** Elaboraremos uma lista detalhada de requisitos, priorizando-os e garantindo que abordem todos os aspectos necessários para o funcionamento do sistema.
  
- **Restrições do Projeto:** Analisaremos cuidadosamente as restrições impostas ao projeto, como limitações tecnológicas, orçamentárias e de tempo, planejando estratégias para trabalhar dentro desses parâmetros.
  
- **Modelagem de Processos:** Utilizaremos ferramentas de modelagem para mapear os processos de negócios e definir como o sistema irá aprimorá-los, garantindo uma visão clara do fluxo de trabalho.
  
- **Prototipagem:** Criaremos protótipos para testar a usabilidade das interfaces e coletar feedback valioso para aprimoramentos contínuos.
  
- **Metodologias Ágeis:** Implementaremos metodologias ágeis para permitir flexibilidade e adaptabilidade durante o desenvolvimento do sistema, garantindo uma resposta rápida às mudanças e necessidades emergentes.

Essa abordagem estruturada assegurará que o sistema desenvolvido esteja alinhado com as necessidades dos usuários e os objetivos do negócio, ao mesmo tempo em que cumpre com as restrições do projeto. O resultado será um sistema de gerenciamento empresarial sob medida, projetado para impulsionar a eficiência e o sucesso organizacional. Estou disponível para fornecer mais assistência ou detalhes sobre qualquer uma dessas etapas, conforme necessário.


## Personas

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/blob/main/docs/img/personas/ANA%20PEDROSO%20DE%20FREITAS-1.png)
<h2 align="center">FIGURA 01</h2>
<br/><br/>

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/blob/main/docs/img/personas/CL%C3%81UDIA%20RIBEIRO%20DURVAL-1.png)
<h2 align="center">FIGURA 02</h2>
<br/><br/>

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/blob/main/docs/img/personas/FERNANDO%20VIEIRA%20SANTIAGO-1.png)
<h2 align="center">FIGURA 03</h2>
<br/><br/>

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/blob/main/docs/img/personas/GEOVANA%20OLIVEIRA%20BARROSO-1.png)
<h2 align="center">FIGURA 04</h2>
<br/><br/>

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/blob/main/docs/img/personas/JEAN%20COSTA%20BARROS-1.png)
<h2 align="center">FIGURA 05</h2>
<br/><br/>

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/blob/main/docs/img/personas/WILL%20GOMES%20MOTOS-1.png)
<h2 align="center">FIGURA 06</h2>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|	Claudia -> Assistente de Recebimento  | verificar e validar as quantidades recebidas em relação aos pedidos de compras  | poder identificar discrepâncias e resolvê-las rapidamente  |
| Claudia -> Assistente de Recebimento	|	registrar facilmente a entrada de produtos ou matérias-primas	  |	possa manter o controle de estoque atualizado	| 	 	
|	Fernado -> Auxiliar de Expedição	| ter acesso a uma lista clara com informações de pedidos prontos para envio | relacionar a venda de pedidos com a saída do produto, poder priorizar e preparar os envios de forma eficiente e sem erros  |
|	Fernado → Auxiliar de Expedição	|	ter um método simples para gerenciar e documentar as saídas dos produtos | o processo de expedição ser rápido e sem erros e manter o controle de estoque atualizado |
|	Ana -> Empreendedora |	acessar relatório de vendas | poder analisar o desempenho das vendas e fazer alinhamento de meta |  
|   Ana -> Empreendedora | acessar relatório de estoque 	|	poder analisar a situação do estoque, de produtos acabados e matéria prima |
|	Geovana -> Analista de PCP  | ser capaz de cadastrar e atualizar listas técnicas dos produtos    | poder garantir uma produção precisa, com todos os materiais necessários especificados e disponíveis   |
|	Geovana -> Analista de PCP |	ser capaz de registrar o lançamento de produção de acordo com as ordens de fabricação | poder monitorar o progresso da produção e garantir a fabricação de produtos dentro do planejamento |
|	Geovana -> Analista de PCP	| ser capaz de cadastrar os produtos acabados 	| possibilitar a montagem das listas técnicas dos produtos 	|
|	Will -> Vendedor |  poder registrar novas vendas ou pedidos de produtos de forma rápida e eficiente   | ter controle financeiro eficaz e garantir que os pedidos sejam processados corretamente |
|	Will -> Vendedor | ter acesso rápido e fácil às informações de estoque e disponibilidade de produtos |  poder fornecer aos clientes informações sobre disponibilidade de produtos e prazos de entrega, e não realizar vendas além da quantidade presente no estoque  	|
|  Jean -> Comprador | criar, visualizar e gerenciar pedidos de compra   |	garantir que o estoque esteja com as necessidades de produção atendidas | 
|	Jean -> Comprador | poder cadastrar fornecedores no sistema | manter um registro organizado e atualizado dos contatos e informações dos fornecedores que a empresa faz negócios |
|	Jean -> Comprador | poder cadastrar as matérias primas de maneira eficiente 	| para ter o registro dos detalhes das matérias primas que serão compradas 	|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID   | Descrição                                                            | Prioridade |
|------|----------------------------------------------------------------------|------------|
| RF-01| O sistema deve conter cadastro de perfis de usuário.                 | Média      |
| RF-02| O sistema deve conter cadastro de usuários.                          | Alta       |
| RF-03| O usuário deve ter um perfil atribuído a ele.                        | Média      |
| RF-04| O sistema deve conter cadastros de matéria prima e produto acabado. | Alta       |
| RF-05| O sistema deve conter lançamentos de movimentações de mercadoria.    | Alta       |
| RF-06| O sistema deve conter lançamentos de compras e vendas.              | Alta       |
| RF-07| O usuário deverá estar logado para acessar o sistema.                | Alta       |
| RF-08| O usuário só poderá acessar as funcionalidades atribuídas ao seu perfil. | Média  |
| RF-09| O usuário Administrador deve ter todo o controle de usuários e seus perfis. | Média |
| RF-10| O sistema deve conter cadastro de listas técnicas.                   | Baixa      |
| RF-11| O sistema deve ter lançamento de produção.                           | Baixa      |
| RF-12| O sistema deve ter cadastro de fornecedores.                         | Média      |
| RF-13| O sistema deve conter uma parte dedicada a relatório de estoque (Cruzando a saída, a entrada e a produção, para relatar quanto há de produto acabado e matéria prima em estoque) | Alta |
| RF-14| O sistema deve conter uma parte dedicada a relatório de vendas.      | Alta       |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ter interface de usuário intuitiva e clara.  | ALTA | 
|RNF-002| O sistema deve ser compatível com os principais navegadores (Google Chrome, Firefox, Microsoft Edge).  |  MÉDIA | 
|RNF-003| O sistema deve ser desenvolvido seguindo boas práticas e convenções de codificação em C#.   		| MÉDIA	|
|RNF-004| O sistema deve incluir medidas básicas de segurança, como autenticação de usuários.		| ALTA |
|RNF-005| O sistema deve ser responsivo e se adaptar a diferentes tamanhos de tela (desktop, celular, tablet). 		| BAIXA |
|RNF-006| O sistema deve ser desenvolvido de forma modular.		| MÉDIA	|

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
| RE-01| O sistema deve ser desenvolvido usando uma arquitetura MVC.        |
| RE-02| Não é permitido à equipe terceirizar o desenvolvimento do trabalho.|
| RE-03| O design do site deve seguir as diretrizes e requisitos estabelecidos, como o uso de cores específicas, logotipos e estilo de fonte.|
| RE-04| O código do Back-end deverá ser feito em C#                        |
| RE-05| O projeto deverá ser entregue até o final do semestre - 23/06/2024|
| RE-06| As decisões pertinentes ao projeto devem ser tomadas por meio democrático de votação.|

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

Diagrama de casos de uso de um sistema de gestão de recursos.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/65174193/80e3fcd4-32d8-4aa2-8fa3-1eb001f09f7b)





