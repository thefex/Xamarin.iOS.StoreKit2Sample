using System;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace StoreKit2Bindings.Extensions
{
    public static class StoreKitAppStoreExtensions
    { 
        public static Task<NSError> ShowManageSubscriptionsIn(UIWindowScene scene)
        {
            var tcs = new TaskCompletionSource<NSError>();

            StoreKitAppStore.ShowManageSubscriptionsIn(scene, error =>
            {
                tcs.TrySetResult(error);
            });

            return tcs.Task;
        }
    }
}