    using UnityEngine;
using System.Collections;

public class MovePiece : MonoBehaviour
{
    public string checkPlacement = "";
    public Transform edgeParticle;
    public string pieceStatus = "idle";
    public KeyCode placePiece;
    public KeyCode returnpiece;
    public bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {

        if (isBeingHeld == true)
        {
            Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = objPosition;


        }

        if (Input.GetKeyDown(placePiece))
        {
            checkPlacement = "y";
  
        }

        if (Input.GetKeyDown(returnpiece) && (pieceStatus == "pickedup"))
        {
            transform.position = new Vector2(Random.Range(7f, 17f), Random.Range(11, -11));
            pieceStatus = "";
            GetComponent<Renderer>().sortingOrder = 0;
        }
    }

    
    void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == "y"))
        {
            isBeingHeld = false;
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 0;
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            Instantiate(edgeParticle, other.gameObject.transform.position, edgeParticle.rotation);
            checkPlacement = "n";
            RemainingPiece.remainingpieces -= 1;
        }

        if ((other.gameObject.name != gameObject.name) && (checkPlacement == "y"))
        {
            checkPlacement = "n";
        }
    }

    private void OnMouseDown()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = objPosition;

        checkPlacement = "n";
        GetComponent<Renderer>().sortingOrder = 10;
        isBeingHeld = true;
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
    


