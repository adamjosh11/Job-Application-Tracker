namespace webapi.Model
{
    public interface IMeal : IIngredient
    {
        List<IIngredient> Ingredients { get; }
        string Description { get; }
        string CookingSteps { get; }
    }
}
