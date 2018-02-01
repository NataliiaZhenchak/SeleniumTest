@pushd %~dp0

"%MSBuild_PATH%MSBuild.exe" ""

@if ERRORLEVEL 1 goto end

@cd ..\packages\SpecRun.Runner.*\tools

@set profile=%2
@set browser=%1

@if "%browser%" == "" set browser=Chrome
@if "%profile%" == "" set profile=Default


SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\%browser%" /log:specrun.log %3 %4 %5 %6

:end

@popd
