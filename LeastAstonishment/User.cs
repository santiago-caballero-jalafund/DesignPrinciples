namespace LeastAstonishment;

public class User
{
  public string Username { get; set; }
  
  public string Email { get; set; }
  
  public string Password { get; set; }

  public void UpdatePassword(string newPassword)
  {
    if (string.IsNullOrWhiteSpace(newPassword))
    {
      throw new ArgumentException("New password cannot be empty.");
    }

    Password = newPassword;
  }
}
