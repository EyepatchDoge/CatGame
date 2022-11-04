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

        Ray ray = cam.ScreenPointToRay(inputHandler.TouchPosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            if (hit.collider.CompareTag(targetTag))
            {
                Debug.Log("target hit!");
                hit.collider.GetComponent<CatPettingScript>().IncreaseScore();
            }
        }
    }

}
