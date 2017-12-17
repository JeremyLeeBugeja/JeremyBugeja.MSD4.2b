using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGoal : MonoBehaviour {

    private LevelManager lManager;
    public TextMesh cScoreL;

    public static int scoreL;


    public int scoreUpdateL(int scoreL)
    {
        
        cScoreL.text = "" + scoreL;
        return scoreL;
    }


    void Start()
    {
        cScoreL.text = "" + scoreL; 
    }

    void Update()
    {

        lManager = GameObject.FindObjectOfType<LevelManager>();
        int cLvl = lManager.CheckLevel();
        if (cLvl == 0)
        {
            scoreL = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        scoreL += 1;
        scoreUpdateL(scoreL);
        int cLvl = lManager.CheckLevel();
        print(cLvl);
        if (cLvl == 1)
        {
            if (scoreL >= 2)
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
            if (scoreL >= 4)
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
            if (scoreL >= 6)
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
