using UnityEngine.UI;
using UnityEngine;


public class Score : MonoBehaviour
{
public Text scoreText;
    public Text finalscore;
    int myscore = 0;
    // Update is called once per frame
    void Update()
    {
       
       scoreText.text = myscore.ToString();

       finalscore.text = myscore.ToString();
       
    }
    public void AddScore(int score)
    {
        myscore = myscore + score;
    }
    }
