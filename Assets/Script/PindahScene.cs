using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public string namaScene;
    public void PindahKeSceneBaru()
    {
        SceneManager.LoadScene(namaScene);
    }
}
