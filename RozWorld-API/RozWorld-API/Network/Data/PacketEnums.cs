/**
 * RozWorld-API.Network.Data.PacketEnums -- RozWorld Network Packet Enumerations
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Network.Data
{
    public enum ClientPacketID
    {
        Ping = 0x0000,
        RequestServerInfo = 0x0001,
        LogIn = 0x0002,
        RequestModCount = 0x0003,
        RequestModVerification = 0x0004,
        RequestModDetails = 0x0005,
        RequestItemIDUpdate = 0x0006,
        NoPacket = 0xFFFE,
        VerifyImportantPacket = 0xFFFF
    }

    public enum ServerPacketID
    {
        Pong = 0x0000,
        NoPacket = 0xFFFE
    }

    public enum PacketPriority
    {
        Low,
        Medium,
        High
    }

    public enum PacketDestiny
    {
        Client,
        Server
    }
}