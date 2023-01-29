using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public Sprite[] diceFaces;
    public GameObject dice;
    public Score addToScore;
    public List<GameObject> additionalFruits;

    private string result;


    private void Start()
    {
        for(int i =0; i< additionalFruits.Count; i++)
        {
            additionalFruits[i].SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        int _index01 = Random.Range(0, diceFaces.Length);
        dice.gameObject.GetComponent<SpriteRenderer>().sprite = diceFaces[_index01];
        result = diceFaces[_index01].name;
        if(result == "bear" && additionalFruits.Count!= 0)
        {
            int _index02 = Random.Range(0, additionalFruits.Count);
            additionalFruits[_index02].SetActive(true);
            additionalFruits.Remove(additionalFruits[_index02]);

            addToScore.maxCount++;
            
        }

    }
  
}
