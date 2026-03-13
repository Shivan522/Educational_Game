using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    
    public AudioSource audioSource;
    public AudioClip clickSound;

    public GameObject HowToPlay; 
    public void buttonMainGame()
    {
        Invoke(nameof(LoadScene), 0.15f);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("MainGame");     //Play Button
    }

    public void audioOnClick()
    {
        audioSource.PlayOneShot(clickSound);    //Play audio on click 
    }

        public void buttonExit()
    {
        Debug.Log("Exit Clicked");  //exit button

        Application.Quit(); 
    }

public void mainGameMenuButton()
{
    SceneManager.LoadScene("MainMenu"); //main menu button from main game
}


}






