
namespace TOY.MovieDB.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using TOY.Modules.MovieDB.Movie;

    [ConnectionKey("Default"), TableName("[mov].[Movie]"), DisplayName("Movies"), InstanceName("Movie"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId { get; set; }

        [DisplayName("Title"), Size(200), NotNull, QuickSearch(SearchType.StartsWith)]
        public String Title { get; set; }

        [DisplayName("Description"), Size(1000), QuickSearch]
        public String Description { get; set; }

        [DisplayName("Storyline"), Size(-1), QuickSearch]
        public String Storyline { get; set; }

        [DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly:1)]
        public Int32? Year { get; set; }

        [DisplayName("Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [DisplayName("Runtime (mins)"), Width(150), AlignRight]
        public Int32? Runtime { get; set; }

        [DisplayName("Kind"), NotNull, DefaultValue(MovieKind.Film)]
        public MovieKind? Kind { get; set; }

        [DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
        [LookupEditor("MovieDB.Genre")]
        public Int32? GenreId { get; set; }

        [DisplayName("Genre"), Expression("g.Name")]
        public String GenreName { get; set; }

        IIdField IIdRow.IdField
        {
            get { return Fields.MovieId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public readonly Int32Field Kind;
            public readonly Int32Field GenreId;
            public readonly StringField GenreName;
            //hello

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MovieDB.Movie";
            }
        }
    }
}
