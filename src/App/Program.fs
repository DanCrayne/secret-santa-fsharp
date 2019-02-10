open Library

[<EntryPoint>]
let main argv =
    printfn "Nice command-line arguments! Here's what Json.NET has to say about them:"

    // argv
    // |> Array.map getJsonNetJson
    // |> Array.iter (printfn "%s")
    printfn "%s" (getPeople "Data/People.json")

    0
