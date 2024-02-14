using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform playerScore;
    private float score;
    public GameObject txt;

    private void FixedUpdate()
    {
        score = playerScore.position.z;
        txt.GetComponent<UnityEngine.UI.Text>().text = score.ToString("0");
    }
}
