﻿Public Class Service1

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Adicione código aqui para iniciar seu serviço. Este método deve ajustar
        ' o que é necessário para que seu serviço possa executar seu trabalho.
        EventLog.WriteEntry("I've started!")
    End Sub

    Protected Overrides Sub OnStop()
        ' Adicione código aqui para realizar qualquer limpeza necessária para parar seu serviço.
        EventLog.WriteEntry("I've finished!")
    End Sub

End Class
