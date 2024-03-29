﻿using System;

namespace NotepadSharp
{
    public class TextHandler
    {
        private static TextHandler _instance;

        public string Text { get; set; } = string.Empty;
        
        
        public TextHandler()
        {
            
        }

        public static TextHandler GetTextHandler()
        {
            if (_instance == null)
                _instance = new TextHandler();

            return _instance;
        }
    }
}