using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoresTableOne : MonoBehaviour
{
    [SerializeField] private GameObject scores;
    [SerializeField] private Text scoresText;
    private static Animator scoresAnimator;

    private void Start()
    {
        scoresAnimator = scores.GetComponent<Animator>();
    }

    public void Update()
    {
        scoresText.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public static void ScoresShaker()
    {
        if(scoresAnimator != null)
        scoresAnimator.SetTrigger("ScoreShake");
    }

}
