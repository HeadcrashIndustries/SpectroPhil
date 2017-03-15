using System.Collections.Generic;


namespace SpectroPhil.Spectrophotometers
{
	/// <summary>
	/// Implements a comparer for spectral densities.
	/// </summary>
	public class SpectralDensityComparer : IComparer<SpectralDensity>
	{
		#region IComparer interface

		public int Compare(SpectralDensity x, SpectralDensity y)
		{
			return Comparer<double>.Default.Compare(x.Wavelength, y.Wavelength);
		}

		#endregion
	}
}
