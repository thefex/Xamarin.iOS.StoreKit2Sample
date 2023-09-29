using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace StoreKit2Bindings.Extensions;

public static class StoreKitTransactionExtensions
{
    public static Task<NSError> BeginRefundRequestFor(ulong transactionId, UIWindowScene scene)
    {
        var tcs = new TaskCompletionSource<NSError>();

        StoreKitTransaction.BeginRefundRequestFor(transactionId, scene, error =>
        {
            tcs.TrySetResult(error);
        });

        return tcs.Task;
    }
}