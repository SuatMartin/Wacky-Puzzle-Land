using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchBotMiddle : MonoBehaviour
{
    private GameObject firstPersonController;
    private InteractRight interactRight;
    public GameObject rightHolder;
    // Start is called before the first frame update
    void Start()
    {
        firstPersonController = GameObject.Find("FirstPersonController");
        interactRight = rightHolder.GetComponent<InteractRight>();
    }
    

    // Update is called once per frame
    void Update()
    {
        bool Check = interactRight.Correct;
        Debug.Log(Check);
        if (isPlayerOnTop() && Check)
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        interactRight.Correct = false;
        SceneManager.LoadScene("bottommiddle");
    }

    private bool isPlayerOnTop()
    {
        if (firstPersonController == null)
        {
            Debug.LogError("FirstPersonController reference not set in the inspector!");
            return false;
        }

        float xThreshold = 50;
        float zThreshold = 50;
        
        Vector3 playerPosition = firstPersonController.transform.position;
        Debug.Log(transform.position.x +" " +playerPosition.x);
        Debug.Log(transform.position.z +" " +playerPosition.z);
        if (Mathf.Abs(transform.position.x - playerPosition.x) < xThreshold &&
               Mathf.Abs(transform.position.z - playerPosition.z) < zThreshold){
                Debug.Log("standing on it");
                return true;
        } else {
            return false;
        }
    }
}
