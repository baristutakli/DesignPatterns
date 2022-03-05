namespace DesignPatterns.Builder
{
    /// <summary>
    /// <c>PhoneBuilder</c> is a  Builder
    /// </summary>
    public abstract class PhoneBuilder
    {
        public Phone Phone { get; protected set; }
        public abstract void SetName();
        public abstract void SetColor();
        public abstract void SetStock();
        public abstract void SetPrice();
    }
}
