using UnityEngine;

public class DisplayControl : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = Click.playernumber;
    }
}
