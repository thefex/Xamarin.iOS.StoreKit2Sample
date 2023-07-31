//
//  StoreKitAppStoreBridge.swift
//  StoreKit2
//
//  Created by Przemysław Raciborski on 31/07/2023.
//

import Foundation
import StoreKit;

@objc public class StoreKitAppStore : NSObject
{
    @objc public func showManageSubscriptions(in scene: UIWindowScene) async throws {
        try await AppStore.showManageSubscriptions(in: scene)
    }
}
