# ADR 0001 — Usar Clean Architecture no ponto de partida

- Status: Aceita
- Data: 2026-07-11

## Contexto

O repositório precisa suportar estudos progressivos de domínio, APIs, persistência, testes e infraestrutura sem transformar cada assunto em um projeto desconectado.

## Decisão

A solução será separada inicialmente em Domain, Application, Infrastructure e API. O domínio não poderá depender dos demais projetos.

## Consequências

### Positivas

- regras de negócio isoladas;
- testes mais simples;
- troca de infraestrutura com menor impacto;
- evolução gradual para modularização ou microsserviços.

### Negativas

- maior número de projetos;
- necessidade de disciplina nas referências;
- possível excesso de abstração em casos muito simples.
