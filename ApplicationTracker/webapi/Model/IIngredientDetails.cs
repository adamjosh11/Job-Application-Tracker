namespace webapi.Model
{
    public interface IIngredientDetails
    {
        string Name { get; set; }
        int Calories { get; set; }
        int Weight { get; set; }
        HashSet<INutritionValue> NutritionalValues { get; set; }
        public IIngredientDetails GetIngredientDetailsByWeight(float weight);
    }
}
