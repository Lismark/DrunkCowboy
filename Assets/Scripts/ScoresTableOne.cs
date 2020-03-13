using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoresTableOne : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject scoresPanel;
    [SerializeField] private GameObject playerHealthBar;
    [SerializeField] private Player player;
    private float playerMaxHealth;
    private float playerHealthBarValue;
    private static Animator scoresAnimator;



    public void Update()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public static void ScoresShaker()
    {
        if(scoresAnimator != null)
        scoresAnimator.SetTrigger("ScoreShake");
    }

}
