Namespace DelphTech
    Public Class DT_Sound

        Public Sub PlayFromFile(ByVal FileLoc As String, ByVal PlayMode As AudioPlayMode)
            'PLAY WAV AUDIO FILE USING THE FILE LOCATION AND PLAY MODE
            My.Computer.Audio.Play(FileLoc, PlayMode)
        End Sub

        Public Sub SystemSound(ByVal Sound As Media.SystemSound)
            'PLAY SYSTEM SOUND
            My.Computer.Audio.PlaySystemSound(Sound)
        End Sub

        Public Sub StopSound()
            'STOP ANY AUDIO
            My.Computer.Audio.Stop()
        End Sub

    End Class
End Namespace