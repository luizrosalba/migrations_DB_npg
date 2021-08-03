﻿// <auto-generated />
namespace dip2.Migrations

open System
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion
open Npgsql.EntityFrameworkCore.PostgreSQL.Metadata

[<DbContext(typeof<AddressBookModel.AddressBookContext>)>]
[<Migration("20210803000531_Initial")>]
type Initial() =
    inherit Migration()

    override this.Up(migrationBuilder:MigrationBuilder) =
        migrationBuilder.CreateTable(
            name = "AddressBook"
            ,columns = (fun table -> 
            {|
                Id =
                    table.Column<int>(
                        nullable = false
                        ,``type`` = "integer"
                    ).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                Name =
                    table.Column<string>(
                        nullable = true
                        ,``type`` = "text"
                    )
                Email =
                    table.Column<string>(
                        nullable = true
                        ,``type`` = "text"
                    )
            |})
            ,constraints =
                (fun table -> 
                    table.PrimaryKey("PK_AddressBook", (fun x -> (x.Id) :> obj)) |> ignore
                ) 
        ) |> ignore


    override this.Down(migrationBuilder:MigrationBuilder) =
        migrationBuilder.DropTable(
            name = "AddressBook"
            ) |> ignore


    override this.BuildTargetModel(modelBuilder: ModelBuilder) =
        modelBuilder

            .UseIdentityByDefaultColumns().HasAnnotation("Relational:MaxIdentifierLength", 63)
            .HasAnnotation("ProductVersion", "5.0.7")
            |> ignore

        modelBuilder.Entity("AddressBookModel+AddressBook", (fun b ->

            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer")
                .UseIdentityByDefaultColumn() |> ignore
            b.Property<string>("Email")
                .HasColumnType("text") |> ignore
            b.Property<string>("Name")
                .HasColumnType("text") |> ignore

            b.HasKey("Id") |> ignore

            b.ToTable("AddressBook") |> ignore

        )) |> ignore
