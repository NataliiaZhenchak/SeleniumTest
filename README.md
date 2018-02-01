# SeleniumTest

To run tests from command line you need:

1. Install path to your Visual Studio MSBuild.exe in Environmant Variables:
  - go to PC Properties
  - open Advanced system settings
  - open Environment Variables
  - go to System Variables and click New
  - add variable name MSBuild_PATH
  - add variable path (path of your MSBuild.exe, e.g. C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\)
  - click OK to save changes
2. Open command line and go to folder where SeleniumTest project is cloned your path\SeleniumTest\SeleniumTest
3. Enter runtests command to run Default test configuration (Chrome)
4. Enter runtests FireFox to run tests in Firefox browser
5. Enter runtests IE to run tests in IE browser (note IE is very slow and tests are failing very often because of this reason)

NOTE: when you are running tests in Firefox it is advised to have installed Firefox Nightly latest version because Firefox WebDriver works 
best with this version.
