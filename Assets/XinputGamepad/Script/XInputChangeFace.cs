using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using XinputGamePad;
using VRM;

public class XInputChangeFace : MonoBehaviour {
	public XinputGamePadListener GamePad;
	public VRMBlendShapeProxy target;
	public Transform LookTarget;
	private Vector2 beforeStickPos;

	// Use this for initialization	
	void Start () {
		GamePad.OnButtonPushed.Subscribe(key =>
        {
			if(key == XinputKey.A){
                target.ImmediatelySetValue(BlendShapePreset.Fun, 1f);;
			}
			if(key == XinputKey.B){
                target.ImmediatelySetValue(BlendShapePreset.Angry, 1f);
			}
			if(key == XinputKey.X){
                target.ImmediatelySetValue(BlendShapePreset.Joy, 1f);
			}
			if(key == XinputKey.Y){
                target.ImmediatelySetValue(BlendShapePreset.Sorrow, 1f);
			}
        });
	}

	void Update(){
		target.ImmediatelySetValue(BlendShapePreset.Fun, 0f);
		target.ImmediatelySetValue(BlendShapePreset.Angry, 0f);
		target.ImmediatelySetValue(BlendShapePreset.Joy, 0f);
		target.ImmediatelySetValue(BlendShapePreset.Sorrow, 0f);
		target.ImmediatelySetValue(BlendShapePreset.Blink_R, Mathf.Clamp01(GamePad.GetTriger().Right));
		target.ImmediatelySetValue(BlendShapePreset.Blink_L, Mathf.Clamp01(GamePad.GetTriger().Left));

		Vector2 nowStickPos = GamePad.GetLeftStick();
		if(nowStickPos != beforeStickPos){
			if(nowStickPos.x > beforeStickPos.x){
				LookTarget.Rotate(0,3,0);
			}else if(nowStickPos.x < beforeStickPos.x){
				LookTarget.Rotate(0,-3,0);
			}
			if(nowStickPos.y > beforeStickPos.y){
				LookTarget.Rotate(3,0,0);
			}else if(nowStickPos.x < beforeStickPos.y){
				LookTarget.Rotate(-3,0,0);
			}
			LookTarget.rotation = Quaternion.Euler(Mathf.Clamp(LookTarget.localEulerAngles.x,-50,50), Mathf.Clamp(LookTarget.localEulerAngles.y,-50,50), 0f);
		}
		beforeStickPos = nowStickPos;
	}
}
