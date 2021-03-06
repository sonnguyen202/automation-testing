﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenBrowser recording.
    /// </summary>
    [TestModule("0083ae9b-4a71-4b76-a206-f9b4208d29a7", ModuleType.Recording, 1)]
    public partial class OpenBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static OpenBrowser instance = new OpenBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://hoclieu.sachmem.vn/folder/0' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://hoclieu.sachmem.vn/folder/0", "chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Add}{Add}{Add}{Add}{LControlKey up}'.", new RecordItemIndex(1));
            Keyboard.Press("{LControlKey down}{Add}{Add}{Add}{Add}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(2));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}'.", new RecordItemIndex(3));
            Keyboard.Press("{LControlKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}'.", new RecordItemIndex(5));
            Keyboard.Press("{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1320 units.", new RecordItemIndex(6));
            Mouse.ScrollWheel(-1320);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1080 units.", new RecordItemIndex(7));
            Mouse.ScrollWheel(1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{LControlKey up}{LControlKey down}{Subtract}{Subtract}{LControlKey up}{LControlKey down}{LControlKey down}{Add}{Add}{Add}{Add}{LControlKey up}{LControlKey down}{Add}{Add}{LControlKey up}'.", new RecordItemIndex(8));
            Keyboard.Press("{LControlKey down}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{Subtract}{LControlKey up}{LControlKey down}{Subtract}{Subtract}{LControlKey up}{LControlKey down}{LControlKey down}{Add}{Add}{Add}{Add}{LControlKey up}{LControlKey down}{Add}{Add}{LControlKey up}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
