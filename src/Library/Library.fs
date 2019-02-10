module Library

open Newtonsoft.Json
open System.IO

type Person = {
    name: string;
    email: string
}

let getPeople filePath =
    File.ReadAllText(filePath)