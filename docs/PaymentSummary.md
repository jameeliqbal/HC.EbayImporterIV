# EBay.OAS3v1IV.Models.PaymentSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | This array consists of payment information for the order, including payment status, payment method, payment amount, and payment date. This array is always returned, although some of the fields under this container will not be returned until payment has been made. | [optional] 
**Refunds** | [**List&lt;OrderRefund&gt;**](OrderRefund.md) | This array is always returned, but is returned as an empty array unless the seller has submitted a partial or full refund to the buyer for the order. If a refund has occurred, the refund amount and refund date will be shown for each refund. | [optional] 
**TotalDueSeller** | [**Amount**](Amount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

