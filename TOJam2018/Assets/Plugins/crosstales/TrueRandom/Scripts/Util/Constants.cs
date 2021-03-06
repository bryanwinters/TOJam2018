﻿namespace Crosstales.TrueRandom.Util
{
    /// <summary>Collected constants of very general utility for the asset.</summary>
    public abstract class Constants : Common.Util.BaseConstants
    {

        #region Constant variables

        /// <summary>Is PRO-version?</summary>
        public static readonly bool isPro = true;
        
        /// <summary>Name of the asset.</summary>
        //public const string ASSET_NAME = "True Random";
        public const string ASSET_NAME = "TR PRO";

        /// <summary>Version of the asset.</summary>
        public const string ASSET_VERSION = "1.5.2";

        /// <summary>Build number of the asset.</summary>
        public const int ASSET_BUILD = 180326;

        /// <summary>Create date of the asset (YYYY, MM, DD).</summary>
        public static readonly System.DateTime ASSET_CREATED = new System.DateTime(2016, 12, 5);

        /// <summary>Change date of the asset (YYYY, MM, DD).</summary>
        public static readonly System.DateTime ASSET_CHANGED = new System.DateTime(2018, 3, 26);
        
        /// <summary>URL of the PRO asset in UAS.</summary>
        public const string ASSET_PRO_URL = "https://www.assetstore.unity3d.com/#!/content/61617?aid=1011lNGT&pubref=" + ASSET_NAME;
        
        /// <summary>URL for update-checks of the asset</summary>
        public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/truerandom_versions.txt";
        //public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/test/truerandom_versions_test.txt";

        /// <summary>Contact to the owner of the asset.</summary>
        public const string ASSET_CONTACT = "truerandom@crosstales.com";

        /// <summary>URL of the asset manual.</summary>
        public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/truerandom/TrueRandom-doc.pdf";

        /// <summary>URL of the asset API.</summary>
        public const string ASSET_API_URL = "https://goo.gl/u5YaXk";

        /// <summary>URL of the asset forum.</summary>
        public const string ASSET_FORUM_URL = "https://goo.gl/N9OJ1K";

        /// <summary>URL of the asset in crosstales.</summary>
        public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio/truerandom/";

        /// <summary>URL of the promotion video of the asset (Youtube).</summary>
        public const string ASSET_VIDEO_PROMO = "https://youtu.be/BsKR3V1EZOU?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

        /// <summary>URL of the tutorial video of the asset (Youtube).</summary>
        public const string ASSET_VIDEO_TUTORIAL = "TBD";

        // Keys for the configuration of the asset
        public const string KEY_PREFIX = "TRUERANDOM_CFG_";
        public const string KEY_DEBUG = KEY_PREFIX + "DEBUG";
        public const string KEY_SHOW_QUOTA = KEY_PREFIX + "SHOW_QUOTA";

        // Default values
        //public const bool DEFAULT_DONT_DESTROY_ON_LOAD = true;
        public const bool DEFAULT_SHOW_QUOTA = false;

        // Generator URL
        public const string GENERATOR_URL = "https://www.random.org/";

        /// <summary>TR prefab scene name.</summary>
        public const string TRUERANDOM_SCENE_OBJECT_NAME = "TrueRandom";

        #endregion

    }
}
// © 2016-2018 crosstales LLC (https://www.crosstales.com)