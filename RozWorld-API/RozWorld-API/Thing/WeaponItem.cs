﻿/**
 * RozWorld-API.Thing.WeaponItem -- RozWorld Weapon Item
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Thing
{
    public abstract class WeaponItem : Item
    {
        /// <summary>
        /// Gets the amount of damage this weapon does.
        /// </summary>
        public abstract uint Damage { get; }

        /// <summary>
        /// Gets the way this weapon does damage.
        /// </summary>
        public abstract WeaponType DamageType { get; }
    }
}
