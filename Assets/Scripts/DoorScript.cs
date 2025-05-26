using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isup;
    public Animator Dooranimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Dooranimator.SetBool("IsUp", isup);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void flipme()
    {
        if (isup)
        {
            isup = false;
        }
        else
        {
            isup = true;
        }
        Dooranimator.SetBool("IsUp", isup);
    }

    public void forceCloseDoor()
    {
        isup = false;
        Dooranimator.SetBool("IsUp", isup);
    }

    public void forceOpenDoor()
    {
        isup = true;
        Dooranimator.SetBool("IsUp", isup);
    }
}
