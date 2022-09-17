using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Change scene via sceneID 
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}