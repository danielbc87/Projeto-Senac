# Protótipo do Sistema de Gestão Escolar

## Tela 1: Tela de Login

- **Campos**:
  - **E-mail**: Campo de entrada para o e-mail do usuário.
  - **Senha**: Campo de entrada para a senha do usuário.
- **Botões**:
  - **Entrar**: Autentica o usuário e redireciona para o painel de controle.
  - **Esqueci minha senha**: Redireciona para a tela de recuperação de senha.
- **Links**:
  - **Registrar-se**: Redireciona para a tela de cadastro de novo usuário.

!(https://github.com/danielbc87/Projeto-Senac/blob/Vers%C3%A3o-2_Teste/Tela%20Login.jpg)
---

## Tela 2: Tela de Cadastro de Pessoa Física

- **Campos**:
  - **Nome Completo**: Campo de entrada para o nome completo.
  - **CPF**: Campo de entrada para o CPF.
  - **E-mail**: Campo de entrada para o e-mail.
  - **Telefone**: Campo de entrada para o telefone.
  - **Senha**: Campo de entrada para criar uma senha.
- **Botões**:
  - **Cadastrar**: Registra o usuário e redireciona para o painel de controle.
  - **Voltar**: Retorna à tela de login.

---

## Tela 3: Tela de Cadastro de Pessoa Jurídica

- **Campos**:
  - **Nome da Empresa**: Campo de entrada para o nome da empresa.
  - **CNPJ**: Campo de entrada para o CNPJ.
  - **E-mail**: Campo de entrada para o e-mail.
  - **Telefone**: Campo de entrada para o telefone.
  - **Senha**: Campo de entrada para criar uma senha.
- **Botões**:
  - **Cadastrar**: Registra a empresa e redireciona para o painel de controle.
  - **Voltar**: Retorna à tela de login.

---

## Tela 4: Tela de Cadastro de Professor

- **Campos**:
  - **Nome Completo**: Campo de entrada para o nome completo.
  - **CPF**: Campo de entrada para o CPF.
  - **E-mail**: Campo de entrada para o e-mail.
  - **Telefone**: Campo de entrada para o telefone.
  - **Disciplinas**: Campo para selecionar as disciplinas lecionadas.
  - **Senha**: Campo de entrada para criar uma senha.
- **Botões**:
  - **Cadastrar**: Registra o professor e redireciona para o painel de controle.
  - **Voltar**: Retorna à tela de login.

---

## Tela 5: Tela de Cadastro de Fornecedor

- **Campos**:
  - **Nome da Empresa**: Campo de entrada para o nome da empresa.
  - **CNPJ**: Campo de entrada para o CNPJ.
  - **E-mail**: Campo de entrada para o e-mail.
  - **Telefone**: Campo de entrada para o telefone.
  - **Tipo de Material Fornecido**: Campo de entrada para o tipo de material fornecido.
  - **Senha**: Campo de entrada para criar uma senha.
- **Botões**:
  - **Cadastrar**: Registra o fornecedor e redireciona para o painel de controle.
  - **Voltar**: Retorna à tela de login.

---

## Tela 6: Tela de Cadastro de Aluno

- **Campos**:
  - **Nome Completo**: Campo de entrada para o nome completo.
  - **CPF**: Campo de entrada para o CPF.
  - **E-mail**: Campo de entrada para o e-mail.
  - **Telefone**: Campo de entrada para o telefone.
  - **Curso**: Campo de entrada para o curso no qual está matriculado.
  - **Senha**: Campo de entrada para criar uma senha.
- **Botões**:
  - **Cadastrar**: Registra o aluno e redireciona para o painel de controle.
  - **Voltar**: Retorna à tela de login.

---

## Tela 7: Painel de Controle

- **Seções**:
  - **Perfil**: Mostra informações do usuário logado e permite edição.
  - **Cadastro**:
    - **Aluno**: Link para a tela de cadastro de alunos.
    - **Professor**: Link para a tela de cadastro de professores.
    - **Fornecedor**: Link para a tela de cadastro de fornecedores.
  - **Outras Funcionalidades**:
    - **Lançar Notas** (apenas para professores): Link para a tela de lançamento de notas.
    - **Visualizar Notas** (apenas para alunos): Link para a tela de visualização de notas.
    - **Registrar Entrega** (apenas para fornecedores): Link para a tela de registro de entregas.

- **Botões**:
  - **Sair**: Desloga o usuário e retorna à tela de login.

---

## Interações

- **Tela de Login > Entrar**: Redireciona para o Painel de Controle.
- **Tela de Login > Registrar-se**: Redireciona para a Tela de Cadastro de Pessoa Física ou Jurídica, dependendo da seleção.
- **Painel de Controle > Aluno**: Redireciona para a Tela de Cadastro de Aluno.
- **Painel de Controle > Professor**: Redireciona para a Tela de Cadastro de Professor.
- **Painel de Controle > Fornecedor**: Redireciona para a Tela de Cadastro de Fornecedor.
- **Painel de Controle > Lançar Notas**: Redireciona para a Tela de Lançamento de Notas.
- **Painel de Controle > Visualizar Notas**: Redireciona para a Tela de Visualização de Notas.
- **Painel de Controle > Registrar Entrega**: Redireciona para a Tela de Registro de Entregas.
- **Painel de Controle > Sair**: Retorna à Tela de Login.
