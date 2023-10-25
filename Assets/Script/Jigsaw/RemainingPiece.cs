using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainingPiece : MonoBehaviour
{
    [SerializeField] private GameObject code;
    public static int remainingpieces = 25;

    void Update()
    {
        if (remainingpieces == 0)
        {
            code.SetActive(true);
            remainingpieces = 25;
        }
    }
}
