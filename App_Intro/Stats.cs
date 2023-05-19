using System;
using System.Text.Json.Serialization;

namespace App_Intro;

public class Stats
{
    [JsonPropertyName("HP")]
    public float HP { get; set; }
    
    [JsonPropertyName("Attack")]
    public float Attack { get; set; }
    
    [JsonPropertyName("Defense")]
    public float Defense { get; set; }
    
    [JsonPropertyName("Sp. Attack")]
    public float SpAttack { get; set; }
    
    [JsonPropertyName("Sp. Defense")]
    public float SpDefense { get; set; }
    
    [JsonPropertyName("Speed")]
    public float Speed { get; set; }

    private float OtherThanHPStatAt(float stat, int level) => (float)Math.Floor(0.01 * (2 * stat * level) + 5);

    public Stats CalculateStatsAt(int level)
    {
        return new Stats
        {
            HP = (float)Math.Floor(0.01 * (2 * HP * level) + level + 10),
            Attack = OtherThanHPStatAt(Attack, level),
            Defense = OtherThanHPStatAt(Defense, level),
            SpAttack = OtherThanHPStatAt(SpAttack, level),
            SpDefense = OtherThanHPStatAt(SpDefense, level),
            Speed = OtherThanHPStatAt(Speed, level)
        };
    }
}