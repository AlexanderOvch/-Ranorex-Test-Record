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

namespace Test00
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RunApp recording.
    /// </summary>
    [TestModule("c6ff64e1-0c12-4e58-a5fb-ee7025ea6cd7", ModuleType.Recording, 1)]
    public partial class RunApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test00Repository repository.
        /// </summary>
        public static Test00Repository repo = Test00Repository.Instance;

        static RunApp instance = new RunApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RunApp()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RunApp Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\MyAssays\\MyAssays Desktop\\MyAssays.Desktop.Explorer.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\MyAssays\\MyAssays Desktop\\MyAssays.Desktop.Explorer.exe", "", "C:\\Program Files (x86)\\MyAssays\\MyAssays Desktop", false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
