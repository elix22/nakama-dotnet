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

namespace Nakama
{
    /// <summary>
    /// Incoming information about a party.
    /// </summary>
    public interface IParty
    {
        /// <summary>
        /// Unique party identifier.
        /// </summary>
        string PartyId { get; }

        /// <summary>
        /// Open flag.
        /// </summary>
        bool Open { get; }

        /// <summary>
        /// Maximum number of party members.
        /// </summary>
        bool MaxSize { get; }

        /// <summary>
        /// Self.
        /// </summary>
        IUserPresence Self { get; }

        /// <summary>
        /// Leader
        /// </summary>
        IUserPresence Leader { get; }

        /// <summary>
        /// All current party members.
        /// </summary>
        IUserPresence[] Presences { get; }
    }
}
