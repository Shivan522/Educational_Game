using TMPro;
using UnityEngine;

public class GateWall : MonoBehaviour
{

    public RoomProgress Roomprogress; 

    public Collider2D wallCollider; //prevents player from progressing 
    public bool opened = false;     //checks gate status 

    void Start()
    {
        wallCollider = GetComponent<Collider2D>();  
 
    }

    void Update()
    {
        if(opened) return; 
        if (Roomprogress != null && Roomprogress.wordCompleted) //check for room progress 
        {
            wallCollider.enabled = false;       //marks the gate as opened 
            opened = true; 
        }
    }
}
