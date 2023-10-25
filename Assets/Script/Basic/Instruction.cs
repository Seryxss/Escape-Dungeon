using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    [SerializeField] private GameObject Help;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void Close()
    {
        Help.SetActive(false);
        Time.timeScale = 1;
    }
}
