﻿using UnityEngine;
using UnityEditor;

namespace Crosstales.TrueRandom.EditorUtil
{
    /// <summary>Editor helper class.</summary>
    public static class EditorHelper
    {
        #region Static variables

        /// <summary>Start index inside the "GameObject"-menu.</summary>
        //public const int GO_ID = 28;
        public const int GO_ID = 20;

        /// <summary>Start index inside the "Tools"-menu.</summary>
        public const int MENU_ID = 12018;// 1, T = 20, R = 18

        private static Texture2D logo_asset;
        private static Texture2D logo_asset_small;
        private static Texture2D logo_ct;
        private static Texture2D logo_unity;

        private static Texture2D icon_save;
        private static Texture2D icon_reset;
        private static Texture2D icon_plus;
        private static Texture2D icon_minus;
        private static Texture2D icon_generate;

        private static Texture2D icon_manual;
        private static Texture2D icon_api;
        private static Texture2D icon_forum;
        private static Texture2D icon_product;

        private static Texture2D icon_check;

        private static Texture2D social_Facebook;
        private static Texture2D social_Twitter;
        private static Texture2D social_Youtube;
        private static Texture2D social_Linkedin;
        private static Texture2D social_Xing;

        private static Texture2D video_promo;
        private static Texture2D video_tutorial;

        private static Texture2D icon_videos;

        private static Texture2D store_PlayMaker;

        private static Texture2D icon_3p_assets;

        #endregion


        #region Static properties

        public static Texture2D Logo_Asset
        {
            get
            {
                if (Util.Constants.isPro)
                {
                    return loadImage(ref logo_asset, "logo_asset_pro.png");
                }
                else
                {
                    return loadImage(ref logo_asset, "logo_asset.png");
                }
            }
        }
        
        public static Texture2D Logo_Asset_Small
        {
            get
            {
                if (Util.Constants.isPro)
                {
                    return loadImage(ref logo_asset_small, "logo_asset_small_pro.png");
                }
                else
                {
                    return loadImage(ref logo_asset_small, "logo_asset_small.png");
                }
            }
        }

        public static Texture2D Logo_CT
        {
            get
            {
                return loadImage(ref logo_ct, "logo_ct.png");
            }
        }

        public static Texture2D Logo_Unity
        {
            get
            {
                return loadImage(ref logo_unity, "logo_unity.png");
            }
        }

        public static Texture2D Icon_Save
        {
            get
            {
                return loadImage(ref icon_save, "icon_save.png");
            }
        }

        public static Texture2D Icon_Reset
        {
            get
            {
                return loadImage(ref icon_reset, "icon_reset.png");
            }
        }

        public static Texture2D Icon_Plus
        {
            get
            {
                return loadImage(ref icon_plus, "icon_plus.png");
            }
        }

        public static Texture2D Icon_Minus
        {
            get
            {
                return loadImage(ref icon_minus, "icon_minus.png");
            }
        }

        public static Texture2D Icon_Generate
        {
            get
            {
                return loadImage(ref icon_generate, "icon_generate.png");
            }
        }

        public static Texture2D Icon_Manual
        {
            get
            {
                return loadImage(ref icon_manual, "icon_manual.png");
            }
        }

        public static Texture2D Icon_API
        {
            get
            {
                return loadImage(ref icon_api, "icon_api.png");
            }
        }

        public static Texture2D Icon_Forum
        {
            get
            {
                return loadImage(ref icon_forum, "icon_forum.png");
            }
        }

        public static Texture2D Icon_Product
        {
            get
            {
                return loadImage(ref icon_product, "icon_product.png");
            }
        }

        public static Texture2D Icon_Check
        {
            get
            {
                return loadImage(ref icon_check, "icon_check.png");
            }
        }

        public static Texture2D Social_Facebook
        {
            get
            {
                return loadImage(ref social_Facebook, "social_Facebook.png");
            }
        }

        public static Texture2D Social_Twitter
        {
            get
            {
                return loadImage(ref social_Twitter, "social_Twitter.png");
            }
        }

