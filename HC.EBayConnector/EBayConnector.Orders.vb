Imports eBay.OAS3v1IV.Models
Imports eBay.OAS3v1IV.Client
Imports eBay.OAS3v1IV.SellApi.FulfillmentApis

Partial Public Class EBayConnector

    Public Function GetOrders(Optional fieldGroups As String = Nothing, Optional filter As String = Nothing,
                              Optional limit As String = Nothing, Optional offset As String = Nothing,
                              Optional orderIds As String = Nothing) As IList(Of EBayOrder)

        Dim orders As New List(Of EBayOrder)

        Dim IsNewAccessToken = GetNewAccessTokenIfExpired()
        If IsNewAccessToken Then
            apiCallConfig = New Configuration With {
            .AccessToken = config.AccessToken,
            .BasePath = config.BasePath
        }
            ebayOrderAPI = New OrderApi(apiCallConfig)
        End If

        Dim result As OrderSearchPagedCollection = ebayOrderAPI.GetOrders(fieldGroups, filter, limit, offset, orderIds)
        For Each order In result.Orders
            Dim ebayOrder = New EBayOrder With {
               .OrderID = order.OrderId,
               .OrderFulfillmentStatus = order.OrderFulfillmentStatus
            }

        Next
        Return orders

    End Function


End Class
