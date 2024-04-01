Imports eBay.OAS3v1IV.Models
Imports HC.EBayModule

''' <summary>
''' ORDERS
''' </summary>
Partial Public Class EBayImporterClient
    Public Function GetOrders(Optional fieldGroups As String = Nothing, Optional filter As String = Nothing, Optional limit As String = Nothing, Optional offset As String = Nothing, Optional orderIds As String = Nothing) As IList(Of Order)

        Dim ebayOrders = ebayConnector.GetOrders(fieldGroups, filter, limit, offset, orderIds)

        Dim orders As List(Of Order) = New List(Of [Order])

        For Each ebayOrder In ebayOrders
            Dim order = New Order With
                {
                    .OrderId = ebayOrder.OrderID,
                    .OrderStatus = ebayOrder.OrderFulfillmentStatus
                }
            orders.Add(order)
        Next
        Return orders
    End Function
End Class
