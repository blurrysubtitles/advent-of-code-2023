function Sync-Solution {
    dotnet sln remove (dotnet sln list)
    dotnet sln add (ls -r **/*.*proj)
}