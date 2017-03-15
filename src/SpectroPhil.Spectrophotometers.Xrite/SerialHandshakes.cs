namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Enumerates handshake modes for the serial port.
    /// </summary>
    public enum SerialHandshakes
    {
        /// <summary>
        /// No handshakes.
        /// </summary>
        Off = 0,

        /// <summary>
        /// Clear to send handshake.
        /// </summary>
        Cts = 1,

        /// <summary>
        /// Busy handshake.
        /// </summary>
        Busy = 2,

        /// <summary>
        /// XOn/XOff handshake.
        /// </summary>
        Xon = 3,
    }
}