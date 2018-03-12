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
    ///The EditeSamples recording.
    /// </summary>
    [TestModule("512b4497-ad0b-46aa-999b-ce727385f14b", ModuleType.Recording, 1)]
    public partial class EditeSamples : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test00Repository repository.
        /// </summary>
        public static Test00Repository repo = Test00Repository.Instance;

        static EditeSamples instance = new EditeSamples();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditeSamples()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditeSamples Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer1' at 135;87.", repo.NewProtocolWizard.SomeContainer1Info, new RecordItemIndex(0));
            repo.NewProtocolWizard.SomeContainer1.Click("135;87");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.EditButton' at 64;9.", repo.NewProtocolWizard.EditButtonInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.EditButton.Click("64;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTImage1' at 23;22.", repo.RackLayoutEditor.PARTElementRibbon.PARTImage1Info, new RecordItemIndex(2));
            repo.RackLayoutEditor.PARTElementRibbon.PARTImage1.Click("23;22");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementAddButtonTextBlock' at 45;9.", repo.RackLayoutEditor.PARTElementAddButtonTextBlockInfo, new RecordItemIndex(3));
            repo.RackLayoutEditor.PARTElementAddButtonTextBlock.Click("45;9");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.PARTRowsPresenter.Row0'.", repo.RackLayoutEditor.PARTRowsPresenter.Row0Info, new RecordItemIndex(4));
            Validate.Exists(repo.RackLayoutEditor.PARTRowsPresenter.Row0Info);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.PARTRowsPresenter.Row5'.", repo.RackLayoutEditor.PARTRowsPresenter.Row5Info, new RecordItemIndex(5));
            Validate.Exists(repo.RackLayoutEditor.PARTRowsPresenter.Row5Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTImage2' at 16;19.", repo.RackLayoutEditor.PARTElementRibbon.PARTImage2Info, new RecordItemIndex(6));
            repo.RackLayoutEditor.PARTElementRibbon.PARTImage2.Click("16;19");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'RackLayoutEditor.PARTRowsPresenter.Row0'.", repo.RackLayoutEditor.PARTRowsPresenter.Row0Info, new RecordItemIndex(7));
            Validate.NotExists(repo.RackLayoutEditor.PARTRowsPresenter.Row0Info);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'RackLayoutEditor.PARTRowsPresenter.Row5'.", repo.RackLayoutEditor.PARTRowsPresenter.Row5Info, new RecordItemIndex(8));
            Validate.NotExists(repo.RackLayoutEditor.PARTRowsPresenter.Row5Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTImage3' at 13;32.", repo.RackLayoutEditor.PARTElementRibbon.PARTImage3Info, new RecordItemIndex(9));
            repo.RackLayoutEditor.PARTElementRibbon.PARTImage3.Click("13;32");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.PARTRowsPresenter.Row0'.", repo.RackLayoutEditor.PARTRowsPresenter.Row0Info, new RecordItemIndex(10));
            Validate.Exists(repo.RackLayoutEditor.PARTRowsPresenter.Row0Info);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.PARTRowsPresenter.Row5'.", repo.RackLayoutEditor.PARTRowsPresenter.Row5Info, new RecordItemIndex(11));
            Validate.Exists(repo.RackLayoutEditor.PARTRowsPresenter.Row5Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.Preview' at 34;9.", repo.RackLayoutEditor.PARTElementRibbon.PreviewInfo, new RecordItemIndex(12));
            repo.RackLayoutEditor.PARTElementRibbon.Preview.Click("34;9");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.SomeContainer1.PARTElementPreviewImage'.", repo.RackLayoutEditor.SomeContainer1.PARTElementPreviewImageInfo, new RecordItemIndex(13));
            Validate.Exists(repo.RackLayoutEditor.SomeContainer1.PARTElementPreviewImageInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'RackLayoutEditor.PARTElementRibbon.SomeElement' at 23;10.", repo.RackLayoutEditor.PARTElementRibbon.SomeElementInfo, new RecordItemIndex(14));
            repo.RackLayoutEditor.PARTElementRibbon.SomeElement.MoveTo("23;10");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'RackLayoutEditor.PARTElementRibbon.SomeElement' at 31;2.", repo.RackLayoutEditor.PARTElementRibbon.SomeElementInfo, new RecordItemIndex(15));
            repo.RackLayoutEditor.PARTElementRibbon.SomeElement.MoveTo("31;2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'RackLayoutEditor.PARTElementRibbon.LargeImage' at 10;17.", repo.RackLayoutEditor.PARTElementRibbon.LargeImageInfo, new RecordItemIndex(16));
            repo.RackLayoutEditor.PARTElementRibbon.LargeImage.MoveTo("10;17");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2'.", new RecordItemIndex(17));
            Keyboard.Press("2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTImage' at 3;11.", repo.RackLayoutEditor.PARTElementRibbon.PARTImageInfo, new RecordItemIndex(18));
            repo.RackLayoutEditor.PARTElementRibbon.PARTImage.Click("3;11");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.SomeContainer1.PARTElementPreviewImage'.", repo.RackLayoutEditor.SomeContainer1.PARTElementPreviewImageInfo, new RecordItemIndex(19));
            Validate.Exists(repo.RackLayoutEditor.SomeContainer1.PARTElementPreviewImageInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'RackLayoutEditor.PARTElementRibbon.SomeElement' at 16;7.", repo.RackLayoutEditor.PARTElementRibbon.SomeElementInfo, new RecordItemIndex(20));
            repo.RackLayoutEditor.PARTElementRibbon.SomeElement.MoveTo("16;7");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'RackLayoutEditor.PARTElementRibbon.SomeElement' at 24;-1.", repo.RackLayoutEditor.PARTElementRibbon.SomeElementInfo, new RecordItemIndex(21));
            repo.RackLayoutEditor.PARTElementRibbon.SomeElement.MoveTo("24;-1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'RackLayoutEditor.PARTElementRibbon.PARTElementSequencingRibbonBar' at 62;48.", repo.RackLayoutEditor.PARTElementRibbon.PARTElementSequencingRibbonBarInfo, new RecordItemIndex(22));
            repo.RackLayoutEditor.PARTElementRibbon.PARTElementSequencingRibbonBar.MoveTo("62;48");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-'.", new RecordItemIndex(23));
            Keyboard.Press("-");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0'.", new RecordItemIndex(24));
            Keyboard.Press("0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTElementSequenceButton' at 6;8.", repo.RackLayoutEditor.PARTElementRibbon.PARTElementSequenceButtonInfo, new RecordItemIndex(25));
            repo.RackLayoutEditor.PARTElementRibbon.PARTElementSequenceButton.Click("6;8");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='numberOfSamples : 0 is invalid, it must be more than 0') on item 'RackLayoutEditor.NumberOfSamples0IsInvalidItMust'.", repo.RackLayoutEditor.NumberOfSamples0IsInvalidItMustInfo, new RecordItemIndex(26));
            Validate.Attribute(repo.RackLayoutEditor.NumberOfSamples0IsInvalidItMustInfo, "Text", "numberOfSamples : 0 is invalid, it must be more than 0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'RackLayoutEditor.PARTElementRibbon.SomeElement' at 16;7.", repo.RackLayoutEditor.PARTElementRibbon.SomeElementInfo, new RecordItemIndex(27));
            repo.RackLayoutEditor.PARTElementRibbon.SomeElement.MoveTo("16;7");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'RackLayoutEditor.PARTElementRibbon.SomeElement' at 24;-1.", repo.RackLayoutEditor.PARTElementRibbon.SomeElementInfo, new RecordItemIndex(28));
            repo.RackLayoutEditor.PARTElementRibbon.SomeElement.MoveTo("24;-1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'RackLayoutEditor.PARTElementRibbon.PARTElementSequencingRibbonBar' at 62;48.", repo.RackLayoutEditor.PARTElementRibbon.PARTElementSequencingRibbonBarInfo, new RecordItemIndex(29));
            repo.RackLayoutEditor.PARTElementRibbon.PARTElementSequencingRibbonBar.MoveTo("62;48");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '38'.", new RecordItemIndex(30));
            Keyboard.Press("38");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTImage' at 5;13.", repo.RackLayoutEditor.PARTElementRibbon.PARTImageInfo, new RecordItemIndex(31));
            repo.RackLayoutEditor.PARTElementRibbon.PARTImage.Click("5;13");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SomeContainer' at 9;8.", repo.RackLayoutEditor.SomeContainer1.SomeContainerInfo, new RecordItemIndex(32));
            repo.RackLayoutEditor.SomeContainer1.SomeContainer.Click("9;8");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.SomeListItem1' at 91;7.", repo.MyAssaysDesktopExplorer.SomeListItem1Info, new RecordItemIndex(33));
            repo.MyAssaysDesktopExplorer.SomeListItem1.Click("91;7");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SomeElement1' at 63;11.", repo.RackLayoutEditor.SomeContainer1.SomeElement1Info, new RecordItemIndex(34));
            repo.RackLayoutEditor.SomeContainer1.SomeElement1.Click("63;11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SomeElement1' at 63;11.", repo.RackLayoutEditor.SomeContainer1.SomeElement1Info, new RecordItemIndex(35));
            repo.RackLayoutEditor.SomeContainer1.SomeElement1.Click("63;11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.Upbutton1' at 7;3.", repo.RackLayoutEditor.SomeContainer1.Upbutton1Info, new RecordItemIndex(36));
            repo.RackLayoutEditor.SomeContainer1.Upbutton1.Click("7;3");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SomeElement' at 56;10.", repo.RackLayoutEditor.SomeContainer1.SomeElementInfo, new RecordItemIndex(37));
            repo.RackLayoutEditor.SomeContainer1.SomeElement.Click("56;10");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.Upbuttonpath1' at 6;0.", repo.RackLayoutEditor.SomeContainer1.Upbuttonpath1Info, new RecordItemIndex(38));
            repo.RackLayoutEditor.SomeContainer1.Upbuttonpath1.Click("6;0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.PARTElementAddSampleButton' at 244;10.", repo.RackLayoutEditor.SomeContainer1.PARTElementAddSampleButtonInfo, new RecordItemIndex(39));
            repo.RackLayoutEditor.SomeContainer1.PARTElementAddSampleButton.Click("244;10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'RackLayoutEditor.PARTRowsPresenter.Cell23'.", repo.RackLayoutEditor.PARTRowsPresenter.Cell23Info, new RecordItemIndex(40));
            Validate.Attribute(repo.RackLayoutEditor.PARTRowsPresenter.Cell23Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'RackLayoutEditor.PARTRowsPresenter.Cell2'.", repo.RackLayoutEditor.PARTRowsPresenter.Cell2Info, new RecordItemIndex(41));
            Validate.Attribute(repo.RackLayoutEditor.PARTRowsPresenter.Cell2Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.SomeCell5' at 110;13.", repo.RackLayoutEditor.PARTRowsPresenter.SomeCell5Info, new RecordItemIndex(42));
            repo.RackLayoutEditor.PARTRowsPresenter.SomeCell5.Click("110;13");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.PARTElementChangeStateTextBlock' at 11;1.", repo.MyAssaysDesktopExplorer.PARTElementChangeStateTextBlockInfo, new RecordItemIndex(43));
            repo.MyAssaysDesktopExplorer.PARTElementChangeStateTextBlock.Click("11;1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.SomeCell3' at 77;11.", repo.RackLayoutEditor.PARTRowsPresenter.SomeCell3Info, new RecordItemIndex(44));
            repo.RackLayoutEditor.PARTRowsPresenter.SomeCell3.Click("77;11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTImage4' at 17;22.", repo.RackLayoutEditor.PARTElementRibbon.PARTImage4Info, new RecordItemIndex(45));
            repo.RackLayoutEditor.PARTElementRibbon.PARTImage4.Click("17;22");
            
            // ????
            //Report.Log(ReportLevel.Info, "Validation", "????\r\nValidating CompareImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=325,Height=25}) on item 'RackLayoutEditor.PARTRowsPresenter.Row5'.", repo.RackLayoutEditor.PARTRowsPresenter.Row5Info, new RecordItemIndex(46));
            //Validate.CompareImage(repo.RackLayoutEditor.PARTRowsPresenter.Row5Info, Row5_Screenshot3, Row5_Screenshot3_Options);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.SomeCell3' at 99;9.", repo.RackLayoutEditor.PARTRowsPresenter.SomeCell3Info, new RecordItemIndex(47));
            repo.RackLayoutEditor.PARTRowsPresenter.SomeCell3.Click("99;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.SomePicture' at 24;3.", repo.MyAssaysDesktopExplorer.SomePictureInfo, new RecordItemIndex(48));
            repo.MyAssaysDesktopExplorer.SomePicture.Click("24;3");
            
            // ????
            //Report.Log(ReportLevel.Info, "Validation", "????\r\nValidating CompareImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=325,Height=25}) on item 'RackLayoutEditor.PARTRowsPresenter.Row5'.", repo.RackLayoutEditor.PARTRowsPresenter.Row5Info, new RecordItemIndex(49));
            //Validate.CompareImage(repo.RackLayoutEditor.PARTRowsPresenter.Row5Info, Row5_Screenshot2, Row5_Screenshot2_Options);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.Cell23' at 60;11.", repo.RackLayoutEditor.PARTRowsPresenter.Cell23Info, new RecordItemIndex(50));
            repo.RackLayoutEditor.PARTRowsPresenter.Cell23.Click("60;11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.Downbuttonpath1' at 4;1.", repo.RackLayoutEditor.PARTRowsPresenter.Downbuttonpath1Info, new RecordItemIndex(51));
            repo.RackLayoutEditor.PARTRowsPresenter.Downbuttonpath1.Click("4;1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.Cell51' at 10;9.", repo.RackLayoutEditor.PARTRowsPresenter.Cell51Info, new RecordItemIndex(52));
            repo.RackLayoutEditor.PARTRowsPresenter.Cell51.Click("10;9");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'RackLayoutEditor.PARTRowsPresenter.Cell23'.", repo.RackLayoutEditor.PARTRowsPresenter.Cell23Info, new RecordItemIndex(53));
            Validate.Attribute(repo.RackLayoutEditor.PARTRowsPresenter.Cell23Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.Downbuttonpath1' at 4;3.", repo.RackLayoutEditor.PARTRowsPresenter.Downbuttonpath1Info, new RecordItemIndex(54));
            repo.RackLayoutEditor.PARTRowsPresenter.Downbuttonpath1.Click("4;3");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.SomeCell5' at 117;15.", repo.RackLayoutEditor.PARTRowsPresenter.SomeCell5Info, new RecordItemIndex(55));
            repo.RackLayoutEditor.PARTRowsPresenter.SomeCell5.Click("117;15");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'RackLayoutEditor.PARTRowsPresenter.Cell51'.", repo.RackLayoutEditor.PARTRowsPresenter.Cell51Info, new RecordItemIndex(56));
            Validate.Attribute(repo.RackLayoutEditor.PARTRowsPresenter.Cell51Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.SomeContainer' at 6;5.", repo.RackLayoutEditor.PARTRowsPresenter.SomeContainerInfo, new RecordItemIndex(57));
            repo.RackLayoutEditor.PARTRowsPresenter.SomeContainer.Click("6;5");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.SomeListItem' at 69;12.", repo.MyAssaysDesktopExplorer.SomeListItemInfo, new RecordItemIndex(58));
            repo.MyAssaysDesktopExplorer.SomeListItem.Click("69;12");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.SomeCell8' at 151;14.", repo.RackLayoutEditor.PARTRowsPresenter.SomeCell8Info, new RecordItemIndex(59));
            repo.RackLayoutEditor.PARTRowsPresenter.SomeCell8.Click("151;14");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.PARTRowsPresenter.Row6'.", repo.RackLayoutEditor.PARTRowsPresenter.Row6Info, new RecordItemIndex(60));
            Validate.Exists(repo.RackLayoutEditor.PARTRowsPresenter.Row6Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SplitToggleButton' at 17;16.", repo.RackLayoutEditor.SomeContainer1.SplitToggleButtonInfo, new RecordItemIndex(61));
            repo.RackLayoutEditor.SomeContainer1.SplitToggleButton.Click("17;16");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.SplitListView' at 219;37.", repo.MyAssaysDesktopExplorer.SplitListViewInfo, new RecordItemIndex(62));
            repo.MyAssaysDesktopExplorer.SplitListView.Click("219;37");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SomeContainer1' at 130;2.", repo.RackLayoutEditor.SomeContainer1.SomeContainer1Info, new RecordItemIndex(63));
            repo.RackLayoutEditor.SomeContainer1.SomeContainer1.Click("130;2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.PARTRowsPresenter.Row6'.", repo.RackLayoutEditor.PARTRowsPresenter.Row6Info, new RecordItemIndex(64));
            Validate.Exists(repo.RackLayoutEditor.PARTRowsPresenter.Row6Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTRowsPresenter.SomeCell3' at 122;8.", repo.RackLayoutEditor.PARTRowsPresenter.SomeCell3Info, new RecordItemIndex(65));
            repo.RackLayoutEditor.PARTRowsPresenter.SomeCell3.Click("122;8");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SplitToggleButton' at 26;19.", repo.RackLayoutEditor.SomeContainer1.SplitToggleButtonInfo, new RecordItemIndex(66));
            repo.RackLayoutEditor.SomeContainer1.SplitToggleButton.Click("26;19");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.SplitListView' at 241;9.", repo.MyAssaysDesktopExplorer.SplitListViewInfo, new RecordItemIndex(67));
            repo.MyAssaysDesktopExplorer.SplitListView.Click("241;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SomeContainer' at 6;9.", repo.RackLayoutEditor.SomeContainer1.SomeContainerInfo, new RecordItemIndex(68));
            repo.RackLayoutEditor.SomeContainer1.SomeContainer.Click("6;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.Control' at 38;5.", repo.MyAssaysDesktopExplorer.ControlInfo, new RecordItemIndex(69));
            repo.MyAssaysDesktopExplorer.Control.Click("38;5");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.MainButton' at 247;12.", repo.RackLayoutEditor.SomeContainer1.MainButtonInfo, new RecordItemIndex(70));
            repo.RackLayoutEditor.SomeContainer1.MainButton.Click("247;12");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RackLayoutEditor.PARTRowsPresenter.Row6'.", repo.RackLayoutEditor.PARTRowsPresenter.Row6Info, new RecordItemIndex(71));
            Validate.Exists(repo.RackLayoutEditor.PARTRowsPresenter.Row6Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.PARTImage1' at 20;28.", repo.RackLayoutEditor.PARTElementRibbon.PARTImage1Info, new RecordItemIndex(72));
            repo.RackLayoutEditor.PARTElementRibbon.PARTImage1.Click("20;28");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.SomeContainer1.SomeContainer' at 13;16.", repo.RackLayoutEditor.SomeContainer1.SomeContainerInfo, new RecordItemIndex(73));
            repo.RackLayoutEditor.SomeContainer1.SomeContainer.Click("13;16");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopExplorer.Standard' at 47;9.", repo.MyAssaysDesktopExplorer.StandardInfo, new RecordItemIndex(74));
            repo.MyAssaysDesktopExplorer.Standard.Click("47;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementAddButtonTextBlock' at 11;13.", repo.RackLayoutEditor.PARTElementAddButtonTextBlockInfo, new RecordItemIndex(75));
            repo.RackLayoutEditor.PARTElementAddButtonTextBlock.Click("11;13");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RackLayoutEditor.PARTElementRibbon.And' at 14;9.", repo.RackLayoutEditor.PARTElementRibbon.AndInfo, new RecordItemIndex(76));
            repo.RackLayoutEditor.PARTElementRibbon.And.Click("14;9");
            
            // ????
            //Report.Log(ReportLevel.Info, "Validation", "????\r\nValidating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=260,Height=177}) on item 'NewProtocolWizard.SomeContainer1'.", repo.NewProtocolWizard.SomeContainer1Info, new RecordItemIndex(77));
            //Validate.CompareImage(repo.NewProtocolWizard.SomeContainer1Info, SomeContainer1_Screenshot1, SomeContainer1_Screenshot1_Options);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.Next' at 28;3.", repo.NewProtocolWizard.SomeContainer2.NextInfo, new RecordItemIndex(78));
            repo.NewProtocolWizard.SomeContainer2.Next.Click("28;3");
            
        }

#region Image Feature Data
        CompressedImage Row5_Screenshot3
        { get { return repo.RackLayoutEditor.PARTRowsPresenter.Row5Info.GetScreenshot3(new Rectangle(0, 0, 325, 25)); } }

        Imaging.FindOptions Row5_Screenshot3_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,325,25;True;10000000;0ms"); } }

        CompressedImage Row5_Screenshot2
        { get { return repo.RackLayoutEditor.PARTRowsPresenter.Row5Info.GetScreenshot2(new Rectangle(0, 0, 325, 25)); } }

        Imaging.FindOptions Row5_Screenshot2_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,325,25;True;10000000;0ms"); } }

        CompressedImage SomeContainer1_Screenshot1
        { get { return repo.NewProtocolWizard.SomeContainer1Info.GetScreenshot1(new Rectangle(0, 0, 260, 177)); } }

        Imaging.FindOptions SomeContainer1_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,260,177;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}
