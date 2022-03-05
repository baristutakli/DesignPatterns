namespace DesignPatterns.Proxy
{
    public class CreditManagerProxy : CreditBase
    {
        private CreditManager _creditManager;
        int _cachedValue;
        public override int Calculate()
        {
            if (_creditManager is null)
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }
            return _cachedValue;
        }
    }
}
