using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public  void StartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    public  void StartWuerfeln()
    {
        SceneManager.LoadScene("Wuerfeln");
        Score.totalTrys = 0;
        Score.count = 0; 
    }
    public void StartFreiesSpiel()
    {
        SceneManager.LoadScene("FreiesSpiel");
        Score.totalTrys = 0;
        Score.count = 0;
    }
    public void StartBenennen()
    {
        SceneManager.LoadScene("Benennen");
        Score.totalTrys = 0;
        Score.count = 0;
    }
    public void LieblingsEssen()
    {
        SceneManager.LoadScene("LieblingsEssen");
        Score.totalTrys = 0;
        Score.count = 0;
    }


}
