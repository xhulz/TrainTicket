# TrainTicket

Aplicação usando ASP.NET Core com DDD Clean e Interface em Angular 6.

# Como instalar

# API

1. Baixar e instalar o Visual Studio Community 2017 (ASP.NET CORE)
2. Baixar e instalar o Framework 2.0
3. Abrir a solution **Train.sln**
4. Executar o comando **Build All**
5. Executar o comando **Run**
6. Após executar o comando **Run**, testar o endpoint **STATION** utilizando o verbo **GET**
7. Caso deseje utilizar uma cópia desse mesmo endpoint em produção, utilizar a seguinte **URL**: https://train-ticket.azurewebsites.net/api/station

# WEB

1. Baixar e instalar o **NODE.JS**: https://nodejs.org/en/
2. Baixar e instalar o **ANGULAR**: https://angular.io/guide/quickstart
3. Baixar e instalar o **Visual Studio Code**: https://code.visualstudio.com/
4. Abrir o **DOS** ou **Shell** dentro do diretório onde foi baixado o projeto
  - Executar o comando ```npm install``` para baixar as depenências do projeto
  - Abrir o diretório **Environments** e alterar o parâmetro ```api``` dos seguintes arquivos (caso haja necessidade):
      - **environment.prod.ts**: O parâmetro ```api``` está apontando para o endereço de produção "https://train-ticket.azurewebsites.net/api".
      - **environment.ts**: O parâmetro ```api``` está apontando para o endereço local: "http://localhost:24343/api".
  - Executar o comando ```ng build``` para verificar se o projeto está compilando corretamente.
  - Executar o comando ```ng serve``` para rodar o projeto em modo **DEVELOPER**
  - Executar o comando ```ng build --configuration=production --source-map``` para compilar o projeto em modo **PRODUÇÃO**
  - Fazer o deploy do conteúdo do diretório **DIST** para o servidor web

# Visualizar o projeto em modo produção

 1. Para visualizar o projeto em modo **Produção**, acessar a URL: https://train-ticket.azurewebsites.net/
