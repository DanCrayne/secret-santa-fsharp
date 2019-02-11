module Library

open Newtonsoft.Json
open System.IO

type Person = {
    name: string;
    email: string
}

type People = Person []

let deserializePeople peopleRawText =
    JsonConvert.DeserializeObject<People>(peopleRawText)

let getPeople filePath =
    let people = File.ReadAllText(filePath)
    deserializePeople people