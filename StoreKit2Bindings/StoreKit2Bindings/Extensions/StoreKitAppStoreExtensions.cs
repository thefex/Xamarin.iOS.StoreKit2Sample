using System;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace StoreKit2Bindings.Extensions
{
    public static class StoreKitAppStoreExtensions
    { 
        public static Task<NSError> ShowManageSubscriptionsIn(this StoreKitAppStore storeKitAppStore, UIWindowScene scene)
        {
            var tcs = new TaskCompletionSource<NSError>();

            storeKitAppStore.ShowManageSubscriptionsIn(scene, error =>
            {
                tcs.TrySetResult(error);
            });

            return tcs.Task;
        }
    }
}