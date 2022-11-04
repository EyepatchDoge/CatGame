using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public InputHandler inputHandler;

    private Camera cam;
    public string targetTag;

    void Start()
    {
        cam = Camera.main;
    }

    private void OnEnable()
    {
        inputHandler.OnClickAction += CastRay;
    }

    private void OnDisable()
    {
        inputHandler.OnClickAction -= CastRay;

    }

    public void CastRay()
    {
        Debug.Log(inputHandler.TouchPosition);


        var pointInWorld = cam.ScreenToWorldPoint(inputHandler.TouchPosition);

        RaycastHit2D hit = Physics2D.Raycast(pointInWorld, Vector2.zero);
        if(hit.collider != null)
        {
            if (hit.collider.CompareTag(targetTag))
            {
                Debug.Log("target hit!");
                hit.collider.GetComponent<CatPettingScript>().IncreaseScore();
            }
        }

    }

}
