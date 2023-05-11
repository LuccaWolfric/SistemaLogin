# SistemaLogin
Sistema de Login basico para gincana de jovens - Sem Banco de dados
# Gincana Cristã - Sistema de Login Simples

Este projeto contém um sistema de login simples desenvolvido em C# para a Gincana Cristã. O sistema permite que os participantes insiram logins e senhas específicas para acessar as próximas dicas do evento. Não é necessário um banco de dados para o funcionamento do sistema.

## Funcionalidades do Sistema

O sistema de login possui as seguintes funcionalidades:

1. **Autenticação de Usuário**: Os participantes devem fornecer um login e uma senha específica para acessar as próximas dicas da gincana.

2. **Dicas**: Após inserir as credenciais corretas, o sistema exibirá a próxima dica para a gincana. Cada usuário possui uma dica única associada à sua conta.

3. **Três Logins Diferentes**: Existem três logins diferentes disponíveis para os participantes. Cada login possui uma senha correspondente. Os participantes devem descobrir essas senhas durante a gincana para acessar as próximas etapas.

## Configuração e Uso

Para executar o projeto, siga as instruções abaixo:

1. Certifique-se de ter o Visual Studio instalado em sua máquina. Você pode fazer o download do Visual Studio em [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/).

2. Faça o clone deste repositório para sua máquina local ou baixe o arquivo ZIP e extraia-o.

3. Abra o Visual Studio e selecione a opção "Abrir um projeto ou solução".

4. Navegue até o diretório onde você clonou ou extraiu o projeto e selecione o arquivo de solução (.sln).

5. Após o projeto ser aberto no Visual Studio, compile e execute-o.

6. O programa solicitará que você insira um login e uma senha. Insira as credenciais corretas para acessar a próxima dica da gincana.

## Configuração dos Logins e Senhas

Os logins e senhas correspondentes estão definidos no código-fonte do projeto. Para modificá-los, siga as instruções abaixo:

1. Abra o projeto no Visual Studio.

2. Navegue até o arquivo `CadastroUsuarios.cs`.

3. Dentro da classe `CadastroUsuarios`, você encontrará os logins e senhas definidos no método `Main()`. Atualize essas informações conforme necessário.

```csharp
string[,] users = new string[3, 2]
{
    { "usuario1", "senha1" },
    { "usuario2", "senha2" },
    { "usuario3", "senha3" }
};
```

Certifique-se de salvar as alterações após modificar os logins e senhas.

## Aviso de Segurança

Este sistema de login simples é apenas para fins de demonstração e não deve ser usado em um ambiente de produção real. Ele não fornece medidas de segurança avançadas e não possui um mecanismo de armazenamento seguro para as senhas. Recomenda-se que você utilize um sistema de login mais robusto em um ambiente de produção.

## Contribuição

Se você identificar problemas, erros ou tiver sugestões de melhorias, fique à vontade para abrir uma issue neste repositório ou enviar um pull request com suas alterações.

Espero que este projeto seja útil para a sua gincana cristã.
