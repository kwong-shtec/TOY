using Serenity.Navigation;
using Administration = TOY.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]
[assembly: Serenity.Navigation.NavigationMenu(2000, "Movie Here")]
[assembly: Serenity.Navigation.NavigationLink(2100, "Movie Here/Movie", typeof(TOY.MovieDB.Pages.MovieController))]
[assembly: Serenity.Navigation.NavigationLink(2200, "Movie Here/Genre", typeof(TOY.MovieDB.Pages.GenreController))]
