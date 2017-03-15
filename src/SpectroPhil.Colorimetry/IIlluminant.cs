namespace SpectroPhil.Colorimetry
{
	using System.Collections.Generic;
	
	/// <summary>
	/// Interface for illuminants.
	/// </summary>

	public interface IIlluminant
	{
		#region Methods

		/// <summary>
		/// Gets the illuminant's relative spectral power for the specified wavelength.
		/// </summary>
		/// <param name="wavelength">The wavelength to get the spectral power for.</param>
		/// <returns>The Spectral power.</returns>

		double GetRelativePower(int wavelength);

		#endregion


		#region Properties

		/// <summary>
		/// Gets the illuminant's data table.
		/// </summary>

		IDictionary<int, double> Data { get; }

		/// <summary>
		/// Gets the illuminant's name.
		/// </summary>

		string Name { get; }

		#endregion
	}
}
