using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace TOY.MovieDB
{
    public partial class MovieEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "TOY.MovieDB.MovieEditor";

        public MovieEditorAttribute()
            : base(Key)
        {
        }
    }
}

