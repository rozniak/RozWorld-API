/**
 * Oddmatics.RozWorld.API.Generic.Chat.ChatGraphic -- RozWorld Chat Graphic Symbols
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Chat
{
    /// <summary>
    /// Container for chat graphics.
    /// </summary>
    public static class ChatGraphic
    {
        #region Xbox Controller Graphics

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's A button.
        /// </summary>
        public const char XBOX_A_BUTTON = (char)0x2153;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's B button.
        /// </summary>
        public const char XBOX_B_BUTTON = (char)0x2154;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's X button.
        /// </summary>
        public const char XBOX_X_BUTTON = (char)0x215B;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Y button.
        /// </summary>
        public const char XBOX_Y_BUTTON = (char)0x215C;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Guide button.
        /// </summary>
        public const char XBOX_GUIDE_BUTTON = (char)0x215D;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Back button.
        /// </summary>
        public const char XBOX_BACK_BUTTON = (char)0x215E;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Start button.
        /// </summary>
        public const char XBOX_START_BUTTON = (char)0x2184;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Left Bumper.
        /// </summary>
        public const char XBOX_LEFT_BUMPER = (char)0x2190;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Right Bumper.
        /// </summary>
        public const char XBOX_RIGHT_BUMPER = (char)0x2191;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Left Trigger.
        /// </summary>
        public const char XBOX_LEFT_TRIGGER = (char)0x2192;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Right Trigger.
        /// </summary>
        public const char XBOX_RIGHT_TRIGGER = (char)0x2193;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Left Stick.
        /// </summary>
        public const char XBOX_LEFT_STICK = (char)0x2194;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's Right Stick.
        /// </summary>
        public const char XBOX_RIGHT_STICK = (char)0x2194;

        /// <summary>
        /// Represents a graphic icon of an Xbox 360 controller's D-Pad.
        /// </summary>
        public const char XBOX_DPAD = (char)0x21A8;

        #endregion


        #region Emotes

        /// <summary>
        /// Represents a graphic emote of Jroll's mug.
        /// </summary>
        public const char EMOTE_JROLL = (char)0x00B6;

        /// <summary>
        /// Represents a graphic emote of Jay Valentino's mug.
        /// </summary>
        public const char EMOTE_VALENTINO = (char)0x263C;

        /// <summary>
        /// Represents a graphic emote of BENNVA's mug.
        /// </summary>
        public const char EMOTE_BENNYV = (char)0x2640;

        /// <summary>
        /// Represents a graphic emote of RIG's mug.
        /// </summary>
        public const char EMOTE_RIG = (char)0x2126;

        /// <summary>
        /// Represents a graphic emote of rozza's mug.
        /// </summary>
        public const char EMOTE_ROZ = (char)0x263A;

        /// <summary>
        /// Represents a graphic emote of Sweaty Sweet's mug.
        /// </summary>
        public const char EMOTE_SWEET = (char)0x20AA;

        /// <summary>
        /// Represents a graphic emote of Satan's mug.
        /// </summary>
        public const char EMOTE_MARLOW = (char)0x2105;

        #endregion


        /// <summary>
        /// Gets whether the specified character is a special graphic character.
        /// </summary>
        /// <param name="subject">The character to check.</param>
        /// <returns>True the specified character is a special graphic character.</returns>
        public static bool IsGraphic(char subject)
        {
            // Horrendous long conditional...
            return subject == XBOX_A_BUTTON ||
                subject == XBOX_B_BUTTON ||
                subject == XBOX_X_BUTTON ||
                subject == XBOX_Y_BUTTON ||
                subject == XBOX_GUIDE_BUTTON ||
                subject == XBOX_BACK_BUTTON ||
                subject == XBOX_START_BUTTON ||
                subject == XBOX_LEFT_BUMPER ||
                subject == XBOX_RIGHT_BUMPER ||
                subject == XBOX_LEFT_TRIGGER ||
                subject == XBOX_RIGHT_TRIGGER ||
                subject == XBOX_LEFT_STICK ||
                subject == XBOX_RIGHT_STICK ||
                subject == XBOX_DPAD ||
                subject == EMOTE_JROLL ||
                subject == EMOTE_VALENTINO ||
                subject == EMOTE_BENNYV ||
                subject == EMOTE_RIG ||
                subject == EMOTE_ROZ ||
                subject == EMOTE_SWEET ||
                subject == EMOTE_MARLOW;
        }
    }
}
