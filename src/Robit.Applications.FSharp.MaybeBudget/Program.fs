namespace Robit.Applications.FSharp.MaybeBudget

module Program =

    type Transaction = | Transaction of name:string * payor:string * payee:string * amount:int * date:System.DateOnly
    type Payment =
        | OneTime of Transaction
        | Repeating of Transaction * 
    [<EntryPoint>]
    let main args =
        System.Diagnostics.Debug.Write("Hello?")
        
        exit 0