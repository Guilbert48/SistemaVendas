# Especificações do projeto

Será construido um sistema de vendas com cadastro de funcionários na base de dados, cadastro de produtos, venda com base nos produtos cadastrados. Serão feitas validações de login a partir dos usuários cadastrados na base de dados através de consultas sql. Será possível fazer CRUD (create, read, update, delete), na maioria das informações e diversas tabelas relacionais, do projeto, além de trabalhar diversos conceitos de SQL como joins, foreign key. primary key, dentre outros. Dentro da aplicação será possível executar vendas, que serão realizadas através de produtos cadastrados, onde suas informações vão servir para trazer um processo totalmente automatizado de cálculos de valor total, descontos e trocos. Além disso todas as vendas finalizadas irão gerar notas fiscais e também vão gerar registros na base de dados onde serão armazenadas informações sobre as vendas como: horário, data, usuário que efetuou a venda vendas daquele dia, lucros e gastos.

## ESQUELETO GERAL DO PROJETO 

1 Configuração do Banco de Dados: 

   - Uso do SQL Sever; 

   - Criação das tabelas necessárias para armazenar informações sobre funcionários, produtos, vendas, notas fiscais e registros. 

2 Cadastro de Funcionários: 

   - Criação de formulário para adicionar funcionários à base de dados; 

  -  Os campos do formulário, como nome, cargo, senha são validados; 

  -  Informações do funcionário são armazenadas na tabela apropriada. 

3 Cadastro de Produtos: 

   - Criação de um formulário para adicionar produtos à base de dados; 

   - Os campos do formulário, como nome do produto, preço, estoque, são validados; 

   - Informações do produto são armazenadas na tabela apropriada. 

4 Sistema de Login: 

 - Implementação de um sistema de login que verifica as credenciais do usuário na base de dados; 

5 Vendas: 

 - Criação de uma interface para realizar vendas, onde você pode selecionar produtos e quantidades; 

 - Calcule o valor total, descontos (se houver) e troco automaticamente; 

  -  Atualize automaticamente o estoque dos produtos após uma venda; 

  -  Gere notas fiscais e registre informações da venda. 

6 Registros e Relatórios: 

   - Registro de informações de cada venda, incluindo horário, data, funcionário, produtos vendidos, valor total, descontos, etc. 

   - Criação de relatórios para analisar as vendas diárias, lucros e etc. 

   - Utilização consultas SQL com junções (joins) para obter dados relacionais entre tabelas. 

7 CRUD (Create, Read, Update, Delete): 

   - Implemente operações CRUD para funcionários e produtos, permitindo adicionar, ler, atualizar e excluir registros. 

 
 8 Outros Conceitos SQL: 

   - Uso de conceitos como chaves primárias (primary keys) e chaves estrangeiras (foreign keys) para manter integridade referencial. 

   - Utilização de junções (joins) para buscar dados de tabelas relacionadas. 

### Requisitos Funcionais:

#### 1. Autenticação e Autorização:
   - **RF1:** O sistema deve permitir que os usuários façam login usando credenciais válidas (nome de usuário e senha).
   - **RF2:** O sistema deve autenticar os usuários com base nas informações armazenadas no banco de dados sql server.

#### 2. Cadastro de Funcionários:
   - **RF3:** O sistema deve permitir o cadastro de novos funcionários, incluindo informações como nome, cargo e credenciais de login.
   - **RF4:** O sistema deve permitir a atualização das informações dos funcionários.
   - **RF5:** O sistema deve permitir a exclusão de funcionários do banco de dados.

#### 3. Cadastro de Produtos:
   - **RF6:** O sistema deve permitir o cadastro de novos produtos, incluindo informações como nome, descrição, preço e quantidade em estoque.
   - **RF7:** O sistema deve permitir a atualização das informações dos produtos.
   - **RF8:** O sistema deve permitir a exclusão de produtos do banco de dados.

