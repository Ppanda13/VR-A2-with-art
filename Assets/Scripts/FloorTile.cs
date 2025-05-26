using UnityEngine;

public class FloorTile : MonoBehaviour
{
    public bool SteppedOn = false;
    public StepOnTileMaze manager;
    public Material PrestineTile;
    public Material FragileTile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StepOn()
    {
        if (SteppedOn)
        {
            gameObject.SetActive(false);
        }
        else
        {
            SteppedOn = true;
            gameObject.GetComponent<MeshRenderer>().material = FragileTile;
            if (manager.CheckAllSteppedOn())
            {
                manager.OpenDoor();
            }
        }
    }

    public void ResetObject()
    {
        gameObject.GetComponent<MeshRenderer>().material = PrestineTile;
        SteppedOn = false;
        gameObject.SetActive(true);
    }
}
