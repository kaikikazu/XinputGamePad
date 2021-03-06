﻿# XinputGamePad

## Description
Unityがバックグラウンドにある（フォーカスが合っていない）場合でもジョイパッドの入力イベントを受け取ることができます。
妹尾雄大氏([@senooyudai](https://twitter.com/senooyudai))による[Unityでウィンドウが非アクティブでもジョイパッドの入力を取得する方法](http://blog.vrai.jp/article/463326756.html)を拡張して作られています。

Windowsでのみ動作します。

Xboxコントローラでのみ動作します。

![XinputGamePadListener.prefab](https://i.imgur.com/dJ9UhLn.gif)

## Dependency
 - Windows10
 - Unity2017.4.12f1
 - Xbox controller
 - UniVRM v0.46c 
 
 ※コントローラの動作確認としては[Xbox One ワイヤレス コントローラー (ブラック)](https://www.amazon.co.jp/gp/product/B01MZYWXI3/ref=oh_aui_detailpage_o00_s00?ie=UTF8&psc=1)を利用しました。なお、トリガーは安定していましたが、スティックの値は不安定だったので注意してください。

 ## Download package
[XinputGamePad.unitypackage](https://github.com/kaikikazu/XinputGamePad/releases/tag/0.2b)  

上記リンクからパッケージをDLし、Unityにインポートしてください。

## Setup
[UniRX](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)と[XinputGamePad](https://github.com/kaikikazu/XinputGamePad/releases/tag/0.2b)をインポートします。

`XinputGamePad\Prefabs\XinputGamePad\XinputGamePadListener.prefab`をシーン上に置きます。このオブジェクトがバックグラウンドで入力を監視してくれます。
![XinputGamePadListener.prefab](https://i.imgur.com/DXwAIBe.png)

コントローラのデバイス番号を指定できます。複数接続している場合は監視したいジョイパッドの番号になるようにしてください。

![DeviceNumber](https://i.imgur.com/bdrHBgv.png)

Vtuberでの使用も想定し、VRMモデルでのバックグラウンドフェイシャル変化のサンプルも用意しておきました。もしこちらのサンプルも動かす場合は[UniVRM](https://github.com/dwango/UniVRM)が必要となります。

## Usage
namespaceをincludeします。
```csharp
using UniRx;
using XinputGamePad
```
XinputGamePadListenerを宣言し、シーン上にある`XinputGamePadListener.prefab`をInspector上で入れます。
```csharp
public XinputGamePadListener GamePad;
```
以下のようにすることでボタンが押されたイベントを受け取れるようになります。押されているボタンを受け取れるため、特定のキーが現在押されているかどうかも確認できます(以下の例ではAボタンが押されているか確認している)。
```csharp
GamePad.OnButtonPushed.Subscribe(key =>
        {
            if(key == XinputKey.A){
		Debug.Log(key);
	    }
        }
)
```

左右のスティックの傾きを取得できます。なお、コントローラによって値がブレたりズレていたりするのでうまく調整して使ってください。
```csharp
Vector2 RightStick =　GamePad.GetRightStick();
Vector2 LeftStick =　GamePad.GetLeftStick()
```
左右のスティックのトリガーの押し込みを取得できます。なお、コントローラによって値がブレたりズレていたりするのでうまく調整して使ってください。
```csharp
XinputTriger Triger =  GamePad.GetTriger();
int RightTriger = Triger.Right;
int LeftTriger = Triger.Left;
```

# Authors
妹尾雄大([@senooyudai](https://twitter.com/senooyudai))

# References
[Unityでウィンドウが非アクティブでもジョイパッドの入力を取得する方法](http://blog.vrai.jp/article/463326756.html)

# License
MITライセンスとします。

Copyright <2018> \<kaiki kazuyoshi>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
