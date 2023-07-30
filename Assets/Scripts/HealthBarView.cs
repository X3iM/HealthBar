using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _player.OnHealthChanged += CountSliderValue;
        _slider.value = 1;
    }

    private void CountSliderValue()
    {
        _slider.value = _player.Health / _player.MaxHealth;
    }
}