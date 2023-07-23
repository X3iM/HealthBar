using System;

[Serializable]
public class Player
{
    private float _health;
    private float _maxHealth;

    public Player(float health)
    {
        _health = health;
        _maxHealth = health;
    }

    public float Health => _health;
    public float MaxHealth => _maxHealth;

    public void Damage()
    {
        if (_health > 0)
        {
            _health -= 10;
        }
    }
    
    public void Heal()
    {
        if (_health < _maxHealth)
        {
            _health += 10;
        }
    }
}