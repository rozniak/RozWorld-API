/**
 * RozWorld-API.Network.Data.Packet -- RozWorld Network Packet Construct
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Collections.Generic;

namespace RozWorld_API.Network.Data
{
    public struct Packet
    {
        /// <summary>
        /// Gets or sets this packet's destiny.
        /// </summary>
        public PacketDestiny Destiny { get; private set; }


        /// <summary>
        /// Gets or sets this packet's priority.
        /// </summary>
        public PacketPriority Priority;


        /// <summary>
        /// Gets or sets the ID of this packet.
        /// </summary>
        public ushort ID { get; private set; }


        /// <summary>
        /// Gets or sets the data contents of this packet.
        /// </summary>
        public IList<byte> Data { get; private set; }


        /// <summary>
        /// Gets or sets the origin date/time of this packet.
        /// </summary>
        public DateTime OriginTime { get; private set; }


        /// <summary>
        /// Gets or sets whether this packet should drop on updates.
        /// </summary>
        public bool DropOnUpdate;


        public Packet(ushort id, IList<byte> data, PacketDestiny destiny, PacketPriority priority = PacketPriority.Low) : this()
        {
            ID = id;
            Data = data;
            Destiny = destiny;
            Priority = priority;
        }
    }
}
