namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Enumerates the available density status types.
    /// </summary>
    public enum DensityStatuses
    {
        /// <summary>
        /// Status_A (reflectance, ANSI)
        /// </summary>
        StatusA = 0,

        /// <summary>
        /// Status_B
        /// </summary>
        StatusE = 1,

        /// <summary>
        /// Status_I
        /// </summary>
        StatusI = 2,

        /// <summary>
        /// Status_T
        /// </summary>
        StatusT = 3,

        /// <summary>
        /// Spectral (ANSI)
        /// </summary>
        Spectral = 4,

        /// <summary>
        /// Spectral with correction factors.
        /// </summary>
        SpectralX = 5,

        /// <summary>
        /// VCMYRGBO
        /// </summary>
        StatusHifi = 6,

        /// <summary>
        /// StatusT with correction factors.
        /// </summary>
        StatusTx = 8,

        /// <summary>
        /// Reflectance with correction factors.
        /// </summary>
        StatusAx = 9,

        /// <summary>
        /// Status_E with correction factors.
        /// </summary>
        StatusEx = 10,

        /// <summary>
        /// Status_G
        /// </summary>
        StatusG = 11,

        /// <summary>
        /// Status_M
        /// </summary>
        StatusM = 12,

        /// <summary>
        /// Status_Axt (transmission)
        /// </summary>
        StatusAxt = 13,

        /// <summary>
        /// Status_M with correction factors.
        /// </summary>
        StatusMx = 14
    }
}