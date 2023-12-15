using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthAmericaDoor : MonoBehaviour
{
    private GameObject firstPersonController;
    private InteractRight interactRight;
    public GameObject rightHolder;
    private FlagCheck Flags;
    // Start is called before the first frame update
    void Start()
    {
        firstPersonController = GameObject.Find("FirstPersonController");
        interactRight = rightHolder.GetComponent<InteractRight>();
        Flags = FindObjectOfType<FlagCheck>();
    }
    

    // Update is called once per frame
    void Update()
    {
        bool Check = interactRight.Correct;
        if (isPlayerOnTop() && Check)
        {
            CheckFlag();
        }
    }

    private void CheckFlag()
    {
        Flags.SouthAmerica = true;
    }

    private bool isPlayerOnTop()
    {
        if (firstPersonController == null)
        {
            Debug.LogError("FirstPersonController reference not set in the inspector!");
            return false;
        }

        float xThreshold = 51;
        float zThreshold = 51;
        
        Vector3 playerPosition = firstPersonController.transform.position;
        if (Mathf.Abs(transform.position.x - playerPosition.x) < xThreshold &&
               Mathf.Abs(transform.position.z - playerPosition.z) < zThreshold){
                Debug.Log("standing on it");
                return true;
        } else {
            return false;
        }
    }
}

