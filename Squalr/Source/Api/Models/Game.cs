﻿namespace Squalr.Source.Api.Models
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    internal class Game
    {
        public Game()
        {
            this.GameId = 0;
            this.GameName = String.Empty;
            this.GameMode = 0;
        }

        [DataMember(Name = "id")]
        public Int32 GameId { get; set; }

        [DataMember(Name = "game_name")]
        public String GameName { get; set; }

        [DataMember(Name = "game_mode")]
        public Int32 GameMode { get; set; }
    }
    //// End class
}
//// End namespace