using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public static class CheckboxColorChanger
{
    private static Color checkedColor = Color.DarkGreen;
    private static Color uncheckedColor = Color.DarkRed;

    public static Color CheckedColor
    {
        get { return checkedColor; }
        set { checkedColor = value; }
    }

    public static Color UncheckedColor
    {
        get { return uncheckedColor; }
        set { uncheckedColor = value; }
    }

    public static void ApplyColorChangeToAllCheckboxes(Control control)
    {
        ApplyColorChangeToControlAndChildren(control);
    }

    private static void ApplyColorChangeToControlAndChildren(Control control)
    {
        foreach (CheckBox checkbox in control.Controls.OfType<CheckBox>())
        {
            ApplyColorChange(checkbox);
        }

        foreach (Control childControl in control.Controls)
        {
            ApplyColorChangeToControlAndChildren(childControl);
        }
    }

    public static void ApplyColorChange(CheckBox checkbox)
    {
        checkbox.CheckedChanged += (sender, e) =>
        {
            CheckBox cb = (CheckBox)sender;
            cb.ForeColor = cb.Checked ? checkedColor : uncheckedColor;
            UpdateCheckboxText(cb);
        };

        checkbox.ForeColor = checkbox.Checked ? checkedColor : uncheckedColor;
        StoreOriginalText(checkbox);
        UpdateCheckboxText(checkbox);
    }

    private static void StoreOriginalText(CheckBox checkbox)
    {
        if (!string.IsNullOrEmpty(checkbox.Text))
        {
            checkbox.Tag = checkbox.Text;
        }
    }

    private static void UpdateCheckboxText(CheckBox checkbox)
    {
        string status = checkbox.Checked ? "[ON]" : "[OFF]";
        string originalText = checkbox.Tag?.ToString() ?? string.Empty;
        checkbox.Text = $"{originalText} {status}";
    }
}