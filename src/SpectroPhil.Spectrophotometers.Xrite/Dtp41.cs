using SpectroPhil.Spectrophotometers;
using System;
using System.Collections.Generic;
using System.IO.Ports;


namespace SpectroPhil.Spectrophotometers.Xrite
{
    /// <summary>
    /// Implements an X-Rite spectrophotometer.
    /// </summary>
    public class Dtp41 : ISpectrophotometer
    {
        #region Structors

		/// <summary>
		/// Creates and initializes a new instance.
		/// </summary>
		/// <param name="SerialPort">The name of the serial port that the device is connected to.</param>

		public Dtp41(string portName)
		{
			lastErrors = new List<string>();
			serialPort = new SerialPort(portName, 9600, Parity.None, 8,  StopBits.One);

			serialPort.Handshake = Handshake.None;
			serialPort.NewLine = "\r\n";
		}

        #endregion


        #region Properties

        /// <summary>
        /// Gets or sets whether to auto-transmit output data.
        /// </summary>

		public bool AutoTransmit
        {
            get
            {
                return autoTransmit;
            }
            set
            {
				if (ExecuteCommand((value ? "01" : "00") + "05CF", 200))
				{
					autoTransmit = true;
				}
				else
				{
					throw new CommandException("AutoTransmit=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Holds the number of samples to average per static reading.
        /// </summary>

		public byte AveragedSamplesPerReading
        {
            get
            {
                return averagedSamplesPerReading;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "14CF", 200))
				{
					averagedSamplesPerReading = value;
				}
				else
				{
					throw new CommandException("AveragedSamplesPerReading=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the beeper tone.
        /// </summary>

		public BeeperTones BeeperTone
        {
            get
            {
                return beeperTone;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "01CF", 200))
				{
					beeperTone = value;
				}
				else
				{
					throw new CommandException("BeeperTone=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets whether to include a decimal point in output data.
        /// </summary>

		public bool DecimalPoint
        {
            get
            {
                return decimalPoint;
            }
            set
            {
				if (ExecuteCommand((value ? "01" : "00") + "06CF", 200))
				{
					decimalPoint = true;
				}
				else
				{
					throw new CommandException("DecimalPoint=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the decimal precision of returned data elements.
        /// </summary>

		public DecimalPrecisions DecimalPrecision
        {
            get
            {
                return decimalPrecision;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "0ACF", 200))
				{
					decimalPrecision = value;
				}
				else
				{
					throw new CommandException("DecimalPrecision=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the density status.
        /// </summary>

		public DensityStatuses DensityStatus
        {
            get
            {
                return densityStatus;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "17CF", 200))
				{
					densityStatus = value;
				}
				else
				{
					throw new CommandException("DensityStatus=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets whether echo mode should be enabled.
        /// </summary>

		public bool EchoEnabled
        {
            get
            {
                return echoEnabled;
            }
            set
            {
				if (ExecuteCommand((value ? "01" : "00") + "09CF", 200))
				{
					echoEnabled = value;
				}
				else
				{
					throw new CommandException("EchoEnabled" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the type of illuminants and observers.
        /// </summary>

		public IlluminantObserverTypes IlluminantObserverType
        {
            get
            {
                return illuminantObserverType;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "16CF", 200))
				{
					illuminantObserverType = value;
				}
				else
				{
					throw new CommandException("IlluminantObserverType=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the instrument mode (i.e. reflectance or transmission).
        /// </summary>

		public InstrumentModes InstrumentMode
        {
            get
            {
                return instrumentMode;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "19CF", 200))
				{
					instrumentMode = value;
				}
				else
				{
					throw new CommandException("InstrumentMode=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets the list of errors from the last operation.
        /// </summary>

		public List<string> LastErrors
        {
            get
            {
                return lastErrors;
            }
        }

        /// <summary>
        /// Gets or sets the measurement mode (i.e. static or dynamic).
        /// </summary>

		public MeasurementModes MeasurementMode
        {
            get
            {
                return measurementMode;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "13CF", 200))
				{
					measurementMode = value;
				}
				else
				{
					throw new CommandException("MeasurementMode=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the motor speed (1.2 = default).
        /// </summary>

		public float MotorSpeed
        {
            get
            {
                return motorSpeed;
            }
            set
            {
				if (ExecuteCommand(value.ToString("0.00") + "DM", 200))
				{
					motorSpeed = value;
				}
				else
				{
					throw new CommandException("MotorSpeed=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the output type.
        /// </summary>

		public OutputTypes OutputType
        {
            get
            {
                return outputType;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "18CF", 200))
				{
					outputType = value;
				}
				else
				{
					throw new CommandException("OutputType=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the RS232 protocol mode.
        /// </summary>

		public ProtocolModes ProtocolMode
        {
            get
            {
                return protocolMode;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "12CF", 200))
				{
					protocolMode = value;
				}
				else
				{
					throw new CommandException("ProtocolMode=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the number of readings to take per static measurement.
        /// </summary>

		public byte ReadingsPerMeasurement
        {
            get
            {
                return readingsPerMeasurement;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "15CF", 200))
				{
					readingsPerMeasurement = value;
				}
				else
				{
					throw new CommandException("ReadingsPerMeasurement=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the response data delimiter (used to separate multiple data sets).
        /// </summary>

		public ResponseDelimiters ResponseDelimiter
        {
            get
            {
                return responseDelimiter;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "08CF", 200))
				{
					responseDelimiter = value;

					if (value == ResponseDelimiters.CarriageReturn)
					{
						serialPort.NewLine = "\r";
					}
					else if (value == ResponseDelimiters.LineFeed)
					{
						serialPort.NewLine = "\n";
					}
					else
					{
						serialPort.NewLine = "\r\n";
					}
				}
				else
				{
					throw new CommandException("ResponseDelimiter=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the response data separator mode (used to separate elements within a returned data set).
        /// </summary>

		public ResponseSeparators ResponseSeparator
        {
            get
            {
                return responseSeparator;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "07CF", 500))
				{
					responseSeparator = value;
				}
				else
				{
					throw new CommandException("ResponseSeparator=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets the serial port's handshake mode.
        /// </summary>

		public SerialHandshakes SerialHandshake
        {
            get
            {
                return serialHandshake;
            }
            set
            {
				if (ExecuteCommand(((byte)value).ToString("X2") + "04CF", 200))
				{
					serialHandshake = value;
				}
				else
				{
					throw new CommandException("SerialHandshake=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets or sets whether data labels should be shown in returned data sets.
        /// </summary>

		public bool ShowDataLabels
        {
            get
            {
                return showDataLabels;
            }
            set
            {
				if (ExecuteCommand((value ? "01" : "00") + "09CF", 200))
				{
					showDataLabels = value;
				}
				else
				{
					throw new CommandException("ShowDataLabels=" + value.ToString());
				}
            }
        }

        /// <summary>
        /// Gets the device's version string.
        /// </summary>

		public string Version
        {
            get
            {
                return version;
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// Calibrates the drive motor.
        /// </summary>
		/// <returns>true if calibration succeeded, false otherwise.</returns>

		public bool CalibrateDriveMotor()
        {
			return ExecuteCommand("CM", 15000);
        }

        /// <summary>
        /// Calibrates the reflectance using the reference sheet.
        /// </summary>
		/// <returns>true if calibration succeeded, false otherwise.</returns>
        
		public bool CalibrateReflectance()
        {
			return ExecuteCommand("CR", 60000);
        }

		/// <summary>
		/// Calibrates the transmittance using the reference sheet.
		/// </summary>
		/// <returns></returns>
		
		public bool CalibrateTransmittance()
		{
			return ExecuteCommand("CT", 60000);
		}

        /// <summary>
        /// Calibrates the device.
        /// </summary>
		/// <returns>true if calibration succeeded, false otherwise.</returns>
        
		public bool CalibrateUnit()
        {
			return ExecuteCommand("CU", 60000);
        }

		/// <summary>
		/// Toggles the drive motor on off.
		/// </summary>
		/// <returns>true if the motor was toggled, false otherwise.</returns>
		
		public bool ToggleMotor()
		{
			try
			{
				serialPort.WriteLine("DM");
			}
			catch (System.Exception ex)
			{
				Console.WriteLine("An error occurred when attempting to toggle the drive motor: " + ex.Message);

				return false;
			}

			return true;
		}

		/// <summary>
		/// Reads the current device configuration.
		/// </summary>
		/// <returns>true on success, false otherwise.</returns>
		
		public bool ReadConfiguration()
		{



			return true;
		}

        #endregion


		#region ISpectrophotometer interface

		/// <summary>
		/// Calibrates the instrument.
		/// </summary>
		/// <param name="calibration">The type of calibration to perform.</param>
		/// <returns>true if calibration completed successfully, false otherwise.</returns>

		public bool Calibrate(Calibrations calibration)
		{
			switch (calibration)
			{
				case Calibrations.DriveMotor:
					return CalibrateDriveMotor();

				case Calibrations.Reflectance:
					return CalibrateReflectance();

				case Calibrations.Transmittance:
					return CalibrateTransmittance();

				default:
					return false;
			}
		}

		/// <summary>
		/// Connects the instrument.
		/// </summary>
		/// <returns>true if the instrument is connected, false otherwise.</returns>
		/// <see cref="Disconnect"/>

		public bool Connect()
		{
			try
			{
				serialPort.Open();
			}
			catch (System.Exception ex)
			{
				serialPort.Close();

				Console.WriteLine("Failed to connect to the device: " + ex.Message);

				return false;
			}

			return ReadConfiguration();
		}

		/// <summary>
		/// Disconnects the instrument.
		/// </summary>
		/// <returns>true if the instrument was disconnected, false otherwise.</returns>
		/// <see cref="Connect"/>

		public bool Disconnect()
		{
			try
			{
				serialPort.Close();
			}
			catch (System.Exception ex)
			{
				Console.WriteLine("Failed to disconnect from the device: " + ex.Message);

				return false;
			}

			return true;
		}

		/// <summary>
		/// Checks whether the instrument is connected.
		/// </summary>
		/// <returns>true if the instrument is connected, false otherwise.</returns>
		/// <see cref="Connect"/>
		/// <see cref="Disconnect"/>
		
		public bool IsConnected()
		{
			return serialPort.IsOpen;
		}

		/// <summary>
		/// Requests measurements from the device.
		/// </summary>
		/// <param name="outMeasurements">Will contain the measurements.</param>
		
		public bool RequestMeasurements(List<Dictionary<double, double>> outMeasurements)
        {
			List<string> output = new List<string>();

			if (ExecuteCommand("RM", 30000, output))
			{
				foreach (var line in output)
				{
					var measurement = new Dictionary<double, double>();

					string[] densities = line.Split(new Char[] { '\t' });

					double wavelength = 400;

					foreach (var density in densities)
					{
						measurement.Add(wavelength, float.Parse(density));
						wavelength += 10;
					}

					outMeasurements.Add(measurement);
				}

				return true;
			}

			return false;
        }

		/// <summary>
		/// Resets the instrument to its default (power-up) state.
		/// </summary>
		/// <returns>true if the instrument was reset, false otherwise.</returns>
		
		public bool Reset()
		{
			return ExecuteCommand("RI", 3000);
		}

		#endregion


		#region Implementation

		/// <summary>
		/// Checks the given return code.
		/// </summary>
		/// <remarks>
		/// If the return code indicates that the device has extended error information available,
		/// it will copy all error codes into the LastErrors collection. Otherwise, only the return
		/// code will be copied into LastErrors.
		/// </remarks>
		/// <returns>true if the return code indicates success, false if errors are present.</returns>
		
		protected bool CheckReturnCode(string returnCode)
		{
			lastErrors.Clear();

			if (returnCode.StartsWith("<A", StringComparison.OrdinalIgnoreCase))
			{
				serialPort.WriteLine("XE");

				try
				{
					serialPort.ReadTimeout = 10;

					while (true)
					{
						lastErrors.Add(serialPort.ReadLine());
					}
				}
				catch (Exception ex)
				{
					if (ex is TimeoutException == false)
					{
						Console.WriteLine("An error occurred when attempting to read extended error codes from the device: " + ex.Message);

						return false;
					}
				}

				return true;
			}
			else
			{
				lastErrors.Add(returnCode);
			}

			return (returnCode == "<00>");
		}

		/// <summary>
		/// Executes the specified command and returns all output.
		/// </summary>
		/// <param name="command">The command to execute.</param>
		/// <param name="outResults">Will contain the command results.</param>
		/// <returns>true if the command was executed successfully, false otherwise.</returns>
		
		protected bool ExecuteCommand(string command, int timeout, List<string> outResults = null)
		{
			// send the command
			try
			{
				serialPort.WriteLine(command);
			}
			catch (System.Exception ex)
			{
				Console.WriteLine("An error occurred when attempting to send a command to the device: " + ex.Message);

				return false;
			}

			if (outResults != null)
			{
				outResults.Clear();
			}

			// fetch the results
			try
			{
				serialPort.ReadTimeout = timeout;

				while (true)
				{
					string line = serialPort.ReadLine();

					if (line.StartsWith("<"))
					{
						return CheckReturnCode(line);
					}

					if (outResults != null)
					{
						outResults.Add(line);
					}					
				}
			}
			catch (System.Exception ex)
			{
				if (ex is TimeoutException == false)
				{
					Console.WriteLine("An error occurred when attempting to read the command results from the device: " + ex.Message);
				}
				else
				{
					Console.WriteLine("The device did not provide a return code after executing a command.");
				}

				return false;
			}
		}

		#endregion


		#region Fields

		// Holds a flag indicating whether to auto-transmit output data.
        private bool autoTransmit;

        // Holds the number of samples to average per static reading.
        private byte averagedSamplesPerReading;

        // Holds the beeper tone mode.
        private BeeperTones beeperTone;

        // Holds a flag indicating whether to include a decimal point in output data.
        private bool decimalPoint;

        // Holds the decimal precision of returned data elements.
        private DecimalPrecisions decimalPrecision;

        // Holds the density status.
        private DensityStatuses densityStatus;

        // Holds a flag indicating whether echo mode is enabled.
        private bool echoEnabled;

        // Holds the list of errors from the last operation.
        private List<string> lastErrors;

        // Holds the type of illuminants and observers.
        private IlluminantObserverTypes illuminantObserverType;

        // Holds the instrument mode.
        private InstrumentModes instrumentMode;

        // Holds the measurement mode.
        private MeasurementModes measurementMode;

        // Holds the motor speed (1.2 = default).
        private float motorSpeed;

        // Holds the output type.
        private OutputTypes outputType;

        // Holds the RS232 protocol mode.
        private ProtocolModes protocolMode;

        // Holds the response data delimiter (between each returned data set).
        private ResponseDelimiters responseDelimiter;

        // Holds the response data separator (between each data element).
        private ResponseSeparators responseSeparator;

        // Holds the serial handshake mode.
        private SerialHandshakes serialHandshake;

		// Holds the serial port that the device is connected to.
		private SerialPort serialPort;

        // Holds a flag indicating whether data labels should be shown in returned data sets.
        private bool showDataLabels;

        // Holds the number of readings to take per static measurement.
        private byte readingsPerMeasurement;

        // Holds the device's version string.
        private string version;

        #endregion
    }
}