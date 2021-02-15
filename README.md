# desafio_lemoney

[![Build Status](https://travis-ci.org/martins-wescley/desafio_lemoney.svg?branch=main&status=passed)](https://github.com/martins-wescley/desafio_lemoney)

Automatizado a busca por produtos no site http://automationpractice.com/index.php

## Browser Support

![Chrome](https://cloud.githubusercontent.com/assets/398893/3528328/23bc7bc4-078e-11e4-8752-ba2809bf5cce.png) |
| 88 ✔ |

## Dependências

| Dependências                    | Versão  |
| Nunit                           | 3.13.1  |
| NUnit3TestAdapter               | 3.17.0  |
| Selenium.WebDriver              | 3.141.0 |
| Selenium.WebDriver.ChromeDriver | 88      |
| SpecFlow                        | 2.4.1   |
| SpecFlow.NUnit                  | 2.4.1   |

## Configuração

1. Clonar o projeto;
2. Baixe e instale o .NET Framework mais recente;
3. Baixe o NuGet.exe e coloque-o dentro do diretório da solução;
4. Abra um prompt de comando e mude para o diretório da solução;
5. Invoque NuGet.exepara atualizar os pacotes necessários para esta solução:
    NuGet.exe install "My Project/packages.config" -o packages/

## Execução
1. Abra um prompt de comando e mude para o diretório de instalação do .NET Framework;
2. Use MSBuild.exepara compilar sua solução;
3. Abra um prompt de comando e mude para o diretório da aplicação;
4. Execute o comando dotnet test \bin\Debug\aplication.dll.