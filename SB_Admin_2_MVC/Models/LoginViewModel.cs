namespace SB_Admin_2_MVC.Models;

public class LoginViewModel
{
    public string? RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}