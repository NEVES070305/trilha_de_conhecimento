# Trilha de conhecimento
# .NET

# Introdução ao .NET

.NET é uma plataforma de desenvolvimento criada pela Microsoft que permite a construção e execução de aplicações para Windows, macOS, Linux e mais. Lançada originalmente em 2002, a plataforma .NET tornou-se essencial para desenvolvedores de software devido à sua flexibilidade, desempenho e suporte abrangente a várias linguagens de programação, como C#, F#, e Visual Basic.

## História do .NET

A história do .NET começou no final dos anos 90, quando a Microsoft decidiu desenvolver uma nova plataforma de software para enfrentar o crescente desafio das aplicações baseadas na web e em múltiplas linguagens. Em 2002, a Microsoft lançou a primeira versão do .NET Framework, que se focava principalmente no desenvolvimento de aplicações para o sistema operacional Windows.

### Transição para Multiplataforma

A transição do .NET para uma plataforma verdadeiramente multiplataforma começou com o anúncio do .NET Core em 2014. Esta nova implementação de .NET foi projetada desde o início para ser aberta e funcionar em diferentes sistemas operacionais. Em 2016, a Microsoft lançou o .NET Core 1.0, a primeira versão oficial do .NET Core, permitindo aos desenvolvedores criar e executar aplicações tanto em Windows quanto em macOS e Linux. Essa mudança foi um marco significativo, destacando o compromisso da Microsoft com o código aberto e a interoperabilidade.

Com o lançamento do .NET 5 em 2020, a Microsoft unificou o .NET Core e o .NET Framework em uma única plataforma .NET, simplificando o desenvolvimento e mantendo a compatibilidade multiplataforma. Desde então, as versões subsequentes, como .NET 6 em 2021 e .NET 7 em 2022, têm continuado a expandir as capacidades multiplataforma e a melhorar o desempenho e a produtividade para os desenvolvedores.

### .NET na Atualidade

Nos últimos anos, o .NET se tornou uma das plataformas mais populares para o desenvolvimento de aplicações ao redor do mundo, competindo diretamente com a plataforma Java. Utilizando linguagens como C#, F#, e VB.NET, o .NET oferece um ambiente robusto para o desenvolvimento de uma vasta gama de aplicações, incluindo:

- Aplicativos web
- Aplicativos mobile
- Soluções de microsserviços
- Aplicativos desktop e jogos

### Componentes Centrais do .NET

O .NET é sustentado por dois componentes principais: a Common Language Runtime (CLR) e a Class Library (biblioteca de classes).

#### Common Language Runtime (CLR)

A CLR é a máquina virtual do .NET que gerencia a execução de aplicações. Similar à JVM do Java, a CLR permite que qualquer linguagem que produza códigos em Intermediate Language (IL) seja executada. Ela gerencia memória, verifica tipos, cuida de exceções, implementa segurança, e oferece suporte à interoperabilidade de linguagens e coleta de lixo.

#### Biblioteca de Classes

A biblioteca de classes fornece um conjunto de classes e interfaces que permitem acessar diversas funcionalidades do sistema, sendo o ponto de partida para o desenvolvimento de qualquer solução na plataforma. As principais funcionalidades incluem representação de tipo e exceções, operações de entrada e saída, acesso a dados e rede, e encapsulamento de estruturas de dados.

### Assemblies e JIT

Assemblies são pacotes que contêm arquivos necessários para executar programas .NET, incluindo .dll e .exe. O Just-In-Time (JIT) Compiler converte o código IL para código nativo de máquina em tempo de execução, otimizando o desempenho.

### Certificações Microsoft

A Microsoft oferece diversas certificações para desenvolvedores .NET, ajudando-os a validar suas habilidades e conhecimentos na plataforma. Essas certificações são reconhecidas globalmente e podem impulsionar a carreira de um desenvolvedor ao demonstrar sua competência em tecnologias .NET.

## Conclusão

O .NET evoluiu significativamente desde sua criação, passando de uma plataforma exclusiva para Windows para uma solução de desenvolvimento globalmente acessível. Com o .NET Core e a unificação sob o .NET 5 e além, os desenvolvedores agora têm a liberdade de criar aplicações de alto desempenho para uma ampla variedade de sistemas operacionais e dispositivos. A evolução contínua da plataforma .NET, juntamente com o suporte da Microsoft e uma ativa comunidade de desenvolvedores, assegura seu lugar como uma das principais escolhas para o desenvolvimento de software moderno.

