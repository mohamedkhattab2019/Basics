namespace DesignPatterns.Factory
{
    public interface IBankFactory
    {
        IBank GetBank (string bankcode);
    }
}