namespace User.DTORequestLogin;

public class UserDTORequestGet
{
	public string? Email { get; set; }
	public string? Password { get; set; }
}

public class UserDTORequestPost
{
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}

public class UserDTOActive
{
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }

    public int UserActive { get; set; }
}
