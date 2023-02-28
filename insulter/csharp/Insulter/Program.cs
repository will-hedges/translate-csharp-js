﻿using System;
using System.Collections.Generic;

Main();

void Main()
{
    List<string> insults = new List<string>()
    {
        "You look like what morning breath smells like.",
        "If you tried to give me cpr I would probably throw myself back under water",
        "I am not a fan of you",
        "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
        "I'd rather walk than be on the same plane as you",
        "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
        "Do you have to be so...like that?"
    };

    List<int> indexes = new List<int>();

    while (indexes.Count < 3)
    {
        int insult = getRandomInt(0, insults.Count - 1);
        if (!indexes.Contains(insult))
        {
            indexes.Add(insult);
        }
    }

    for (int i = 0; i < indexes.Count; i++)
    {
        int index = indexes[i];
        Console.WriteLine(insults[index]);
    }
}

int getRandomInt(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max);
}
