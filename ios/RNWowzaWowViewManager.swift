//
//  RNWowzaWowViewManager.swift
//  RNReactNativeWowzaWow
//
//  Created by shwetech on 13/09/18.
//  Copyright © 2018 Facebook. All rights reserved.
//

import UIKit

// CounterViewManager.swift
@objc(CounterViewManager)
class RNWowzaWowViewManager: RCTViewManager {
    override func view() -> UIView! {
        let label = UILabel()
        label.text = "Swift Counter"
        label.textAlignment = .center
        return label
    }
}
