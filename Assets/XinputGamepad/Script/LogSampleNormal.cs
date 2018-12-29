using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using BackGroundGamepad;

public class LogSampleNormal : MonoBehaviour {
	public int DeviceNumber;

	void Update()
	{
		DllConst.Capture();
		int Buttons = DllConst.GetButtons(DeviceNumber);
		
		// 方向（デジタル）
		if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_LEFT) != 0){
			Debug.Log("Left");
		}
		if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_RIGHT) != 0){
			Debug.Log("Right");
		}
		if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_UP) != 0){
			Debug.Log("Up");
		}
		if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_DOWN) != 0){
			Debug.Log("Down");
		}

		// ABXYボタン
		if((Buttons & InputConst.XINPUT_GAMEPAD_A) != 0){
			Debug.Log("A");
		}
		if((Buttons & InputConst.XINPUT_GAMEPAD_B) != 0){
			Debug.Log("B");
		}
		if((Buttons & InputConst.XINPUT_GAMEPAD_X) != 0){
			Debug.Log("X");
		}
		if((Buttons & InputConst.XINPUT_GAMEPAD_Y) != 0){
			Debug.Log("Y");
		}

		// トリガー
		if(DllConst.GetLeftTrigger(DeviceNumber) != 0){
			Debug.Log("LeftTriger : " + DllConst.GetLeftTrigger(DeviceNumber));
		}
		if(DllConst.GetRightTrigger(DeviceNumber) != 0){
			Debug.Log("RightTriger : " + DllConst.GetRightTrigger(DeviceNumber));
		}

		// 軸（アナログ）
		if((DllConst.GetThumbLX(DeviceNumber)) != 0){
			Debug.Log("ThumbLX : " + DllConst.GetThumbLX(DeviceNumber));
		}
		if((DllConst.GetThumbLY(DeviceNumber)) != 0){
			Debug.Log("ThumbLY : " + DllConst.GetThumbLY(DeviceNumber));
		}
		if(DllConst.GetThumbRX(DeviceNumber) != 0){
			Debug.Log("ThumbRX : " + DllConst.GetThumbRX(DeviceNumber));
		}
		if(DllConst.GetThumbRX(DeviceNumber) != 0){
			Debug.Log("ThumbRY : " + DllConst.GetThumbRX(DeviceNumber));
		}
	}
}
