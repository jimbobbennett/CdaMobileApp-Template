rm *.nupkg

mono ./nuget.exe pack ./CdaMobileApp.nuspec
mv ./CdaMobileApp.*.nupkg CdaMobileApp.nupkg
dotnet new --install CdaMobileApp.nupkg