// Learn more about F# at http://fsharp.org

open Suave
open Suave.Operators
open Suave.Filters
open Suave.Successful



let app = 
    choose [ GET >=> choose
                [ path "/" >=> OK "This is my Home Page"
                  path "/hello" >=> OK "This is my GET Hello Page" ]
             POST >=> choose
                [ path "/hello" >=> OK "This is my POST Hello Page"
                  path "/place-order" >=> OK "This is my place-order" ]
    ]



[<EntryPoint>]
let main argv =

    
    startWebServer defaultConfig app

    0 // return an integer exit code
