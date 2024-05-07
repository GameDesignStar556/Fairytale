using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpZoneController : MonoBehaviour
{

    public FirstPersonController FP;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
		if (FP.InZone == true) 
		{
			SceneManager.LoadScene("WonderlandScene1");
		}
	}
    }
}
