using UnityEngine;

public class WordBuilder : MonoBehaviour
{
    public string targetWord = "CAT"; //First word spelt in game 
    public int currentIndex = 0;

    public PlayerSFX sfx;   //for wrong and right sounds

    public bool TryAddLetter(char letter, out bool completedNow)
    {
        completedNow = false;

        if (letter == targetWord[currentIndex]) //check if letter matches required
        {
            currentIndex++;

            if (sfx != null)
                sfx.PlayCorrectLetter();  //word complete sfx 

            if (currentIndex >= targetWord.Length)
            {
                completedNow = true;

                if (sfx != null)
                    sfx.PlayCompletedWord();
            }

            return true;            //wrong and right sounds played 
        }

        if (sfx != null)
            sfx.PlayWrongLetter();

        return false;
    }

    public void ResetWord(string newWord)
    {
        targetWord = newWord;
        currentIndex = 0;               //word reset 
    }
}
