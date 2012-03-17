using System;
using Eto.Forms;
using Eto.Drawing;

namespace PostMachine.EtoGui
{
	public class MainForm : Form
	{
		private TextBox url;
		private TextBox postdata;
		
		public MainForm() : base()
		{
			base.Text = "PostMachine";
			base.Size = new Size(600, 200);
			
			this.url = new TextBox();
			this.postdata = new TextBox();
			
			this.MakeTableLayout();
		}
		
		#region Dynamic layout
		private void MakeDynamicLayout()
		{
			DynamicLayout layout = new DynamicLayout(this);

			layout.BeginVertical(); // create a fields section
			
			//
			// 1st row
			// [url] [url input]
			//
			layout.BeginHorizontal();
			layout.Add(new Label { Text = "Url" });
			layout.Add(this.url, true); // true == scale horizontally
			layout.EndHorizontal();
			
			
			//
			// 2nd row
			// [label]
			//
			layout.BeginHorizontal();
			layout.Add(new Label { Text = "Post data" });
			layout.EndHorizontal();
			
			
			//
			// 3rd row
			// [post input]
			//
			layout.BeginHorizontal();
			layout.Add(this.postdata, true, true);
			layout.EndHorizontal();
			
			
			layout.EndVertical();
			
			/*
			layout.BeginVertical(); // buttons section
			layout.BeginHorizontal();
			layout.Add(null, true); // add a blank space scaled horizontally to fill space
			layout.Add(new Button { Text = "Cancel" });
			layout.Add(new Button { Text = "Ok" });
			layout.EndHorizontal();
			layout.EndVertical();
			*/
		}
		#endregion Dynamic layout
		
		#region Table layout
		private void MakeTableLayout()
		{
			var panel = new Panel();
			var layout = new TableLayout(panel, 2, 4);  // creates a 2x3 table
			
			//
			// 1st row
			// [url] [url input]
			//
			layout.Add(new Label{ Text = "Url" }, 0, 0);
			layout.Add(this.url, 1, 0);
			
			//
			// 2nd row
			// [label]
			//
			// layout.Add(new Label() { Text = "Post data" }, 
			
			layout.Add(new Label{ Text = "Second Line" }, 0, 1);
			layout.Add(new ComboBox(), 1, 1);
			
			layout.Add(new Label{ Text = "Third Line" }, 0, 2);
			layout.Add(new ListBox(), 1, 2);
			
			this.AddDockedControl(panel);
		}
		#endregion Table layout
	}
}