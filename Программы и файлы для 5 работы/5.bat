@echo off
if %1 leq 0 GOTO ErrorExit
if %1 geq 50 GOTO ErrorExit
SET /A number = %1
SET /A f = %1
:BeginLoop
if %number% ==1 GOTO RightExit
set /A number = number-1
SET /A f = f*number
GOTO BeginLoop
:RightExit
echo %1!=%f%
exit /b
:ErrorExit
echo ERROR
exit /b

