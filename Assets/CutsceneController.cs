using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{

	public TextMeshPro Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Cutscene()
	{
	Text.text = "Stories...";
	yield return null;
	}
}
