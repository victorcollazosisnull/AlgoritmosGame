using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
   [SerializeField] private string scene;
    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }
    public void CloseGame()
    {
        Debug.Log("SalisteDelJuego");
        Application.Quit();
    }

}
