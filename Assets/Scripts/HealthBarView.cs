using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private const float _healthBarChangeDuration = 0.5f;
    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _player.HealthChangedEvent += CountSliderValue;
        _slider.value = 1;
    }

    private void CountSliderValue()
    {
        float value = _player.Health / _player.MaxHealth;
        _slider.DOValue(value, _healthBarChangeDuration);
    }
}