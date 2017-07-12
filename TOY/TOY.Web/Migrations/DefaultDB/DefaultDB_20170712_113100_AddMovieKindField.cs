using FluentMigrator;
using System;

namespace TOY.Migrations.DefaultDB
{
    [Migration(20170712113100)]
    public class DefaultDB_20170712_113100_AddMovieKindField : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                .WithDefaultValue(1);
        }

        public override void Down()
        {
        }
    }
}