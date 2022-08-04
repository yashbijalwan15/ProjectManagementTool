public sealed class Login
{
    public string? username { get; set; }
    public string? password { get; set; }
    public int id { get; set; }
}

public sealed class Role
{
    public int role_id { get; set; }
    public string? role_name { get; set; }
    public string? role_desc {get; set; }
}

public sealed class Permission
{
    public int perm_id { get; set; }
    public string? perm_name { get; set; }
    public string? perm_module { get; set; }
}

// public sealed class Users
// {
//     public int id { get; set; }
//     public string name { get; set; }
//     public string phone_no { get; set; }
//     public string email { get; set; }
//     public string address { get; set; }
//     public int role_id {get; set; }
//     public int perm_id { get; set; }
//     public int proj_id { get; set; }
// }

public sealed class Project
{
    public int proj_id { get; set; }
    public string? proj_name { get; set; }
    public string? proj_desc { get; set; }
    public int proj_man_id {get; set; }
}

public sealed class Tasks
{
    public int task_id { get; set; }
    public string? task_title { get; set; }
    public int proj_id { get; set; }
}

public sealed class Todo
{
    public int task_id { get; set; }
    public string? item { get; set; }
    public int dev_id { get; set; }
}

public sealed class Bug
{
    public string? bug_id { get; set; }
    public string? bug_title { get; set; }
    public string? bug_desc { get; set; }
    public int proj_id { get; set; }
    public int found_dev_id { get; set; }
    public int solved_dev_id { get; set; }
}

