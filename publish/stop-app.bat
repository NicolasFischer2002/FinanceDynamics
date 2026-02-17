@echo off

set PORT=5050

echo ========================================
echo Finalizando FinanceDynamics na porta %PORT%
echo ========================================

for /f "tokens=5" %%a in ('netstat -ano ^| findstr :%PORT% ^| findstr LISTENING') do (
    echo Encerrando processo PID %%a
    taskkill /PID %%a /F
)

echo.
echo Aplicacao finalizada.
pause