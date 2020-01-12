using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        //Load Scenes Sequentially via build indices
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
