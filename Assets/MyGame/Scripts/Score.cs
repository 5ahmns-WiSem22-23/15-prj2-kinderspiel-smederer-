
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private bool audioPlayed = false;



    public int maxCount;

    public static int count = 0;
    public static int totalTrys = 0;

    public TextMeshProUGUI winText;
    public TextMeshProUGUI loseText;
    public TextMeshProUGUI corectScore;

    public GameObject[] nahrung;
    public GameObject dice;

    public AudioSource winSound;
    public AudioSource loseSound;

    private void Start()
    {
        maxCount = nahrung.Length;
        count = 0;
        loseText.enabled = false;
        winText.enabled = false;

    }
    private void Update()
    {
        Debug.Log(totalTrys);
        string _x = count.ToString();
        string _laenge = maxCount.ToString();
        corectScore.text = _x + "/" + _laenge;
        if (totalTrys == maxCount)
        {

            dice.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            //lose
            if (((float)count /(float)maxCount) < 0.5f)
            {
                
                if (!loseSound.isPlaying && audioPlayed == false)
                {
                    loseSound.Play();
                    audioPlayed = true;
                }
                loseText.enabled = true;
            }

            //win
            if (((float)count / (float)maxCount) >= 0.5f)
            {
                if (!winSound.isPlaying && audioPlayed == false)
                {
                    winSound.Play();
                    audioPlayed = true;
                }
                winText.enabled = true;
                
            }

        }
       
     

    }
}
