using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace TOY.MovieDB
{
    public partial class GenreEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "TOY.MovieDB.GenreEditor";

        public GenreEditorAttribute()
            : base(Key)
        {
        }
    }
}

