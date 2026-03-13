using System.Numerics;
using UnityEngine;

public class RoomProgress : MonoBehaviour
{
    public bool wordCompleted = false;
    public GameObject animalPrefab; 

    public void MarkWordComplete()
    {
        wordCompleted = true;

    }
}
