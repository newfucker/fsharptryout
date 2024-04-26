// For more information see https://aka.ms/fsharp-console-apps
open Microsoft.AspNetCore.Builder
open System

let builder = WebApplication.CreateBuilder()
let app = builder.Build()

app.MapGet(pattern = "/", handler = Func<string>(fun () -> "Hello World!")) |> ignore
app.Run()