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

Para acessar o localhost da API use: https://localhost:7240/api/ -> Clientes, Pagamentos, Viagem ou Reservas e terá acesso aos dados cadastrados.
## Modelagem do banco de dados
### Modelo conceitual
![image](https://github.com/heitorpimentel/HpViagensAPI/assets/130229709/dcd383a3-7d73-4d7f-8a3a-a9bb380bde1c)
### Modelo lógico
![image](https://github.com/heitorpimentel/HpViagensAPI/assets/130229709/17328a10-bcc2-405f-b70a-6057eaaed9c2)
