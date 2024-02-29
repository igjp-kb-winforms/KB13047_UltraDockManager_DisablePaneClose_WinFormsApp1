using Infragistics.Win;
using Infragistics.Win.UltraWinDock;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KB13047_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SuspendLayout();

        var dcpTreeView = new DockableControlPane("tree", "Tree View", this.treeView1);
        var dcpListView = new DockableControlPane("list", "List View", this.listView1);

        var dcpRichText = new DockableControlPane("rtb", "Rich Text Box", this.richTextBox1);

        dcpRichText.Settings.AllowClose = Infragistics.Win.DefaultableBoolean.False;
        ultraDockManager1.ShowDisabledButtons = false;

        var dgpTreeList = new DockableGroupPane();
        dgpTreeList.ChildPaneStyle = ChildPaneStyle.TabGroup;
        dgpTreeList.Panes.Add(dcpTreeView);
        dgpTreeList.Panes.Add(dcpListView);

        var dapLeft = new DockAreaPane(DockedLocation.DockedLeft);
        dapLeft.Panes.Add(dgpTreeList);

        var dapRight = new DockAreaPane(DockedLocation.DockedRight);
        dapRight.Panes.Add(dcpRichText);

        ultraDockManager1.DockAreas.Add(dapLeft);
        ultraDockManager1.DockAreas.Add(dapRight);
        ultraDockManager1.LayoutStyle = DockAreaLayoutStyle.FillContainer;

        ResumeLayout();
    }

    private void ultraDockManager1_MouseEnterElement(object sender, Infragistics.Win.UIElementEventArgs e)
    {
        var paneCaptionUIElement = e.Element as PaneCaptionUIElement;
        if (paneCaptionUIElement == null) return;

        paneCaptionUIElement.Control.MouseDown += OnMouseDown;
    }

    private void ultraDockManager1_MouseLeaveElement(object sender, Infragistics.Win.UIElementEventArgs e)
    {
        var paneCaptionUIElement = e.Element as PaneCaptionUIElement;
        if (paneCaptionUIElement == null) return;

        paneCaptionUIElement.Control.MouseDown -= OnMouseDown;
    }


    private bool _isContextMenuStripOpeningSubscribed = false;

    private void OnMouseDown(object? sender, MouseEventArgs e)
    {
        var dockableWindow = sender as DockableWindow;
        if (_isContextMenuStripOpeningSubscribed || dockableWindow == null) return;

        var contextMenuStrip = dockableWindow.ContextMenuStrip;
        if (contextMenuStrip == null) return;

        contextMenuStrip.Opening += ContextMenuStrip_Opening;
        _isContextMenuStripOpeningSubscribed = true;
    }

    private void ContextMenuStrip_Opening(object? sender, System.ComponentModel.CancelEventArgs e)
    {
        var contextMenuStrip = sender as ContextMenuStrip;
        if(contextMenuStrip == null) return;

        ToolStripItem[] toolStripItems = new ToolStripItem[contextMenuStrip.Items.Count];
        contextMenuStrip.Items.CopyTo(toolStripItems, 0);
        var hideItem = toolStripItems.ToList().FirstOrDefault(menuItem => menuItem?.Text?.Contains("”ñ•\Ž¦") ?? false);

        if ((contextMenuStrip.SourceControl as DockableWindow)?.Pane.Key == "rtb"
            && hideItem != null)
        {
            contextMenuStrip.Items.Remove(hideItem);
        }
    }
}
