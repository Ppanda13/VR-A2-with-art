using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public List<DoorScript> doors;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void flipstates()
    {
        foreach (DoorScript door in doors)
        {
            Debug.Log("Flipping " + door.gameObject.name);
            door.flipme();
        }
    }
}
