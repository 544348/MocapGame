using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenebutton : MonoBehaviour
{
    public void LoadScene()
    {
        // Load the specified scene
        SceneManager.LoadScene("SampleScene");
    }
}
