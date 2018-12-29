using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace BackGroundGamepad{
	public class BGPadListener : MonoBehaviour {
		public int DeviceNumber;
		private BGpadKey key;
		private Subject<BGpadKey> buttonSubject = new Subject<BGpadKey>();
		public IObservable<BGpadKey> OnTimeChanged
		{
			get { return buttonSubject; }
		} 
		
		void Update () {
			DllConst.Capture();
			int Buttons = DllConst.GetButtons(DeviceNumber);

			// 方向（デジタル）
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_LEFT) != 0){
				buttonSubject.OnNext(BGpadKey.LEFT);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_RIGHT) != 0){
				buttonSubject.OnNext(BGpadKey.RIGHT);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_UP) != 0){
				buttonSubject.OnNext(BGpadKey.UP);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_DPAD_DOWN) != 0){
				buttonSubject.OnNext(BGpadKey.DOWN);
			}

			// ABXYボタン
			if((Buttons & InputConst.XINPUT_GAMEPAD_A) != 0){
				buttonSubject.OnNext(BGpadKey.A);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_B) != 0){
				buttonSubject.OnNext(BGpadKey.B);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_X) != 0){
				buttonSubject.OnNext(BGpadKey.X);
			}
			if((Buttons & InputConst.XINPUT_GAMEPAD_Y) != 0){
				buttonSubject.OnNext(BGpadKey.Y);
			}
		}

		public BGpadTriger GetTriger(){
			BGpadTriger triger = new BGpadTriger();
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