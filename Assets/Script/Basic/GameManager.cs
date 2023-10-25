using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject hint;


    public void Replay0()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Replay1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void Replay2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(7);
    }

    public void Close()
    {
        hint.SetActive(false);
    }

    public void Hint()
    {       
        hint.SetActive(true);
    }
}
