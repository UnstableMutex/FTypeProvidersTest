//namespace FTypeProvidersTest
module Types
open FSharp.Data

[<Literal>]
let connectionString = 
    @"Data Source=.;Initial Catalog=AdventureWorks2014;Integrated Security=True"

type ShipMethod = SqlEnumProvider<"SELECT Name, ShipMethodID FROM Purchasing.ShipMethod ORDER BY ShipMethodID", connectionString>

