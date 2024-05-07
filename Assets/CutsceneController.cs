using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{

	public TextMeshPro Text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cutscene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Cutscene()
	{
	Text.text = "Stories...";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "An inevitable byproduct of human creativity...";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "Countless legends, fables and fairy tales passed down from generation to generation...";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "...though they change over time, remain the same at their very core.";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "But what would happen if the lines between stories get crossed?";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "That's what we're here to explore today...";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	 if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
	}
}
