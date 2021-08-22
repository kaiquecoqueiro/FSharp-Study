module FishExcessTicket =
    open System

    let maxFishWeight = 50.0
    let calculateExcess weight = Math.Abs(weight - maxFishWeight)

    let ticketPriceByWeightUnit = 4.0
    let totalTicket weight = weight * ticketPriceByWeightUnit

    let calculateTicket weight =
        match weight with
        | x when x > maxFishWeight -> printfn "Excesso: %.2f - Multa: %.2f" (calculateExcess weight) (totalTicket weight)
        | _  -> printfn "Excesso: 0 - Multa: 0"

    calculateTicket 100.0

module OddAndEven =
    let getOddsEvens number = 
        number 
        |> List.partition (fun n -> n % 2 <> 0);

    getOddsEvens [1;2;3;4;5;6;7;8;9;10];;

    let numbers = [1;2;3;4;5;6;7;8;9;10]

    let overFive numbers = 
        numbers
        |> List.filter(fun x -> x > 5)
        |> List.map (fun y -> 0)

    let lessThanFive numbers = 
        numbers
        |> List.filter(fun x -> x < 5)
        |> List.map (fun y -> y)

    [] 
    |> List.append (overFive numbers) 
    |> List.append (lessThanFive numbers)


// module ImcCalculator =
//     let imc gender height =
//         match gender with
//         | "F" -> (62.1 * height) - 44.7 
//         | "M" -> (72.7 * height) - 58.0
//         | _ -> 0.0

//     imc "F" 1.70