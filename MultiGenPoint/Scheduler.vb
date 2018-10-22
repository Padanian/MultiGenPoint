Public Class Scheduler
    Private mstrline As String
    Private Structure SchedulerStructureGenerator
        Private F1OnHour As Integer
        Private F1OnMinute As Integer
        Private F1OffHour As Integer
        Private F1OffMinute As Integer
        Private F1Week As Boolean()
        Private F2OnHour As Integer
        Private F2OnMinute As Integer
        Private F2OffHour As Integer
        Private F2OffMinute As Integer
        Private F2Week As Boolean()
        Private F3OnHour As Integer
        Private F3OnMinute As Integer
        Private F3OffHour As Integer
        Private F3OffMinute As Integer
        Private F3Week As Boolean()
    End Structure

    Property Gen1F1On() As String
        Get
            Return mstrLine
        End Get
        Set(ByVal Value As String)
            mstrLine = Value
        End Set
    End Property

    Property Gen1F1Off() As String
        Get
            Return mstrLine
        End Get
        Set(ByVal Value As String)
            mstrLine = Value
        End Set
    End Property

End Class