## Referências 
- [.NET: apresentando a plataforma de desenvolvimento da Microsoft](https://www.alura.com.br/artigos/net-framework-dotnet#:~:text=NET%3F-,O%20.,como%20Windows%2C%20macOS%20e%20Linux) 
- [.NET: Crie. Teste. Implante.](https://dotnet.microsoft.com/pt-br/)


# Procedures e o Padrão de Projeto Repositório

## Introdução

No desenvolvimento de software, a organização e a manutenção do código são aspectos cruciais para a eficiência e a qualidade do projeto. Duas abordagens comuns que ajudam a alcançar esses objetivos são o uso de procedures (procedimentos) e o padrão de projeto repositório. Ambos têm seu lugar em diferentes contextos e podem ser usados de forma complementar para melhorar a estrutura e a gestão do código.

## Procedures

### O que são Procedures?

Procedures, ou procedimentos armazenados, são sub-rotinas disponíveis em sistemas de gerenciamento de banco de dados (SGBD). Eles permitem que um conjunto de instruções SQL seja armazenado e executado repetidamente sem a necessidade de reescrever o código SQL. Procedures podem receber parâmetros de entrada e saída, permitindo a execução de lógica complexa diretamente no banco de dados.

### Benefícios das Procedures

1. **Reutilização de Código**: Procedures permitem que trechos de código SQL sejam reutilizados em várias partes da aplicação, promovendo a manutenção e a consistência.
2. **Desempenho**: Executar lógica diretamente no banco de dados pode reduzir a sobrecarga de rede e melhorar o desempenho, especialmente em operações complexas ou frequentes.
3. **Segurança**: Procedures podem encapsular a lógica do banco de dados, permitindo controle de acesso granular e evitando a exposição direta das tabelas de banco de dados.

### Exemplos de Uso

- **Validações e Regras de Negócio**: Implementação de validações e lógica de negócios complexa.
- **Operações de CRUD**: Procedimentos para criar, ler, atualizar e deletar registros de forma eficiente.
- **Automatização de Tarefas**: Tarefas agendadas ou automáticas, como backups e sincronizações.

```sql
CREATE PROCEDURE GetCustomerOrders
    @CustomerId INT
AS
BEGIN
    SELECT * FROM Orders WHERE CustomerId = @CustomerId
END
```

### O que é o Padrão Repository?

O padrão Repository atua como uma ponte entre o domínio da aplicação e a camada de acesso a dados, proporcionando uma maneira de manipular coleções de objetos de domínio de forma orientada a objetos. Ele permite isolar a lógica de acesso aos dados, separando-a das camadas de apresentação e de negócios da aplicação.


Um repositório é essencialmente uma coleção de objetos de domínio em memória, e, com base nisso o padrão Repository permite realizar o isolamento entre a camada de acesso a dados (DAL) de sua aplicação e sua camada de apresentação (UI) e camada de negócios (BLL).

Ao utilizar o padrão Repository, você pode realizar a persistência e a separação de interesses em seu código de acesso a dados visto que ele encapsula a lógica necessária para persistir os objetos do seu domínio na sua fonte de armazenamento de dados.

### Exemplo de Uso

```csharp
using System;
using System.Data;
using System.Data.SqlClient;

public class CustomerRepository
{
    private readonly string _connectionString;

    public CustomerRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DataTable GetAllCustomers()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(nome_da_procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error retrieving data: " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dataset;
        }
    }
}

```

### Benefícios do Padrão Repository

- **Desacoplamento**: O padrão Repository permite desacoplar o modelo de domínio do código de acesso a dados, facilitando a manutenção, promovendo a reutilização de código e proporcionando uma estrutura mais organizada para a aplicação.
- **Centralização da Lógica de Persistência**: Ele centraliza a lógica de persistência de objetos de domínio em um único lugar, encapsulando as operações necessárias para interagir com a fonte de dados.
- **Flexibilidade**: Proporciona uma maior flexibilidade na escolha da tecnologia de armazenamento de dados, facilitando mudanças e evoluções futuras.

Martin Fowler descreve o Repository como uma coleção de objetos de domínio em memória, medindo a comunicação entre o domínio da aplicação e as camadas de mapeamento de dados. Ele fornece uma visão mais orientada a objetos da camada de persistência e ajuda a alcançar uma separação limpa e uma forma de dependência entre o domínio e as camadas de mapeamento de dados.

Em suma, o padrão Repository permite desacoplar o modelo de domínio do código de acesso a dados, facilitando a manutenção, promovendo a reutilização de código e proporcionando uma estrutura mais organizada para a aplicação.

## Referências
- [.NET - Apresentando o padrão de projeto Repository](https://www.macoratti.net/11/10/net_pr1.htm)
- [REST API's RESTFul do 0 à Azure com ASP.NET Core 5 e Docker] (https://www.udemy.com/course/restful-apis-do-0-a-nuvem-com-aspnet-core-e-docker/learn/lecture/22577532?start=30#overview), seções: 1,2,5, 6, 7, 8, 9, 10, 11, 17, 19, 22 e 23
- [Curso Completo C#: Do Básico ao Avançado!] (https://www.udemy.com/course/curso-c-sharp/learn/lecture/10856538?start=0#overview)

# Docker 
Docker é uma plataforma de código aberto que simplifica o desenvolvimento, a distribuição e a execução de aplicativos em contêineres. Contêineres são unidades leves e autossuficientes que podem ser implantadas consistentemente em qualquer ambiente, desde o desenvolvimento até a produção. Essa abordagem resolve o problema comum do "funciona na minha máquina" ao garantir que o ambiente de execução do aplicativo seja o mesmo em todos os lugares.

Uma das principais vantagens do Docker é o uso de Dockerfiles, que são arquivos de texto que contêm instruções para construir imagens de contêineres personalizadas. É como fornecer uma receita para criar um ambiente de execução específico para o seu aplicativo. Essas imagens contêm todos os componentes necessários para o aplicativo funcionar corretamente, incluindo código, dependências, configurações e ambiente de tempo de execução.

Por exemplo, se você estiver trabalhando com ASP.NET Core, a Microsoft fornece imagens prontas para uso que incluem tudo o que você precisa para desenvolver e executar aplicativos .NET Core em contêineres Docker. Você pode usar essas imagens como base e personalizá-las conforme necessário, adicionando seu código e configurando o ambiente de acordo com os requisitos do seu aplicativo.

Depois de criar sua imagem personalizada usando um Dockerfile, você pode usar o Docker CLI para construir a imagem e criar um contêiner a partir dela. O Docker CLI oferece uma variedade de comandos para gerenciar contêineres, como executar, parar, iniciar e remover. Você também pode usar Docker Compose, uma ferramenta que permite definir e executar aplicativos Docker compostos por vários contêineres.

Uma vez que seu aplicativo esteja em um contêiner Docker, você pode implantá-lo em qualquer lugar onde o Docker Engine esteja em execução, seja em sua máquina local, em um servidor local ou na nuvem. Isso oferece uma grande flexibilidade e portabilidade para seus aplicativos, permitindo que você dimensione facilmente de acordo com as demandas do seu negócio.

Em resumo, o Docker é uma ferramenta poderosa para simplificar o processo de desenvolvimento, distribuição e implantação de aplicativos, fornecendo uma maneira consistente e confiável de executar seus aplicativos em qualquer lugar. Com o uso de Dockerfiles e imagens personalizadas, você pode garantir que seu aplicativo funcione de maneira confiável em qualquer ambiente, eliminando o problema do "funciona na minha máquina".

Claro! Aqui está uma explicação sobre como criar um Dockerfile para uma aplicação C# e como executá-la:

### Criando um Dockerfile para uma Aplicação C#

Para criar um Dockerfile para uma aplicação C#, você pode seguir estas etapas, que é um multi-stage Dockerfiles:

### Estágio 1: Definir a imagem base para produção

```Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app 
ENV ASPNETCORE_ENVIROMENT=Development
```
Neste estágio:
- A imagem base `mcr.microsoft.com/dotnet/aspnet:5.0` é usada para fornecer o ambiente de execução ASP.NET Core.
- Define o diretório de trabalho `/app`.
- Define a variável de ambiente `ASPNETCORE_ENVIRONMENT` como `Development`.

### Estágio 2: Construir e publicar o código

```Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["YourAppName.csproj", "."]
RUN dotnet restore "./YourAppName.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./YourAppName.csproj" -c $BUILD_CONFIGURATION -o /app/build
```
Neste estágio:
- A imagem base `mcr.microsoft.com/dotnet/sdk:5.0` é usada para fornecer o SDK do .NET Core necessário para compilar o código.
- O código-fonte é copiado para dentro do contêiner.
- As dependências são restauradas usando o comando `dotnet restore`.
- O código é compilado usando o comando `dotnet build`.
- O código compilado é armazenado no diretório `/app/build`.

```Dockerfile
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./YourAppName.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
```
Neste estágio, uma nova etapa é criada a partir do estágio de construção:
- O código é publicado usando o comando `dotnet publish`.
- O código publicado é armazenado no diretório `/app/publish`.
- O parâmetro `/p:UseAppHost=false` é usado para garantir que o arquivo do host de aplicativo não seja gerado. Isso é útil quando a aplicação está sendo executada em um ambiente de contêiner, onde não é necessário o arquivo do host de aplicativo.

### Estágio 3: Preparar a imagem final para produção

```Dockerfile
FROM base AS final 
EXPOSE 80
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YourAppName.dll"]
```
Neste estágio:
- Uma nova etapa é criada a partir da etapa base.
- A porta 80 é exposta para que a aplicação possa ser acessada externamente.
- Define o diretório de trabalho `/app`.
- Copia os arquivos publicados do estágio de publicação para dentro do contêiner.
- Define o ponto de entrada para a aplicação como `dotnet ConsultApi.dll`, que é o comando usado para iniciar a aplicação ASP.NET Core.
- 
### Executando a Aplicação com Docker

Depois de criar o Dockerfile, você pode construir a imagem Docker executando o seguinte comando no terminal, estando no diretório que contém o Dockerfile e os arquivos da sua aplicação:

```bash
docker build -t nome-da-sua-imagem .
```

Após a construção da imagem, você pode executar um contêiner baseado nessa imagem usando o seguinte comando:

```bash
docker run -d -p 8080:80 --name meu-container nome-da-sua-imagem
```

Nesse exemplo:
- `-d`: executa o contêiner em segundo plano (detached mode).
- `-p 8080:80`: mapeia a porta 8080 do host para a porta 80 do contêiner.
- `--name meu-container`: atribui o nome "meu-container" ao contêiner.
- `nome-da-sua-imagem`: é o nome da imagem Docker que você construiu anteriormente.

Depois de executar esses comandos, sua aplicação C# estará em execução em um contêiner Docker e será acessível através da porta 8080 do seu host.

## Referências
- [Docker: criando e gerenciando containers](https://cursos.alura.com.br/course/docker-criando-gerenciando-containers)
- [Conhecendo e Instalando o Docker](https://web.dio.me/course/introducao-e-laboratorio-virtual/learning/78816b6d-a1f4-48fa-b788-0fa0a2aa0aba?back=/track/coding-future-avanade-net-developer&tab=undefined&moduleId=undefined)
- [Primeiros Passos com o Docker](https://web.dio.me/course/primeiros-passos-com-o-docker/learning/f97d95bc-2d17-4be6-b1f2-235d97a499ab?back=/track/coding-future-avanade-net-developer&tab=undefined&moduleId=undefined)
- [Docker essencial para a plataforma .NET](https://www.udemy.com/course/docker-essencial-para-a-plataforma-net/learn/lecture/13509466?start=0#overview)
- [Step-by-Step Docker Build: Custom ASP.NET Core Containers](https://www.pluralsight.com/blog/software-development/how-to-build-custom-containers-docker)
- [How create a dockerfile](https://codefresh.io/blog/docker-images-net-core/)
- [How to prevent the `#!/bin/bash: not found` error when calling a script from Dockerfile[( https://stackoverflow.com/questions/45405472/how-to-prevent-the-bin-bash-not-found-error-when-calling-a-script-from-doc)
- [Docker image for .net 5]( https://stackoverflow.com/questions/64844197/docker-image-for-net-5)
- [ENTRYPOINT vs CMD](https://gago.io/blog/entrypoint-vs-command/)
- [Configurando uma API ASP.NET Core (.NET 5) com Docker]( https://www.youtube.com/watch?v=RkYMEbY2Rqo&t=1562s)
- [Docker build] (https://docs.docker.com/reference/cli/docker/image/build/)
- [How to Dockerize a .Net application: All You Need To Know] (https://medium.com/@vndpal/how-to-dockerize-a-net-application-all-you-need-to-know-9b7d62cf5793)
- [Tutorial: Como Iniciar Container Docker em 2024] (https://hostinger.com.br/tutoriais/container-docker)
- [[Introduction to .NET and Docker] (https://learn.microsoft.com/en-us/dotnet/core/docker/introduction)
- [How to run a .NET Core console application on Linux [duplicate]] (https://stackoverflow.com/questions/46843863/how-to-run-a-net-core-console-application-on-linux)
