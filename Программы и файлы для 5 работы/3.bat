@echo off
set /A kolvo = 0
for /R %1 %%i in (.) do set /A kolvo = kolvo+1
echo kolichestvo podkotologov: %kolvo%