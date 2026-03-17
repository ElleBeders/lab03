open System

// Словарь:
let romanToDecimal =
    dict [
        ("I", 1)
        ("II", 2)
        ("III", 3)
        ("IV", 4)
        ("V", 5)
        ("VI", 6)
        ("VII", 7)
        ("VIII", 8)
        ("IX", 9)
    ]

// Ввод последовательности в строку
let getUserInput() =
    printfn "Введите римские цифры от I до IX (через пробел):"
    let input = Console.ReadLine()
    input.Split([|' '|], StringSplitOptions.RemoveEmptyEntries)
    |> Seq.ofArray

// Перевод
let convertRomanToDecimal (roman: string) =
    match romanToDecimal.TryGetValue(roman) with
    | true, value -> value
    | false, _ -> 0  

// Основная функция
[<EntryPoint>]
let main argv =
    
    let romanSeq = getUserInput() // Ввод
    
    // Преобразование в десятичные числа
    let decimalSeq =
        romanSeq
        |> Seq.map convertRomanToDecimal
    
    // Выводим результат
    printfn "Десятичные значения:"
    
    decimalSeq
    |> Seq.iter (printf "%d ")

    0  
