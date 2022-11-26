namespace Minesweeper

type Cell =
    | Covered
    | Bomb
    | Number of int

module Cell =
    let string x : string =
        match x with
        | Covered -> "."
        | Bomb -> "*"
        | Number v -> string v
