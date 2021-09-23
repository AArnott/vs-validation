# Microsoft.VisualStudio.Validation

This project has adopted the [Microsoft Open Source Code of
Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct
FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com)
with any additional questions or comments.

We welcome 3rd party pull requests.
For significant changes we strongly recommend opening an issue to start a design discussion first.

## Microsoft internal developers

You may use quickbuild to build the repo, sometimes more quickly.
Install quickbuild with this command (in cmd shell):

```cmd
powershell -NoProfile -Command "Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://aka.ms/qbootstrap'))" && PATH %LocalAppData%\CloudBuild;%PATH%
```

Or this command in PowerShell:

```ps1
iex ((New-Object System.Net.WebClient).DownloadString('https://aka.ms/qbootstrap')); $env:PATH += '$env:localappdata\CloudBuild'
```
