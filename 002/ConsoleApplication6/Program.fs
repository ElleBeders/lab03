open System

// Фильтр
let makeEvenNumber (digits: seq<char>) =
    let evenChars = Seq.filter (fun c -> c = '0' || c = '2' || c = '4' || c = '6' || c = '8') digits
    
    
    if Seq.isEmpty evenChars then 0 // Чётных нет — 0
    else
        Seq.fold (fun acc c ->
            let digit = int c - int '0'  // Преобразуем тип
            acc * 10 + digit   // Добавляем новую цифру
        ) 0 evenChars

// Основная программа
[<EntryPoint>]
let main argv =
    printfn "Введите последовательность цифр (например, 123):"
    let input = Console.ReadLine()  // Читаем строку 
    
    let result = makeEvenNumber input
    
    printfn "Число из чётных цифр: %d" result
    0  
