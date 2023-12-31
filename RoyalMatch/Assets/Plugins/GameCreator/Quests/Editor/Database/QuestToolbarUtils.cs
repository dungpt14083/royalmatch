﻿namespace GameCreator.Quests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEditor;

    public abstract class QuestToolbarUtils
    {
        public enum ContentType
        {
            Quest,
            Task,
            Delete
        }

        public enum ContentStyle
        {
            TextAndIcon,
            TextOnly,
            IconOnly
        }

        private static readonly string[] NAMES = new string[]
        {
            "Quest",
            "Task",
            "Delete"
        };

        private static readonly string[] TOOLTIPS = new string[]
        {
            "Add a new Quest",
            "Add a new Task",
            "Delete Quest or Task"
        };

        private const string ICONS_PATH = "Assets/Plugins/GameCreator/Quests/Icons/Toolbar/{0}";
        private static readonly string[] ICONS = new string[]
        {
            "Quest.png",
            "Task.png",
            "Delete.png"
        };

        private class ContentData
        {
            public GUIContent[] content;

            public ContentData(string name, Texture2D icon, string tooltip = "")
            {
                this.content = new GUIContent[]
                {
                    new GUIContent(name, icon, tooltip),
                    new GUIContent(name, tooltip),
                    new GUIContent(icon, tooltip)
                };
            }

            public GUIContent Get(ContentStyle style)
            {
                return this.content[(int)style];
            }
        }

        // PROPERTIES: ----------------------------------------------------------------------------

        private static Dictionary<int, ContentData> DATA;

        // PUBLIC STATIC METHODS: -----------------------------------------------------------------

        public static GUIContent GetContent(ContentType type, ContentStyle style)
        {
            QuestToolbarUtils.RequireDataSetup();
            return DATA[(int)type].Get(style);
        }

        // PRIVATE STATIC METHODS: ----------------------------------------------------------------

        private static void RequireDataSetup()
        {
            if (DATA != null) return;

            DATA = new Dictionary<int, ContentData>();

            int contentLength = Enum.GetNames(typeof(ContentType)).Length;
            for (int i = 0; i < contentLength; ++i)
            {
                string path = string.Format(ICONS_PATH, ICONS[i]);
                Texture2D iconTexture = AssetDatabase.LoadAssetAtPath<Texture2D>(path);

                ContentData data = new ContentData(
                    NAMES[i],
                    iconTexture,
                    TOOLTIPS[i]
                );

                DATA.Add(i, data);
            }
        }
    }
}