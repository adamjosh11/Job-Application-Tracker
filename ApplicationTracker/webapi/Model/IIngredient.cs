namespace webapi.Model
{
    public interface IIngredient
    {
        string Name { get; set; }
        int Calories { get; set; }
        HashSet<INutritionValue> NutritionalValues { get; set; }

    }
}
