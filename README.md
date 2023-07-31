# Xamarin.iOS.StoreKit2Sample
This is a sample how to leverage StoreKit2 in Xamarin.iOS. Extend to your needs.

#1 Add required methods in StoreKit2/StoreKit2/AppStoreManager.Swift
The methods need to be objc compatibile (@objc), class has to derive from NSObject so it can be consumed from objc.
I just added showManageSubscriptions because this is the only method I needed in my project.


#2 Build release in xcode for Debug and Release.

#3 Create xcframework so it works on both iPhone and simulator.

xcodebuild -create-xcframework -framework path-from-your-xcode-derived-path/Release-iphoneos/StoreKit2.framework -framework Release-path-from-your-xcode-derived-path//StoreKit2.framework -output ./StoreKit2.xcframework

#4 Download latest objective sharpie pkg

https://github.com/xamarin/xamarin-macios/blob/main/Make.config#L234C1-L235C1

#5 Generate ApiDefinitions / enums
sharpie bind ..../Release-iphoneos/StoreKit2.framework/Headers/StoreKit2-Swift.h --sdk iphoneos16.2

#6 Copy this to Xamarin bindings project (see sample attached)

#7 Build & enjoy
