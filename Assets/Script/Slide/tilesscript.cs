using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilesscript : MonoBehaviour
{
    public Vector3 targetposition;
    private Vector3 correctposition;
    private SpriteRenderer sprite_;
    public int number;
    public bool inRightPlace;

    // Start is called before the first frame update
    void Awake()
    {
        targetposition = transform.position;
        correctposition = transform.position;
        sprite_ = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetposition, 0.05f);
        if(targetposition == correctposition)
        {
            inRightPlace = true;        
        }
        else
        {
            inRightPlace = false;
        }
    }
}
