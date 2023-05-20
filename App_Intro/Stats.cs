using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace App_Intro;

public class Stats : INotifyPropertyChanged
{
    private uint _level;
    public uint Level
    {
        get => _level;
        set
        {
            _level = value;
            OnPropertyChanged();
        }
    }
    
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

    public ObservableCollection<int> EVs { get; set; } = new(){0, 0, 0, 0, 0, 0};
    public ObservableCollection<int> IVs { get; set; } = new(){0, 0, 0, 0, 0, 0};

    private float OtherThanHPStatAt(float stat, int ev, int iv) => (float)Math.Floor(0.01 * (2 * stat  + iv + Math.Floor(ev * 0.25)) * Level) + 5;

    public Stats CalculateStats()
    {
        return new Stats
        {
            HP = (float)Math.Floor(0.01 * (2 * HP + IVs[0] + Math.Floor(EVs[0] * 0.25)) * Level) + Level + 10,
            Attack = OtherThanHPStatAt(Attack, EVs[1], IVs[1]),
            Defense = OtherThanHPStatAt(Defense, EVs[2], IVs[2]),
            SpAttack = OtherThanHPStatAt(SpAttack, EVs[3], IVs[3]),
            SpDefense = OtherThanHPStatAt(SpDefense, EVs[4], IVs[4]),
            Speed = OtherThanHPStatAt(Speed, EVs[5], IVs[5])
        };
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}