namespace DesignPatterns.Builder
{
    /// <summary>
    /// Director
    /// </summary>
    public class PhoneManager
    {
        public void Create(PhoneBuilder phone)
        {
            phone.SetColor();
            phone.SetName();
            phone.SetPrice();
            phone.SetStock();
        }
    }
}
