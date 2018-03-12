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
    ///The CreateNewMicroplate recording.
    /// </summary>
    [TestModule("1feb6012-4260-4009-9fee-26739c7755e1", ModuleType.Recording, 1)]
    public partial class CreateNewMicroplate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test00Repository repository.
        /// </summary>
        public static Test00Repository repo = Test00Repository.Instance;

        static CreateNewMicroplate instance = new CreateNewMicroplate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewMicroplate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewMicroplate Instance
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer' at 44;2.", repo.NewProtocolWizard.SomeContainerInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.SomeContainer.Click("44;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.ListView' at 61;29.", repo.MyAssaysDesktopExplorer.ListViewInfo, new RecordItemIndex(1));
            repo.MyAssaysDesktopExplorer.ListView.Click("61;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.SomeList.LargeImage1' at 8;17.", repo.LayoutEditor.SomeList.LargeImage1Info, new RecordItemIndex(2));
            repo.LayoutEditor.SomeList.LargeImage1.Click("8;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.PARTElementPlateGrid.MAINRECT' at 516;357.", repo.LayoutEditor.PARTElementPlateGrid.MAINRECTInfo, new RecordItemIndex(3));
            repo.LayoutEditor.PARTElementPlateGrid.MAINRECT.Click("516;357");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='(null)') on item 'LayoutEditor.PARTElementPlateGrid.TEXT15'.", repo.LayoutEditor.PARTElementPlateGrid.TEXT15Info, new RecordItemIndex(4));
            Validate.Attribute(repo.LayoutEditor.PARTElementPlateGrid.TEXT15Info, "Text", (string)null);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.ElementPlateRibbonBar.PARTImage' at 9;30.", repo.LayoutEditor.ElementPlateRibbonBar.PARTImageInfo, new RecordItemIndex(5));
            repo.LayoutEditor.ElementPlateRibbonBar.PARTImage.Click("9;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LayoutEditor.PARTElementPlateGrid.RootCanvas'.", repo.LayoutEditor.PARTElementPlateGrid.RootCanvasInfo, new RecordItemIndex(6));
            Validate.Exists(repo.LayoutEditor.PARTElementPlateGrid.RootCanvasInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LayoutEditor.PARTElementPlateGrid.MAINRECT'.", repo.LayoutEditor.PARTElementPlateGrid.MAINRECTInfo, new RecordItemIndex(7));
            Validate.Exists(repo.LayoutEditor.PARTElementPlateGrid.MAINRECTInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='(null)') on item 'LayoutEditor.PARTElementPlateGrid.TEXT0'.", repo.LayoutEditor.PARTElementPlateGrid.TEXT0Info, new RecordItemIndex(8));
            Validate.Attribute(repo.LayoutEditor.PARTElementPlateGrid.TEXT0Info, "Text", (string)null);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.SomeList.SomeContainer' at 3;27.", repo.LayoutEditor.SomeList.SomeContainerInfo, new RecordItemIndex(9));
            repo.LayoutEditor.SomeList.SomeContainer.Click("3;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.PARTElementPlateGrid.MAINRECT' at 61;50.", repo.LayoutEditor.PARTElementPlateGrid.MAINRECTInfo, new RecordItemIndex(10));
            repo.LayoutEditor.PARTElementPlateGrid.MAINRECT.Click("61;50");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LayoutEditor.PARTElementPlateGrid.LAYOUT0'.", repo.LayoutEditor.PARTElementPlateGrid.LAYOUT0Info, new RecordItemIndex(11));
            Validate.Exists(repo.LayoutEditor.PARTElementPlateGrid.LAYOUT0Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'LayoutEditor.PARTElementPlateGrid.TEXT0'.", repo.LayoutEditor.PARTElementPlateGrid.TEXT0Info, new RecordItemIndex(12));
            Validate.Attribute(repo.LayoutEditor.PARTElementPlateGrid.TEXT0Info, "Text", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'LayoutEditor.DoubleTextBox'.", repo.LayoutEditor.DoubleTextBoxInfo, new RecordItemIndex(13));
            Validate.Attribute(repo.LayoutEditor.DoubleTextBoxInfo, "Text", "2");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.ElementPlateRibbonBar.Remove' at 30;6.", repo.LayoutEditor.ElementPlateRibbonBar.RemoveInfo, new RecordItemIndex(14));
            repo.LayoutEditor.ElementPlateRibbonBar.Remove.Click("30;6");
            Delay.Milliseconds(0);
            
            // ????
            //Report.Log(ReportLevel.Info, "Validation", "????\r\nValidating CompareImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=216,Height=512}) on item 'LayoutEditor.PARTElementPlateGrid.PARTElementPlateListView'.", repo.LayoutEditor.PARTElementPlateGrid.PARTElementPlateListViewInfo, new RecordItemIndex(15));
            //Validate.CompareImage(repo.LayoutEditor.PARTElementPlateGrid.PARTElementPlateListViewInfo, PARTElementPlateListView_Screenshot3, PARTElementPlateListView_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.ElementPlateRibbonBar.Duplicate' at 8;3.", repo.LayoutEditor.ElementPlateRibbonBar.DuplicateInfo, new RecordItemIndex(16));
            repo.LayoutEditor.ElementPlateRibbonBar.Duplicate.Click("8;3");
            Delay.Milliseconds(200);
            
            // ????
            //Report.Log(ReportLevel.Info, "Validation", "????\r\nValidating CompareImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=216,Height=512}) on item 'LayoutEditor.PARTElementPlateGrid.PARTElementPlateListView'.", repo.LayoutEditor.PARTElementPlateGrid.PARTElementPlateListViewInfo, new RecordItemIndex(17));
            //Validate.CompareImage(repo.LayoutEditor.PARTElementPlateGrid.PARTElementPlateListViewInfo, PARTElementPlateListView_Screenshot2, PARTElementPlateListView_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LayoutEditor.SomeList.Clear' at 14;7.", repo.LayoutEditor.SomeList.ClearInfo, new RecordItemIndex(18));
            repo.LayoutEditor.SomeList.Clear.Click("14;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='(null)') on item 'LayoutEditor.PARTElementPlateGrid.TEXT0'.", repo.LayoutEditor.PARTElementPlateGrid.TEXT0Info, new RecordItemIndex(19));
            Validate.Attribute(repo.LayoutEditor.PARTElementPlateGrid.TEXT0Info, "Text", (string)null);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'NewProtocolWizard'.", repo.NewProtocolWizard.SelfInfo, new RecordItemIndex(20));
            Host.Local.CloseApplication(repo.NewProtocolWizard.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage PARTElementPlateListView_Screenshot3
        { get { return repo.LayoutEditor.PARTElementPlateGrid.PARTElementPlateListViewInfo.GetScreenshot3(new Rectangle(0, 0, 216, 512)); } }

        Imaging.FindOptions PARTElementPlateListView_Screenshot3_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,216,512;True;10000000;0ms"); } }

        CompressedImage PARTElementPlateListView_Screenshot2
        { get { return repo.LayoutEditor.PARTElementPlateGrid.PARTElementPlateListViewInfo.GetScreenshot2(new Rectangle(0, 0, 216, 512)); } }

        Imaging.FindOptions PARTElementPlateListView_Screenshot2_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,216,512;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}
