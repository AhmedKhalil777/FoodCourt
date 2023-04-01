# EF Migrations
```
# Visual Studio 

Add-Migration V1 -context FoodCourt.Infrastructure.Data.AppDbContext -Project FoodCourt.Web
Update-Database V1 -context FoodCourt.Infrastructure.Data.AppDbContext -Project FoodCourt.Web

# CMD or Ps
dotnet ef --startup-project ./src/FoodCourt.Web/FoodCourt.Web.csproj migrations add V1 --context FoodCourt.Infrastructure.Data.AppDbContext --output-dir Migrations --project ./src/FoodCourt.Web/FoodCourt.Web.csproj
dotnet ef --startup-project ./src/FoodCourt.Web/FoodCourt.Web.csproj database update V1 --context FoodCourt.Infrastructure.Data.AppDbContext  --project ./src/FoodCourt.Web/FoodCourt.Web.csproj
```