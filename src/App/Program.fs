open Library

[<EntryPoint>]
let main argv =
    printfn "%d" (getPeople "Data/People.json").Length

    0
