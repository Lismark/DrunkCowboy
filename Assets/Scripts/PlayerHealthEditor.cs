using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthEditor : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Player player;
    [SerializeField] GameObject healthBar;
    private Animator animator;

    private void Start()
    {
        animator = healthBar.GetComponent<Animator>();
    }

    private void Update()
    {
        EditHealth();
        animator.SetInteger("hp", player.currentHealth);
    }

    private void EditHealth()
    {
        if (player.currentHealth < 0)
        {
            player.currentHealth = 0;
            Time.timeScale = Mathf.Lerp(1f,0f, .1f * Time.deltaTime);   // постепенно замедляет время // таймскейл лучше вынести в скриптабл
        }
        slider.value = (float)player.currentHealth / (float)player.maxHealth;
    }
}
