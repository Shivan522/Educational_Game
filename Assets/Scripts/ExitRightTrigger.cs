

using UnityEngine;


public class ExitRightTrigger : MonoBehaviour
{
    public RoomProgress progress;               
    public bool requireWordComplete = false;        //only exits when word completes 
    public GameObject ActivateBarrier;  //Back barrier activates after triggering 
    public float DelayBarrier = 0.3f;

   

    private bool used = false;
    public float timer = -1f; 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (used) return;
        if (!other.CompareTag("Player")) return;    //To prevent problems, only the player can activate the barrier 

        used = true;
       
        if (ActivateBarrier != null)
        {
            timer = DelayBarrier; 
        }
    }

 private void Update()
    {
        if (timer < 0f) return;

        timer -= Time.deltaTime;
        if (timer <= 0f)                //adds slight delay to barrier activation 
        {
            timer = -1f;
            ActivateBarrier.SetActive(true);
        }
    }
}