#### 4. Vendas:
   - **RF9:** O sistema deve permitir que os funcionários selecionem produtos para venda.
   - **RF10:** O sistema deve calcular o valor total da venda com base nos produtos selecionados, aplicando descontos, se houver.
   - **RF11:** O sistema deve permitir a finalização da venda, incluindo a geração de nota fiscal.
   - **RF12:** O sistema deve calcular o troco, se o cliente pagar com um valor superior ao total da compra.
   - **RF13:** O sistema deve registrar a venda no banco de dados, incluindo informações como horário, data, produtos vendidos, valor total e funcionário responsável.

#### 5. Relatórios:
   - **RF14:** O sistema deve permitir a geração de relatórios diários de vendas, incluindo informações sobre vendas, lucros e gastos.
   - **RF15:** O sistema deve permitir a visualização de histórico de vendas por funcionário.

### Requisitos Não Funcionais:

#### 1. **Desempenho:**
   - **RNF1:** O sistema deve ser responsivo, fornecendo feedback ao usuário dentro de 5 segundos para qualquer operação.
   - **RNF2:** O sistema deve ser capaz de lidar com pelo menos 50 usuários simultâneos sem degradação significativa no desempenho.

#### 2. **Segurança:**
   - **RNF3:** As senhas dos usuários devem ser armazenadas de forma segura, utilizando algoritmos de hash seguros com salt para proteger contra ataques de força bruta.
   - **RNF4:** O sistema deve ter controle de acesso baseado em papéis (RBAC), garantindo que apenas usuários autorizados tenham permissões específicas.

#### 3. **Confiabilidade:**
   - **RNF5:** O sistema deve ter um backup diário dos dados para evitar a perda de informações em caso de falha.
   - **RNF6:** O sistema deve ser capaz de se recuperar automaticamente de falhas, minimizando o tempo de inatividade.

#### 4. **Usabilidade:**
   - **RNF7:** A interface do usuário deve ser intuitiva e fácil de usar, exigindo o mínimo de treinamento para os usuários.
   - **RNF8:** O sistema deve fornecer feedback claro e mensagens de erro compreensíveis para orientar os usuários em caso de problemas.

#### 5. **Manutenibilidade:**
   - **RNF9:** O código fonte deve ser bem organizado e seguir as melhores práticas de programação para facilitar a manutenção e extensibilidade do sistema.
   - **RNF10:** O sistema deve ser modular, permitindo a fácil adição ou remoção de funcionalidades sem afetar outras partes do sistema.

#### 6. **Compatibilidade:**
   - **RNF11:** O sistema deve ser compatível com os principais navegadores web, como Chrome, Firefox, Safari e Edge.
   - **RNF12:** O sistema deve ser compatível com sistemas operacionais Windows, macOS e Linux.

#### 7. **Documentação:**
   - **RNF13:** O sistema deve ter uma documentação abrangente, incluindo manual do usuário, guia de instalação e documentação técnica para facilitar o entendimento e a manutenção do sistema.

#### 8. **Escalabilidade:**
   - **RNF15:** O sistema deve ser escalável, permitindo a adição de mais usuários, produtos e transações sem comprometer o desempenho.


     Com base nos requisitos funcionais fornecidos, é possível identificar vários casos de uso para o sistema de vendas em C#. Aqui estão alguns exemplos de casos de uso:

## Casos de Uso do Sistema de Vendas:

### 1. **Autenticação do Usuário:**
   - **Ator:** Funcionário
   - **Descrição:** O funcionário fornece suas credenciais (nome de usuário e senha) para acessar o sistema.
   - **Fluxo Principal:**
     1. O sistema exibe a tela de login.
     2. O funcionário insere seu nome de usuário e senha.
     3. O sistema valida as credenciais.
     4. Se as credenciais forem válidas, o funcionário é autenticado e pode acessar o sistema.

### 2. **Gerenciamento de Funcionários:**
   - **Ator:** Administrador
   - **Descrição:** O administrador pode adicionar, visualizar, atualizar e excluir informações de funcionários no sistema.
   - **Fluxo Principal:**
     1. O administrador seleciona a opção de gerenciamento de funcionários.
     2. O sistema exibe a lista de funcionários.
     3. O administrador pode adicionar um novo funcionário, editar as informações de um funcionário existente ou excluir um funcionário.

