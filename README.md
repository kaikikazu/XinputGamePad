# XinputGamePad
## Download package
For Unity 2017.4 : [XinputGamePad.unitypackage](https://github.com/kaikikazu/XinputGamePad/releases/tag/0.2b)  

上記リンクからパッケージをDLし、Unityにインポートしてください。

## Description
Unityがバックグラウンドにある（フォーカスが合っていない）場合でもジョイパッドの入力イベントを受け取ることができるようにしたライブラリです。
妹尾雄大氏([@senooyudai](https://twitter.com/senooyudai))による[Unityでウィンドウが非アクティブでもジョイパッドの入力を取得する方法](http://blog.vrai.jp/article/463326756.html)を拡張して作られています。

Windowsのみ動作します。

Xboxコントローラでのみ動作します。

## Usage
[UniRX](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)と[XinputGamePad](https://github.com/kaikikazu/XinputGamePad/releases/tag/0.2b)をインポートします。

namespaceをincludeします。
```csharp
using UniRx;
using BackGroundGamepad
```

