
namespace DesignPatterns.FluentInterface
{
    public class Validator : Validate
    {

        public Validator()
        {
            RuleFor("Hellow World!").IsNotNull().IsNotEmpty();
            RuleFor("").IsNotEmpty();
            RuleFor(null).IsNotNull();
        }
    }
}
