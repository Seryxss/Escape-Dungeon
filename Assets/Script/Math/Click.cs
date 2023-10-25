using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public static string correctnumber="2436";
    public static string playernumber;
    [SerializeField] private GameObject code;
    public static int totaldigit=0;

    private void Start()
    {
        totaldigit = 0;
        playernumber = "";
    }

    void Update()
    {
      

        if (totaldigit == 4)
        {
            if (playernumber == correctnumber)
            {
                Debug.Log("Correct");
                Time.timeScale = 0;
                code.SetActive(true);
            }
            else
            {
                playernumber = "";
                totaldigit = 0;
                Debug.Log("Wrong");
            }
        }
    }

    void OnMouseUp()
    {
        playernumber += gameObject.name;
        totaldigit += 1;
    }
}
