using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTxt;
    public Text DescriptionTxt;
    public Text targetScore;
    public CatSO catSO;

    // Start is called before the first frame update
    void Start()
    {
        DescriptionTxt.text = " ";
        targetScore.text = "/ " + catSO.catTotalPoints.ToString();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
