using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Eating : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static bool correctArea = false;
    public static int count = 0;

    public GameObject[] nahrung;
    public GameObject bear;
    public Sprite bearHighlightSrite;
    public Sprite bearSprite;

    private void Start()
    {
        count = 0;
        bear.gameObject.GetComponent<SpriteRenderer>().sprite = bearSprite;
    }
    private void Update()
    { 

        string _x = count.ToString();
        string _laenge = nahrung.Length.ToString();
        score.text = _x + "/" + _laenge;
    }

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
