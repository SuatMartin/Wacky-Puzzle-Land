using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractWrong : MonoBehaviour
{
    public GameObject FirstPersonController;
    System.Random random = new System.Random();
    private int randomNumber;

        
    private void Update()
    {
        if (isPlayerOnTop() && Input.GetKeyDown(KeyCode.E))
        {
            ToggleObjectState();
        }
    }

    private void ToggleObjectState()
    {
        randomNumber = random.Next(1, 6);
        if(randomNumber == 1){
            SceneManager.LoadScene("algeriaroom");
        } else if (randomNumber == 2){
            SceneManager.LoadScene("japanroom");
        } else if (randomNumber == 3){
            SceneManager.LoadScene("brazilroom");
        } else if (randomNumber == 4){
            SceneManager.LoadScene("icelandroom");
        } else {
            SceneManager.LoadScene("russiaroom");
        }
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
