#I ".paket/load/"
#load "main.group.fsx"

open Microsoft.Azure.ServiceBus

let [<Literal>] ServiceBusConnectionString = "{connection string here}"
let [<Literal>] QueueName = "testqueue1"

let createQueueClient () = QueueClient(ServiceBusConnectionString, QueueName, ReceiveMode.PeekLock) :> IQueueClient