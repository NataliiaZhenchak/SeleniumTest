@pushd %~dp0

@if "%browser%" == "" set browser=Chrome
"%MSBuild_PATH%MSBuild.exe" "" /p:Configuration=%browser%

@if ERRORLEVEL 1 goto end

@cd ..\packages\SpecRun.Runner.*\tools

@set profile=%2
@set browser=%1

@if "%profile%" == "" set profile=Default
@if "%browser%" == "" set browser=Chrome

SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\%browser%" /log:specrun.log %3 %4 %5 %6

:end

@popd
