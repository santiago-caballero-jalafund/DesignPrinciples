namespace LeastAstonishment;

public class UserManager
    {
    private readonly List<User> _users;

    public UserManager()
    {
        _users = new List<User>();
    }

    private bool DoesUserExists(User user) 
    {
      return user != null;
    }

    public void AddUser(string username, string email, string password)
    {
        _users.Add(new User { Username = username, Email = email, Password = password });
    }

    public void UpdateUserPassword(string username, string newPassword)
    {
        var user = _users.FirstOrDefault(u => u.Username == username);

        if (DoesUserExists(user))
        {
            user.UpdatePassword(newPassword);
        }
        else
        {
            DisplayAlertMessage("User with username {username} not found.");
        }
    }

    public void DisplayUserDetails(string username)
    {
        var user = _users.FirstOrDefault(u => u.Username == username);

        if (DoesUserExists(user))
        {
            DisplayAlertMessage("Username: {user.Username}, Email: {user.Email}");
        }
    }

    private void DisplayAlertMessage(string message)
    {
      Console.WriteLine('$'+message);
    }
}