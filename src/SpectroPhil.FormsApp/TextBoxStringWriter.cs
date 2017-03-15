using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SpectroPhil.FormsApp
{
	/// <summary>
	/// Implements a string writer that can write to a text box.
	/// </summary>
	public class TextBoxStringWriter : TextWriter
	{
		#region Structors

		/// <summary>
		/// Creates and initializes a new instance.
		/// </summary>
		/// <param name="textBox">The text box to write to.</param>
		public TextBoxStringWriter(TextBox textBox)
		{
			outputBox = textBox;
		}

		#endregion


		#region TextWriter overrides

		public override Encoding Encoding
		{
			get
			{
				return Encoding.UTF8;
			}
		}

		public override void Write(char value)
		{
			base.Write(value);

			outputBox.AppendText(value.ToString());
		}

		#endregion


		#region Fields

		// Holds the text box to write to.
		TextBox outputBox;

		#endregion
	}
}
