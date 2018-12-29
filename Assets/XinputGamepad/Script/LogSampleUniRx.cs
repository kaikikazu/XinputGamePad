using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using XinputGamePad;

public class LogSampleUniRx : MonoBehaviour {
	public XinputGamePadListener GamePad;

	// Use this for initialization	
	void Start () {
		GamePad.OnButtonPushed.Subscribe(key =>
        {
			if(key == XinputKey.LEFT){
				Debug.Log(key);
			}
			if(key == XinputKey.RIGHT){
				Debug.Log(key);
			}
			if(key == XinputKey.UP){
				Debug.Log(key);
			}
			if(key == XinputKey.DOWN){
				Debug.Log(key);
			}
			if(key == XinputKey.A){
				Debug.Log(key);
			}
			if(key == XinputKey.B){
				Debug.Log(key);
			}
			if(key == XinputKey.X){
				Debug.Log(key);
			}
			if(key == XinputKey.Y){
				Debug.Log(key);
			}
        });
	}

	void Update(){

		Debug.LogFormat("RightStick : ({0} , {1})\n",GamePad.GetRightStick().x,GamePad.GetRightStick().y);
		Debug.LogFormat("LeftStick : ({0} , {1})\n",GamePad.GetLeftStick().x,GamePad.GetLeftStick().y);
		Debug.Log("TrigerRight : " + GamePad.GetTriger().Right + " TrigerLeft : " + GamePad.GetTriger().Left);
	}
}
