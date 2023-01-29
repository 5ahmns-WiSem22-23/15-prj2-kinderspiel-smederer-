using UnityEngine;
using UnityEngine.UI;



public class RandomFruit : MonoBehaviour
{
    public Sprite[] fruitFaces;

    public GameObject randomFruit01;
    public GameObject randomFruit02;

    public Button richitgButton;

    public AudioSource richitgButtonSound;

    private void Start()
    {
        DisableButton();
    }
    private void OnMouseDown()
    {
        int _index01 = Random.Range(0, fruitFaces.Length);
        randomFruit01.gameObject.GetComponent<SpriteRenderer>().sprite = fruitFaces[_index01];
        

        int _index02 = Random.Range(0, fruitFaces.Length);
        randomFruit02.gameObject.GetComponent<SpriteRenderer>().sprite = fruitFaces[_index02];

        richitgButton.gameObject.SetActive(true);
    }
    public void DisableButton()
    {
        richitgButton.gameObject.SetActive(false);
    }
    public void RichitgButtonSound()
    {
        richitgButtonSound.Play();
    }
}
