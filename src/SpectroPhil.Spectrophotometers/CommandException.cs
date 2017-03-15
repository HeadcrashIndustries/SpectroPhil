using System;


namespace SpectroPhil.Spectrophotometers
{
	/// <summary>
	/// Implements an exception that is thrown if a command failed to execute on a spectrophotometer device.
	/// </summary>
	public class CommandException : Exception
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public CommandException(string command)
			: base("The command failed to execute: " + command)
		{ }
	}
}
