@echo off
cd /d "%~dp0"

set PORT=5050

echo ========================================
echo Iniciando FinanceDynamics na porta %PORT%
echo ========================================

start "FinanceDynamics" cmd /k dotnet FinanceDynamics.Presentation.dll --urls=http://localhost:%PORT%

timeout /t 2 > nul

start http://localhost:%PORT%

echo.
echo Aplicacao iniciada.