### 3. **Gerenciamento de Produtos:**
   - **Ator:** Administrador
   - **Descrição:** O administrador pode adicionar, visualizar, atualizar e excluir informações de produtos no sistema.
   - **Fluxo Principal:**
     1. O administrador seleciona a opção de gerenciamento de produtos.
     2. O sistema exibe a lista de produtos disponíveis.
     3. O administrador pode adicionar um novo produto, editar as informações de um produto existente ou excluir um produto.

### 4. **Realização de Vendas:**
   - **Ator:** Funcionário
   - **Descrição:** O funcionário pode selecionar produtos para venda, calcular o total, aplicar descontos, finalizar a venda e gerar uma nota fiscal.
   - **Fluxo Principal:**
     1. O funcionário seleciona produtos da lista de produtos disponíveis.
     2. O sistema calcula o valor total da compra.
     3. O funcionário aplica descontos, se houver.
     4. O funcionário finaliza a venda, indicando o método de pagamento.
     5. O sistema gera uma nota fiscal para a venda.

### 5. **Geração de Relatórios:**
   - **Ator:** Funcionário
   - **Descrição:** O funcionário pode gerar relatórios diários de vendas e visualizar o histórico de vendas por funcionário.
   - **Fluxo Principal:**
     1. O funcionário seleciona a opção de geração de relatórios.
     2. O sistema permite ao funcionário escolher entre relatório diário ou histórico de vendas por funcionário.
     3. O sistema gera o relatório solicitado e o exibe para o funcionário.

### Regras de Negócio:

### 1. **Autenticação de Usuários:**
   - **RN1:** Apenas usuários cadastrados no sistema podem fazer login.
   - **RN2:** As credenciais de login (nome de usuário e senha) devem ser validadas antes de permitir o acesso ao sistema.

### 2. **Gerenciamento de Funcionários:**
   - **RN3:** O nome de usuário de um funcionário deve ser único no sistema.
   - **RN4:** Todos os funcionários devem ter um cargo atribuído (por exemplo, vendedor, gerente).
   - **RN5:** Um funcionário não pode ser excluído se tiver registros de vendas associados a ele.

### 3. **Gerenciamento de Produtos:**
   - **RN6:** O código de identificação único de um produto (SKU) deve ser único no sistema.
   - **RN7:** O preço de um produto não pode ser negativo ou zero.
   - **RN8:** A quantidade em estoque de um produto não pode ser negativa.

### 4. **Realização de Vendas:**
   - **RN9:** O sistema deve calcular corretamente o valor total da venda com base nos produtos selecionados e nos descontos aplicados.
   - **RN10:** O sistema deve calcular corretamente o troco, se o cliente pagar com um valor superior ao total da compra.
   - **RN11:** A venda só pode ser finalizada se houver pelo menos um produto na lista de itens vendidos.

### 5. **Geração de Relatórios:**
   - **RN12:** Os relatórios diários de vendas devem incluir informações precisas sobre vendas, lucros e gastos do dia.
   - **RN13:** O histórico de vendas por funcionário deve ser preciso e mostrar todas as vendas realizadas por um funcionário específico.

### 6. **Segurança:**
   - **RN14:** A senha do usuário deve ser armazenada de forma segura, utilizando técnicas de hash e salt para proteger contra acesso não autorizado.
   - **RN15:** As transações devem ser protegidas contra acessos não autorizados. Apenas usuários autenticados têm permissão para realizar vendas ou acessar informações confidenciais.

### 7. **Outras Regras:**
   - **RN16:** O sistema deve manter um registro de todas as transações de vendas, incluindo informações sobre produtos vendidos, horário da venda, valor total, descontos aplicados e funcionário responsável.


## Caso de Uso: Efetuar login 

### Atores principais:
- vendedor
- administrador 

### Interessados: 

   Administrador: Responsável por gerenciar as informações dos funcionários no sistema. 

   Vendedor: Responsável pela realização de vendas no sistema 

### Pré-condições: 

   Os atores (usuários) devem estar cadastrados no sistema. 

### Fluxo Principal: 

- Os atores autenticam-se no sistema; 

- O sistema solicita as informações obrigatórias para a autenticação, inicialmente solicitando a qual grupo pertence o ator(usuário): 

