using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Negocio
{
    public class MListBox : ListBox
    {
        private System.ComponentModel.Container components = null;

        public MListBox()
        {
            InitializeComponent();
            base.DrawMode = DrawMode.OwnerDrawFixed;
        }

        [Browsable(false)]
        public override DrawMode DrawMode
        {
            get { return DrawMode.OwnerDrawFixed; }
            set { }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Draw background for each item.
            e.DrawBackground();

            // Get's fired even if there are no itme sin the list!
            if (Items.Count > 0)
            {
                string item = Items[e.Index].ToString();

                SizeF itemSize = e.Graphics.MeasureString(item, e.Font, 0);
                PointF centredPoint = new PointF(e.Bounds.Left + ((e.Bounds.Width -
                itemSize.Width) / 2), e.Bounds.Top);
                Brush itemBrush = SystemBrushes.ControlText;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    itemBrush = SystemBrushes.HighlightText;
                }

                // draw item at correct location
                e.Graphics.DrawString(item, e.Font, itemBrush, centredPoint);
            }

            // Draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion
    }
}