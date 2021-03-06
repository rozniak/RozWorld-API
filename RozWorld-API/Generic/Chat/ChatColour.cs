﻿/**
 * Oddmatics.RozWorld.API.Generic.Chat.ChatColour -- RozWorld Chat Colour Codes
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Linq;

namespace Oddmatics.RozWorld.API.Generic.Chat
{
    /// <summary>
    /// Container for chat colours.
    /// </summary>
    public static class ChatColour
    {
        /// <summary>
        /// Represents the colour black.
        /// </summary>
        public const string BLACK = "&0";

        /// <summary>
        /// Represents the colour dark blue.
        /// </summary>
        public const string DARK_BLUE = "&1";

        /// <summary>
        /// Represents the colour green.
        /// </summary>
        public const string GREEN = "&2";

        /// <summary>
        /// Represents the colour teal.
        /// </summary>
        public const string TEAL = "&3";

        /// <summary>
        /// Represents the colour dark red.
        /// </summary>
        public const string DARK_RED = "&4";

        /// <summary>
        /// Represents the colour purple.
        /// </summary>
        public const string PURPLE = "&5";

        /// <summary>
        /// Represents the colour orange.
        /// </summary>
        public const string ORANGE = "&6";

        /// <summary>
        /// Represents the colour grey.
        /// </summary>
        public const string GREY = "&7";

        /// <summary>
        /// Represents the colour dark grey.
        /// </summary>
        public const string DARK_GREY = "&8";

        /// <summary>
        /// Represents the colour blue.
        /// </summary>
        public const string BLUE = "&9";

        /// <summary>
        /// Represents the colour lime.
        /// </summary>
        public const string LIME = "&A";

        /// <summary>
        /// Represents the colour cyan.
        /// </summary>
        public const string CYAN = "&B";

        /// <summary>
        /// Represents the colour red.
        /// </summary>
        public const string RED = "&C";

        /// <summary>
        /// Represents the colour magenta.
        /// </summary>
        public const string MAGENTA = "&D";

        /// <summary>
        /// Represents the colour yellow.
        /// </summary>
        public const string YELLOW = "&E";

        /// <summary>
        /// Represents the colour white.
        /// </summary>
        public const string WHITE = "&F";

        /// <summary>
        /// Represents the client's default colour.
        /// </summary>
        public const string DEFAULT = "&S";


        /// <summary>
        /// Represents all strings that are valid as a ChatColour.
        /// </summary>
        private static string[] ValidColours = new string[] { BLACK, DARK_BLUE, GREEN, TEAL, DARK_RED,
            PURPLE, ORANGE, GREY, DARK_GREY, BLUE, LIME, CYAN, RED, MAGENTA, YELLOW, WHITE, DEFAULT };


        /// <summary>
        /// Checks whether a given string is a valid ChatColour.
        /// </summary>
        /// <param name="subject">The string subject to check.</param>
        /// <returns>True if the string is a valid ChatColour.</returns>
        public static bool IsChatColour(string subject)
        {
            return ValidColours.Contains(subject);
        }
    }
}
