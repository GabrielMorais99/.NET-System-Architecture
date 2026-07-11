$ErrorActionPreference = "Stop"

Write-Host "Restaurando dependencias..."
dotnet restore

Write-Host "Compilando solucao..."
dotnet build

Write-Host "Executando testes..."
dotnet test

Write-Host "Repositorio pronto."
