# HpViagensApiCsharpe
 Api usando linguagem C#

## Instruções de uso
#### Primeiro crie o banco de dados com o seguinte comando no seu MySQL
```bash
CREATE DATABASE hp_viagenscs
```
Após isso, se estiver usando o Visual Studio faça o seguinte
- Clique em Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes
- E digite:
```bash
Update-Database
```

Se for usar o VS Code fará:
- Terminal > Novo Terminal 
```bash
cd HpViagensApiCsharpe
# Em seguida
dotnet tool install --global dotnet-ef
# Em seguida
dotnet ef database update
# Em seguida
dotnet run
```
Para que o uso da api seja eficiente, será necesário cadastrar Cliente, Viagem, Pagamento e por último uma reserva, pois reserva contém os dados das 3 tabelas, não sendo possível cadastrar algum dado sem antes existir. </br>
Poderá fazer uso da aplicação Next para o consumo desta API: [clique aqui para ver o repositório](https://github.com/heitorpimentel/hp-viagens-final.git)

Para acessar o localhost da API use:`` http://localhost:<yourport>/api/ ``-> Clientes, Pagamentos, Viagem ou Reservas e terá acesso aos dados cadastrados.

## Visão Geral

### CLIENTES [api/Clientes]

### 1. Listar Clientes

**Rota:** `GET api/Clientes`

**Descrição:** Retorna uma lista de todos os clientes.

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    [
        {
            "id": 1,
            "nome": "Nome do Cliente",
            "cpf": "000.000.000-00",
            "sexo": "Sexo do Cliente",
            "dataNascimento": "2023-05-24T00:00:00.000Z",
            "telefone": "(00) 90000-0000",
            "email": "email@email.com",
            "senha": "Senha do Cliente"
        }
    ]
    ```

### 2. Criar Cliente

**Rota:** `POST api/Clientes`

**Descrição:** Cria um novo cliente.

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "nome": "Nome do Cliente",
        "cpf": "000.000.000-00",
        "sexo": "Sexo do Cliente",
        "dataNascimento": "2023-05-24T00:00:00.000Z",
        "telefone": "(00) 90000-0000",
        "email": "email@email.com",
        "senha": "Senha do Cliente"
    }
    ```

**Resposta:**

- **Status:** 201 Created
- **Corpo:**
    ```json
    {
        "id": 1,
        "nome": "Nome do Cliente",
        "cpf": "000.000.000-00",
        "sexo": "Sexo do Cliente",
        "dataNascimento": "2023-05-24T00:00:00.000Z",
        "telefone": "(00) 90000-0000",
        "email": "email@email.com",
        "senha": "Senha do Cliente"
    }
    ```

### 3. Obter Detalhes de um Cliente

**Rota:** `GET api/Clientes/{id}`

**Descrição:** Retorna os detalhes de um cliente específico.

**Parâmetros:**

- `id` (obrigatório): ID do cliente

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "nome": "Nome do Cliente",
        "cpf": "000.000.000-00",
        "sexo": "Sexo do Cliente",
        "dataNascimento": "2023-05-24T00:00:00.000Z",
        "telefone": "(00) 90000-0000",
        "email": "email@email.come",
        "senha": "Senha do Cliente"
    }
    ```

### 4. Atualizar Cliente

**Rota:** `PUT api/Clientes/{id}`

**Descrição:** Atualiza um cliente existente.

**Parâmetros:**

- `id` (obrigatório): ID do cliente

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "nome": "Nome Atualizado",
        "cpf": "000.000.000-00",
        "sexo": "Sexo Atualizado",
        "dataNascimento": "2023-05-24T00:00:00.000Z",
        "telefone": "(00) 90000-0001",
        "email": "email@email.com",
        "senha": "Senha Atualizada"
    }
    ```

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "nome": "Nome Atualizado",
        "cpf": "000.000.000-00",
        "sexo": "Sexo Atualizado",
        "dataNascimento": "2023-05-24T00:00:00.000Z",
        "telefone": "(00) 90000-0001",
        "email": "email@email.com",
        "senha": "Senha Atualizada"
    }
    ```

### 5. Excluir Cliente

**Rota:** `DELETE api/Clientes/{id}`

**Descrição:** Exclui um cliente.

**Parâmetros:**

- `id` (obrigatório): ID do cliente

**Resposta:**

- **Status:** 204 No Content

### PAGAMENTOS [api/Pagamentos]

### 1. Listar Pagamentos

**Rota:** `GET api/Pagamentos`

**Descrição:** Retorna uma lista de todos os pagamentos.

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    [
        {
            "id": 1,
            "dataPagamento": "2023-05-24T00:00:00.000Z",
            "valorPag": 100.00,
            "formaPag": "Cartão",
            "parcela": 1
        }
    ]
    ```

