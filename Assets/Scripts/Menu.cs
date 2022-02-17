using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("Level");
    }
   public void Character()
    {
        SceneManager.LoadScene("Character");
    } 
}
