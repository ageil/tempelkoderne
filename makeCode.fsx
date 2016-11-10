// makeCode : player -> code
// som tager en spillertype og returnerer en opgave enten ved at få input fra brugeren eller ved at beregne en opgave.


type codeColor = Red | Green | Yellow | Purple | White | Black
type code = codeColor list
type answer = int * int
type board = (code * answer) list
type player = Human | Computer


(*
Modtag input skal bruge:
En variabel, som gemmer brugerens input som string, f.eks. "red green yellow purple"
En funktion, som kan splitte denne string i et array à fire elementer (ved mellemrum eller anden character)
En funktion, som via pattern matching læser array-elementerne og indsætter den tilsvarende type i en liste.
*)



let testCode =
    let colours = []
    match (System.Console.ReadLine ()) with
    | "red" -> colours @ [Red]
    | "green" -> colours @ [Green]
    | "yellow" -> colours @ [Yellow]
    | "purple" -> colours @ [Purple]
    | "white" -> colours @ [White]
    | "black" -> colours @ [Black]
    | _ -> failwith "Invalid input."

printfn "%A" (testCode)


// makeCode virker. Den returnerer 1, hvis input er Human.
let makeCode (user : player) =
    if user = Human then
        [(System.Console.ReadLine ());(System.Console.ReadLine ());(System.Console.ReadLine ());(System.Console.ReadLine ())]
    else
        ["fejl"]

printfn "%A" (makeCode (Human))
// printfn "%A" (makeCode (Computer))