using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using BackGroundGamepad;

public class LogSampleUniRx : MonoBehaviour {
	public BGPadListener GamePad;

	// Use this for initialization	
	void Start () {
		GamePad.OnTimeChanged.Subscribe(key =>
        {
			if(key == BGpadKey.LEFT){
				Debug.Log(key);
			}
			if(key == BGpadKey.RIGHT){
				Debug.Log(key);
			}
			if(key == BGpadKey.UP){
				Debug.Log(key);
			}
			if(key == BGpadKey.DOWN){
				Debug.Log(key);
			}
			if(key == BGpadKey.A){
				Debug.Log(key);
			}
			if(key == BGpadKey.B){
				Debug.Log(key);
			}
			if(key == BGpadKey.X){
				Debug.Log(key);
			}
			if(key == BGpadKey.Y){
				Debug.Log(key);
			}
        });
	}

	void Update(){
		// Debug.LogFormat("RightStick : ({0} , {1})\n",GamePad.GetRightStick().x,GamePad.GetRightStick().y);
		// Debug.LogFormat("LeftStick : ({0} , {1})\n",GamePad.GetLeftStick().x,GamePad.GetLeftStick().y);
		// Debug.Log("TrigerRight : " + GamePad.GetTriger().Right + " TrigerLeft : " + GamePad.GetTriger().Left);
	}
}
