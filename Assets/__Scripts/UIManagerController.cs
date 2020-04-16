using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
    }
}
