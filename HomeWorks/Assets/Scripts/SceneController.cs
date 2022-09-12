
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
}
