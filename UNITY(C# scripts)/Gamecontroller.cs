using UnityEngine.SceneManagement;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public GameObject Gameoverpanel;
    public GameObject taptostart;
    public GameObject scoretext;
    private void Start()
    {
        Gameoverpanel.SetActive(false);
        taptostart.SetActive(true);
        scoretext.SetActive(false);
        Pausegame();


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Startgame();
            taptostart.SetActive(false);
            scoretext.SetActive(true);
        }
    }
    public void Gameover()
   {
        Gameoverpanel.SetActive(true);
        scoretext.SetActive(false ) ;
   }

    public void Restart()
    {
        SceneManager.LoadScene("BOXDESTROYER");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Pausegame()
    {
        Time.timeScale = 0f;
    }

    public void Startgame()
    {
        Time.timeScale = 1f;
    }
}
