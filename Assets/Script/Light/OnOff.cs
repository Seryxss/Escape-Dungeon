using UnityEngine.UI;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    [SerializeField] private GameObject light1;
    [SerializeField] private GameObject light2;
    [SerializeField] private GameObject light3;
    [SerializeField] private GameObject light4;
    [SerializeField] private GameObject light5;
    [SerializeField] private GameObject code;
    [SerializeField] private GameObject on1;
    [SerializeField] private GameObject on2;
    [SerializeField] private GameObject on3;
    [SerializeField] private GameObject on4;
    [SerializeField] private GameObject on5;
    private bool IsOn1 = false;
    private bool IsOn2 = false;
    private bool IsOn3 = false;
    private bool IsOn4 = false;
    private bool IsOn5 = false;
    private bool firstlightOn = false;
    private bool secondlightOn = false;
    private bool thirdlightOn = false;
    private bool fourthlightOn = false;
    private bool fifthlightOn = false;


    public void Button1()
    {
        if (fifthlightOn == false)
        {
            fifthlightOn = true;
            light5.SetActive(true);

        }

        else if (fifthlightOn == true)
        {
            fifthlightOn = false;
            light5.SetActive(false);
        }


        if (thirdlightOn == false)
        {
            thirdlightOn = true;
            light3.SetActive(true);

        }

        else if (thirdlightOn == true)
        {
            thirdlightOn = false;
            light3.SetActive(false);
        }



    }

    public void Button2()
    {
        if (firstlightOn == false)
        {
            firstlightOn = true;
            light1.SetActive(true);
            
        }

        else if (firstlightOn == true)
        {
            firstlightOn = false;
            light1.SetActive(false);
        }

        if (fourthlightOn == false)
        {
            fourthlightOn = true;
            light4.SetActive(true);
            
        }

        else if (fourthlightOn == true)
        {
            fourthlightOn = false;
            light4.SetActive(false);
        }
    }
    public void Button3()
    {
        if (fourthlightOn == false)
        {
            fourthlightOn = true;
            light4.SetActive(true);

        }

        else if (fourthlightOn == true)
        {
            fourthlightOn = false;
            light4.SetActive(false);
            
        }

        if (fifthlightOn == false)
        {
            fifthlightOn = true;
            light5.SetActive(true);
            
        }

        else if (fifthlightOn == true)
        {
            fifthlightOn = false;
            light5.SetActive(false);
        }
    }

    public void Button4()
    {
        if (fifthlightOn == false)
        {
            fifthlightOn = true;
            light5.SetActive(true);
            
        }

        else
        {
            fifthlightOn = false;
            light5.SetActive(false);
        }
    }

    public void Button5()
    {
        if (secondlightOn == false)
        {
            secondlightOn = true;
            light2.SetActive(true);
            
        }

        else if (secondlightOn == true)
        {
            secondlightOn = false;      
            light2.SetActive(false);
        }

        if (thirdlightOn == false)
        {
            thirdlightOn = true;
            light3.SetActive(true);
            
        }

        else if (thirdlightOn == true)
        {
            thirdlightOn = false;
            light3.SetActive(false);
        }
    }

    public void bulbone()
    {
        if (IsOn1 == false)
        {
            on1.SetActive(true);
            IsOn1 = true;
        }

        else
        {
            on1.SetActive(false);
            IsOn1 = false;
        }
    }
    public void bulbtwo()
    {
        if (IsOn2 == false)
        {
            on2.SetActive(true);
            IsOn2 = true;
        }

        else
        {
            on2.SetActive(false);
            IsOn2 = false;
        }
    }
    public void bulbthree()
    {
        if (IsOn3 == false)
        {
            on3.SetActive(true);
            IsOn3 = true;
        }

        else
        {
            on3.SetActive(false);
            IsOn3 = false;
        }
    }

    public void bulbfour()
    {
        if (IsOn4 == false)
        {
            on4.SetActive(true);
            IsOn4 = true;
        }

        else
        {
            on4.SetActive(false);
            IsOn4 = false;
        }
    }

    public void bulbfive()
    {
        if(IsOn5 == false)
        {
            on5.SetActive(true);
            IsOn5 = true;
        }
        
        else
        {
            on5.SetActive(false);
            IsOn5 = false;
        }
    }    
    
    public void Check()
    {
        if (firstlightOn == true && secondlightOn == true && thirdlightOn == true && fourthlightOn == true && fifthlightOn == true)
        {
            Time.timeScale = 0;
            Debug.Log("Fin");
            code.SetActive(true);
        }
    }
}
