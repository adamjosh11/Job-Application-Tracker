namespace webapi.Model
{
    public interface INutritionValue
    {
        string Name { get; set; }
        string UnitOfMeasurement { get; set; }
        int Value { get; set; }
    }
}
