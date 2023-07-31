using System;
using CoreGraphics;
using Foundation;
using StoreKit2Bindings.Extensions;
using UIKit;

namespace TestProject
{
    public class MainViewController : UIViewController
    {
        public MainViewController()
        {
        }

        public MainViewController(NSCoder coder) : base(coder)
        {
        }

        protected MainViewController(NSObjectFlag t) : base(t)
        {
        }

        protected internal MainViewController(IntPtr handle) : base(handle)
        {
        }

        public MainViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
            var button = new UIButton(new CGRect(
                    100, 100, 100, 100
                ));
            button.SetTitle("Show Manage Subscriptions", UIControlState.Normal);
            button.SetTitleColor(UIColor.Blue, UIControlState.Normal);
            button.SizeToFit();

            button.TouchUpInside += async (e, a) =>
            {
                var response = await StoreKitAppStoreExtensions.ShowManageSubscriptionsIn(View.Window.WindowScene);
                var z = response;
                //  if (response != null)
                //  {
                //       
                //   }
            };
            
            Add(button);
        }
    }
}