using FluentMigrator;
using System;

namespace TOY.Migrations.DefaultDB
{
    [Migration(20170712141800)]
    public class DefaultDB_20170712_141800_SampleGenres : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Genre").InSchema("mov")
                .Row(new { Name = "Action" })
                .Row(new { Name = "Drama" })
                .Row(new { Name = "Comedy" })
                .Row(new { Name = "Sci-fi" })
                .Row(new { Name = "Fantasy" })
                .Row(new { Name = "Documentary" });
        }

        public override void Down()
        {
        }
    }
}