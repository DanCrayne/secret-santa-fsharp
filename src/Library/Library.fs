module Library

open Newtonsoft.Json
open System.IO

let getJsonNetJson value =
    sprintf "I used to be %s but now I'm %s thanks to Json.NET!" value (JsonConvert.SerializeObject(value))

type Person = {
    name: string;
    email: string
}

let getPeople filePath =
    File.ReadAllText(filePath)