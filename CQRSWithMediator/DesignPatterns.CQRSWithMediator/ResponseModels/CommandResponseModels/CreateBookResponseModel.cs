namespace DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels
{
    public class CreateBookResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
