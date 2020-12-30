namespace Exercicis.Contracts.Domain.Items.Factories
{
    public abstract class Creator
    {
        public abstract AItem FactoryMethod();
    }

    public class ItemCreator : Creator
    {
        public override AItem FactoryMethod()
        {
            return new Item();
        }
    }
}
