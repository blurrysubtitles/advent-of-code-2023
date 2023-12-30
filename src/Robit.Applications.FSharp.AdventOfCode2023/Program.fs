namespace Robit.Applications.FSharp.AdventOfCode2023

open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Hosting

type Program =
    [<EntryPoint>]
    let main args =
        let tryParse (input: string) =
            match System.Int32.TryParse input with
            | true, value -> value.ToString()
            | _ -> System.String.Empty
    
        let getMatch target pattern options =
            System.Text.RegularExpressions.Regex.Match(target, pattern, options).Value.ToLowerInvariant()
            |> tryParse
        use reader = new System.IO.StreamReader(@"..\..\content\inputs\day01.txt")
        let lines = List.empty
        exit 0