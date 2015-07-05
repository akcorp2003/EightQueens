Public Class Queen
    Private m_Row As Integer
    Private m_Column As Integer


    Public Sub New()
        m_Row = 0
        m_Column = 0
    End Sub

    Public Sub New(ByVal Row As Byte, ByVal Column As Byte)
        m_Row = Row
        m_Column = Column
    End Sub

    Public Property Row() As Integer
        Get
            Return m_Row
        End Get
        Set(value As Integer)
            m_Row = value
        End Set
    End Property

    Public Property Column() As Integer
        Get
            Return m_Column
        End Get
        Set(value As Integer)
            m_Column = value
        End Set
    End Property

End Class
