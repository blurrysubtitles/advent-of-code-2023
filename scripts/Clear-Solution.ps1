function Clear-Solution {
    dotnet sln remove (ls -r **/*.*proj)
}