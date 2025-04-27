namespace Project02_MVC_WithCLI_TopLevelStatement.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); // amacı RequestId'in boş olup olmadığını kontrol etmek.
}
