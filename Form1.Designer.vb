<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstMoves = New System.Windows.Forms.ListBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.ufoEnd = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ufoStart = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.ufoEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ufoStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstMoves
        '
        Me.lstMoves.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lstMoves.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMoves.ForeColor = System.Drawing.Color.Lime
        Me.lstMoves.FormattingEnabled = True
        Me.lstMoves.ItemHeight = 23
        Me.lstMoves.Location = New System.Drawing.Point(448, 37)
        Me.lstMoves.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstMoves.MultiColumn = True
        Me.lstMoves.Name = "lstMoves"
        Me.lstMoves.Size = New System.Drawing.Size(991, 671)
        Me.lstMoves.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Lime
        Me.btnStart.Location = New System.Drawing.Point(106, 574)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(232, 55)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'ufoEnd
        '
        Me.ufoEnd.Image = Global.Wormhole.My.Resources.Resources.ufo
        Me.ufoEnd.Location = New System.Drawing.Point(106, 455)
        Me.ufoEnd.Name = "ufoEnd"
        Me.ufoEnd.Size = New System.Drawing.Size(232, 85)
        Me.ufoEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ufoEnd.TabIndex = 3
        Me.ufoEnd.TabStop = False
        Me.ufoEnd.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wormhole.My.Resources.Resources.wormhole
        Me.PictureBox1.Location = New System.Drawing.Point(22, 187)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 220)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ufoStart
        '
        Me.ufoStart.Image = Global.Wormhole.My.Resources.Resources.ufo
        Me.ufoStart.Location = New System.Drawing.Point(106, 37)
        Me.ufoStart.Name = "ufoStart"
        Me.ufoStart.Size = New System.Drawing.Size(232, 85)
        Me.ufoStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ufoStart.TabIndex = 4
        Me.ufoStart.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Lime
        Me.btnReset.Location = New System.Drawing.Point(106, 653)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(232, 55)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1464, 736)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.ufoStart)
        Me.Controls.Add(Me.ufoEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lstMoves)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("OCR A Extended", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Wormhole"
        CType(Me.ufoEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ufoStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstMoves As ListBox
    Friend WithEvents btnStart As Button
    Friend WithEvents ufoEnd As PictureBox
    Friend WithEvents ufoStart As PictureBox
    Friend WithEvents btnReset As Button
End Class
