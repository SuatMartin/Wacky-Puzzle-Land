using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractWrong : MonoBehaviour
{
    public GameObject FirstPersonController;

    private void Update()
    {
        if (isPlayerOnTop() && Input.GetKeyDown(KeyCode.E))
        {
            ToggleObjectState();
        }
    }

    private void ToggleObjectState()
    {
        SceneManager.LoadScene("topleft");
    }

     private bool isPlayerOnTop()
    {
        if (FirstPersonController == null)
        {
            Debug.LogError("FirstPersonController reference not set in the inspector!");
            return false;
        }

        float xThreshold = 50;
        float zThreshold = 50;
        
        Vector3 playerPosition = FirstPersonController.transform.position;
        if (Mathf.Abs(transform.position.x - playerPosition.x) < xThreshold &&
               Mathf.Abs(transform.position.z - playerPosition.z) < zThreshold){
                Debug.Log("standing on it");
                return true;
        } else {
            return false;
        }
    }
}
