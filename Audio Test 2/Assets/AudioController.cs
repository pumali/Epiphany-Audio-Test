using UnityEngine;
using System.Collections;
using UnityEngine.Audio; 

public class AudioController : MonoBehaviour {

	public AudioMixerSnapshot tutorialBegin; 
	public AudioMixerSnapshot tutorialPuzzle1;
	public AudioMixerSnapshot tutorialPuzzle2;
	public AudioMixerSnapshot tutorialPuzzle3;
	public AudioMixerSnapshot LevelComplete;

	bool isNormal = true; 

	// makes basic tune play at start of level
	void Start () {
		tutorialBegin.TransitionTo (.2f); 
		isNormal = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	//NEED CODE HERE TO REFERENCE PLAYER STATE "THIRD/SIXTH"//
		if (Input.GetMouseButtonDown (0)) {
			if (isNormal) {
				tutorialPuzzle1.TransitionTo (.2f);
				isNormal = false; 
			} else {
				tutorialBegin.TransitionTo (.2f); 
				isNormal = true;
			}
		} 

		else if (Input.GetKeyDown ("space")) 
		{
			if (isNormal) 
			{
				tutorialPuzzle2.TransitionTo (.2f);
				isNormal = false; 
			} 
			else 
			{
				tutorialBegin.TransitionTo (.2f); 
				isNormal = true;
			}
		}
}
}
