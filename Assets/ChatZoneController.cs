using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatZoneController : MonoBehaviour
{

    public FirstPersonController FP;
    public NPCAliceScript Alice;
    public TextMeshPro Text;
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
		StartCoroutine(AliceDialogue());
		}
	}
    }

	public IEnumerator AliceDialogue()
	{
	Text.text = "Good heavens! Are you okay?";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "That must've been some fall!";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "Welcome to Wonderland! Not many people have fallen from the sky in a while!";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "I'm Alice! What's your name?";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "...";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "Red, huh? Nice to meetcha!";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
	yield return null;
	Text.text = "Since you're new to Wonderland, I'll show you around!";
	while (!Input.GetKeyDown(KeyCode.Space))
	{
		yield return null;
	}
}}
