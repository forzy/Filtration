﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Filtration.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultFilterDirectory {
            get {
                return ((string)(this["DefaultFilterDirectory"]));
            }
            set {
                this["DefaultFilterDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExtraLineBetweenBlocks {
            get {
                return ((bool)(this["ExtraLineBetweenBlocks"]));
            }
            set {
                this["ExtraLineBetweenBlocks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SuppressUpdatesUpToVersionMajorPart {
            get {
                return ((int)(this["SuppressUpdatesUpToVersionMajorPart"]));
            }
            set {
                this["SuppressUpdatesUpToVersionMajorPart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SuppressUpdates {
            get {
                return ((bool)(this["SuppressUpdates"]));
            }
            set {
                this["SuppressUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SuppressUpdatesUpToVersionMinorPart {
            get {
                return ((int)(this["SuppressUpdatesUpToVersionMinorPart"]));
            }
            set {
                this["SuppressUpdatesUpToVersionMinorPart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2016-01-01")]
        public global::System.DateTime StaticDataLastUpdated {
            get {
                return ((global::System.DateTime)(this["StaticDataLastUpdated"]));
            }
            set {
                this["StaticDataLastUpdated"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://ben-wallis.github.io/Filtration/ItemBaseTypes.txt")]
        public string ItemBaseTypesStaticDataUrl {
            get {
                return ((string)(this["ItemBaseTypesStaticDataUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://ben-wallis.github.io/Filtration/ItemClasses.txt")]
        public string ItemClassesStaticDataUrl {
            get {
                return ((string)(this["ItemClassesStaticDataUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://ben-wallis.github.io/Filtration/filtration_version.xml")]
        public string UpdateDataUrl {
            get {
                return ((string)(this["UpdateDataUrl"]));
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowSectionBrowser
        {
            get
            {
                return ((bool)(this["ShowSectionBrowser"]));
            }
            set
            {
                this["ShowSectionBrowser"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowBlockGroupBrowser
        {
            get
            {
                return ((bool)(this["ShowBlockGroupBrowser"]));
            }
            set
            {
                this["ShowBlockGroupBrowser"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowBlockOutputPreview
        {
            get
            {
                return ((bool)(this["ShowBlockOutputPreview"]));
            }
            set
            {
                this["ShowBlockOutputPreview"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowAdvanced
        {
            get
            {
                return ((bool)(this["ShowAdvanced"]));
            }
            set
            {
                this["ShowAdvanced"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.WindowState WindowState
        {
            get
            {
                return ((global::System.Windows.WindowState)(this["WindowState"]));
            }
            set
            {
                this["WindowState"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("960")]
        public int WindowWidth
        {
            get
            {
                return ((int)(this["WindowWidth"]));
            }
            set
            {
                this["WindowWidth"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("720")]
        public int WindowHeight
        {
            get
            {
                return ((int)(this["WindowHeight"]));
            }
            set
            {
                this["WindowHeight"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastActiveDocument
        {
            get
            {
                return ((string)(this["LastActiveDocument"]));
            }
            set
            {
                this["LastActiveDocument"] = value;
            }
        }
    }
}
