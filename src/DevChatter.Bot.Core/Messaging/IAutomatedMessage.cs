﻿using System;

namespace DevChatter.Bot.Core.Messaging
{
    public interface IAutomatedMessage
    {
        void Initialize(DateTime currentTime);
        bool IsItYourTimeToDisplay(DateTime currentTime);
        string GetMessageInstance(DateTime currentTime);
    }
}