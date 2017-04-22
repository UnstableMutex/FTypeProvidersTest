module TP
open System
open System.Reflection
open Microsoft.FSharp.Core.CompilerServices
open Microsoft.FSharp.Quotations

[<TypeProvider>]
type SampleTypeProvider(config: TypeProviderConfig) as this = 

// Inheriting from this type provides implementations of ITypeProvider 
// in terms of the provided types below.
inherit TypeProviderForNamespaces()

let namespaceName = "Samples.HelloWorldTypeProvider"
let thisAssembly = Assembly.GetExecutingAssembly()

// Make one provided type, called TypeN.
let makeOneProvidedType (n:int) = 


// Now generate 100 types
let types = [ for i in 1 .. 100 -> makeOneProvidedType i ] 

// And add them to the namespace
do this.AddNamespace(namespaceName, types)

[<assembly:TypeProviderAssembly>] 
do()
