namespace KB13047_WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        ultraDockManager1 = new Infragistics.Win.UltraWinDock.UltraDockManager(components);
        _Form1UnpinnedTabAreaLeft = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
        _Form1UnpinnedTabAreaRight = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
        _Form1UnpinnedTabAreaTop = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
        _Form1UnpinnedTabAreaBottom = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
        _Form1AutoHideControl = new Infragistics.Win.UltraWinDock.AutoHideControl();
        treeView1 = new TreeView();
        listView1 = new ListView();
        richTextBox1 = new RichTextBox();
        ((System.ComponentModel.ISupportInitialize)ultraDockManager1).BeginInit();
        SuspendLayout();
        // 
        // ultraDockManager1
        // 
        ultraDockManager1.CompressUnpinnedTabs = false;
        ultraDockManager1.HostControl = this;
        ultraDockManager1.MouseEnterElement += ultraDockManager1_MouseEnterElement;
        ultraDockManager1.MouseLeaveElement += ultraDockManager1_MouseLeaveElement;
        // 
        // _Form1UnpinnedTabAreaLeft
        // 
        _Form1UnpinnedTabAreaLeft.Dock = DockStyle.Left;
        _Form1UnpinnedTabAreaLeft.Font = new Font("Yu Gothic UI", 9F);
        _Form1UnpinnedTabAreaLeft.Location = new Point(0, 0);
        _Form1UnpinnedTabAreaLeft.Name = "_Form1UnpinnedTabAreaLeft";
        _Form1UnpinnedTabAreaLeft.Owner = ultraDockManager1;
        _Form1UnpinnedTabAreaLeft.RightToLeft = RightToLeft.No;
        _Form1UnpinnedTabAreaLeft.Size = new Size(0, 450);
        _Form1UnpinnedTabAreaLeft.TabIndex = 0;
        // 
        // _Form1UnpinnedTabAreaRight
        // 
        _Form1UnpinnedTabAreaRight.Dock = DockStyle.Right;
        _Form1UnpinnedTabAreaRight.Font = new Font("Yu Gothic UI", 9F);
        _Form1UnpinnedTabAreaRight.Location = new Point(800, 0);
        _Form1UnpinnedTabAreaRight.Name = "_Form1UnpinnedTabAreaRight";
        _Form1UnpinnedTabAreaRight.Owner = ultraDockManager1;
        _Form1UnpinnedTabAreaRight.RightToLeft = RightToLeft.No;
        _Form1UnpinnedTabAreaRight.Size = new Size(0, 450);
        _Form1UnpinnedTabAreaRight.TabIndex = 1;
        // 
        // _Form1UnpinnedTabAreaTop
        // 
        _Form1UnpinnedTabAreaTop.Dock = DockStyle.Top;
        _Form1UnpinnedTabAreaTop.Font = new Font("Yu Gothic UI", 9F);
        _Form1UnpinnedTabAreaTop.Location = new Point(0, 0);
        _Form1UnpinnedTabAreaTop.Name = "_Form1UnpinnedTabAreaTop";
        _Form1UnpinnedTabAreaTop.Owner = ultraDockManager1;
        _Form1UnpinnedTabAreaTop.RightToLeft = RightToLeft.No;
        _Form1UnpinnedTabAreaTop.Size = new Size(800, 0);
        _Form1UnpinnedTabAreaTop.TabIndex = 2;
        // 
        // _Form1UnpinnedTabAreaBottom
        // 
        _Form1UnpinnedTabAreaBottom.Dock = DockStyle.Bottom;
        _Form1UnpinnedTabAreaBottom.Font = new Font("Yu Gothic UI", 9F);
        _Form1UnpinnedTabAreaBottom.Location = new Point(0, 450);
        _Form1UnpinnedTabAreaBottom.Name = "_Form1UnpinnedTabAreaBottom";
        _Form1UnpinnedTabAreaBottom.Owner = ultraDockManager1;
        _Form1UnpinnedTabAreaBottom.RightToLeft = RightToLeft.No;
        _Form1UnpinnedTabAreaBottom.Size = new Size(800, 0);
        _Form1UnpinnedTabAreaBottom.TabIndex = 3;
        // 
        // _Form1AutoHideControl
        // 
        _Form1AutoHideControl.Font = new Font("Yu Gothic UI", 9F);
        _Form1AutoHideControl.Location = new Point(0, 0);
        _Form1AutoHideControl.Name = "_Form1AutoHideControl";
        _Form1AutoHideControl.Owner = ultraDockManager1;
        _Form1AutoHideControl.RightToLeft = RightToLeft.No;
        _Form1AutoHideControl.Size = new Size(0, 0);
        _Form1AutoHideControl.TabIndex = 4;
        // 
        // treeView1
        // 
        treeView1.Location = new Point(0, 0);
        treeView1.Name = "treeView1";
        treeView1.Size = new Size(182, 146);
        treeView1.TabIndex = 5;
        // 
        // listView1
        // 
        listView1.Location = new Point(8, 8);
        listView1.Name = "listView1";
        listView1.Size = new Size(182, 146);
        listView1.TabIndex = 6;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(16, 16);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(150, 144);
        richTextBox1.TabIndex = 7;
        richTextBox1.Text = "";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(_Form1AutoHideControl);
        Controls.Add(richTextBox1);
        Controls.Add(listView1);
        Controls.Add(treeView1);
        Controls.Add(_Form1UnpinnedTabAreaBottom);
        Controls.Add(_Form1UnpinnedTabAreaTop);
        Controls.Add(_Form1UnpinnedTabAreaRight);
        Controls.Add(_Form1UnpinnedTabAreaLeft);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraDockManager1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Infragistics.Win.UltraWinDock.UltraDockManager ultraDockManager1;
    private Infragistics.Win.UltraWinDock.AutoHideControl _Form1AutoHideControl;
    private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaBottom;
    private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaTop;
    private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaRight;
    private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaLeft;
    private RichTextBox richTextBox1;
    private ListView listView1;
    private TreeView treeView1;
}
