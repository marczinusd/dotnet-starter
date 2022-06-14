module Tests

open Starter.Fsharp
open Xunit
open FsUnit.Xunit

type ``Given a LightBulb that has had its state set to true`` ()=
    let lightBulb = LightBulb(true)

    [<Fact>] member x.
     ``when I ask whether it is On it answers true.`` ()=
            lightBulb.On |> should be True

    [<Fact>] member x.
     ``when I convert it to a string it becomes "On".`` ()=
            string lightBulb |> should equal "On"
