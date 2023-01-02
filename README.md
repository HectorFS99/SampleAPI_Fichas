# SampleAPI_Fichas
Amostra simples de uma API que faz operações CRUD para gerencimento de fichas cadastrais.

Para realizar um teste com o banco de dados (além de ter este instalado na sua máquina), abra o gerenciador de pacotes do Nuget, e digite os seguintes comandos, na ordem destacada:

Remove-Migration
Add-Migration Fichas
Update-Database

Feito isso, verifique se o banco "ficha" foi criado, e execute o projeto para testar a API utilizando o Swagger, caso não queira utilizar o Postman.
