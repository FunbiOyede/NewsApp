using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApp.Util
{
   public static class Settings
    {
        /// <summary>  
        /// This is the Settings static class that can be used in your Core solution or in any  
        /// of your client applications. All settings are laid out the same exact way with getters  
        /// and setters.   
        /// </summary>  
        /// 
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }


        #region Setting Keys

        private const string Api_Key = "Api_key";
        private static readonly string Api_Value = "0f108cb1c6744b3ba179a42e46b11f89";
       
        #endregion


        public static string API_KEY
        {
            get => AppSettings.GetValueOrDefault(Api_Key, Api_Value);

            set => AppSettings.AddOrUpdateValue(Api_Key, value);
        }
    }
}
