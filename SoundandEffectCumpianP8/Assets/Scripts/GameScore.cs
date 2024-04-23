using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public int score;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        playerControllerScript = GetComponent<PlayerController>();
        InvokeRepeating("ChangeScore", 0f, 1f);
    }

    void ChangeScore()
    {
        if (Input.GetKey("left shift"))
        {
            score += 2;
        }
        else
        {
            score += 1;
        }
        if (!playerControllerScript.gameOver)
        {
            Debug.Log("Score : " + score);
        }
    }
}
