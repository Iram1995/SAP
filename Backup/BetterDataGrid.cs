
// Type: SAP2012.BetterDataGrid




using System.Drawing;
using System.Windows.Forms;

namespace SAP2012
{
  public class BetterDataGrid : DataGridView
  {
    public BetterDataGrid()
    {
      this.DoubleBuffered = true;
      this.Visible = true;
      this.Dock = DockStyle.Fill;
      this.RowHeadersWidth = 15;
      this.AllowUserToAddRows = false;
      this.AllowUserToDeleteRows = false;
      this.AllowUserToResizeRows = false;
      this.Cursor = Cursors.Hand;
      this.ReadOnly = true;
      this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
    }
  }
}
