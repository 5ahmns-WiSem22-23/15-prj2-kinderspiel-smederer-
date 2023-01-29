using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BennenenBelohnung : MonoBehaviour
{
    public Sprite[] fruitFaces;
    

    void Start()
    {
        this.gameObject.SetActive(false);
        int _index01 = Random.Range(0, fruitFaces.Length);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = fruitFaces[_index01];
    }
    public void SpawnBelohnung()
    {
        this.gameObject.SetActive(true);
    }

    // !! die Scene wird in "DragDrop" script neu geladen!!
}
