using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamie.Model
{

    // Ein Rezept enthält eine Zutatenliste bestehend aus x Einträgen, wobei jeder die Zutat und die erforderliche Menge beschreibt.
    public class IngredientRecipeSet : ObservableCollection<IngredientItem>
    {
    }


    public class IngredientItem
    {
        public Ingredient SpecificIngredient { get; set; }
        public string Unit { get; set; }
        public float? Quantity { get; set; }
    }



    /* Eine Zutat beschreibt ein Produkt, welches in einem Rezept verarbeitet werden kann. Zutaten werden im Gegensatz zu Werkzeugen verbraucht. 
     * Hat Eigenschaften: x kcal/100g, Ernährungsampel (rot, gelb, grün)
     * länderspezifische Zuordnung?
     */

    public class Ingredient
    {
        public string Name { get; set; }
        public bool IsVegetarian { get; set; }
    }


}
