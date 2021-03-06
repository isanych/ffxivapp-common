﻿// FFXIVAPP.Common ~ Constants.cs
// 
// Copyright © 2007 - 2017 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using FFXIVAPP.Common.Helpers;

namespace FFXIVAPP.Common
{
    public static class Constants
    {
        public static readonly FlowDocHelper FD = new FlowDocHelper();

        public static string CachePath
        {
            get
            {
                try
                {
                    var location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    return Path.Combine(location, "FFXIVAPP");
                }
                catch
                {
                    return "./";
                }
            }
        }

        #region Directories

        public static string ConfigurationsPath
        {
            get { return Path.Combine(CachePath, "Configurations"); }
        }

        public static string LogsPath
        {
            get { return Path.Combine(CachePath, "Logs"); }
        }

        public static string ScreenShotsPath
        {
            get { return Path.Combine(CachePath, "ScreenShots"); }
        }

        public static string SoundsPath
        {
            get { return Path.Combine(CachePath, "Sounds"); }
        }

        public static string SettingsPath
        {
            get { return Path.Combine(CachePath, "Settings"); }
        }

        public static string PluginsSettingsPath
        {
            get { return Path.Combine(CachePath, "Settings", "Plugins"); }
        }

        #endregion

        #region Auto-Properties MAIN APPLICATION

        public static bool EnableNLog { get; set; }
        public static bool EnableNetworkReading { get; set; }

        public static Guid DefaultAudioDevice { get; set; }

        #endregion
    }
}
