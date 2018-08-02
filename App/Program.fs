open Suave
open System.Net

let port = System.Environment.GetEnvironmentVariable("PORT")
let cfg = { defaultConfig with bindings = [ HttpBinding.create HTTP IPAddress.Any (uint16 port) ] }

startWebServer cfg (Successful.OK "Hello, World!")

