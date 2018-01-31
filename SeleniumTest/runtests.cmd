@pushd %~dp0

"C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\MSBuild.exe" ""

@if ERRORLEVEL 1 goto end

@cd ..\packages\SpecRun.Runner.*\tools

@set profile=%1
@if "%profile%" == "" set profile=Default

SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\FireFox" /log:specrun.log %2 %3 %4 %5

:end

@popd
