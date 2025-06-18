namespace LearnifyStockApp.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; } //Hata ayıklama için kullanılan benzersiz istek kimliği.

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
