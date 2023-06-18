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
