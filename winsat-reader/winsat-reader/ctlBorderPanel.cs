﻿/*
 * "how i can i change the panel border line color(very urgent)" - MSDN Forum
 * https://social.msdn.microsoft.com/Forums/vstudio/en-US/bb34d858-4023-4a51-9448-2842f32829f2/how-i-can-i-change-the-panel-border-line-colorvery-urgent?forum=csharpgeneral
 */
using System.Windows.Forms;
using System.Drawing;

namespace winsat_reader
{
    class ctlBorderPanel : Panel
    {
		public ctlBorderPanel()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(BorderColor), 6), e.ClipRectangle); //Penのwidthは偶数（奇数は幅がおかしい）
        }

		public Color BorderColor { get; set; } = Color.Transparent;
	}
}
