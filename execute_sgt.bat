@echo off
tasklist /fi "imagename eq SGT - Sistema de Gerenciamento Total.exe" |find ":" > nul
if errorlevel 1 taskkill /f /im "SGT - Sistema de Gerenciamento Total.exe"

start /d "%temp%\SGT\Instaladores" SGT.msi

exit