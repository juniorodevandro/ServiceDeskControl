namespace Desenvolvimento.Custom
{
    public class RichTextBoxCustom : RichTextBox
    {
        public RichTextBoxCustom(RichTextBox original)
        {
            this.Location = original.Location;
            this.Size = original.Size;
            this.Font = original.Font;
            this.ForeColor = original.ForeColor;
            this.BackColor = original.BackColor;
            this.WordWrap = original.WordWrap;
            this.ScrollBars = original.ScrollBars;
            this.Multiline = original.Multiline;
            this.BorderStyle = original.BorderStyle;
            this.Dock = original.Dock;
        }
    }
}
