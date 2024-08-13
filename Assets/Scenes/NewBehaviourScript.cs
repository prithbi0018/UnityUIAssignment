using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void GoBackToMasterScene()
    {
        SceneManager.LoadScene("MasterScene");

    }
    public void GoTONextScene(int nextscene)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + nextscene);
    }
}
