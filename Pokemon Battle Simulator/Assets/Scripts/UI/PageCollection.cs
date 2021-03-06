﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RDUI
{
    public static class PageCollection
    {
        public static string EditPage = "EditPage";
        public static string StartPage = "StartPage";
        public static string BattlePage = "BattlePage";
        private static Dictionary<string, string> scenePages = new Dictionary<string, string>()
        {          
            {"MainScene","StartPage|EditPage|BattlePage"}
        };
        public static string GetPages(string _sceneName)
        {
            if(scenePages.ContainsKey(_sceneName))
            {
                return scenePages[_sceneName]; 
            }
            else
            {
                return null;
            }
        }
    }
}


