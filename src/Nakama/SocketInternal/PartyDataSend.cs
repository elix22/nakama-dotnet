


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
    // Send data to a party.
    /// </summary>
    [DataContract]
    public class PartyDataSend : IPartyDataSend
    {
      [DataMember(Name = "party_id", Order = 1), Preserve]
      public string PartyId { get; set; }

      [DataMember(Name = "op_code", Order = 2), Preserve]
      public int OpCode { get; set; }

      [DataMember(Name = "data", Order = 3), Preserve]
      public byte[] Data { get; set; }
    }
}