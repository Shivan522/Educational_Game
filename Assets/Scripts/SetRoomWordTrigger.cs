using UnityEngine;

public class SetRoomWordTrigger : MonoBehaviour
{
    public WordBuilder wordBuilder;
    public RoomProgress progress;   
    public string newWord = "FROG";     //sets the word 

    private bool used = false;

    private void OnTriggerEnter2D(Collider2D other) //sets word when player enters trigger 
    {
        if (used) return;
        if (!other.CompareTag("Player")) return;    //player can activate trigger 

        used = true;        //mark used so cant run again
    }
}
