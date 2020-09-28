# Zego Express Example Topics DotNet (c#)

[English](README.md) | [Chinese](README_zh.md)

Zego Express Example Topics DotNet (c#)

## Download SDK

The SDK required to run the Demo project may be missing from this Repository. You need to unzip the SDK, then reference ZegoExpress Csharp.dll in the project, and copy ZegoExpressEngine.dll to the directory where the compiled binary is output (in the same directory as the exe directory).
**[https://storage.zego.im/express/video/windows-csharp/zego-express-video-windows-csharp.zip](https://storage.zego.im/express/video/windows-csharp/zego-express-video-windows-csharp.zip)**

```

## Fill in the appID and appSign required by the SDK

Go to [ZEGO Management Console](https://console-express.zego.im/acount/register) and apply for appID and appSign, then fill it in the `GetAppIdConfig.cs` file, otherwise compile for the first time Will report an error in this file.