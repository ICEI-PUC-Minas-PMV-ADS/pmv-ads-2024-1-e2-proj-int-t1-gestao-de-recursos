# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

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

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário gerencie suas tarefas | ALTA | 
|RF-002| A aplicação deve emitir um relatório de tarefas realizadas no mês   | MÉDIA |

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

Diagrama de casos de uso de um sistema de gestão de estoque.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-gestao-de-recursos/assets/65174193/0c63f202-fc20-4b03-88fe-41788e323ccf)