        public static Texture2D Social_Youtube
        {
            get
            {
                return loadImage(ref social_Youtube, "social_Youtube.png");
            }
        }

        public static Texture2D Social_Linkedin
        {
            get
            {
                return loadImage(ref social_Linkedin, "social_Linkedin.png");
            }
        }

        public static Texture2D Social_Xing
        {
            get
            {
                return loadImage(ref social_Xing, "social_Xing.png");
            }
        }

        public static Texture2D Video_Promo
        {
            get
            {
                return loadImage(ref video_promo, "video_promo.png");
            }
        }

        public static Texture2D Video_Tutorial
        {
            get
            {
                return loadImage(ref video_tutorial, "video_tutorial.png");
            }
        }

        public static Texture2D Icon_Videos
        {
            get
            {
                return loadImage(ref icon_videos, "icon_videos.png");
            }
        }

        public static Texture2D Store_PlayMaker
        {
            get
            {
                return loadImage(ref store_PlayMaker, "store_PlayMaker.png");
            }
        }

        public static Texture2D Icon_3p_Assets
        {
            get
            {
                return loadImage(ref icon_3p_assets, "icon_3p_assets.png");
            }
        }

        #endregion


        #region Static methods

        /// <summary>Shows a "True Random unavailable"-UI.</summary>
        public static void TRUnavailable()
        {
            EditorGUILayout.HelpBox("True Random not available!", MessageType.Warning);

            EditorGUILayout.HelpBox("Did you add the '" + Util.Constants.TRUERANDOM_SCENE_OBJECT_NAME + "'-prefab to the scene?", MessageType.Info);

            GUILayout.Space(8);

            if (GUILayout.Button(new GUIContent(" Add " + Util.Constants.TRUERANDOM_SCENE_OBJECT_NAME, Icon_Plus, "Add the '" + Util.Constants.TRUERANDOM_SCENE_OBJECT_NAME + "'-prefab to the current scene.")))
            {
                InstantiatePrefab(Util.Constants.TRUERANDOM_SCENE_OBJECT_NAME);
                GAApi.Event(typeof(EditorHelper).Name, "Add " + Util.Constants.TRUERANDOM_SCENE_OBJECT_NAME);
            }
        }

        /// <summary>Shows a separator-UI.</summary>
        /// <param name="space">Space in pixels between the component and the seperator line (default: 12, optional).</param>
        public static void SeparatorUI(int space = 12)
        {
            GUILayout.Space(space);
            GUILayout.Box(string.Empty, new GUILayoutOption[] { GUILayout.ExpandWidth(true), GUILayout.Height(1) });
        }

        /// <summary>Instantiates a prefab.</summary>
        /// <param name="prefabName">Name of the prefab.</param>
        public static void InstantiatePrefab(string prefabName)
        {
            PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath("Assets" + EditorConfig.PREFAB_PATH + prefabName + ".prefab", typeof(GameObject)));
        }

        /// <summary>Checks if the 'TrueRandom'-prefab is in the scene.</summary>
        /// <returns>True if the 'TrueRandom'-prefab is in the scene.</returns>
        public static bool isTrueRandomInScene
        {
            get
            {
                return GameObject.Find(Util.Constants.TRUERANDOM_SCENE_OBJECT_NAME) != null;
            }
        }

        /// <summary>Loads an image as Texture2D from 'Editor Default Resources'.</summary>
        /// <param name="logo">Logo to load.</param>
        /// <param name="fileName">Name of the image.</param>
        /// <returns>Image as Texture2D from 'Editor Default Resources'.</returns>
        private static Texture2D loadImage(ref Texture2D logo, string fileName)
        {
            if (logo == null)
            {
#if tr_ignore_setup
                logo = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets" + EditorConfig.ASSET_PATH + "Icons/" + fileName, typeof(Texture2D));
#else
                logo = (Texture2D)EditorGUIUtility.Load("TrueRandom/" + fileName);
#endif

                if (logo == null)
                {
                    Debug.LogWarning("Image not found: " + fileName);
                }
            }

            return logo;
        }

        #endregion
    }
}
// © 2016-2018 crosstales LLC (https://www.crosstales.com)