- No caso do grupo usuário-vendedor: 

  > Nome 

  > Nome de usuário 

  > Código de vendedor 

  > Senha  

     Grupo usuário-Admin: 

  > Nome 

  > Nome de usuário 

  > Código de administrador

  > Senha 

3. O sistema informa os dados de autenticação; 

4. O sistema valida os dados de autenticação; 

5. A autenticação realizada pelo usuário é registrada no histórico; 

6. O sistema informa que a autenticação foi realizada com sucesso. 

Fluxo Alternativo: 

A1. Erro de autenticação:  O sistema informa o erro de autenticação ao usuário, detalhando o motivo, e o fluxo principal retorna ao passo 2. 

A2. Usuário Bloqueado: 

   - O sistema informa que o usuário está bloqueado, e o fluxo principal retorna ao passo 2. 

### Pós-condições: 

   - O usuário fica habilitado a realizar ações na área restrita do sistema. 

### Regras de Negócio: 

RN01- Apenas usuários cadastrados podem se autenticar no sistema 

RN02- Não haverá duplicidade de nome de usuário e código de identificação. 
 
## Caso de Uso: Realizar Venda 

### Ator Principal: Vendedor 

### Interessados: 

   Vendedor: Quem inicia o processo de venda. 

   Cliente: A pessoa que está comprando os produtos. 

   Sistema: Para calcular o valor total, descontos e atualizar o estoque. 

### Pré-condições: 

- O vendedor fez login no sistema. 
- O sistema está funcionando corretamente. 

### Fluxo Principal: 

1. O  vendedor seleciona a opção "Iniciar Venda" no sistema; 
2. O sistema exibe uma tela para adicionar produtos à venda (leitura do código de barra); 
3. O vendedor adiciona produtos ao carrinho de compras, especificando a quantidade desejada; 
4. O sistema atualiza automaticamente o valor total da venda à medida que os produtos são adicionados; 
5. O vendedor aplica descontos, se necessário, especificando o valor ou a porcentagem de desconto; 
6. O sistema recalcula o valor total após a aplicação dos descontos; 
7. O  vendedor verifica os itens no carrinho e confirma a venda; 
8. O sistema gera uma nota fiscal, registrando informações sobre a venda, como data, hora, produtos vendidos e valor total; 
9. O sistema atualiza automaticamente o estoque, reduzindo a quantidade de produtos vendidos. 
	 

### Fluxo Alternativo: 

A1. Cancelar Venda: 

   Se o usuário solicitar cancelar a venda a qualquer momento durante o processo, o sistema permite que a venda seja cancelada.  
   A nota fiscal não é gerada e o estoque não é atualizado. 

### Pós-condições: 

   - Uma nota fiscal é gerada para a venda. 

   - O estoque de produtos é atualizado. 

   - O  valor total da venda é registrado. 

   - A venda é registrada no sistema. 

### Regras de Negócio: 

RN7- O sistema deve calcular automaticamente o valor total da venda e o troco. 

RN8- Os descontos aplicados não podem exceder o valor total da venda. 

RN9- O sistema deve validar a disponibilidade de produtos em estoque. 

 

### Caso de Uso: Gerenciar Produtos 

### Ator Principal: Gerente 

### Interessados: 

 Gerente: Quem inicia o processo de gerenciamento de produtos no sistema. 

### Pré-condições: 

   O gerente fez login no sistema. 

   O sistema está funcionando corretamente. 
     

### Fluxo Principal: 

1. O gerente seleciona a opção "Gerenciar Produtos" no sistema. 

2. O sistema exibe uma lista de produtos cadastrados no sistema. 

3. O gerente pode optar por realizar as seguintes ações: 
 

3.1 Adicionar Produto: 
 - O gerente insere os detalhes do novo produto, incluindo nome, preço, descrição, categoria e quantidade em estoque; 
- O sistema gera automaticamente um código específico e único para o novo produto;  
- O sistema verifica se os campos obrigatórios estão preenchidos corretamente 
- O produto é adicionado ao sistema e a lista de produtos é atualizada. 
 

