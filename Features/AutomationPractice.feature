#language: pt

Funcionalidade: Automation Practice

Contexto: Acessar URL da aplicação
	Dado que o usuário acesse a aplicação

Cenário: Validar pesquisa pelo item T-shirt
	Quando o usuário pesquisar pelo item 'T-shirt'
	Então deverá ser exibido um resultado que contenha o valor informado na pesquisa

Esquema do Cenário: Adicionar o item T-shirt no carrinho de compras
	Quando o usuário pesquisar pelo item '<Item>'
	E selecionar o item pesquisado
	E adicionar o item no carrinho de compras
	Então deverá ser exibido um modal com a mensagem '<Mensagem>'
	E deverá ser exibido os dados do produto selecionado

Exemplos: 
	| Item    | Mensagem                                         |
	| T-shirt | Product successfully added to your shopping cart |
	| Blouse  | Product successfully added to your shopping cart |