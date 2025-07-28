namespace webapi.Model
{
    public interface IMeal : IIngredientDetails
    {
        List<IIngredientDetails> Ingredients { get; }
        string Description { get; }
        string CookingSteps { get; }
    }
}
