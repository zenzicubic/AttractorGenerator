using Tuple = Renderer.Tuple;

namespace CliffordAttractor
{
    public partial class Form1 : Form
    {
        double a = -2, 
            b = -2, 
            c = -1.2, 
            d = -2; // parameters
        int res = 100000, 
            prec = 10000; // number of points in preview and precision of decimals in calculation
        Tuple lastParameters;

        public Form1()
        {
            lastParameters = new(a, b, c, d);
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            // draw preview
            Tuple parameters = new(a, b, c, d);
            lastParameters = parameters;
            Bitmap bitmap = Renderer.Renderer.Render(parameters, 918, 100, res);
            previewBox.Image = bitmap;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void randomizerBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            // randomly generate new params
            a = rand.Next(-3 * prec, 3 * prec) / (1.0 * prec);
            b = rand.Next(-3 * prec, 3 * prec) / (1.0 * prec);
            c = rand.Next(-3 * prec, 3 * prec) / (1.0 * prec);
            d = rand.Next(-3 * prec, 3 * prec) / (1.0 * prec);
            // update label text
            ALabel.Text = "a: " + a.ToString();
            BLabel.Text = "b: " + b.ToString();
            CLabel.Text = "c: " + c.ToString();
            DLabel.Text = "d: " + d.ToString();
            // update slider values
            ASlider.Value = (int)a * prec;
            BSlider.Value = (int)b * prec;
            CSlider.Value = (int)c * prec;
            DSlider.Value = (int)d * prec;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            // export result
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Bitmap images (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // get file path and write bitmap there
                string filePath = saveDialog.FileName;

                Bitmap bitmap = Renderer.Renderer.Render(lastParameters, 5000, 600, 1000000);
                bitmap.Save(filePath);
            }
        }

        private void resSlider_Scroll(object sender, EventArgs e)
        {
            // control preview resolution
            res = resSlider.Value;
            numPointsL.Text = "Resolution of preview: " + res.ToString() + " points";
            Draw();
        }

        #region parameter sliders
        private void ASlider_Scroll(object sender, EventArgs e)
        {
            a = (ASlider.Value * 1.0) / prec;
            ALabel.Text = "a: " + a.ToString();
        }

        private void BSlider_Scroll(object sender, EventArgs e)
        {
            b = (BSlider.Value * 1.0) / prec;
            BLabel.Text = "b: " + b.ToString();
        }

        private void CSlider_Scroll(object sender, EventArgs e)
        {
            c = (CSlider.Value * 1.0) / prec;
            CLabel.Text = "c: " + c.ToString();
        }

        private void DSlider_Scroll(object sender, EventArgs e)
        {
            d = (DSlider.Value * 1.0) / prec;
            DLabel.Text = "d: " + d.ToString();
        }
        #endregion
    }
} 