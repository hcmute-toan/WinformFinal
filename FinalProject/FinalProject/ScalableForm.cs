using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

public class ScalableForm : MaterialForm
{
    protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
    {
        base.ScaleControl(factor, specified);

        // Điều chỉnh kích thước của các controls khi form thay đổi kích thước
        foreach (Control control in Controls)
        {
            control.Left = (int)(control.Left * factor.Width);
            control.Top = (int)(control.Top * factor.Height);
            control.Width = (int)(control.Width * factor.Width);
            control.Height = (int)(control.Height * factor.Height);

            // Điều chỉnh font size của các controls
            control.Font = new Font(control.Font.FontFamily, control.Font.Size * factor.Height);
        }
    }
}
