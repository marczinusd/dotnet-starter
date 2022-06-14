namespace Starter.Fsharp

type LightBulb(state) =
    member x.On = state
    override x.ToString() =
        match x.On with
        | true  -> "On"
        | false -> "Off"