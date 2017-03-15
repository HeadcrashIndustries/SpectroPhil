namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Enumerates known device errors.
    /// </summary>
    public enum ErrorCodes
    {
        NoError = 0,
        BadCommand = 0x11,
        Timeout = 0x21,
        BadStrip = 0x22,
        BadReading = 0x27,
        NeedsCalibration = 0x28,
        CalibrationFailure = 0x29,
        LampError = 0x31,
        DriveMotorError = 0x34,
        TemperatureError = 0x3d,
        TransmissionLampError = 0x3f
    }
}