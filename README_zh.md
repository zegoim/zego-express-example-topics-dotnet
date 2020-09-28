# Zego Express Example Topics DotNet (c#)

[English](README.md) | [中文](README_zh.md)

Zego Express Example Topics DotNet (c#) 示例专题 Demo

## 下载 SDK

此 Repository 中可能缺少运行 Demo 工程所需的SDK ，您需要解压SDK,然后在项目中引用ZegoExpress Csharp.dll，并将ZegoExpressEngine.dll拷贝到编译输出二进制的目录下（与exe目录同个目录下）

**[https://storage.zego.im/express/video/windows-csharp/zego-express-video-windows-csharp.zip](https://storage.zego.im/express/video/windows-csharp/zego-express-video-windows-csharp.zip)**


## 填写 SDK 所需的 appID 与 appSign

到 [ZEGO 管理控制台](https://console-express.zego.im/acount/register) 申请 appID 与 appSign , 然后将其填入 `GetAppIdConfig.cs`文件中，否则在首次编译时会在这个文件报错。