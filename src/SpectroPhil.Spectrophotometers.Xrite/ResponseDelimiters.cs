namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Enumerates delimiters for response data.
    /// </summary>
    /// <remarks>
    /// The delimiter is used to separate multiple data sets.
    /// </remarks>
    public enum ResponseDelimiters
    {
        /// <summary>
        /// Carriage return separator.
        /// </summary>
        CarriageReturn = 0,

        /// <summary>
        /// Carriage return and line feed separator.
        /// </summary>
        CarriageReturnLineFeed = 1,

        /// <summary>
        /// Line feed separator.
        /// </summary>
        LineFeed = 2,
    }
}