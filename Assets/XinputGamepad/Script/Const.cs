using System.Runtime.InteropServices;

namespace XinputGamePad{

	public static class DllConst{
		[DllImport ("XInputCapture")] public static extern void	Capture();

		// 状態取得
		[DllImport ("XInputCapture")] public static extern bool	IsConnected(int DeviceNumber);

		[DllImport ("XInputCapture")] public static extern int		GetButtons(int DeviceNumber);

		[DllImport ("XInputCapture")] public static extern int		GetLeftTrigger(int DeviceNumber);
		[DllImport ("XInputCapture")] public static extern int		GetRightTrigger(int DeviceNumber);

		[DllImport ("XInputCapture")] public static extern int		GetThumbLX(int DeviceNumber);
		[DllImport ("XInputCapture")] public static extern int		GetThumbLY(int DeviceNumber);
		[DllImport ("XInputCapture")] public static extern int		GetThumbRX(int DeviceNumber);
		[DllImport ("XInputCapture")] public static extern int		GetThumbRY(int DeviceNumber);
	}

	public static class InputConst{
		// XInput定数
		public static readonly int	XUSER_MAX_COUNT = 4;
		public static readonly int XINPUT_GAMEPAD_DPAD_UP          = 0x0001;
		public static readonly int XINPUT_GAMEPAD_DPAD_DOWN        = 0x0002;
		public static readonly int XINPUT_GAMEPAD_DPAD_LEFT        = 0x0004;
		public static readonly int XINPUT_GAMEPAD_DPAD_RIGHT       = 0x0008;
		public static readonly int XINPUT_GAMEPAD_START            = 0x0010;
		public static readonly int XINPUT_GAMEPAD_BACK             = 0x0020;
		public static readonly int XINPUT_GAMEPAD_LEFT_THUMB       = 0x0040;
		public static readonly int XINPUT_GAMEPAD_RIGHT_THUMB      = 0x0080;
		public static readonly int XINPUT_GAMEPAD_LEFT_SHOULDER    = 0x0100;
		public static readonly int XINPUT_GAMEPAD_RIGHT_SHOULDER   = 0x0200;
		public static readonly int XINPUT_GAMEPAD_A                = 0x1000;
		public static readonly int XINPUT_GAMEPAD_B                = 0x2000;
		public static readonly int XINPUT_GAMEPAD_X                = 0x4000;
		public static readonly int XINPUT_GAMEPAD_Y                = 0x8000;

		public static readonly int XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE  = 7849;
		public static readonly int XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE = 8689;
		public static readonly int XINPUT_GAMEPAD_TRIGGER_THRESHOLD    = 30;
	}
}
