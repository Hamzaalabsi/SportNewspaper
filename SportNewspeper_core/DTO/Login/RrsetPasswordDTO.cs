namespace SportNewspeper_core.DTO.Login
{
    public class RrsetPasswordDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}
