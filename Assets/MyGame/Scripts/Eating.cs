using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour
{
    public static bool correctArea = false;

    public GameObject bear;
    public Sprite bearHighlightSrite;
    public Sprite bearSprite;
    

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        bear.gameObject.GetComponent<SpriteRenderer>().sprite = bearHighlightSrite;
        correctArea = true;
      

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        bear.gameObject.GetComponent<SpriteRenderer>().sprite = bearSprite;
        correctArea = false;

    }
}
