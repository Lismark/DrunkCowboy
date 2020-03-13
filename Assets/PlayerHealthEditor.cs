using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthEditor : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Player player;
    private float playerMaxHealth;

    private void Start()
    {
        playerMaxHealth = player.health;
    }

    private void Update()
    {
        EditHealth();
    }

    private void EditHealth()
    {
        if (player.health < 0)
        {
            player.health = 0;
            Time.timeScale = 0;
        }
        slider.value = player.health / playerMaxHealth;
    }
}
