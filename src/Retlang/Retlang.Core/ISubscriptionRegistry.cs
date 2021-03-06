﻿using System;

namespace Retlang.Core
{
    ///<summary>
    /// Allows for the registration and deregistration of subscriptions
    ///</summary>
    public interface ISubscriptionRegistry
    {
        /// <summary>
        /// Returns the number of subscriptions.
        /// </summary>
        int SubscriptionsCount { get; }

        ///<summary>
        /// Register subscription to be unsubcribed from when the fiber is disposed.
        ///</summary>
        ///<param name="toAdd"></param>
        void RegisterSubscription(IDisposable toAdd);

        ///<summary>
        /// Deregister a subscription.
        ///</summary>
        ///<param name="toRemove"></param>
        ///<returns></returns>
        bool DeregisterSubscription(IDisposable toRemove);
    }
}
