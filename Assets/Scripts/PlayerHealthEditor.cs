using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthEditor : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] GameObject healthBar;
    [SerializeField] Player player;
    private Animator animator;

    private void Start()
    {
        animator = healthBar.GetComponent<Animator>();
    }

    private void Update()
    {
        EditHealth();
        animator.SetFloat("hp", player.CurrentHealth);
    }

    private void EditHealth()
    {
        if (player.CurrentHealth < 0)
        {
            player.CurrentHealth = 0;
            Time.timeScale = Mathf.Lerp(1f,0f, .1f * Time.deltaTime);   // постепенно замедляет время // таймскейл лучше вынести в скриптабл
        }
        slider.value = player.CurrentHealth / player.MaxHealth;
    }
}
