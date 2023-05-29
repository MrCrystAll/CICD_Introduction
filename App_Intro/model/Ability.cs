namespace App_Intro.model;

public class Ability
{
    public string Name { get; set; }
    public bool Hidden { get; set; }

    public Ability(string name, bool hidden)
    {
        Name = name;
        Hidden = hidden;
    }
}