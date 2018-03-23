using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "CdaMobileApp.VsMacExtension",
    Namespace = "CdaMobileApp.VsMacExtension",
    Version = "1.0.3"
)]

[assembly: AddinName("CDA Mobile app generator")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("Adds a new project type to create a Xamarin Forms mobile app themed for Xamarin CDAs")]
[assembly: AddinAuthor("Jim Bennett")]
