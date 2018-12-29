using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace XinputGamePad{
	public class XinputGamePadListener : MonoBehaviour {
		public int DeviceNumber;
		private XinputKey key;
		private Subject<XinputKey> buttonSubject = new Subject<XinputKey>();
		public IObservable<XinputKey> OnTimeChanged
		{
			get { return buttonSubject; }
		} 
		
		void Update () {
			DllConst.Capture();
			int Buttons = DllConst.GetButtons(DeviceNumber);

			// 方向（デジタル）
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_LEFT) != 0){
				buttonSubject.OnNext(XinputKey.LEFT);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_RIGHT) != 0){
				buttonSubject.OnNext(XinputKey.RIGHT);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_UP) != 0){
				buttonSubject.OnNext(XinputKey.UP);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_DOWN) != 0){
				buttonSubject.OnNext(XinputKey.DOWN);
			}

			// ABXYボタン
			if((Buttons & InputConst.XINPUT_GAMEPAD_A) != 0){
				buttonSubject.OnNext(XinputKey.A);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_B) != 0){
				buttonSubject.OnNext(XinputKey.B);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_X) != 0){
				buttonSubject.OnNext(XinputKey.X);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_Y) != 0){
				buttonSubject.OnNext(XinputKey.Y);
			}
		}

		public XinputTriger GetTriger(){
			XinputTriger triger = new XinputTriger();
			triger.Right = DllConst.GetRightTrigger(DeviceNumber);
			triger.Left = DllConst.GetLeftTrigger(DeviceNumber);
			return triger;
		}

		public Vector2 GetLeftStick(){
			return new Vector2(DllConst.GetThumbLX(DeviceNumber),DllConst.GetThumbLY(DeviceNumber));
		}
		public Vector2 GetRightStick(){
			return new Vector2(DllConst.GetThumbRX(DeviceNumber),DllConst.GetThumbRY(DeviceNumber));
		}
	}
}