Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CriteriaItemControl
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.LayoutPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.bnRemove = New System.Windows.Forms.Button()
            Me.te = New StaxRip.UI.TextEdit()
            Me.mbCondition = New StaxRip.UI.MenuButton()
            Me.mbProperties = New StaxRip.UI.MenuButton()
            Me.LayoutPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'LayoutPanel
            '
            Me.LayoutPanel.AutoSize = True
            Me.LayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.LayoutPanel.ColumnCount = 4
            Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
            Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
            Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
            Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.LayoutPanel.Controls.Add(Me.mbProperties, 0, 0)
            Me.LayoutPanel.Controls.Add(Me.bnRemove, 3, 0)
            Me.LayoutPanel.Controls.Add(Me.te, 2, 0)
            Me.LayoutPanel.Controls.Add(Me.mbCondition, 1, 0)
            Me.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.LayoutPanel.Name = "LayoutPanel"
            Me.LayoutPanel.RowCount = 1
            Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.LayoutPanel.Size = New System.Drawing.Size(582, 42)
            Me.LayoutPanel.TabIndex = 0
            '
            'buRemove
            '
            Me.bnRemove.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.bnRemove.AutoSize = True
            Me.bnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.bnRemove.Location = New System.Drawing.Point(523, 3)
            Me.bnRemove.Name = "buRemove"
            Me.bnRemove.Size = New System.Drawing.Size(56, 35)
            Me.bnRemove.TabIndex = 3
            Me.bnRemove.Text = "Add"
            Me.bnRemove.UseVisualStyleBackColor = True
            '
            'te
            '
            Me.te.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.te.Location = New System.Drawing.Point(367, 3)
            Me.te.Name = "te"
            Me.te.Size = New System.Drawing.Size(150, 36)
            Me.te.TabIndex = 4
            '
            'mbCondition
            '
            Me.mbCondition.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.mbCondition.Location = New System.Drawing.Point(211, 3)
            Me.mbCondition.ShowMenuSymbol = True
            Me.mbCondition.Size = New System.Drawing.Size(150, 36)
            '
            'mbProperties
            '
            Me.mbProperties.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.mbProperties.Location = New System.Drawing.Point(3, 3)
            Me.mbProperties.ShowMenuSymbol = True
            Me.mbProperties.Size = New System.Drawing.Size(202, 36)
            '
            'CriteriaItemControl
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.Controls.Add(Me.LayoutPanel)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "CriteriaItemControl"
            Me.Size = New System.Drawing.Size(582, 42)
            Me.LayoutPanel.ResumeLayout(False)
            Me.LayoutPanel.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LayoutPanel As System.Windows.Forms.TableLayoutPanel
        Public WithEvents bnRemove As System.Windows.Forms.Button
        Friend WithEvents te As StaxRip.UI.TextEdit
        Friend WithEvents mbCondition As MenuButton
        Friend WithEvents mbProperties As MenuButton
    End Class
End Namespace

