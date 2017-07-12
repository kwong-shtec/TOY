namespace TOY.Modules.MovieDB.Movie {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnum(MovieKind, 'MovieDB.MovieKind');
}

