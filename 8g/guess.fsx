// guess : player -> board -> code
// som tager en spillertype, et bræt bestående af et spils tidligere gæt og svar og returnerer et nyt gæt enten ved input fra brugeren eller ved at programmet beregner et gæt.

type codeColor = Red | Green | Yellow | Purple | White | Black
type code = codeColor list
type answer = int * int // sort * hvid
type board = (code * answer) list
type player = Human | Computer

let testCode = [Yellow;Purple;Red;Green]

let testBoard : board = [([Red;Red;Green;Green],(1,1));
                        ([Yellow;Yellow;Purple;Purple],(1,1));
                        ([White;Black;Purple;Purple],(0,0));]



let printBoard (aBoard : board) =
    let mutable stringBoard = ""
    for i = 0 to aBoard.Length - 1 do
        stringBoard <- stringBoard + (sprintf "%90A%10A" (fst (aBoard.[i])) (snd (aBoard.[i]))) +  "\n"
    stringBoard

printfn "%s" (printBoard testBoard)
