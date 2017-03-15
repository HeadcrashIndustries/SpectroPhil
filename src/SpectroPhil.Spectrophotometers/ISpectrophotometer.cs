using System.Collections.Generic;


namespace SpectroPhil.Spectrophotometers
{
	/// <summary>
	/// Interface for spectrophotometers.
	/// </summary>
	public interface ISpectrophotometer
	{
		#region Methods

		/// <summary>
		/// Calibrates the instrument.
		/// </summary>
		/// <param name="calibration">The type of calibration to perform.</param>
		/// <returns>true if calibration completed successfully, false otherwise.</returns>
		/// <see cref="SpectroPhil.Spectrophotometers.Calibrations"/>
		
		bool Calibrate( Calibrations calibration );

		/// <summary>
		/// Connects the instrument.
		/// </summary>
		/// <returns>true if the instrument is connected, false otherwise.</returns>
		/// <see cref="Disconnect"/>
		
		bool Connect( );

		/// <summary>
		/// Disconnects the instrument.
		/// </summary>
		/// <returns>true if the instrument was disconnected, false otherwise.</returns>
		/// /// <see cref="Connect"/>
		
		bool Disconnect( );

		/// <summary>
		/// Checks whether the instrument is connected.
		/// </summary>
		/// <returns>true if the instrument is connected, false otherwise.</returns>
		/// <see cref="Connect"/>
		/// <see cref="Disconnect"/>
		
		bool IsConnected( );

		/// <summary>
        /// Requests measurements from the device.
        /// </summary>
		/// <param name="outMeasurements">Will contain the measurements.</param>
        
		bool RequestMeasurements( List<Dictionary<double, double>> outMeasurements );

		/// <summary>
		/// Resets the instrument to its default (power-up) state.
		/// </summary>
		/// <returns>true if the instrument was reset, false otherwise.</returns>
		
		bool Reset( );

		#endregion
	}
}
