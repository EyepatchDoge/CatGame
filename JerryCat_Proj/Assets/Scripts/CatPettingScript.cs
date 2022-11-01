using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatPettingScript : MonoBehaviour
{

    #region Variables 
    public Text scoreTxt;
    public Text DescriptionTxt;
    public CircleCollider2D catSprite;

    public int score;
    public int maxScore;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        maxScore = 10; //this value will eventually come from cat scriptable objects
        DescriptionTxt.text = " ";
    }


    public void TamedCat()
    {
        if (score == maxScore)
        {
            DescriptionTxt.text = "You have sucessfully tamed the cat!";
        }
    }

    public void IncreaseScore()
    {
        if (score != maxScore)
        {
            score++;
            scoreTxt.text = score.ToString();
        }
    }
}
