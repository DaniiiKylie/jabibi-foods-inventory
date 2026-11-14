namespace mabalot_try
{
    // A page the dashboard opens from its sidebar (Items, Users). When the page closes, NextPage
    // names the page to open in its place ("Items", "Users"), is "LogOut" after the page's Log out
    // was confirmed, or is null to go back to the dashboard.
    public interface ISidebarPage
    {
        string NextPage { get; }
    }
}
