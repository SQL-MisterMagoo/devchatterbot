﻿using System;
using System.Threading.Tasks;
using DevChatter.Bot.Core;
using DevChatter.Bot.Core.Events;

namespace DevChatter.Bot
{
    public class ConsoleChatClient : IChatClient
    {
        public Task Connect()
        {
            return Task.CompletedTask;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public event EventHandler<CommandReceivedEventArgs> OnCommandReceived;
        public event EventHandler<NewSubscriberEventArgs> OnNewSubscriber;
        public event EventHandler<NewFollowersEventArgs> OnNewFollower;
    }
}