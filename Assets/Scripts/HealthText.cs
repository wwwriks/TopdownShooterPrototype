using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Player _player;

    private void Update()
    {
        _healthText.text = $"HEALTH:{_player.Health}";
    }
}
