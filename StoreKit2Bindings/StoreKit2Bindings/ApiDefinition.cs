using System;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace StoreKit2Bindings
{

    // @interface StoreKitAppStore : NSObject
    [BaseType (typeof(NSObject), Name = "_TtC9StoreKit216StoreKitAppStore")]
    interface StoreKitAppStore
    {
        // -(void)showManageSubscriptionsIn:(UIWindowScene * _Nonnull)scene completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler;
        [Export ("showManageSubscriptionsIn:completionHandler:")]
        void ShowManageSubscriptionsIn (UIWindowScene scene, Action<NSError> completionHandler);
    } 
}