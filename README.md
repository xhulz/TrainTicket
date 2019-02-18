# TrainTicket

Aplicação usando ASP.NET Core com DDD Clean e Interface em Angular 6.

# Como instalar

# API

1. Baixar e instalar o Visual Studio Community (ASP.NET CORE)
2. Baixar e instalar o Framework 2.0
3. Abrir a solution **Train.sln**
4. Executar o comando **Build All**
5. Executar o comando **Run**
6. Após executar, testar o **GET** em **STATION** no seguinte endpoint: http://localhost:24343/station
7. Caso deseje utilizar esse mesmo endpoint em produção, utilizar a seguinte **URL**: https://train-ticket.azurewebsites.net/api/station

# WEB

1. Baixar e instalar o **NODE.JS**: https://nodejs.org/en/
2. Baixar e instalar o **ANGULAR**: https://angular.io/guide/quickstart
3. Baixar e instalar o Visual Studio Code: https://code.visualstudio.com/
4. Instalar as extensões para o Visual Studio Code: 
  - https://marketplace.visualstudio.com/items?itemName=JuanBlanco.solidity
  - https://marketplace.visualstudio.com/items?itemName=lemon-berry.web3js-snippets
5. Abrir o **DOS** ou **Shell**
  - Baixar ou Clonar o projeto via **GIT**
  - Executar o comando ```npm install``` para baixar as depenências do projeto
  - Abrir o diretório **Environments** e alterar o endereço das apis, caso haja necessidade
      - **environment.prod.ts**: O Parâmetro ```api``` está apontando para o endereço de produção "https://train-ticket.azurewebsites.net/api".
      - **environment.ts**: O Parâmetro ```api``` está apontando para o endereço local: "http://localhost:24343/api".
  - Executar o comando ```ng build``` para verificar se a compilação está correta.
  - Executar o comando ```ng serve``` para executar o projeto em modo **DEVELOPER**
  - Executar o comando ```ng build --configuration=production --source-map``` para compilar o projeto em modo **PRODUÇÃO**
  - Fazer o deploy do conteúdo do diretório **DIST**
