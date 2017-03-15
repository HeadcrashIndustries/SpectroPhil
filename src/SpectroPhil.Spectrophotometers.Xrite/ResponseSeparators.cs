namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Enumerates separator modes for response data in ICP mode.
    /// </summary>
    /// <remarks>
    /// The separator is used to separate elements within a returned data set.
    /// </remarks>
    public enum ResponseSeparators
    {
        /// <summary>
        /// Space separator.
        /// </summary>
        Space = 0,

        /// <summary>
        /// Comma separator.
        /// </summary>
        Comma = 1,

        /// <summary>
        /// Tab separator.
        /// </summary>
        Tab = 2,

        /// <summary>
        /// Carriage return separator.
        /// </summary>
        CarriageReturn = 3,

        /// <summary>
        /// Carriage return and line feed separator.
        /// </summary>
        CarriageReturnLineFeed = 4,

        /// <summary>
        /// Line feed separator.
        /// </summary>
        LineFeed = 5,
    }
}