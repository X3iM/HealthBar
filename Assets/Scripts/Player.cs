using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Action HealthChangedEvent;
    
    [SerializeField] private float _health = 100f;
    [SerializeField] private float _damage = 10f;
    [SerializeField] private float _heal = 10f;
    private float _maxHealth;

    private void Awake()
    {
        _maxHealth = _health;
    }

    public float Health => _health;
    public float MaxHealth => _maxHealth;

    public void Damage()
    {
        float health = _health - _damage;
        _health = Mathf.Clamp(health, 0, _maxHealth);
        HealthChangedEvent();
    }
    
    public void Heal()
    {
        float health = _health + _heal;
        _health = Mathf.Clamp(health, 0, _maxHealth);
        HealthChangedEvent();
    }
}