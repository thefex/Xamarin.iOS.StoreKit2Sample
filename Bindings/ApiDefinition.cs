using System;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace StoreKit2Bindings
{
    [BaseType (typeof(NSObject), Name = "_TtC9StoreKit216StoreKitAppStore")]
    interface StoreKitAppStore
    {
        // +(void)showManageSubscriptionsIn:(UIWindowScene * _Nonnull)scene completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler;
        [Static]
        [Export ("showManageSubscriptionsIn:completionHandler:")]
        void ShowManageSubscriptionsIn (UIWindowScene scene, Action<NSError> completionHandler);
    }

    [BaseType (typeof(NSObject), Name = "_TtC9StoreKit219StoreKitTransaction")]
    interface StoreKitTransaction
    {
        // +(void)beginRefundRequestFor:(uint64_t)transactionId in:(UIWindowScene * _Nonnull)scene completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler;
        [Static]
        [Export ("beginRefundRequestFor:in:completionHandler:")]
        void BeginRefundRequestFor (ulong transactionId, UIWindowScene scene, Action<NSError> completionHandler);
    }

}