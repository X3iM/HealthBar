using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Action OnHealthChanged;
    
    [SerializeField] private float _health = 100f;
    private float _maxHealth;

    private void Awake()
    {
        _maxHealth = _health;
    }

    public float Health => _health;
    public float MaxHealth => _maxHealth;

    public void Damage()
    {
        float health = _health - 10;
        _health = Mathf.Clamp(health, 0, _maxHealth);
        OnHealthChanged();
    }
    
    public void Heal()
    {
        float health = _health + 10;
        _health = Mathf.Clamp(health, 0, _maxHealth);
        OnHealthChanged();
    }
}