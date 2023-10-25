using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Text interactText;
    private bool interactAllowed;
    public static bool GameIsPause = false;

    // Update is called once per frame
    void Update()
    {
        if (interactAllowed && Input.GetKeyDown(KeyCode.F))
        {
            if (gameObject.name.Equals("Jigsaw"))
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(2);
            }
            if (gameObject.name.Equals("Light"))
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(3);
            }
            if (gameObject.name.Equals("Math"))
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(5);
            }
            if (gameObject.name.Equals("Slider"))
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(6);
            }
            if (gameObject.name.Equals("Maze"))
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(8);
            }
            if (gameObject.name.Equals("Word"))
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(9);
            }
            if (gameObject.name.Equals("Door1"))
            {
                panel.SetActive(true);
                interactText.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
            if (gameObject.name.Equals("Door2"))
            {
                panel.SetActive(true);
                interactText.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
            if (gameObject.name.Equals("Door3"))
            {
                panel.SetActive(true);
                interactText.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            interactText.gameObject.SetActive(true);
            interactAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            interactText.gameObject.SetActive(false);
            interactAllowed = false;
        }
    }

    public void Close()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}