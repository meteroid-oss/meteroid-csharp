# Changelog

## [0.31.0](https://github.com/meteroid-oss/meteroid-csharp/compare/v0.30.0...v0.31.0) (2026-10-28)


### ⚠ BREAKING CHANGES

* **api:** update SDKs to meteroid 0.1.0 ([#15](https://github.com/meteroid-oss/meteroid-csharp/issues/15))
* **api:** `GET /api/v1/coupons`: added `#/components/schemas/CreditDiscount` to the `data/items/discount` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/coupons/{coupon_id}`: added `#/components/schemas/CreditDiscount` to the `discount` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/plans`: added `#/components/schemas/CreditPlanFee` to the `data/items/price_components/items/fee/oneOf[#/components/schemas/Fee]/` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/plans/{plan_id}`: added `#/components/schemas/CreditPlanFee` to the `price_components/items/fee/oneOf[#/components/schemas/Fee]/` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/products`: added `#/components/schemas/CreditFeeStructure` to the `data/items/fee_structure` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/products/{product_id}`: added `#/components/schemas/CreditFeeStructure` to the `fee_structure` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/subscriptions/{subscription_id}`: added `#/components/schemas/CreditDiscount` to the `applied_coupons/items/coupon/discount` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/subscriptions/{subscription_id}`: added `#/components/schemas/CreditFee` to the `add_ons/items/fee` response property `oneOf` list for the response status `200`
* **api:** `GET /api/v1/subscriptions/{subscription_id}`: added `#/components/schemas/CreditFee` to the `components/items/fee` response property `oneOf` list for the response status `200`
* **api:** `PATCH /api/v1/coupons/{coupon_id}`: added the new required request property `discount/oneOf[#/components/schemas/CouponDiscount]/oneOf[#/components/schemas/FixedDiscount]/type`
* **api:** 90 more breaking changes

### Features

* **api:** `GET /api/v1/coupons/{coupon_id}`: added `#/components/schemas/CreditDiscount` to the `discount` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/coupons`: added `#/components/schemas/CreditDiscount` to the `data/items/discount` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/plans/{plan_id}`: added `#/components/schemas/CreditPlanFee` to the `price_components/items/fee/oneOf[#/components/schemas/Fee]/` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/plans`: added `#/components/schemas/CreditPlanFee` to the `data/items/price_components/items/fee/oneOf[#/components/schemas/Fee]/` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/products/{product_id}`: added `#/components/schemas/CreditFeeStructure` to the `fee_structure` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/products`: added `#/components/schemas/CreditFeeStructure` to the `data/items/fee_structure` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/subscriptions/{subscription_id}`: added `#/components/schemas/CreditDiscount` to the `applied_coupons/items/coupon/discount` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/subscriptions/{subscription_id}`: added `#/components/schemas/CreditFee` to the `add_ons/items/fee` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `GET /api/v1/subscriptions/{subscription_id}`: added `#/components/schemas/CreditFee` to the `components/items/fee` response property `oneOf` list for the response status `200` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** `PATCH /api/v1/coupons/{coupon_id}`: added the new required request property `discount/oneOf[#/components/schemas/CouponDiscount]/oneOf[#/components/schemas/FixedDiscount]/type` ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** 90 more breaking changes ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** update SDKs to meteroid 0.1.0 ([#15](https://github.com/meteroid-oss/meteroid-csharp/issues/15)) ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))
* **api:** update the API definitions ([3562010](https://github.com/meteroid-oss/meteroid-csharp/commit/356201060d8678f159339f737ac201160fd05b15))


### Bug Fixes

* **api:** update SDKs to meteroid 0.1.0 ([#13](https://github.com/meteroid-oss/meteroid-csharp/issues/13)) ([f11d42e](https://github.com/meteroid-oss/meteroid-csharp/commit/f11d42e1d8e656393d83687728d6ff83c2cce8bf))

## [0.30.0](https://github.com/meteroid-oss/meteroid-csharp/compare/v0.29.0...v0.30.0) (2026-10-09)


### ⚠ BREAKING CHANGES

* **api:** update SDKs to meteroid 0.1.0 ([#11](https://github.com/meteroid-oss/meteroid-csharp/issues/11))
* **api:** `POST /api/v1/events/ingest`: the `events/items/timestamp` request property `type/format` changed from `string` to `string, null/date-time`

### Features

* **api:** `POST /api/v1/events/ingest`: the `events/items/timestamp` request property `type/format` changed from `string` to `string, null/date-time` ([ebec009](https://github.com/meteroid-oss/meteroid-csharp/commit/ebec0097aff766abf360e03e873c7d602697432d))
* **api:** add `DELETE /api/v1/webhooks/endpoints/{endpoint_id}` ([ebec009](https://github.com/meteroid-oss/meteroid-csharp/commit/ebec0097aff766abf360e03e873c7d602697432d))
* **api:** update `GET /api/v1/plans` and 1029 more ([ebec009](https://github.com/meteroid-oss/meteroid-csharp/commit/ebec0097aff766abf360e03e873c7d602697432d))
* **api:** update SDKs to meteroid 0.1.0 ([#11](https://github.com/meteroid-oss/meteroid-csharp/issues/11)) ([ebec009](https://github.com/meteroid-oss/meteroid-csharp/commit/ebec0097aff766abf360e03e873c7d602697432d))

## [0.29.0](https://github.com/meteroid-oss/meteroid-csharp/compare/v0.28.0...v0.29.0) (2026-10-08)


### ⚠ BREAKING CHANGES

* **api:** update SDKs to meteroid 0.1.0 ([#9](https://github.com/meteroid-oss/meteroid-csharp/issues/9))

### Features

* **api:** update SDKs to meteroid 0.1.0 ([#9](https://github.com/meteroid-oss/meteroid-csharp/issues/9)) ([b511641](https://github.com/meteroid-oss/meteroid-csharp/commit/b5116412337cb8bf3e15d484864a1713da838af4))

## [0.28.0](https://github.com/meteroid-oss/meteroid-csharp/compare/v0.27.1...v0.28.0) (2026-10-07)


### ⚠ BREAKING CHANGES

* **api:** update SDKs to meteroid 0.1.0 ([#7](https://github.com/meteroid-oss/meteroid-csharp/issues/7))

### Features

* **api:** update SDKs to meteroid 0.1.0 ([#7](https://github.com/meteroid-oss/meteroid-csharp/issues/7)) ([a121b1a](https://github.com/meteroid-oss/meteroid-csharp/commit/a121b1a76a849d57dc2bfa679c096621cbfcbea3))

## [0.27.1](https://github.com/meteroid-oss/meteroid-csharp/compare/v0.27.0...v0.27.1) (2026-10-06)


### Bug Fixes

* **api:** update SDKs to meteroid 0.1.0 ([#3](https://github.com/meteroid-oss/meteroid-csharp/issues/3)) ([2ce8fc7](https://github.com/meteroid-oss/meteroid-csharp/commit/2ce8fc7e5923bc8ecf6e35c5574bf036d165b025))

## 0.27.0 (2026-10-06)


### Features

* **api:** update SDKs to meteroid 0.1.0 ([#1](https://github.com/meteroid-oss/meteroid-csharp/issues/1)) ([bd686b6](https://github.com/meteroid-oss/meteroid-csharp/commit/bd686b60d86d265f20654e362f3b09cb1ba06b22))
