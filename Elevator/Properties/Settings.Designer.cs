﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elevator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-3E20OVV\\SQLEXPRESS;AttachDbFilename=\"D:\\Настя\\Диплом\\ВКРБ Мих" +
            "еева\\База данных\\AccountingOfGrain.mdf\";Integrated Security=True")]
        public string contractorConnectionString {
            get {
                return ((string)(this["contractorConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-3E20OVV\\SQLEXPRESS;AttachDbFilename=\"D:\\Настя\\Диплом\\ВКРБ Мих" +
            "еева\\База данных\\AccountOfGrain.mdf\";Integrated Security=True")]
        public string AccountOfGrainConnectionString {
            get {
                return ((string)(this["AccountOfGrainConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-3E20OVV\\SQLEXPRESS;Initial Catalog=\"D:\\НАСТЯ\\ДИПЛОМ\\ВКРБ МИХЕ" +
            "ЕВА\\БАЗА ДАННЫХ\\ACCOUNTOFGRAIN.MDF\";Integrated Security=True")]
        public string AccountOfGrainElevator {
            get {
                return ((string)(this["AccountOfGrainElevator"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-3E20OVV\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\AccountOf" +
            "Grain.mdf;Integrated Security=True")]
        public string AccountOfGrainConnection {
            get {
                return ((string)(this["AccountOfGrainConnection"]));
            }
        }
    }
}
