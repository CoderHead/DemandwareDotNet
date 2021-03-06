﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Enumerates the valid statuses for a coupon item.
    /// </summary>
    public enum CouponItemStatus
    {
        /// <summary>
        /// Indicates a code already in basket status.
        /// </summary>
        [EnumMember(Value = "coupon_code_already_in_basket")]
        CouponCodeAlreadyInBasket,

        /// <summary>
        /// Indicates an already redeemed status.
        /// </summary>
        [EnumMember(Value = "coupon_code_already_redeemed")]
        CouponCodeAlreadyRedeemed,

        /// <summary>
        /// Indicates a code unknown status.
        /// </summary>
        [EnumMember(Value = "coupon_code_unknown")]
        CouponCodeUnknown,

        /// <summary>
        /// Indicates a disabled status.
        /// </summary>
        [EnumMember(Value = "coupon_disabled")]
        CouponDisabled,

        /// <summary>
        /// Indicates a coupon limit exceeded status.
        /// </summary>
        [EnumMember(Value = "redemption_limit_exceeded")]
        RedemptionLimitExceeded,

        /// <summary>
        /// Indicates a customer limit exceeded status.
        /// </summary>
        [EnumMember(Value = "customer_redemption_limit_exceeded")]
        CustomerRedemptionLimitExceeded,

        /// <summary>
        /// Indicates a timeframe limit exceeded status.
        /// </summary>
        [EnumMember(Value = "timeframe_redemption_limit_exceeded")]
        TimeframeRedemptionLimitExceeded,

        /// <summary>
        /// Indicates an inactive status.
        /// </summary>
        [EnumMember(Value = "no_active_promotion")]
        NoActivePromotion,

        /// <summary>
        /// Indicates a coupon already in basket status.
        /// </summary>
        [EnumMember(Value = "coupon_already_in_basket")]
        CouponAlreadyInBasket,

        /// <summary>
        /// Indicates an inapplicable status.
        /// </summary>
        [EnumMember(Value = "no_applicable_promotion")]
        NoApplicablePromotion,

        /// <summary>
        /// Indicates an applied status.
        /// </summary>
        [EnumMember(Value = "applied")]
        Applied,

        /// <summary>
        /// Indicates an ad-hoc status.
        /// </summary>
        [EnumMember(Value = "adhoc")]
        AdHoc
    }

    /// <summary>
    /// Represents a coupon item.
    /// </summary>
    public sealed class CouponItem : BaseClass
    {
        #region Properties

        /// <summary>
        /// The coupon code.
        /// </summary>
        [JsonProperty(PropertyName = "code", Required = Required.AllowNull)]
        [StringLength(256)]
        public string Code { get; set; }

        /// <summary>
        /// The coupon item id.
        /// </summary>
        [JsonProperty(PropertyName = "coupon_item_id")]
        public override string Id { get; set; }

        /// <summary>
        /// A flag indicating whether the coupon item is valid. A coupon line item is valid if the status code is 'applied' or 'no_applicable_promotion'.
        /// </summary>
        [JsonProperty(PropertyName = "valid")]
        public bool IsValid { get; set; }

        /// <summary>
        /// The status of the coupon item.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public CouponItemStatus Status { get; set; }

        #endregion
    }
}
