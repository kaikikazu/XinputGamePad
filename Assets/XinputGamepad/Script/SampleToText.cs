using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using BackGroundGamepad;

public class SampleToText : MonoBehaviour {
	

	//
	[SerializeField]
	Text		text;
	
	// Update is called once per frame
	void Update()
	{
		if (!text) return;

		DllConst.Capture();

		//
		string ShowText = "";

		for (int DeviceIndex = 0; DeviceIndex < InputConst.XUSER_MAX_COUNT; DeviceIndex++) {
			int Buttons = DllConst.GetButtons(DeviceIndex);

			// デバイス番号
			ShowText += string.Format("Device : {0} {1}\n", DeviceIndex, DllConst.IsConnected(DeviceIndex));

			// 方向（デジタル）
			ShowText += string.Format("LRUD : {0} {1} {2} {3}\n",
				(((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_LEFT) != 0) ? 1 : 0),
				(((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_RIGHT) != 0) ? 1 : 0),
				(((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_UP) != 0) ? 1 : 0),
				(((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_DOWN) != 0) ? 1 : 0));

			// ABXYボタン
			ShowText += string.Format("ABXY : {0} {1} {2} {3}\n",
				(((Buttons & InputConst.XINPUT_GAMEPAD_A) != 0) ? 1 : 0),
				(((Buttons & InputConst.XINPUT_GAMEPAD_B) != 0) ? 1 : 0),
				(((Buttons & InputConst.XINPUT_GAMEPAD_X) != 0) ? 1 : 0),
				(((Buttons & InputConst.XINPUT_GAMEPAD_Y) != 0) ? 1 : 0));

			// トリガー
			ShowText += string.Format("TriggerLR : {0} {1}\n",
				DllConst.GetLeftTrigger(DeviceIndex),
				DllConst.GetRightTrigger(DeviceIndex));

			// 軸（アナログ）
			ShowText += string.Format("Thumb {0}, {1}, {2}, {3}\n",
				DllConst.GetThumbLX(DeviceIndex),
				DllConst.GetThumbLY(DeviceIndex),
				DllConst.GetThumbRX(DeviceIndex),
				DllConst.GetThumbRX(DeviceIndex));

			//
			ShowText += "\n";
		}

		//
		text.text = ShowText;
	}
}
