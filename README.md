# Projeto de Modelagem de Sistemas
## Executando uma API em .NET

Este arquivo README fornecerá instruções sobre como executar uma API em .NET. Vamos supor que você já tenha baixado o código-fonte da API e tenha um ambiente de desenvolvimento .NET configurado. Certifique-se de ter o SDK do .NET instalado em sua máquina.

## Pré-requisitos

Antes de começar, verifique se você possui os seguintes pré-requisitos instalados:

- .NET SDK: visite o site oficial do .NET (https://dotnet.microsoft.com/download) para baixar e instalar a versão adequada para o seu sistema operacional.

## Passo 1: Configuração do ambiente

1. Abra o terminal ou prompt de comando e navegue até o diretório raiz do projeto da API.

2. Execute o seguinte comando para restaurar as dependências do projeto:

```shell
dotnet restore
```

## Passo 2: Configuração do banco de dados (se necessário)

Se a sua API utiliza um banco de dados, você precisa configurar a conexão antes de executá-la.

1. Abra o arquivo de configuração da API, geralmente chamado `appsettings.json` ou `appsettings.Development.json`.
2. Procure a seção relacionada ao banco de dados e verifique se as informações de conexão estão corretas. Certifique-se de que o servidor, o nome do banco de dados, o usuário e a senha estejam configurados corretamente.

## Passo 3: Executando a API

1. Execute o seguinte comando para compilar o projeto:

```shell
dotnet build
```

2. Após a conclusão da compilação, execute o seguinte comando para iniciar a API:


```shell
dotnet run
```

3. A API agora está em execução. Você verá uma mensagem no terminal indicando em qual endereço a API está ouvindo (por exemplo, `http://localhost:5000`).

## Testando a API

Agora que a API está em execução, você pode testá-la usando uma ferramenta como o Postman ou o curl no terminal. Aqui está um exemplo de como você pode fazer uma solicitação HTTP para a API:

```shell
curl -X GET http://localhost:5000/api/endpoint
```
Substitua `/api/endpoint` pelo caminho do endpoint específico que deseja acessar.

## Considerações finais

Essas são as etapas básicas para executar uma API em .NET. Lembre-se de que o processo pode variar dependendo do projeto e das configurações específicas que você está usando. Consulte a documentação oficial do .NET ou o arquivo README fornecido no projeto para obter informações mais detalhadas e específicas sobre a API que você está executando.

Divirta-se explorando e desenvolvendo com sua API em .NET!


