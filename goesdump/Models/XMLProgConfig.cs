﻿using System;
using System.Configuration;

namespace OpenSatelliteProject {
    sealed class XMLProgConfig: ApplicationSettingsBase {

        #region Web Server
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("8090")]
        public int HTTPPort {
            get { return (int)this["HTTPPort"]; }
            set { this["HTTPPort"] = value; }
        }
        #endregion

        #region Folders
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("tmp")]
        public string TemporaryFileFolder {
            get { return (string)this["TemporaryFileFolder"]; }
            set { this["TemporaryFileFolder"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("output")]
        public string FinalFileFolder {
            get { return (string)this["FinalFileFolder"]; }
            set { this["FinalFileFolder"] = value; }
        }
        #endregion

        #region Decoder Data

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool RecordIntermediateFile {
            get { return (bool)this["RecordIntermediateFile"]; }
            set { this["RecordIntermediateFile"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("5001")]
        public int ChannelDataServerPort {
            get { return (int)this["ChannelDataServerPort"]; }
            set { this["ChannelDataServerPort"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("5002")]
        public int StatisticsServerPort {
            get { return (int)this["StatisticsServerPort"]; }
            set { this["StatisticsServerPort"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("9000")]
        public int ConstellationServerPort {
            get { return (int)this["ConstellationServerPort"]; }
            set { this["ConstellationServerPort"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("localhost")]
        public string ChannelDataServerName {
            get { return (string)this["ChannelDataServerName"]; }
            set { this["ChannelDataServerName"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("localhost")]
        public string StatisticsServerName {
            get { return (string)this["StatisticsServerName"]; }
            set { this["StatisticsServerName"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("localhost")]
        public string ConstellationServerName {
            get { return (string)this["ConstellationServerName"]; }
            set { this["ConstellationServerName"] = value; }
        }
        #endregion

        #region Image Processing
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool GenerateVisibleImages {
            get { return (bool)this["GenerateVisibleImages"]; }
            set { this["GenerateVisibleImages"] = value; }
        }
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool GenerateInfraredImages {
            get { return (bool)this["GenerateInfraredImages"]; }
            set { this["GenerateInfraredImages"] = value; }
        }
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool GenerateWaterVapourImages {
            get { return (bool)this["GenerateWaterVapourImages"]; }
            set { this["GenerateWaterVapourImages"] = value; }
        }
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("3")]
        public int MaxGenerateRetry {
            get { return (int)this["MaxGenerateRetry"]; }
            set { this["MaxGenerateRetry"] = value; }
        }
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("true")]
        public bool GenerateFDFalseColor {
            get { return (bool)this["GenerateFDFalseColor"]; }
            set { this["GenerateFDFalseColor"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("true")]
        public bool GenerateXXFalseColor {
            get { return (bool)this["GenerateXXFalseColor"]; }
            set { this["GenerateXXFalseColor"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("true")]
        public bool GenerateNHFalseColor {
            get { return (bool)this["GenerateNHFalseColor"]; }
            set { this["GenerateNHFalseColor"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("true")]
        public bool GenerateSHFalseColor {
            get { return (bool)this["GenerateSHFalseColor"]; }
            set { this["GenerateSHFalseColor"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("true")]
        public bool GenerateUSFalseColor {
            get { return (bool)this["GenerateUSFalseColor"]; }
            set { this["GenerateUSFalseColor"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool EraseFilesAfterGeneratingFalseColor {
            get { return (bool)this["EraseFilesAfterGeneratingFalseColor"]; }
            set { this["EraseFilesAfterGeneratingFalseColor"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool UseNOAAFormat {
            get { return (bool)this["UseNOAAFormat"]; }
            set { this["UseNOAAFormat"] = value; }
        }

        #endregion

        #region Packet Processing
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool EnableDCS {
            get { return (bool)this["EnableDCS"]; }
            set { this["EnableDCS"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")]
        public bool EnableEMWIN {
            get { return (bool)this["EnableEMWIN"]; }
            set { this["EnableEMWIN"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("true")]
        public bool EnableWeatherData {
            get { return (bool)this["EnableWeatherData"]; }
            set { this["EnableWeatherData"] = value; }
        }
        #endregion

        #region Syslog Configuration
        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("localhost")]
        public string SysLogServer {
            get { return (string)this["SysLogServer"]; }
            set { this["SysLogServer"] = value; }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("LOG_USER")]
        public string SysLogFacility {
            get { return (string)this["SysLogFacility"]; }
            set { this["SysLogFacility"] = value; }
        }
        #endregion
    }
}

