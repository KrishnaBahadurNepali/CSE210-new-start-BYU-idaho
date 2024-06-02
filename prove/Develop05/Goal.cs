using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    // Base class for all goals
    abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public abstract bool IsComplete { get; }

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public abstract void RecordEvent();
        public abstract void DisplayProgress();
    }
}