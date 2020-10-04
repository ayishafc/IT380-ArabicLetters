using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Script");
    }

    // Update is called once per frame
    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
