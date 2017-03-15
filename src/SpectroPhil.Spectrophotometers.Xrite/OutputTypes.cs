namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Enumerates data output types.
    /// </summary>
    public enum OutputTypes
    {
        Density = 0,

        PlusDot = 1,

        MinusDot = 2,

        /// <summary>
        /// Reflectance
        /// </summary>
        Reflectance = 3,

        /// <summary>
        /// LAB
        /// </summary>
        Lab = 4,

        /// <summary>
        /// XYZ
        /// </summary>
        Xyx = 5,

        /// <summary>
        /// Yxy
        /// </summary>
        Yxy = 6,

        /// <summary>
        /// xyY
        /// </summary>
        xyY = 7,

        /// <summary>
        /// LCh
        /// </summary>
        Lch = 8,

        /// <summary>
        /// Density (VCMYRGBO)
        /// </summary>
        Vcmyrgbo = 9,
    }
}