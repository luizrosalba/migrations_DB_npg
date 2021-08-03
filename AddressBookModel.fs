module AddressBookModel

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open EntityFrameworkCore.FSharp.Extensions

[<CLIMutable>]
type AddressBook = {
    [<Key>] Id: int
    mutable Name: string
    mutable Email: string
}

type AddressBookContext() =  
    inherit DbContext()
    
    [<DefaultValue>] val mutable addressBook : DbSet<AddressBook>
    member this.AddressBook with get() = this.addressBook and set v = this.addressBook <- v

    override _.OnModelCreating builder =
        builder.RegisterOptionTypes() 

    override __.OnConfiguring(options: DbContextOptionsBuilder) : unit =
        options.UseNpgsql("Host=localhost;Database=testdatabase;Username=efcoretest;Password=password") |> ignore
