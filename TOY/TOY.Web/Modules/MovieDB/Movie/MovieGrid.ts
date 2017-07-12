
namespace TOY.MovieDB {
    
    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'MovieDB.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[]
        {
            var fld = MovieRow.Fields;

            var txt = (s) => Q.text("Db." + MovieRow.localTextPrefix + "." + s).toLocaleLowerCase();

            return [
                {
                    name: "", title: "all"
                },
                {
                    name: fld.Description, title: txt(fld.Description)
                },
                {
                    name: fld.Storyline, title: txt(fld.Storyline)
                },
                {
                    name: fld.Year, title: txt(fld.Year)
                }
            ]
        }
    }
}