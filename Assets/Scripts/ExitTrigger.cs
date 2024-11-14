using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    [SerializeField] private string targetScene;
    
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(targetScene);
    }
}
