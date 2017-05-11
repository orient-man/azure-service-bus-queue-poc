#load "Common.fsx"

open System
open System.Text
open Microsoft.Azure.ServiceBus

let sendToQueue (msg: string) = async {
    let client = Common.createQueueClient ()
    do! msg |> Encoding.UTF8.GetBytes |> Message |> client.SendAsync |> Async.AwaitTask
    do! client.CloseAsync() |> Async.AwaitTask
}

"Hello!" |> sendToQueue |> Async.RunSynchronously