```bash
#!/bin/bash
echo 'alias sln_add_all="find -name '*.csproj' -exec dotnet sln add {} \;"' >> ~/.bash_profile