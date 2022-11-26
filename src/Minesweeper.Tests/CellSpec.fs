module CellSpec

open System
open Xunit
open Minesweeper
open Minesweeper.Cell

[<Fact>]
let ``Cell is Number`` () =
    let sut = Number 7
    let ret = string sut

    Assert.Equal("7", ret)

[<Fact>]
let ``Cell is Bomb`` () =
    let sut = Bomb
    let ret = string sut

    Assert.Equal("*", ret)
