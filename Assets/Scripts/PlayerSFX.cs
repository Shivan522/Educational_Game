using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip CorrectLetterSound;        //all correct, incorrect, and finished sounds are attached to player 
    public AudioClip WrongLetterSound;
    public AudioClip WordCompletedJingle;

    public void PlayCorrectLetter()
    {
        audioSource.PlayOneShot(CorrectLetterSound);    
    }

    public void PlayWrongLetter()
    {
        audioSource.PlayOneShot(WrongLetterSound);
    }

    public void PlayCompletedWord()
    {
        audioSource.PlayOneShot(WordCompletedJingle);
    }
}
