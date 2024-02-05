Imports EBay.OAS3v1IV.SellApi.FulfillmentApis
Imports EBay.OAS3v1IV.Client
Imports EBay.OAS3v1IV.Models

Public Class Form1
    Private Const EBayBaseAPIPathSandbox As String = "https://api.sandbox.ebay.com/sell/fulfillment/v1" '" 
    Private Const EBayBaseAPIPathProd As String = "https://api.ebay.com/sell/fulfillment/v1" '" https://api.ebay.com
    Private Const jameelToken As String = "v^1.1#i^1#p^3#r^0#I^3#f^0#t^H4sIAAAAAAAAAOVZf2wbVx2PkzRTKaUSTNsoQ0QG/uiis9/57DvftfFkN3bjtHFcO2nWqCV69+5dfMn57rj3LokjkEKACU1qNZBWbQJEGUysQv0LNDSxMlBBovDH1FGhUcSExiiVWhU06NgGtLyzk9RxWRvbk7Dg/rB1776/Pt9f7xdY7tv60KPDj/59e+Ce7pPLYLk7EOC3ga19WwY+0NO9c0sXqCMInFz+xHLvSs/lPQSWTUcpYOLYFsH9i2XTIkp1cDDouZZiQ2IQxYJlTBSKlGJy9IASCQHFcW1qI9sM9meHBoNxGIliKMY1QUUC0lQ2aq3JHLcHg7wQRzIvSCLE8ZjMi+w7IR7OWoRCiw4GIyAS5UCEA9FxICsxWYkIIYkHU8H+Q9glhm0xkhAIJqrmKlVet87WO5sKCcEuZUKCiWwyUxxLZofSufE94TpZiVU/FCmkHtn4ttfWcP8haHr4zmpIlVopeghhQoLhRE3DRqFKcs2YFsyvulqScFRUYQzoCGMZqe+JKzO2W4b0znb4I4bG6VVSBVvUoJW7eZR5Q53FiK6+5ZiI7FC//3fQg6ahG9gdDKZTycMTxXQh2F/M51173tCw5iPlhagQ52OyHExQTJgLsTs9y1ixuaqpJm7Vzw2q9tqWZvheI/05m6YwMxs3Oida5xxGNGaNuUmd+ibV0fH8mhOBNOVHtRZGj5YsP7C4zDzRX329ewjWcuJWFrxXWRGLAD4WV3kQhaoQF0BjVvi13kpmJPzgJPP5sG8LVmGFK0N3DlPHhAhziLnXK2PX0BQhpkeEuI45TZR1LirrOqfGNJHjdYwBxqqK5Pj/VYJQ6hqqR/F6kjR+qKIcDBaR7eC8bRqoEmwkqXad1ZRYJIPBEqWOEg4vLCyEFoSQ7c6EIwDw4UdGDxRRCZdhcJ3WuDsxZ1STA2HGRQyFVhxmzSLLPabcmgkmBFfLQ5dWUl6FvRexabK/tfzdYGGicfRdoO41DeaHcaaos5AO24RirS1oGp43EJ42tA5A5td6HTqObwuZac8Y1iimJbsTsNXh8jtCdqgtbKyBQtpZqOobUGS1AYkizwFJAaAtsEnHyZbLHoWqibMdFktBjrHpqy14jud1RPXVoUKiWylp5U+TpYW2oPnzrmJAXaH2HLY29E+/1jsCayGdKaSLw9PjY/vTubbQFrDuYlIa97F2Wp4mDybTSfaM5qbSCEiZscKknsmOawVTmkiri1mamZmYhWb2EJFwNjezZMhLYTgzMqBZQyMpJO5LDU/y+wvq0OHk4GBbTipi5OIOa1145DCfmxyet0t2Zm7s0Gw+xbvh1NRYborCKZDiB8TZinlwKZaZm2gP/PhtZdAR+N1a4k5Xq3SavbUFMj3T2M/8Wv+vgxRjkhwDWODjGoBSNCpDNSqjaEzXdTECRKntKarDKn6kup8oQm7YNk1oaVwx9Qgna3FNFrQ44OKCqouqHGtz6vpfnbmIv7npLGg+P2ECoGOE/Ik1hOxy2IZsA+8PTVct7t8MUVj1Kky/ht2Qi6FmW2Zl83wzHtuw1rj/I5Nf67cxErYHC9X23wxKk1o3MjfBY1jzbNdmu5VWFK4zN8EDEbI9i7aibpW1CQ7dM3XDNP0NeisK69ibMdOCZoUaiLQew+oBDHMvMWZKtFk5bKyMXcaPIIVsg9dCApOS7Th+FiLobhJ6tV50ndUL9FD1sKs5Yw2tdujYKth1ftYlDLNtKU7JtnDbUqCm+bXOFg4tB3Fdln9K2LaQ2jF2S7VgWH7fJU2wOLBSrTzNII4/azTRWCguhzQX6s3Unc/UBLmLmVFw85nawNRqKCybGrqBajKIpxLkGk4L9fKucloJLmFNvKnQ1hjWVbV3ToM1w8WITnuu0VmridrycLoIXRuypT/XsFzkNLikerPmOk5W6z2teMD3cCcewuWTxeLkWKG9Y7ghPN9py34gxKLxOJY5QRZ5Lor1KAc19hPnMQIoEscAobYwd9zBIy8BCUSBFBM3i6thoO6i47ZLrvDGa+ZEV/XhVwJnwErg+e5AgOnm+AGwq69norfn/UHCOnWIsO2Wai+GDKiH2DLHYvOSi0NzuOJAw+3uCxgXL6C36i64Tx4FD6xfcW/t4bfV3XeDB2992cLvuH97JAoiDK4ckyPCFPj4ra+9/H2990o7R+SVr3tLey+8Ih7/1/nPPPvYX94C29eJAoEtXb0rga5dFz559vc3rl687jy259qZ6/JDP8Rv/ONn3z/7k1+EYqee/kIqf/Nz90W27jpdeOfnOwe+/dz5y99I/nHpyyfokd+cSJy+cezloSPSZH7lfU98/u1Xj579ww/QEy9+8IXydO+fPnXsnx/986/3vXTvledDT5+7+tKbH3n1eO93P2afexj89oU3vvqicyl5/Gvf+ewp752/xvaEevqeHfii/sv9uy+O7TvzFahduyIe01+LvC0tfujH1tGfhpbpzeEfnX+49xL55tUHX1e301deu9/4Hf/h7518/EvRl/PwOblQ3HF5968CT71+4AF85G+7czjypL1D6jox+61M5Z5nrg08deD09dHKxOVnLh2/+fi5G9KbR3Pbiqeu5Gph/Dd9GZuteiAAAA=="
    Private Const jameelToken2 As String = "v^1.1#i^1#I^3#r^0#p^1#f^0#t^H4sIAAAAAAAAAOVYa2wURRzvXl/WCiSiFdHouRBBye7t3u49duUuXktLC6U9en1Ajamzu3Pttnu7l93Z3p36oTbQNH4wijFEjKEag2AI+Ekl8UEEEiwmJCIQCWrig5eGKD54KOLctpRrIVDoJTbxcslmZv7P3/wfM8P0lZQ9OlA7cHYGUeoa6mP6XATBljNlJcWLZha65hYXMDkExFDf/L6i/sITiy2Q0JJiE7SShm5Bdzqh6ZboTIZI29RFA1iqJeogAS0RyWIssqJe9NKMmDQNZMiGRrrrloRIjgUCz/tkgfcpUAn48ax+WWazESJ9QJCDPk4RWJkLKgLA65ZlwzrdQkBHIdLLeHmK8VIM38yyIsfjP80HmXbS3QpNSzV0TEIzZNgxV3R4zRxbr28qsCxoIiyEDNdFamKNkbol1Q3Niz05ssKjOMQQQLY1flRlKNDdCjQbXl+N5VCLMVuWoWWRnvCIhvFCxchlY27BfAfqIKdwIMAH/N6gFAwAf16grDHMBEDXtyM7oypU3CEVoY5UlLkRohgNqRvKaHTUgEXULXFnPyttoKlxFZohsroysjoSjZLhZXgeajFA1RqaBnSFilWuogQFBwynBBkqyElxvyT4RvWMCBtFeYKiKkNX1CxmlrvBQJUQGw0nQuPNgQYTNeqNZiSOsgbl0nGXIQz427N7OrKJNurSs9sKExgHtzO88QaMcSNkqpKN4JiEiQsOQiESJJOqQk5cdEJxNHrSVojsQigpejypVIpOcbRhdnq8DMN6Vq2oj8ldMIFzDdNmc92hV2/MQKmOKzLEnJYqokwS25LGoYoN0DvJMCf4WF9wFPfxZoUnzl41keOzZ3xC5CtBeM4vwWCc4by8P87KUj4SJDwao56sHVACGSoBzB6IkhqQISXjOLMT0FQVkfPFvVwwDinFL8QpXojHKcmn+Ck2DiEDoSTJQvB/lCeTjfQYlE2I8hPq+QpzuGw129BW22t0GTU9ja3d0UrW9FS2Nza0I9DOVLKL/N0ZbeXTvpqeltBkk+GazldpKkamGeuffrlea1gIKlNyLyYbSRg1NFXOTK8N5kwlCkyUqbQzeByDmoY/U3I1kkzW5alg58vJm6sVt+Z2HvvUf9OjrumVlY3b6eVVlt/CAkBSpbNdiJazuW4kPAbAR5DsdIdjtftqwquJPJKdoTttaCFsiYIPgZNmUnEtp3FDUybPMtIusROTZ8E3DMWW0S0pcvoyjdFUO7uQdVM601MBRbK1nsmzKBBoUwpRFd8zplWAYk9HXFaVkQsC7fhNW70ybULLsE18N6IbswfmZqMH6vj8gUxcmKDZyk658iYSNgKSBqdbCc5DLVIBPhwV9RO/Tye/2AATYHg/H+Cn5JvsHH86plsHyXPjvIlrkGf8m0y4wPmx/cRHTD+xw0UQGHaKXcQ8UlLYUlR4B2nh0kNb2ETJSNMqiNO46ukA2Sake2AmCVTTVUKoR76Uz+W8Bg09ycwZew8qK2TLcx6HmPuvrBSzs+6Z4eUZL8OzLMdzfDsz78pqEVtRdNd29z+lf14QDu/qLd92+4LSNzNHX9rHzBgjIojiAhy6BXefO/WrMPCcvqzJlwYp86kvDry7/pWLW9etm7lv45YNJ+tve2HX8PpDn7y85rVXj84urQ18vZPWZ/994J2mpdrC5aV7ts9MtbQt+OaDOzcnbWUv8XrTZvH4+YPV9p4TC2ue+Oq9S1Gmbrur4+TwrM/9fw3sl9p++c216fH5y3s/fIN+v2recMdg2Y7B3RE39WDqu+ZnH6tOXyDmvF2xdOfhhzaYFT9f2F++7Yc2+fTueYdO/3FMqD+zZe3DtkdrEV4a3lp17HzF2kt7X/yW/iw9pFjfF6/zHFz+8eCm/c+wxz9d/yM/n4DcAxf7C7qjC43he4/cd3aj68zcpdpb1QNlxYNMrPX5Pacuron+tGJkG/8FqpZcw6cTAAA="
    Private Const hollandToken As String = "v^1.1#i^1#r^1#f^0#p^3#I^3#t^Ul4xMF82OjkzQzdGQzk3RUU0QkQxQTVCNjg2MDc4NDI2MzU4MjczXzJfMSNFXjI2MA=="
    Private Const hollandToken_test As String = "AgAAAA**AQAAAA**aAAAAA**F+GRUA**nY+sHZ2PrBmdj6wVnY+sEZ2PrA2dj6wFk4GhCZWEowSdj6x9nY+seQ**gfsBAA**AAMAAA**aP51UK7BOTSDSLoXvZEYnybpP6Kodeh7j7jOL9KRWCYBs7uLJhIVmB0ALvII+/adXNZ+ZXhQe69+XSUjmWxfL5AtBS5q/D3fVyoc2/RY0UPSCUE6KhHW6oASBp9+M656p4YCQeERlTlZ/xH6VrCwaeHa/MNN92ueffbi6eWGyrMVgVsJ7R/lSljAjFEI8xGcJGQPG3Z/+k/MbWm33gyFL/Rf9s5z1P3JQeERBVD1EkOGLEEs0JA8W2lznzXml9/4dvcfG0ue0/rUSefzVpClnNiQAm0h/Pcs2Kn7T0Uy80pALvfmTRT9q/k50bmtyXFYzqej7k4CVzd/pEFOILw0qNeULTzBuLjGezs9HdYPbP5rH8jbIhfwSZfLfwq3STo6pLXbjBwCw45becVzuovCYT3LhzFM78aEXa4c5XZ5Zrw4pbeSYWrl2fiQpfHWw1tZ5uZBbRCFSJ9mQJcg6CuushCVq6ZZbL69YpZG+4dDHiUpRkl3MP80xZSN59oMj9sXlWmQNvTFXbIvGAzHGYVa0gCw4AzBT7H+id0/siOjPTq3OhM+NP1tGehqr2KMheq6NSB4jricbREhZWkR8/sRXlsqRLTrdcBV5fHG7k0QqJuBaeiLI1zYVx/l1ObLNLHT59eefuTXu3DOQAaRlHx19AwY+G7KitUzZvIdRy9fRGWi6LZpby6bnMYqvBbjZhtnV4tP89GJc59OHQIZ7k2TlfaK5EJQPpZkAG6iCbkBVhuOrBGZq7po3xCV/8C1PNzv"


    Public Property Config As Configuration
    Private Sub btnSearchOrders_Click(sender As Object, e As EventArgs) Handles btnSearchOrders.Click

        'Dim config = New Configuration With {
        '    .AccessToken = jameelToken2,
        '    .BasePath = EBayBaseAPIPathSandbox
        '}
        Try
            Cursor.Current = Cursors.WaitCursor
            txtLog.Clear()

            WriteLog("Searching orders...")
            WriteLog("Congiguration:")
            WriteLog("\t Base Path:" & Config.BasePath)
            WriteLog("\t Access Token:" & Config.AccessToken)

            Dim ordersApi = New OrderApi(Config)

            'Configuration.Default.AccessToken = hollandToken
            'Configuration.Default.BasePath = EBayBaseAPIPathSandbox

            'Dim ordersApi = New OrderApi()

            Dim ofs = cmbOrderFulfillmentStatus.Text

            Dim filter As String = "orderfulfillmentstatus:" & ofs.Replace("{", "%7B").Replace("|", "%7C").Replace("}", "%7D")
            Dim limit As Integer = 10
            Dim offset As Integer = 0


            ' Get orders
            'Dim result As OrderSearchPagedCollection = ordersApi.GetOrders(Nothing, filter, limit, offset)
            WriteLog("Fetching Orders...")
            Dim result As OrderSearchPagedCollection = ordersApi.GetOrders()
            WriteLog("\t Orders Fetched!")
            WriteLog("Listing Orders:")
            For Each order As Order In result.Orders
                Console.WriteLine($"Order ID: {order.OrderId}, Status: {order.OrderFulfillmentStatus}")
                WriteLog($"\t Order ID: {order.OrderId}, Status: {order.OrderFulfillmentStatus}")
            Next
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Console.WriteLine("Exception when calling OrderApi.GetOrders: " & ex.Message)
            WriteLog(Environment.NewLine & "****Exception when calling OrderApi.GetOrders:**** " & Environment.NewLine & ex.Message & Environment.NewLine & ex.InnerException?.Message)

        End Try

    End Sub

    Private Sub WriteLog(v As String)
        Dim message As String = $"[{DateTime.Now}] {v} {Environment.NewLine}"

        txtLog.AppendText(message)

    End Sub

End Class
