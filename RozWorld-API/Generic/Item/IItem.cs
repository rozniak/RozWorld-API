/**
 * Oddmatics.RozWorld.API.Generic.Item.IItem -- RozWorld Base Item
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Item
{
    /// <summary>
    /// Represents an in game item.
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// Gets whether this IItem is a shop item instance.
        /// If it is, then this IItem should be inactive.
        /// </summary>
        bool IsShopItem { get; }

        /// <summary>
        /// Gets the language string ID for this IItem's description.
        /// </summary>
        ushort LidDescription { get; }

        /// <summary>
        /// Gets the language string ID for this IItem's name.
        /// </summary>
        ushort LidName { get; }

        /// <summary>
        /// Gets the listing icon path (relative to texture pack directories) for this IItem.
        /// This value is client-side only.
        /// </summary>
        string PathListingIcon { get; }

        /// <summary>
        /// Gets the preview image path (relative to texture pack directories) for this IItem.
        /// This value is client-side only.
        /// </summary>
        string PathPreviewImage { get; }

        /// <summary>
        /// Gets the value of this IItem, good for trading or selling to NPCs.
        /// 0 value is unsellable, above that, value is interpretted by the other party.
        /// </summary>
        ushort Value { get; }
    }
}
