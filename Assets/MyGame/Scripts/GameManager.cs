using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public  void start()
    {
        SceneManager.LoadScene("StartScene");
    }
    public  void startWuerfeln()
    {
        SceneManager.LoadScene("Wuerfeln");
    }
    public void startFreiesSpiel()
    {
        SceneManager.LoadScene("FreiesSpiel");
    }
    public void startBenennen()
    {
        SceneManager.LoadScene("Benennen");
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
