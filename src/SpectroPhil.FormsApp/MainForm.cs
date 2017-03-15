namespace SpectroPhil.FormsApp
{
	using SpectroPhil.Colorimetry;
	using SpectroPhil.Colorimetry.Illuminants;
	using SpectroPhil.Spectrophotometers.Xrite;
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Windows.Forms;
	using ZedGraph;
	
	/// <summary>
	/// Implements the main form.
	/// </summary>

	public partial class MainForm : Form
	{
		#region Structors

		/// <summary>
		/// Default constructor.
		/// </summary>

		public MainForm()
        {
            InitializeComponent();
		}

		#endregion


		#region Implementation

		/// <summary>
		/// Refreshes the chart.
		/// </summary>

		protected void RefreshChart( )
		{
			GraphPane pane = chart1.GraphPane;

			pane.CurveList.Clear();
			pane.GraphObjList.Clear();

			// generate spectral gradients
			if (showSpectrumCheckBox.Checked)
			{
				pane.GraphObjList.Add(new BoxObj(400.0, 100.0, 40.0, 100.0, Color.Transparent, Color.FromArgb(spectrumAlpha, 170, 0, 255), Color.FromArgb(spectrumAlpha, 0, 0, 255)));
				pane.GraphObjList.Add(new BoxObj(440.0, 100.0, 50.0, 100.0, Color.Transparent, Color.FromArgb(spectrumAlpha, 0, 0, 255), Color.FromArgb(spectrumAlpha, 0, 255, 255)));
				pane.GraphObjList.Add(new BoxObj(490.0, 100.0, 20.0, 100.0, Color.Transparent, Color.FromArgb(spectrumAlpha, 0, 255, 255), Color.FromArgb(spectrumAlpha, 0, 255, 0)));
				pane.GraphObjList.Add(new BoxObj(510.0, 100.0, 70.0, 100.0, Color.Transparent, Color.FromArgb(spectrumAlpha, 0, 255, 0), Color.FromArgb(spectrumAlpha, 255, 255, 0)));
				pane.GraphObjList.Add(new BoxObj(580.0, 100.0, 65.0, 100.0, Color.Transparent, Color.FromArgb(spectrumAlpha, 255, 255, 0), Color.FromArgb(spectrumAlpha, 255, 0, 0)));
				pane.GraphObjList.Add(new BoxObj(645.0, 100.0, 55.0, 100.0, Color.Transparent, Color.FromArgb(spectrumAlpha, 255, 0, 0), Color.FromArgb(spectrumAlpha, 255, 0, 0)));

				foreach (var obj in pane.GraphObjList)
				{
					obj.ZOrder = ZOrder.F_BehindGrid;
					obj.IsClippedToChartRect = true;
				}
			}

			// draw D65 illuminant
			if (showCieD65CheckBox.Checked)
			{
				PointPairList list = new PointPairList();

				foreach (var entry in cieD65.Data)
				{
					list.Add(entry.Key, entry.Value);
				}

				LineItem curve = pane.AddCurve("d65", list, Color.Gray, SymbolType.None);

				curve.IsY2Axis = true;
				curve.Line.IsSmooth = smoothCurvesCheckBox.Checked;
				curve.Line.SmoothTension = 0.5f;
			}

			// draw samples
			int measurementIndex = 0;

			foreach (var measurement in samples)
			{
				++measurementIndex;

				PointPairList list = new PointPairList();

				foreach (var spectralDensity in measurement)
				{
					list.Add(spectralDensity.Key, spectralDensity.Value);
				}

				LineItem curve = pane.AddCurve("s" + measurementIndex.ToString(), list, Color.Gray, SymbolType.None);

				curve.Line.IsSmooth = smoothCurvesCheckBox.Checked;
				curve.Line.SmoothTension = 0.5f;
			}

			// redraw chart
			chart1.AxisChange();
			chart1.Invalidate();
		}

        #endregion


        #region Callbacks

        // Callback for when the 'Clear' button is clicked
        private void HandleClearButtonClick(object sender, EventArgs e)
        {
            samples.Clear();
            RefreshChart();
        }

        // Callback for when the drop-down portion of the 'Com' combo box is shown
        private void HandleComDropDownDropDown(object sender, EventArgs e)
        {
            comComboBox.Items.Clear();

            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();

            foreach (var name in portNames)
            {
                comComboBox.Items.Add(name);
            }
        }

        // Callback for clicking the 'Scan' button.
        private void HandleScanButtonClick(object sender, EventArgs e)
		{
            if (comComboBox.SelectedItem == null)
            {
                Console.Write("Error: Please select a COM port!");
                return;
            }

            string comPort = comComboBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(comPort))
            {
                Console.Write("Error: Please select a COM port!");
                return;
            }

			Dtp41 spectro = new Dtp41(comPort);

            if (!spectro.Connect())
            {
                Console.Write("Error: Failed to connect to " + comPort);
                return;
            }

            bool success = false;

            try
			{
				// initialize device
				spectro.AutoTransmit = true;
				spectro.DecimalPoint = true;
				spectro.InstrumentMode = InstrumentModes.Reflectance;
				spectro.MeasurementMode = MeasurementModes.Static;
				spectro.OutputType = OutputTypes.Reflectance;
				spectro.DecimalPrecision = DecimalPrecisions.FiveDigits;
				spectro.ReadingsPerMeasurement = 10;
				spectro.ResponseDelimiter = ResponseDelimiters.CarriageReturnLineFeed;
				spectro.ResponseSeparator = ResponseSeparators.Tab;

				// take a measurement & update chart
				List<Dictionary<double, double>> measurements = new List<Dictionary<double, double>>();

				if (spectro.RequestMeasurements(measurements))
				{
					samples.AddRange(measurements);
                    RefreshChart();

                    success = true;
				}
 			}
			catch (System.Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

            if (!success)
            {
                Console.WriteLine("Error: Failed to get measurement");

                if (spectro.LastErrors.Count > 0)
                {
                    Console.Write("Last errors: ");

                    foreach (var error in spectro.LastErrors)
                    {
                        Console.Write(error + " ");
                    }

                    Console.Write("\n");
                }
            }

			spectro.Disconnect();

			RefreshChart();
		}

		// Callback for when the main form is loaded.
		private void HandleMainFormLoad(object sender, System.EventArgs e)
		{
			Console.SetOut(new TextBoxStringWriter(textBox1));

			// initialize chart
			chart1.IsShowHScrollBar = true;
			chart1.IsShowVScrollBar = true;
			chart1.IsAutoScrollRange = true;
			chart1.IsShowPointValues = true;

			GraphPane pane = chart1.GraphPane;

			pane.Legend.IsVisible = false;
			pane.Title.IsVisible = false;

			pane.XAxis.MajorGrid.IsVisible = true;
			pane.XAxis.Scale.Min = 400.0;
			pane.XAxis.Scale.Max = 700.0;
			pane.XAxis.Scale.MajorStep = 50.0;
			pane.XAxis.Scale.MinorStep = 10.0;
			pane.XAxis.Title.Text = "Wavelength (nm)";

			pane.YAxis.MajorTic.IsOpposite = false;
			pane.YAxis.MinorTic.IsOpposite = false;
			pane.YAxis.Scale.Min = 0.0;
			pane.YAxis.Scale.Max = 100.0;
			pane.YAxis.Scale.MajorStep = 10.0;
			pane.YAxis.Scale.MinorStep = 2.0;
			pane.YAxis.Title.Text = "Reflectance factor (%)";

			pane.Y2Axis.IsVisible = true;
			pane.Y2Axis.MajorTic.IsOpposite = false;
			pane.Y2Axis.MinorTic.IsOpposite = false;
			pane.Y2Axis.Scale.Min = 0.0;
			pane.Y2Axis.Scale.Max = 120.0;
			pane.Y2Axis.Title.Text = "Relative power";

			spectrumAlpha = 64;

			RefreshChart();
		}

		// Callback for clicking the 'Reset' button.
		private void HandleResetButtonClick( object sender, EventArgs e )
		{
			chart1.GraphPane.CurveList.Clear();
            chart1.RestoreScale(chart1.GraphPane);

			RefreshChart();
		}

		// Callback for clicking the 'Show Spectrum' check box.
		private void HandleShowSpectrumCheckBoxCheckedChanged( object sender, EventArgs e )
		{
			RefreshChart();
		}

		// Callback for clicking the 'Smooth curves' check box.
		private void HandleSmoothCurvesCheckBoxCheckedChanged( object sender, EventArgs e )
		{
			RefreshChart();
		}

		#endregion


		#region Fields

		// Holds the CIE D65 illuminant data.
		IIlluminant cieD65 = new CieD65();

		// Holds the collection of measured samples.
		List<Dictionary<double, double>> samples = new List<Dictionary<double, double>>();

		// Holds the alpha value of the spectrum background colors.
		int spectrumAlpha;

        #endregion
    }
}