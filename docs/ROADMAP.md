# Roadmap de Arquitetura de Sistemas .NET

Este roadmap transforma a grade pública da Pós Tech em um plano de estudos orientado a entregas. Cada fase deve produzir documentação, código executável e testes.

## Fase 1 — Arquitetura e Qualidade de Software

### Conteúdos

- DDD, Domain Storytelling, Event Storming e Bounded Contexts;
- levantamento de requisitos, refinamento técnico, DoR e DoD;
- APIs ASP.NET Core, DI, middlewares, logs e serialização;
- autenticação, autorização, cache e documentação;
- Dapper, Entity Framework Core e estratégias de carregamento;
- pirâmide de testes, TDD, BDD, integração, interface e carga.

### Entrega

Criar uma API modular com:

- domínio explícito;
- casos de uso;
- persistência intercambiável;
- autenticação e autorização;
- logs estruturados;
- testes unitários e de integração;
- OpenAPI.

### Critério de conclusão

- arquitetura registrada em ADR;
- domínio sem dependência de infraestrutura;
- pipeline executando build e testes;
- cobertura dos principais comportamentos de negócio.

---

## Fase 2 — Microsserviços e Orquestração de Containers

### Conteúdos

- Docker e boas práticas de imagens;
- Kubernetes: pods, deployments, services, ConfigMaps, volumes, probes e HPA;
- AKS e CI/CD;
- limites de microsserviços e banco por serviço;
- comunicação síncrona e assíncrona;
- RabbitMQ, MassTransit, Kafka, CDC e Event Sourcing;
- resiliência, segurança, alta disponibilidade e observabilidade.

### Entrega

Extrair um contexto do monólito modular para um serviço independente e implementar:

- comunicação assíncrona;
- outbox;
- idempotência;
- retry e circuit breaker;
- Docker Compose;
- manifestos Kubernetes.

### Critério de conclusão

- serviço implantável independentemente;
- mensagens versionadas;
- métricas e logs correlacionados;
- testes de contrato ou integração entre serviços.

---

## Fase 3 — Serverless e Monitoramento

### Conteúdos

- modularização, atributos de qualidade e arquitetura hexagonal;
- Azure Functions, AWS Lambda e Step Functions;
- API Management, Kong e gateways;
- Zabbix, Prometheus, Grafana, Datadog e New Relic;
- MongoDB, Redis e DynamoDB;
- CQRS, Event Sourcing, aggregates, snapshots e versionamento.

### Entrega

Adicionar:

- função serverless para um processo assíncrono;
- dashboard de métricas;
- tracing distribuído;
- cache Redis;
- read model NoSQL;
- fluxo CQRS em um caso de uso justificável.

### Critério de conclusão

- SLOs e alertas documentados;
- correlação ponta a ponta;
- estratégia de consistência explícita;
- testes de resiliência.

---

## Fase 4 — DevOps e Cloud

### Conteúdos

- Azure Boards, Repos, Artifacts, Pipelines e Releases;
- ACR, ACI, App Service e Container Apps;
- IAM, VPC, EC2, ECR, ECS, EKS, CloudWatch, Lambda e RDS;
- GitHub Actions e runners;
- Elasticsearch, indexação e consultas avançadas.

### Entrega

Criar pipelines de:

- pull request;
- build e testes;
- análise estática;
- criação e publicação de imagem;
- implantação por ambiente;
- rollback.

Adicionar uma busca baseada em Elasticsearch quando o domínio justificar.

### Critério de conclusão

- segredos fora do repositório;
- artefatos imutáveis;
- ambiente reproduzível;
- estratégia de promoção e rollback documentada.

---

## Fase 5 — Agilidade, Segurança e IA

### Conteúdos

- Scrum, XP, Lean, Kanban e feedback contínuo;
- SOLID;
- LGPD, GDPR, RIPD, anonimização e criptografia;
- Blazor e Razor;
- IA e LLMs no .NET;
- visão, áudio, multimodalidade, Semantic Kernel e IA local.

### Entrega

Consolidar a solução com:

- threat model;
- checklist LGPD;
- criptografia em trânsito e repouso;
- painel Blazor;
- funcionalidade de IA com avaliação, limites e observabilidade;
- documentação final da arquitetura.

### Critério de conclusão

- riscos e trade-offs registrados;
- arquitetura final comparada com a inicial;
- demonstração executável;
- retrospectiva técnica e plano de evolução.
