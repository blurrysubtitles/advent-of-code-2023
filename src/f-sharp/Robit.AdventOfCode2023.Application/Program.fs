namespace Robit.AdventOfCode2023.Application

module Program

let defaultBuilder args = WebApplication.CreateBuilder(args)
let defaultApplication args = defaultBuilder(args).Build()

[<EntryPoint>]
let main args =
    let app = defaultApplication(args)
    app.Logger.LogInformation("Hello, world!")
    exit 0