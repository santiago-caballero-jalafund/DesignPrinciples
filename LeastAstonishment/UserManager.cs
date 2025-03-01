﻿namespace LeastAstonishment;

public class UserManager
{
  private readonly List<User> _users;

  public UserManager()
  {
    _users = [];
  }

  public void AddUser(string username, string email, string password)
  {
    _users.Add(new User { Username = username, Email = email, Password = password });
  }

  public void UpdateUserPassword(string username, string newPassword)
  {
    var user = _users.FirstOrDefault(u => u.Username == username);

    if (user != null)
    {
      user.UpdatePassword(newPassword);
    }
    else
    {
      Console.WriteLine($"User with username {username} not found.");
    }
  }

  public void SetUserRole(string username, string role)
  {
    var user = _users.FirstOrDefault(u => u.Username == username);
    
    if (user != null)
    {
      user.Role = role;
    }
  }

  public void DisplayUserDetails(string username)
  {
    var user = _users.FirstOrDefault(u => u.Username == username);
    
    if (user != null)
    {
      Console.WriteLine($"Username: {user.Username}, Email: {user.Email}, Role: {user.Role}");
    }
  }
}
