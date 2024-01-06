namespace Robit.Applications.FSharp.AdventOfCode2023

module Program =
    open Spectre.Console
    open Spectre.Console.Rendering

    type ConfirmationPromptDefaultValue =
        | Yes
        | No

    type ConfirmationPromptOptions =
        { Title:Option<string>
          Prompt:Option<string>
          DefaultValue:Option<ConfirmationPromptDefaultValue>
          ChoiceStyle:Option<Style>
          DefaultValueStyle:Option<Style>
          InvalidChoiceMessage:Option<string>
          No:Option<char>
          Yes:Option<char> }
    type Prompt =
        | Confirmation of ConfirmationPrompt
    let relativePathToInputs = "../../content/"
    let getInputFiles = System.IO.Directory.GetFiles relativePathToInputs

    [<EntryPoint>]
    let main =
        let solutions =
            typeof<Solution>
            |> Reflection.FSharpType.GetUnionCases
            |> Seq.map (fun case -> case.Name)
            |> Seq.map (fun name -> new Text(name))
            |> Seq.map (fun text -> text :> IRenderable)
        let prompt = new SelectionPrompt<string>()
        prompt.Title <- "Welcome! Please choose a solution to compute."
        prompt.AddChoices solutions
        let choice = AnsiConsole.Prompt prompt
        match choice with
        | "Day01" -> AnsiConsole.WriteLine("whoope, not yet implemented")
        | _ -> AnsiConsole.WriteLine("ok, hope to see you again soon")
        exit 0