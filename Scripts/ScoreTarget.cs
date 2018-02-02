using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTarget : MonoBehaviour {

    static Text scoreText;
    static Text messegeText;
    static Text PedestrianText;
    static Text CurbScoreText;
    static Text CheckpointsText;
    static Text CollisionsText;
    static int currentScore = 0;
    static int PedestrianScore = 0;
    static int CurbScore = 0;
    static int Checkpoints = 0;
    static int CollisionsScore = 0;
    static string currentMessege = "Szerokiej drogi!";

    private void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
        messegeText = GameObject.FindGameObjectWithTag("MessegeText").GetComponent<Text>();
/*
        PedestrianText = GameObject.FindGameObjectWithTag("PedestrianScore").GetComponent<Text>();
        CurbScoreText = GameObject.FindGameObjectWithTag("CurbScore").GetComponent<Text>();
        CheckpointsText = GameObject.FindGameObjectWithTag("Checkpoints").GetComponent<Text>();
        CollisionsText = GameObject.FindGameObjectWithTag("collisionW").GetComponent<Text>();
        */
        UpdateScore(currentScore);
        UpdateMessege(currentMessege);
    }

    public static void UpdateScore(int addedValue)
    {
        currentScore += addedValue;
        scoreText.text = "Score: " + currentScore;
        


    }

    public static void UpdateMessege(string messege)
    {
        currentMessege = messege;
        messegeText.text = "" + currentMessege;

    }


    public static void UpdateRank(int aValue, int bValue, int cValue, int dValue )
    {
        
        
        PedestrianScore += aValue;
        CurbScore+= bValue;
        Checkpoints += cValue;
        CollisionsScore += dValue;


    }


    public static void ShowRank()
    {
       /* scoreText.text = "Score: " + currentScore;
        PedestrianText.text = "Rozjechani ludzie: " + PedestrianScore;
        CurbScoreText.text = "Opuszczenie drogi: " + CurbScore;
        CheckpointsText.text = "Punkty kontrolne: " + Checkpoints;
        CollisionsText.text = "Kolizje: " + CollisionsScore;
        */

    }
}