3.2 Editar Produto: 
- O gerente seleciona um produto da lista e opta por editá-lo. 
- O sistema exibe um formulário pré-preenchido com as informações do produto. 
- O gerente faz as edições necessárias (preço, descrição, quantidade, etc.). 
- O sistema verifica se as alterações são válidas. 
- O produto é atualizado com as novas informações. 
 
3.3 Visualizar Produto: 
-O gerente seleciona um produto na lista para visualizar detalhes. 
- O sistema exibe informações detalhadas sobre o produto, incluindo nome, preço, descrição, categoria e quantidade em estoque. 
 
3.4 Excluir Produto: 
- O gerente seleciona um produto na lista e opta por excluí-lo. 
- O sistema exibe uma confirmação de exclusão. 
 

- O produto é removido do sistema e a lista de produtos é atualizada. 

 

### Fluxo Alternativo: 

A1. Cancelar Ação: 
- Em qualquer ponto do processo, o funcionário pode optar por cancelar a ação e voltar à lista de produtos. 

Pós-condições: 
- Os produtos são adicionados, editados, visualizados ou excluídos conforme a ação realizada 

### Regras de Negócio: 

RN10- Campos obrigatórios devem ser validados ao adicionar ou editar produtos. 

RN03- O sistema deve garantir a integridade referencial entre produtos e categorias. 

RN11- Os produtos devem ser associados a categorias adequadas. 

 

## Caso de Uso: Gerenciar Usuário 

### Ator Principal: Administrador

### Interessados: 

- Administrador: Responsável por gerenciar as informações dos funcionários no sistema. 
- Vendedor: O próprio funcionário que terá suas informações gerenciadas. 

### Pré-condições: 

- O adimin fez login no sistema. 
- O sistema está funcionando corretamente. 
 

### Fluxo Principal: 
1. O admin seleciona a opção "Gerenciar Usuário" no sistema. 

2. O sistema exibe uma lista de usuários cadastrados no sistema, incluindo informações como nome, nome de usuário, cargo e outras informações pessoais. 

3. O administrador pode optar por realizar as seguintes ações: 

 a. Adicionar Funcionário: 
- O gerente inicia a ação "Adicionar usuário". 
- O sistema exibe um formulário com campos para inserção das informações do novo usuário. 
- O gerente preenche os campos obrigatórios, como nome, sobrenome, nome de usuário e senha. 
- O sistema verifica se os campos obrigatórios estão preenchidos corretamente. 
- O usuário é adicionado ao sistema como um novo usuário, e a lista de funcionários é atualizada automaticamente. 

   b. Editar Funcionário: 
- O gerente seleciona um usuário da lista para edição. 
- O sistema exibe um formulário pré-preenchido com as informações do funcionário selecionado. 
- O gerente faz as edições necessárias, como nome, nome de usuário, cargo, etc. 
- O sistema verifica se as alterações são válidas. 
- As informações do usuário são atualizadas, e a lista de usuários é atualizada automaticamente. 

   c. Visualizar Usuário: 
- O gerente seleciona um usuário na lista para visualizar detalhes. 
- O sistema exibe uma tela com informações detalhadas sobre o usuário   selecionado, incluindo nome, nome de usuário, cargo e outras informações pessoais. 

   d. Excluir Usuário: 
- O admin seleciona um usuário na lista e opta por excluí-lo. 
 - O sistema exibe uma confirmação de exclusão. 
 - Após a confirmação, o usuário é removido do sistema, e a lista de usuários é atualizada automaticamente. 
 

### Fluxo Alternativo: 

A1. Cancelar Ação: 

   Em qualquer ponto do processo, o admin pode optar por cancelar a ação atual e voltar à lista de usuários. 

### Pós-condições: 

   Os usuários são adicionados, editados, visualizados ou excluídos conforme a ação realizada. 

 

### Regras de Negócio: 

RN12- Campos obrigatórios, como nome, nome de usuário e senha, devem ser validados ao adicionar ou editar usuários. 

RN13- O sistema deve garantir que os nomes de usuário sejam únicos. 

RN14- A senha deve ser armazenada de forma segura, utilizando técnicas de criptografia. 