### 2. Criar Pagamento

**Rota:** `POST api/Pagamentos`

**Descrição:** Cria um novo pagamento.

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "dataPagamento": "2023-05-24T00:00:00.000Z",
        "valorPag": 100.00,
        "formaPag": "Cartão",
        "parcela": 1
    }
    ```

**Resposta:**

- **Status:** 201 Created
- **Corpo:**
    ```json
    {
        "id": 1,
        "dataPagamento": "2023-05-24T00:00:00.000Z",
        "valorPag": 100.00,
        "formaPag": "Cartão",
        "parcela": 1
    }
    ```

### 3. Obter Detalhes de um Pagamento

**Rota:** `GET api/Pagamentos/{id}`

**Descrição:** Retorna os detalhes de um pagamento específico.

**Parâmetros:**

- `id` (obrigatório): ID do pagamento

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "dataPagamento": "2023-05-24T00:00:00.000Z",
        "valorPag": 100.00,
        "formaPag": "Cartão",
        "parcela": 1
    }
    ```

### 4. Atualizar Pagamento

**Rota:** `PUT api/Pagamentos/{id}`

**Descrição:** Atualiza um pagamento existente.

**Parâmetros:**

- `id` (obrigatório): ID do pagamento

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "dataPagamento": "2023-05-24T00:00:00.000Z",
        "valorPag": 150.00,
        "formaPag": "Cartão",
        "parcela": 2
    }
    ```

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "dataPagamento": "2023-05-24T00:00:00.000Z",
        "valorPag": 150.00,
        "formaPag": "Cartão",
        "parcela": 2
    }
    ```

### 5. Excluir Pagamento

**Rota:** `DELETE api/Pagamentos/{id}`

**Descrição:** Exclui um pagamento.

**Parâmetros:**

- `id` (obrigatório): ID do pagamento

**Resposta:**

- **Status:** 204 No Content

### VIAGENS [api/Viagem]

### 1. Listar Viagens

**Rota:** `GET api/viagem`

**Descrição:** Retorna uma lista de todas as viagens.

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    [
        {
            "id": 1,
            "origem": "Origem da Viagem",
            "destino": "Destino da Viagem",
            "dataIda": "2023-05-24T00:00:00.000Z",
            "dataVolta": "2023-05-30T00:00:00.000Z"
        }
    ]
    ```

### 2. Criar Viagem

**Rota:** `POST api/viagem`

**Descrição:** Cria uma nova viagem.

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "origem": "Origem da Viagem",
        "destino": "Destino da Viagem",
        "dataIda": "2023-05-24T00:00:00.000Z",
        "dataVolta": "2023-05-30T00:00:00.000Z"
    }
    ```

**Resposta:**

- **Status:** 201 Created
- **Corpo:**
    ```json
    {
        "id": 1,
        "origem": "Origem da Viagem",
        "destino": "Destino da Viagem",
        "dataIda": "2023-05-24T00:00:00.000Z",
        "dataVolta": "2023-05-30T00:00:00.000Z"
    }
    ```

### 3. Obter Detalhes de uma Viagem

