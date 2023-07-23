using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Button _damage;
    [SerializeField] private Button _heal;
    [SerializeField] private float _playerHealth = 100f;

    private Player _player;

    private void Start()
    {
        _player = new Player(_playerHealth);
        _damage.onClick.AddListener(Damage);
        _heal.onClick.AddListener(Heal);
        _slider.value = 1;
    }

    private void Damage()
    {
        _player.Damage();
        CountSliderValue();
    }
    
    private void Heal()
    {
        _player.Heal();
        CountSliderValue();
    }

    private void CountSliderValue()
    {
        float health = _player.Health / _player.MaxHealth;
        _slider.value = Mathf.MoveTowards(_slider.value, health, 1);
    }
}