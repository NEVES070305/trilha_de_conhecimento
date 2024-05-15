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
