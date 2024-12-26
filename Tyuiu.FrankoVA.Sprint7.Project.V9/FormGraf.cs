using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.FrankoVA.Sprint7.Project.V9.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.FrankoVA.Sprint7.Project.V9
{
    public partial class FormGraf : Form
    {
        public FormGraf()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "z.csv");

        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;

        private void buttonGuide_VA_Click(object sender, EventArgs e)
        {
            FormGuide fmen = new FormGuide();
            fmen.TopMost = true;
            fmen.ShowDialog();
        }

        private void buttonOProg_VA_Click(object sender, EventArgs e)
        {
            FormOProg fmen = new FormOProg();
            fmen.TopMost = true;
            fmen.ShowDialog();
        }

        private void buttonExit_VA_Click(object sender, EventArgs e)
        {
            FormMain gr = new FormMain();
            gr.Visible = true;
            this.Close();
        }

        //минимальная
        private void длительностьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);

            chartGraf_VA.Series.Clear();
            chartGraf_VA.ChartAreas.Clear(); 
            chartGraf_VA.ChartAreas.Add("MainChartArea"); 

            
            var chartArea = chartGraf_VA.ChartAreas["MainChartArea"];
            chartArea.AxisX.Title = "Фильмы"; 
            chartArea.AxisY.Title = "Длительность (минуты)"; 
            chartArea.AxisX.Interval = 1; 
            chartArea.AxisX.LabelStyle.Angle = -45; 
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold); 
            chartArea.AxisY.LabelStyle.Font = new Font("Arial", 10); 
            chartArea.AxisX.MajorGrid.Enabled = false; 
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray; 

           
            chartArea.AxisX.IsMarginVisible = true; 
            chartArea.AxisX.Minimum = 0; 
            chartArea.AxisX.Maximum = rows - 1; 

            double minDuration = double.MaxValue;

            for (int i = 1; i < rows; i++)
            {
                string filmName = matrix[i, 2]; 
                string durationText = matrix[i, 3]; 
                double parsedDuration = ParseDurationToMinutes(durationText); 

                if (parsedDuration >= 0) 
                {

                    if (parsedDuration < minDuration)
                    {
                        minDuration = parsedDuration;
                    }

                    
                    var series = chartGraf_VA.Series.Add(filmName);
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; 

                  
                    series.Points.AddXY(i, parsedDuration);

                    
                    series["PointWidth"] = "2"; 
                    series.Color = Color.FromArgb(100 + i * 10 % 155, 50 + i * 20 % 155, 200 - i * 15 % 155); 
                }
                else
                {
                    
                    MessageBox.Show($"Ошибка обработки длительности в строке {i + 1}: {durationText}",
                                     "Ошибка",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            
            if (minDuration != double.MaxValue) 
            {
                textBoxRes_VA.Text = $"Min: {minDuration} мин";
            }
            else
            {
                textBoxRes_VA.Text = "Не удалось найти минимальную длительность.";
            }
        }

        //Максимальная
        private void длительностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);

            
            chartGraf_VA.Series.Clear();
            chartGraf_VA.ChartAreas.Clear(); 
            chartGraf_VA.ChartAreas.Add("MainChartArea"); 

            
            var chartArea = chartGraf_VA.ChartAreas["MainChartArea"];
            chartArea.AxisX.Title = "Фильмы"; 
            chartArea.AxisY.Title = "Длительность (минуты)"; 
            chartArea.AxisX.Interval = 1; 
            chartArea.AxisX.LabelStyle.Angle = -45; 
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold); 
            chartArea.AxisY.LabelStyle.Font = new Font("Arial", 10); 
            chartArea.AxisX.MajorGrid.Enabled = false; 
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray; 

            
            chartArea.AxisX.IsMarginVisible = true; 
            chartArea.AxisX.Minimum = 0; 
            chartArea.AxisX.Maximum = rows - 1; 

        
            for (int i = 1; i < rows; i++)
            {
                string filmName = matrix[i, 2]; 
                string durationText = matrix[i, 3]; 
                double parsedDuration = ParseDurationToMinutes(durationText); 

                if (parsedDuration >= 0) 
                {
                    
                    var series = chartGraf_VA.Series.Add(filmName);
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; 

                    
                    series.Points.AddXY(i, parsedDuration);

                  
                    series["PointWidth"] = "2";
                    series.Color = Color.FromArgb(100 + i * 10 % 155, 50 + i * 20 % 155, 200 - i * 15 % 155);
                }
                else
                {
                    
                    MessageBox.Show($"Ошибка обработки длительности в строке {i + 1}: {durationText}",
                                     "Ошибка",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            
            double maxDuration = 0;
            if (rows > 1) 
            {
                maxDuration = chartGraf_VA.Series.SelectMany(s => s.Points).Max(p => p.YValues[0]);
            }
            textBoxRes_VA.Text = $"Max: {maxDuration} мин";

        }
        private double ParseDurationToMinutes(string durationText)
        {
            chartGraf_VA.ChartAreas[0].AxisX.Title = "Фильмы";
            chartGraf_VA.ChartAreas[0].AxisY.Title = "Длительность (минуты)";
            try
            {
                
                string[] parts = durationText.Split(' '); 

                int hours = 0;
                int minutes = 0;

                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Contains("ч")) 
                    {
                        hours = int.Parse(parts[i - 1]); 
                    }
                    else if (parts[i].Contains("мин")) 
                    {
                        minutes = int.Parse(parts[i - 1]); 
                    }
                }

                return hours * 60 + minutes; 
            }
            catch
            {
                return -1; 
            }
        }

       
        
           
    }
}

  



