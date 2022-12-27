using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoints : MonoBehaviour
{
    public int _health { get; private set; }
    public int _maxhealth { get; private set; }

    //events
    public event Action Damaged;
    public event Action Healed;
    public event Action Death;

    public void Damage(int dmg)
    {
        _health -= dmg;
        if (_health > 0)
        {
            Damaged?.Invoke();
        }
        else
        {
            Death?.Invoke();
        }
    }

    public void Heal(int heal)
    {
        _health = Mathf.Min(_health + heal, _maxhealth);

        Healed?.Invoke();
    }
}
