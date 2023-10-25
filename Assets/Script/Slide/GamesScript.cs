using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesScript : MonoBehaviour
{
    [SerializeField] private Transform emptyspace = null;
    [SerializeField] private GameObject code;
    [SerializeField] private tilesscript[] tiles;
    [SerializeField] private GameObject button;
    private Camera camera_;
    int emptySpaceIndex = 15;
    private bool isFinished_;

    // Start is called before the first frame update
    void Start()
    {
        camera_ = Camera.main;
        shuffle();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera_.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit)
            {
                if (Vector2.Distance(emptyspace.position, hit.transform.position) < 2.5)
                {
                    Vector2 lastemptyspacePosition = emptyspace.position;
                    tilesscript thisTile = hit.transform.GetComponent<tilesscript>();
                    emptyspace.position = thisTile.targetposition;
                    thisTile.targetposition = lastemptyspacePosition;
                    int tileindex = findindex(thisTile);
                    tiles[emptySpaceIndex] = tiles[tileindex];
                    tiles[tileindex] = null;
                    emptySpaceIndex = tileindex;
                }
            }
        }
        int correctTiles = 0;
        foreach (var a in tiles)
        {
            if (a != null)
            {
                if (a.inRightPlace)
                {
                    correctTiles++;
                }
            }
        }
        if (correctTiles == tiles.Length - 1)
        {
            code.SetActive(true);
            Time.timeScale = 0;
            isFinished_ = true;
            button.SetActive(false);
        }
    }

    public void shuffle()
    {
        if (emptySpaceIndex != 15)
        {
            var tileOn15LastPos = tiles[15].targetposition;
            tiles[15].targetposition = emptyspace.position;
            emptyspace.position = tileOn15LastPos;
            tiles[emptySpaceIndex] = tiles[15];
            tiles[15] = null;
            emptySpaceIndex = 15;
        }

        int invertion;
        do
        {
            for (int i = 0; i <= 14; i++)
            {
                var lastpos = tiles[i].targetposition;
                int randomindex = Random.Range(0, 14);
                tiles[i].targetposition = tiles[randomindex].targetposition;
                tiles[randomindex].targetposition = lastpos;
                var tile = tiles[i];
                tiles[i] = tiles[randomindex];
                tiles[randomindex] = tile;
            }
            invertion = GetInversions();
            Debug.Log("Puzzle Shuffle");
        } while (invertion%2 != 0);
    }

    public int findindex(tilesscript ts)
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if (tiles[i] != null)
            {
                if (tiles[i] == ts)
                {
                    return i;
                }
            }
        }
        return -1;
    }

    int GetInversions()
    {
        int inversionsSum = 0;
        for (int i = 0; i < tiles.Length; i++)
        {
            int thisTileInvertion = 0;
            for (int j = i; j < tiles.Length; j++)
            {
                if (tiles[j] != null)
                {
                    if (tiles[i].number > tiles[j].number)
                    {
                        thisTileInvertion++;
                    }
                }
            }
            inversionsSum += thisTileInvertion;
        }
        return inversionsSum;
    }
}
    
