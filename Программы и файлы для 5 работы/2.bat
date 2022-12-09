@echo off
:BegLoop
set /P number=enter number 
if %number% ==- goto ExitLoop
if not defined min set min=%number%
if not defined max set max=%number%
if %number% leq %min% set min=%number%
if %number% geq %max% set max=%number%
goto BegLoop
:ExitLoop
echo Min= %min%
echo Max= %max%