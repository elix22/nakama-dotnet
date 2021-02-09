

using System.Runtime.Serialization;
/**
* Copyright 2021 The Nakama Authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
namespace Nakama.SocketInternal
{
    /// <summary>
    /// Announcement of a new party leader.
    /// </summary>
    [DataContract]
    public class PartyLeader : IPartyLeader
    {
        [DataMember(Name = "party_id", Order = 1)]
        public string PartyId { get; set; }

        public IUserPresence Presence => _presence;

        [DataMember(Name = "presence", Order = 2)]
        private UserPresence _presence;
    }
}
