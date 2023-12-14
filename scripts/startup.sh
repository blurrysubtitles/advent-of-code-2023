```bash
#!/bin/bash
echo 'alias sln_add_all="find -name '*.csproj' -exec dotnet sln add {} \;"' >> ~/.bash_profile
echo 'alias sln_remove_all="find -name '*.csproj' -exec dotnet sln remove {} \;"' >> ~/.bash_profile