using System;


namespace SpectroPhil.Spectrophotometers
{
	/// <summary>
	/// Structure for a spectral density.
	/// </summary>
	[Serializable]
	public struct SpectralDensity
	{
		#region Fields

		/// <summary>
		/// Holds the spectral density for the wavelength.
		/// </summary>
		public double Density;

		/// <summary>
		/// Holds the wavelength at which the spectral density was measured.
		/// </summary>
		public double Wavelength;

		#endregion


		#region Structors

		/// <summary>
		/// Creates and initializes a new instance.
		/// </summary>
		/// <param name="inWavelength">The wavelength at which the spectral density was measured.</param>
		/// <param name="inDensity">The spectral density for the wavelength.</param>
		public SpectralDensity(double inWavelength, double inDensity)
		{
			Density = inDensity;
			Wavelength = inWavelength;
		}

		#endregion
	}
}