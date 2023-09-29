//
//  StoreKitTransaction.swift
//  StoreKit2
//
//  Created by Przemysław Raciborski on 29/09/2023.
//

import Foundation
import UIKit
import StoreKit

@objc public final class StoreKitTransaction : NSObject
{
    @objc public static func beginRefundRequest(
        for transactionId: UInt64,
        in scene: UIWindowScene) async throws {
            try await Transaction.beginRefundRequest(for: transactionId, in: scene);
    }
}