**Rota:** `GET api/viagem/{id}`

**Descrição:** Retorna os detalhes de uma viagem específica.

**Parâmetros:**

- `id` (obrigatório): ID da viagem

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "origem": "Origem da Viagem",
        "destino": "Destino da Viagem",
        "dataIda": "2023-05-24T00:00:00.000Z",
        "dataVolta": "2023-05-30T00:00:00.000Z"
    }
    ```

### 4. Atualizar Viagem

**Rota:** `PUT api/viagem/{id}`

**Descrição:** Atualiza uma viagem existente.

**Parâmetros:**

- `id` (obrigatório): ID da viagem

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "origem": "Origem Atualizada",
        "destino": "Destino Atualizado",
        "dataIda": "2023-05-24T00:00:00.000Z",
        "dataVolta": "2023-05-30T00:00:00.000Z"
    }
    ```

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "origem": "Origem Atualizada",
        "destino": "Destino Atualizado",
        "dataIda": "2023-05-24T00:00:00.000Z",
        "dataVolta": "2023-05-30T00:00:00.000Z"
    }
    ```

### 5. Excluir Viagem

**Rota:** `DELETE api/viagem/{id}`

**Descrição:** Exclui uma viagem.

**Parâmetros:**

- `id` (obrigatório): ID da viagem

**Resposta:**

- **Status:** 204 No Content

### RESERVAS [api/Reservas]

### 1. Listar Reservas

**Rota:** `GET api/Reservas`

**Descrição:** Retorna uma lista de todas as reservas.

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    [
        {
            "id": 1,
            "dataReserva": "2023-05-24T00:00:00.000Z",
            "clienteId": 1,
            "viagemId": 1,
            "pagamentoId": 1
        }
    ]
    ```

### 2. Criar Reserva

**Rota:** `POST api/Reservas`

**Descrição:** Cria uma nova reserva.

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "dataReserva": "2023-05-24T00:00:00.000Z",
        "clienteId": 1,
        "viagemId": 1,
        "pagamentoId": 1
    }
    ```

**Resposta:**

- **Status:** 201 Created
- **Corpo:**
    ```json
    {
        "id": 1,
        "dataReserva": "2023-05-24T00:00:00.000Z",
        "clienteId": 1,
        "viagemId": 1,
        "pagamentoId": 1
    }
    ```

### 3. Obter Detalhes de uma Reserva

**Rota:** `GET api/Reservas/{id}`

**Descrição:** Retorna os detalhes de uma reserva específica.

**Parâmetros:**

- `id` (obrigatório): ID da reserva

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "dataReserva": "2023-05-24T00:00:00.000Z",
        "clienteId": 1,
        "viagemId": 1,
        "pagamentoId": 1
    }
    ```

### 4. Atualizar Reserva

**Rota:** `PUT api/Reservas/{id}`

**Descrição:** Atualiza uma reserva existente.

**Parâmetros:**

- `id` (obrigatório): ID da reserva

**Requisição:**

- **Cabeçalhos:** `Content-Type: application/json`
- **Corpo:**
    ```json
    {
        "dataReserva": "2023-05-24T00:00:00.000Z",
        "clienteId": 1,
        "viagemId": 1,
        "pagamentoId": 1
    }
    ```

**Resposta:**

- **Status:** 200 OK
- **Corpo:**
    ```json
    {
        "id": 1,
        "dataReserva": "2023-05-24T00:00:00.000Z",
        "clienteId": 1,
        "viagemId": 1,
        "pagamentoId": 1
    }
    ```

### 5. Excluir Reserva

**Rota:** `DELETE api/Reservas/{id}`

**Descrição:** Exclui uma reserva.

**Parâmetros:**

- `id` (obrigatório): ID da reserva

**Resposta:**

- **Status:** 204 No Content

## Erros

### Estrutura de Erro

**Exemplo de Resposta de Erro:**

```json
{
    "error": "id não encontrado"
}
