using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZEGO;
namespace ZegoCsharpWinformDemo
{
    public partial class QuickStartDemo : Form
    {
        private ZegoExpressEngine engine;
        Random ran = new Random();
        public QuickStartDemo()
        {
            InitializeComponent();
        }

        private void PublishStream(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(publishSreamID.Text))
            {
                throw new Exception("publishSreamID should not be empty!");
            }
            ZegoCanvas preViewCanvas = new ZegoCanvas();
            preViewCanvas.view = pictureBox1.Handle;
            preViewCanvas.viewMode = ZegoViewMode.Fit;//设置有效
            engine.StartPreview(preViewCanvas);
            engine.StartPublishingStream(publishSreamID.Text);
        }

        private void PlayStream(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(playSreamId.Text))
            {
                throw new Exception("playSreamID should not be empty!");
            }
            ZegoCanvas playCanvas = new ZegoCanvas();
            playCanvas.view = pictureBox2.Handle;
            playCanvas.viewMode = ZegoViewMode.AspectFill;//设置有效  
            engine.StartPlayingStream(playSreamId.Text, playCanvas);
        }

        private void Load_1(object sender, EventArgs e)
        {
            string version = ZegoExpressEngine.GetVersion();
            System.Diagnostics.Debug.WriteLine("version:" + version);
            //填写自己申请的appId和appSign
            engine = ZegoExpressEngine.CreateEngine(GetAppIdConfig.appId, GetAppIdConfig.appSign, true, ZegoScenario.General, new SynchronizationContext());
            engine.SetDebugVerbose(true, ZegoLanguage.Chinese);
            engine.onDebugError = (errorCode, funcName, info) =>
            {
                System.Diagnostics.Debug.WriteLine("onDebugError errorCode:" + errorCode + "  funcName:" + funcName + "  info" + info);
            };
            engine.onRoomStateUpdate = (roomId, state, errorCode, extendedData) =>
            {
                System.Diagnostics.Debug.WriteLine("onRoomStateUpdate roomId:" + roomId + "  state:" + state);
            };
            engine.onPublisherStateUpdate = (streamId, state, errorCode, extendedData) =>
            {
                System.Diagnostics.Debug.WriteLine("onPublisherStateUpdate streamId:" + streamId + "  state:" + state + "  errorCode:" + errorCode);
            };
            engine.onPublisherQualityUpdate = (streamId, quality) =>
            {
                System.Diagnostics.Debug.WriteLine("onPublisherQualityUpdate streamId:" + streamId + "  quality:" + quality.quality);
            };
            engine.onPlayerQualityUpdate = (streamId, quality) =>
            {
                System.Diagnostics.Debug.WriteLine("onPlayerQualityUpdate streamId:" + streamId + "  quality:" + quality.quality);
            };

        }

        private void LoginRoom(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(roomId.Text))
            {
                throw new Exception("roomID should not be empty!");
            }
            Random ran = new Random();

            int userId = ran.Next(100, 10000);
            engine.LoginRoom(roomId.Text, new ZegoUser("user-" + userId));
        }
    }
}
