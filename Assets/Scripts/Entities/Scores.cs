using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New_score_object", menuName ="ScoreObject")] 

public class Scores : ScriptableObject
{
    public GameObject scoreObject;
    public int scoreCount;
}
