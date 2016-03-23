using System;

namespace Jamie.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }

        public void GetData2(Action<RecipeSet, Exception> callback)
        {
            var allRecipes = new RecipeSet();
            //var Ingredients = new IngredientRecipeSet();

            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "backstarkes Weizenmehl Type 550", IsVegetarian = false }, Quantity = 1, Unit = "kg" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Trockenhefe", IsVegetarian = false }, Quantity = 1, Unit = "Päckchen" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "bestes Olivenöl oder Bratenfett", IsVegetarian = false }, Quantity = 3, Unit = "EL" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Knoblauchzehen", IsVegetarian = true }, Quantity = 2, Unit = null });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "getrockneter Oregano", IsVegetarian = true }, Quantity = 1, Unit = null });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Tomatenstücke", IsVegetarian = true }, Quantity = 1, Unit = "Dose" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Rotweinessig", IsVegetarian = true }, Quantity = null, Unit = null });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Ciabatta oder altbackenes Weißbrot", IsVegetarian = true }, Quantity = 50, Unit = "g" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Olivenöl", IsVegetarian = true }, Quantity = null, Unit = null });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "gegartes Schweinefleisch", IsVegetarian = true }, Quantity = 350, Unit = "g" });

            //allRecipes.Add(new Recipe
            //{
            //    Name = "American Hot Pizza Pie",
            //    Summary = "Hier habe ich die in Großbritannien beliebteste Pizza, die American Hot, mit der klassischen Chicago Pizza Pie (in der Form gebacken, weil die Kohle, der typische Chicagoer Brennstoff, sonst den Boden schwärzte) gekreuzt. Mit knusprigem Schweinefleisch und ein paar munteren Chilis belegt – eine ganz heiße Sache.",
            //    PortionQuantity = 8,
            //    Source = "http://www.sixx.de/tv/jamie-oliver/rezepte/american-hot-pizza-pie-von-jamie-oliver-rezept",
            //    ToTakeAway = true,
            //    Ingredients = Ingredients,
            //}); // Portion min max


            //Ingredients = new IngredientRecipeSet();
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Ingwer", IsVegetarian = false }, Quantity = 2, Unit = "daumengroße Stücke" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "frische rote Chilischoten", IsVegetarian = false }, Quantity = 1, Unit = null });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Olivenöl", IsVegetarian = true }, Quantity = 8, Unit = "EL" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Rotweinessig", IsVegetarian = true }, Quantity = 4, Unit = "EL" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "salzarme Sojasauce", IsVegetarian = true }, Quantity = 4, Unit = "EL" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "mittelfeine Reisnudeln", IsVegetarian = true }, Quantity = 300, Unit = "g" });

            //allRecipes.Add(new Recipe
            //{
            //    Name = "Asia-Salat mit Lammfleisch",
            //    Summary = "Farbenfroh, gesund und voller großartiger Aromen und Texturen – dieser Salat rückt Reste vom Lammbraten, die von Minze und Chili begleitet werden, ins Rampenlicht. Er enttäuscht nie und eignet sich auch bestens als Füllung für Wraps. Einfach genießen!",
            //    PortionQuantity = 6,
            //    Source = "http://www.sixx.de/tv/jamie-oliver/rezepte/asia-salat-mit-lammfleisch-von-jamie-oliver-rezept",
            //    ToTakeAway = false,
            //    Ingredients = Ingredients,
            //});


            //Ingredients = new IngredientRecipeSet();
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Möhre", IsVegetarian = true }, Quantity = 1, Unit = null });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Salatgurke", IsVegetarian = true }, Quantity = 1, Unit = "1/4" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Weißkohl", IsVegetarian = true }, Quantity = 1, Unit = "1/4" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "brauner Zucker", IsVegetarian = true }, Quantity = 1, Unit = "EL" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Weißweinessig", IsVegetarian = true }, Quantity = 3, Unit = "EL" });
            //Ingredients.Add(new IngredientItem { SpecificIngredient = new Ingredient { Name = "Hähnchenlebern", IsVegetarian = true }, Quantity = 200, Unit = "g" });

            //allRecipes.Add(new Recipe
            //{
            //    Name = "Banh Mi",
            //    Summary = "Die vietnamesische Gemeinde in London ist über die Jahrzehnte beständig gewachsen und so tauchten immer neue und ziemlich originelle Snacks und Gerichte auf. Überall in den Markthallen der Stadt locken Banh-Mi-Stände mit ihren typisch französisch-vietnamesisch belegten Baguettes.",
            //    PortionQuantity = 4,
            //    Source = "http://www.sixx.de/tv/jamie-oliver/rezepte/banh-mi-von-jamie-oliver-rezept",
            //    ToTakeAway = true,
            //    Ingredients = Ingredients,
            //});



            allRecipes = DataSourceSimpleXml<RecipeSet>.Deserialize(@"\Recipe\Data\Recipes.txt");

            callback(allRecipes, null);
        }


    }
}