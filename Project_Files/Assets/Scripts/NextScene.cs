using UnityEngine.SceneManagement;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    public void newScene() {

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
