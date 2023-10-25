using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{

    public InputField inputField;
    [SerializeField] private GameObject code;

    // Start is called before the first frame update
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

    public void read(string answer)
    {
        if (answer == "Jakarta" || answer == "jakarta" || answer == "JAKARTA")
        {
            code.SetActive(true);
        }

        inputField.text = "";
    }    

}
