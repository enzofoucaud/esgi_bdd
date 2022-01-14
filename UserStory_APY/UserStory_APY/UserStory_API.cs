using System;
using System.Collections.Generic;

namespace UserStory_APY
{
    public class UserStory_API
    {
        public int MaxParticipants { set; get; }
        public List<int> Participants { set; get; } = new List<int>();
        public int MaxVotes { set; get; }
        public List<int> Votes { set; get; } = new List<int>();

        public int setMaxParticipants()
        {
            // Generates participants
            for (int i = 0; i < MaxParticipants; i++)
            {
                Participants.Add(i);
            }
            return Participants.Count;
        }
        public int setMaxVotes()
        {
            // Generates votes
            var rand = new Random();
            for (int i = 0; i < MaxVotes; i++)
            {
                Votes.Add(rand.Next(MaxParticipants));
                if (isClosed())
                {
                    break;
                }
            }
            return Votes.Count;
        }

        public bool isClosed()
        {
            if (Votes.Count == MaxVotes)
            {
                return true;
            }
            return false;
        } 
    }
}
