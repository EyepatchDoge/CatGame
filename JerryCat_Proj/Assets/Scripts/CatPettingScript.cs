using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatPettingScript : MonoBehaviour
{

    #region Variables 

    public static int score;
    public int maxScore;
    private int annoyVal;

    public CatSO catSO;

    public ScoreManager scoreM;

    public CatParts catPart;

    public GameObject catObj;
    private SpriteRenderer catSpriteRenderer;
    int scoreToIncrement = 0;


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        maxScore = catSO.catTotalPoints; //this value will eventually come from cat scriptable objects
        scoreToIncrement = catSO.catPartData.Find(x => x.catPart == catPart).score;
        catSpriteRenderer = catObj.GetComponent<SpriteRenderer>();
    }


    public void TryTamedCat()
    {
        if (score == maxScore)
        {
            scoreM.DescriptionTxt.text = "You have sucessfully tamed " + catSO.catName + "!";
            catSpriteRenderer.sprite = catSO.happySprite;
        }
    }

    public void CatAnnoy()
    {
        annoyVal++;
        scoreM.DescriptionTxt.text = catSO.catName + " is getting annoyed. Try petting somewhere else";

        catSpriteRenderer.sprite = catSO.sadSprite;
        if (annoyVal >= 3)
        {
            scoreM.DescriptionTxt.text = catSO.catName + " is upset. Try again later.";
         
            catObj.SetActive(false);
        }
    }

    public void IncreaseScore()
    {
        if (score < maxScore)
        {
            if (score == 0 && score + scoreToIncrement < 0)
            {
                CatAnnoy();
                return;
            }
            annoyVal = 0;
            score += scoreToIncrement;
            catSpriteRenderer.sprite = catSO.neutralSprite;
            scoreM.scoreTxt.text = score.ToString();

            TryTamedCat();

        }

    } 
}
