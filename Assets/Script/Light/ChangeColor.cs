using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Image buttonbackground;

    public void buttonGreenclicked()
    {
        buttonbackground.color = Color.green;
    }

    public void buttonYellowclicked()
    {
        buttonbackground.color = Color.yellow;
    }

    public void buttonBlueclicked()
    {
        buttonbackground.color = Color.blue;
    }

    public void buttonRedclicked()
    {
        buttonbackground.color = Color.red;
    }

    public void buttonCyanClicked()
    {
        buttonbackground.color = Color.cyan;
    }
}
