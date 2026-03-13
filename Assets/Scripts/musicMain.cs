using UnityEngine;

public class musicMain : MonoBehaviour
{
    public static musicMain instance;

    void Awake()
    {
        if (instance != null && instance != this)   //makes sure only one music plays 
        {
            Destroy(gameObject);        //plays when game is opened 
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);  //allows music to play through scenes 
    }
}
