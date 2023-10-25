using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorInteract : MonoBehaviour
{
    private string input;
    public InputField inputField;
    [SerializeField] private Text interactText;
    [SerializeField] private GameObject countdown;
    [SerializeField] private GameObject finalcountdown;
    [SerializeField] private GameObject Finish;

    // Start is called before the first frame update
    private int num;

    void Start()
    {
        inputField.text = "";
    }

    // Update is called once per frame
    void Update()
    { 

        if (Input.GetKeyDown(KeyCode.Return))
        {
            read(inputField.text);
        }
    }

    public void read(string s)
    {
        int number;
        bool check = int.TryParse(s, out number);

        if (gameObject.name.Equals("Door1"))
        {
            num = 7521;
            if (num == number)
            {
                Debug.Log("Correct");
                Time.timeScale = 1;
                SceneManager.LoadScene(4);
            }
        }
        if (gameObject.name.Equals("Door2"))
        {
            num = 3095;
            if (num == number)
            {
                Debug.Log("Correct");
                Time.timeScale = 1;
                SceneManager.LoadScene(7);
            }
        }

        if (gameObject.name.Equals("Door3"))
        {
            num = 1254;
            if (num == number)
            {
                Debug.Log("Correct");
                Time.timeScale = 0;
                Finish.SetActive(true);
                countdown.SetActive(false);
                finalcountdown.SetActive(true);
            }
        }

        inputField.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            interactText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            interactText.gameObject.SetActive(false);
        }
    }
}