// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<EventType>))]
public readonly partial record struct EventType(string Value) : IStringEnum<EventType>
{
    /// <summary><c>metric.created</c></summary>
    public static EventType MetricCreated { get; } = new("metric.created");

    /// <summary><c>customer.created</c></summary>
    public static EventType CustomerCreated { get; } = new("customer.created");

    /// <summary><c>subscription.created</c></summary>
    public static EventType SubscriptionCreated { get; } = new("subscription.created");

    /// <summary><c>subscription.updated</c></summary>
    public static EventType SubscriptionUpdated { get; } = new("subscription.updated");

    /// <summary><c>subscription.cancelled</c></summary>
    public static EventType SubscriptionCancelled { get; } = new("subscription.cancelled");

    /// <summary><c>subscription.ended</c></summary>
    public static EventType SubscriptionEnded { get; } = new("subscription.ended");

    /// <summary><c>invoice.created</c></summary>
    public static EventType InvoiceCreated { get; } = new("invoice.created");

    /// <summary><c>invoice.finalized</c></summary>
    public static EventType InvoiceFinalized { get; } = new("invoice.finalized");

    /// <summary><c>invoice.paid</c></summary>
    public static EventType InvoicePaid { get; } = new("invoice.paid");

    /// <summary><c>invoice.voided</c></summary>
    public static EventType InvoiceVoided { get; } = new("invoice.voided");

    /// <summary><c>invoice.closed</c></summary>
    public static EventType InvoiceClosed { get; } = new("invoice.closed");

    /// <summary><c>invoice.consolidated</c></summary>
    public static EventType InvoiceConsolidated { get; } = new("invoice.consolidated");

    /// <summary><c>invoice.deleted</c></summary>
    public static EventType InvoiceDeleted { get; } = new("invoice.deleted");

    /// <summary><c>invoice.accounting_pdf_generated</c></summary>
    public static EventType InvoiceAccountingPdfGenerated { get; } = new("invoice.accounting_pdf_generated");

    /// <summary><c>quote.accepted</c></summary>
    public static EventType QuoteAccepted { get; } = new("quote.accepted");

    /// <summary><c>quote.converted</c></summary>
    public static EventType QuoteConverted { get; } = new("quote.converted");

    /// <summary><c>credit_note.created</c></summary>
    public static EventType CreditNoteCreated { get; } = new("credit_note.created");

    /// <summary><c>credit_note.finalized</c></summary>
    public static EventType CreditNoteFinalized { get; } = new("credit_note.finalized");

    /// <summary><c>credit_note.voided</c></summary>
    public static EventType CreditNoteVoided { get; } = new("credit_note.voided");

    /// <summary><c>plan.created</c></summary>
    public static EventType PlanCreated { get; } = new("plan.created");

    /// <summary><c>plan.published</c></summary>
    public static EventType PlanPublished { get; } = new("plan.published");

    /// <summary><c>plan.archived</c></summary>
    public static EventType PlanArchived { get; } = new("plan.archived");

    /// <summary><c>product.created</c></summary>
    public static EventType ProductCreated { get; } = new("product.created");

    /// <summary><c>product.updated</c></summary>
    public static EventType ProductUpdated { get; } = new("product.updated");

    /// <summary><c>product.archived</c></summary>
    public static EventType ProductArchived { get; } = new("product.archived");

    /// <summary><c>metric.updated</c></summary>
    public static EventType MetricUpdated { get; } = new("metric.updated");

    /// <summary><c>metric.archived</c></summary>
    public static EventType MetricArchived { get; } = new("metric.archived");

    /// <summary><c>coupon.created</c></summary>
    public static EventType CouponCreated { get; } = new("coupon.created");

    /// <summary><c>coupon.updated</c></summary>
    public static EventType CouponUpdated { get; } = new("coupon.updated");

    /// <summary><c>coupon.archived</c></summary>
    public static EventType CouponArchived { get; } = new("coupon.archived");

    /// <summary><c>addon.created</c></summary>
    public static EventType AddonCreated { get; } = new("addon.created");

    /// <summary><c>addon.updated</c></summary>
    public static EventType AddonUpdated { get; } = new("addon.updated");

    /// <summary><c>addon.archived</c></summary>
    public static EventType AddonArchived { get; } = new("addon.archived");

    /// <summary><c>refund.issued</c></summary>
    public static EventType RefundIssued { get; } = new("refund.issued");

    /// <summary><c>refund.settled</c></summary>
    public static EventType RefundSettled { get; } = new("refund.settled");

    /// <summary><c>refund.failed</c></summary>
    public static EventType RefundFailed { get; } = new("refund.failed");

    /// <summary><c>payment.reversed</c></summary>
    public static EventType PaymentReversed { get; } = new("payment.reversed");

    /// <summary><c>payment.failed</c></summary>
    public static EventType PaymentFailed { get; } = new("payment.failed");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "metric.created"
                or "customer.created"
                or "subscription.created"
                or "subscription.updated"
                or "subscription.cancelled"
                or "subscription.ended"
                or "invoice.created"
                or "invoice.finalized"
                or "invoice.paid"
                or "invoice.voided"
                or "invoice.closed"
                or "invoice.consolidated"
                or "invoice.deleted"
                or "invoice.accounting_pdf_generated"
                or "quote.accepted"
                or "quote.converted"
                or "credit_note.created"
                or "credit_note.finalized"
                or "credit_note.voided"
                or "plan.created"
                or "plan.published"
                or "plan.archived"
                or "product.created"
                or "product.updated"
                or "product.archived"
                or "metric.updated"
                or "metric.archived"
                or "coupon.created"
                or "coupon.updated"
                or "coupon.archived"
                or "addon.created"
                or "addon.updated"
                or "addon.archived"
                or "refund.issued"
                or "refund.settled"
                or "refund.failed"
                or "payment.reversed"
                or "payment.failed";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>metric.created</c></summary>
        public const string MetricCreated = "metric.created";

        /// <summary><c>customer.created</c></summary>
        public const string CustomerCreated = "customer.created";

        /// <summary><c>subscription.created</c></summary>
        public const string SubscriptionCreated = "subscription.created";

        /// <summary><c>subscription.updated</c></summary>
        public const string SubscriptionUpdated = "subscription.updated";

        /// <summary><c>subscription.cancelled</c></summary>
        public const string SubscriptionCancelled = "subscription.cancelled";

        /// <summary><c>subscription.ended</c></summary>
        public const string SubscriptionEnded = "subscription.ended";

        /// <summary><c>invoice.created</c></summary>
        public const string InvoiceCreated = "invoice.created";

        /// <summary><c>invoice.finalized</c></summary>
        public const string InvoiceFinalized = "invoice.finalized";

        /// <summary><c>invoice.paid</c></summary>
        public const string InvoicePaid = "invoice.paid";

        /// <summary><c>invoice.voided</c></summary>
        public const string InvoiceVoided = "invoice.voided";

        /// <summary><c>invoice.closed</c></summary>
        public const string InvoiceClosed = "invoice.closed";

        /// <summary><c>invoice.consolidated</c></summary>
        public const string InvoiceConsolidated = "invoice.consolidated";

        /// <summary><c>invoice.deleted</c></summary>
        public const string InvoiceDeleted = "invoice.deleted";

        /// <summary><c>invoice.accounting_pdf_generated</c></summary>
        public const string InvoiceAccountingPdfGenerated = "invoice.accounting_pdf_generated";

        /// <summary><c>quote.accepted</c></summary>
        public const string QuoteAccepted = "quote.accepted";

        /// <summary><c>quote.converted</c></summary>
        public const string QuoteConverted = "quote.converted";

        /// <summary><c>credit_note.created</c></summary>
        public const string CreditNoteCreated = "credit_note.created";

        /// <summary><c>credit_note.finalized</c></summary>
        public const string CreditNoteFinalized = "credit_note.finalized";

        /// <summary><c>credit_note.voided</c></summary>
        public const string CreditNoteVoided = "credit_note.voided";

        /// <summary><c>plan.created</c></summary>
        public const string PlanCreated = "plan.created";

        /// <summary><c>plan.published</c></summary>
        public const string PlanPublished = "plan.published";

        /// <summary><c>plan.archived</c></summary>
        public const string PlanArchived = "plan.archived";

        /// <summary><c>product.created</c></summary>
        public const string ProductCreated = "product.created";

        /// <summary><c>product.updated</c></summary>
        public const string ProductUpdated = "product.updated";

        /// <summary><c>product.archived</c></summary>
        public const string ProductArchived = "product.archived";

        /// <summary><c>metric.updated</c></summary>
        public const string MetricUpdated = "metric.updated";

        /// <summary><c>metric.archived</c></summary>
        public const string MetricArchived = "metric.archived";

        /// <summary><c>coupon.created</c></summary>
        public const string CouponCreated = "coupon.created";

        /// <summary><c>coupon.updated</c></summary>
        public const string CouponUpdated = "coupon.updated";

        /// <summary><c>coupon.archived</c></summary>
        public const string CouponArchived = "coupon.archived";

        /// <summary><c>addon.created</c></summary>
        public const string AddonCreated = "addon.created";

        /// <summary><c>addon.updated</c></summary>
        public const string AddonUpdated = "addon.updated";

        /// <summary><c>addon.archived</c></summary>
        public const string AddonArchived = "addon.archived";

        /// <summary><c>refund.issued</c></summary>
        public const string RefundIssued = "refund.issued";

        /// <summary><c>refund.settled</c></summary>
        public const string RefundSettled = "refund.settled";

        /// <summary><c>refund.failed</c></summary>
        public const string RefundFailed = "refund.failed";

        /// <summary><c>payment.reversed</c></summary>
        public const string PaymentReversed = "payment.reversed";

        /// <summary><c>payment.failed</c></summary>
        public const string PaymentFailed = "payment.failed";
    }

    static EventType IStringEnum<EventType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator EventType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
