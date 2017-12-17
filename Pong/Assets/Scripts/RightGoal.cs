using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGoal : MonoBehaviour {

    public TextMesh cScoreR;
    private LevelManager lManager;

    public static int scoreR;

    public int scoreUpdateR(int scoreR)
    {
        cScoreR.text = "" + scoreR;
        return scoreR;
    }

    void Start()
    {
        cScoreR.text = "" + scoreR;
    }

    void Update()
    {
        
        lManager = GameObject.FindObjectOfType<LevelManager>();
        int cLvl = lManager.CheckLevel();
        if (cLvl == 0)
        {
            scoreR = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        scoreR += 1;
        scoreUpdateR(scoreR);
        int cLvl = lManager.CheckLevel();
        print(cLvl);
        if (cLvl == 1)
        {
            if (scoreR >= 2)
            {
                lManager.NextLevel();
            }
            else
            {
                lManager.SameLevel();
            }
        }
        else if (cLvl == 2)
        {
            if (scoreR >= 4)
            {
                lManager.NextLevel();
            }
            else
            {
                lManager.SameLevel();
            }
        }
        else
        {
            if (scoreR >= 6)
            {
                lManager.NextLevel();
            }
            else
            {
                lManager.SameLevel();
            }
        }
    }
}
