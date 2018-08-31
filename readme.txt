###### intalar nuget

https://www.nuget.org/downloads

##### comandos nuget
https://docs.microsoft.com/pt-br/nuget/tools/nuget-exe-cli-reference


##### site dos pacotes nuget
https://www.nuget.org/

-- dotnet add package SqlConnection --version 1.0.2

-- dotnet add package Microsoft.AspNetCore.Razor --version 2.2.0-preview1-35029

######## comandos utilizados para a criação da aplicação

dotnet new sln -n unipaulistana.sac -> cria uma solução

dotnet new mvc --name unipaulistana.web   -> criar o projeto web

dotnet new classlib -n unipaulistana.model -> criação da dll de modelo

dotnet new classlib -n unipaulistana.data -> criação do projeto de data

dotnet new classlib -n unipaulistana.services -> criação do projeto de serviços

dotnet sln unipaulistana.sac.sln add ./unipaulistana.web/unipaulistana.web.csproj -> adicionando projeto a solução

dotnet sln unipaulistana.sac.sln add ./unipaulistana.model/unipaulistana.model.csproj -> adicionar projeto a solução

dotnet sln unipaulistana.sac.sln add ./unipaulistana.data/unipaulistana.data.csproj -> adicionar projeto a solução

dotnet sln unipaulistana.sac.sln add ./unipaulistana.services/unipaulistana.services.csproj -> adicionar projeto a solução

dotnet add unipaulistana.web/unipaulistana.web.csproj reference unipaulistana.model/unipaulistana.model.csproj -> adiciona o projeto model na camada web

dotnet add unipaulistana.data/unipaulistana.data.csproj reference unipaulistana.model/unipaulistana.model.csproj -> adiciona o projeto model na camada data

dotnet add unipaulistana.services/unipaulistana.services.csproj reference unipaulistana.model/unipaulistana.model.csproj -> adiciona o projeto model na camada service

dotnet add unipaulistana.web/unipaulistana.web.csproj reference unipaulistana.data/unipaulistana.data.csproj -> adiciona o projeto data na camada web

dotnet add unipaulistana.web/unipaulistana.web.csproj reference unipaulistana.services/unipaulistana.services.csproj -> adiciona o projeto service na camada web

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.2.0-preview1-35029 -> adicionando scafolding ao projeto



############################## comandos 

dotnet sln unipaulistana.sac.sln remove ./unipaulistana.web/unipaulistana.web.csproj

dotnet new razor -n unipaulistana.web -> cria um projeto do tipo razor page

dotnet new xunit --name Reminders.Tests

dotnet aspnet-codegenerator controller -name Cliente2Controller -m Cliente --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries







