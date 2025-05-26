using UnityEngine;

public class StepOnTileMaze : MonoBehaviour
{
    public DoorScript roomDoor;
    public FloorTile[] floorTiles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CheckAllSteppedOn()
    {
        bool passed = true;
        foreach (FloorTile tile in floorTiles)
        {
            if(tile.SteppedOn == false)
            {
                passed = false;
                break;
            }
        }
        return passed;
    }

    public void OpenDoor()
    {
        roomDoor.flipme();
    }

    public void ResetRoom()
    {
        roomDoor.forceCloseDoor();
        foreach (FloorTile tile in floorTiles)
        {
            tile.ResetObject();
        }
    }
}
