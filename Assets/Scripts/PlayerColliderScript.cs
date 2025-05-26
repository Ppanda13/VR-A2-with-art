using UnityEngine;

public class PlayerColliderScript : MonoBehaviour
{
    public StepOnTileMaze[] rooms;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Transform>().position.y < 0.1)
        {
            Debug.Log("Player Hit Floor");
            foreach (StepOnTileMaze room in rooms)
            {
                room.ResetRoom();
                player.GetComponent<Transform>().position = new Vector3(0, 2, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Stepping on" + other.gameObject.name);
        FloorTile Below = other.gameObject.GetComponent<FloorTile>();
        if (Below != null) {
            Below.StepOn();
        }        
    }
}
