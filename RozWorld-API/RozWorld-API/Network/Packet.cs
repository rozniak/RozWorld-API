/**
 * RozWorld-API.Network.Packet -- RozWorld Network Packet Construct
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace RozWorld_API.Network
{
    public struct Packet
    {
        public PacketPriority Priority { get; private set; }
        public bool ID { get; private set; }
        public IList<byte> Data;
    }
}
