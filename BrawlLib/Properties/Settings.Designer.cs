﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrawlLib.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BrawlLib.Modeling.Collada ColladaImportOptions {
            get {
                return ((global::BrawlLib.Modeling.Collada)(this["ColladaImportOptions"]));
            }
            set {
                this["ColladaImportOptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideMDL0Errors {
            get {
                return ((bool)(this["HideMDL0Errors"]));
            }
            set {
                this["HideMDL0Errors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<BrawlLib.SSBB.ResourceNodes.CodeStorage> Codes {
            get {
                return ((global::System.Collections.Generic.List<BrawlLib.SSBB.ResourceNodes.CodeStorage>)(this["Codes"]));
            }
            set {
                this["Codes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveGCTWithInfo {
            get {
                return ((bool)(this["SaveGCTWithInfo"]));
            }
            set {
                this["SaveGCTWithInfo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public global::System.Nullable<System.Double> AudioVolumePercent {
            get {
                return ((global::System.Nullable<System.Double>)(this["AudioVolumePercent"]));
            }
            set {
                this["AudioVolumePercent"] = value;
            }
        }
    }
}
