using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoresTableOne : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject scoresPanel;
    private static Animator scoresAnimator;

    private void Start()
    {
        scoresAnimator = scoresPanel.GetComponent<Animator>();
    }


    public void FixedUpdate()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public static void ScoresShaker()
    {
        scoresAnimator.SetTrigger("ScoreShake");
    }

}
