using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject[] Character = new GameObject[16];
    public void Generate() 
    {
        CharacterSelector.RandomSelector();
    }
    public void Play() 
    {
        SceneManager.LoadScene(1);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
