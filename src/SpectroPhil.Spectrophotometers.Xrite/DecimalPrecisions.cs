namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Enumerates available decimal precisions for returned data elements.
    /// </summary>
    public enum DecimalPrecisions
    {
        /// <summary>
        /// Round values to integer.
        /// </summary>
        Integer = 0,

        /// <summary>
        /// One digit precision (i.e. 3.1).
        /// </summary>
        OneDigit = 1,

        /// <summary>
        /// Two digits precision (i.e. 3.14).
        /// </summary>
        TwoDigits = 2,

        /// <summary>
        /// Three digits precision (i.e. 3.141).
        /// </summary>
        ThreeDigits = 3,

        /// <summary>
        /// Four digits precision (i.e. 3.1415).
        /// </summary>
        FourDigits = 4,

        /// <summary>
        /// Five digits precision (i.e. 3.1419).
        /// </summary>
        FiveDigits = 5,
    }
}