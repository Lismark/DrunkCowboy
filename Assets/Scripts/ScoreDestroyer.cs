using UnityEngine;

public class ScoreDestroyer : MonoBehaviour
{


    public Transform destroyPoint;
    public float speed = 5;
    private int score;

    private void Start()
    {
        score = gameObject.GetComponent<DropObject>().score;
    }


    private void Update()
    {
        if (destroyPoint == null)
        { return; }
        DestroyScore();

    }
    public void DestroyScore()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, destroyPoint.position, speed * Time.deltaTime);
        var distance = gameObject.transform.position.x - destroyPoint.position.x;
        if ( distance < 0.2f)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnDestroy()
    {
        var currentScore = PlayerPrefs.GetInt("Score");
        PlayerPrefs.SetInt("Score", currentScore + score);
        ScoresTableOne.ScoresShaker();
    }

    public void Init(Transform destroyPoint)
    {
      this.destroyPoint = destroyPoint;
    }

}
