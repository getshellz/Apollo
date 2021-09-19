﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApolloInterop.Structs.MythicStructs;
namespace ApolloInterop.Interfaces
{
    public interface IPeerManager
    {
        IPeer AddPeer(PeerInformation info);
        bool Remove(string uuid);
        bool Remove(IPeer peer);
        bool Route(DelegateMessage msg);
    }
}