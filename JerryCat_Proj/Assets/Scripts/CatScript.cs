using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    #region Variables 
    public CircleCollider2D catSprite;
    public CatPettingScript cps;

    #endregion

    private void Start()
    {
        catSprite = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("You are on the cat");
        Debug.Log(cps.score.ToString());

        if(Input.GetMouseButtonDown(0))
        {
            cps.IncreaseScore();
            cps.TamedCat();
        }
    }
}
