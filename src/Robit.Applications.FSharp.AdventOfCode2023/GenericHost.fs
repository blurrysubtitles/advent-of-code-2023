namespace Robit.Applications.FSharp.AdventOfCode2023

module GenericHost =
    open Microsoft.Extensions.Hosting

    let createBuilder (args:string[]) =
        args
        |> Host.CreateApplicationBuilder

    let modifyBuilder (action:HostApplicationBuilder -> 'T) (builder:HostApplicationBuilder) =
        builder
        |> action
        |> ignore
        builder

    let buildHost (builder:HostApplicationBuilder) =
        builder.Build()
        
    let runHost (host:IHost) =
        host.Run()