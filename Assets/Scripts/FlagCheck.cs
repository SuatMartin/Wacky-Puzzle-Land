using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagCheck : MonoBehaviour
{
    private static FlagCheck _instance;

    // Boolean flags for continents
    public bool Asia;
    public bool Europe;
    public bool Africa;
    public bool Oceania;
    public bool NorthAmerica;
    public bool SouthAmerica;

    private void Awake()
    {
        // Ensure only one instance of this script exists
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(Asia && Europe && Africa && Oceania && NorthAmerica && SouthAmerica){
            Asia = false;
            SceneManager.LoadScene("algeriaroom");
        }
    }
}
