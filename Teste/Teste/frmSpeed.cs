using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Win.Gauges.Digital;

namespace Teste
{
    public partial class frmSpeed : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmSpeed _instance;
        public static frmSpeed Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmSpeed();

                return _instance;
            }
        }

        public frmSpeed()
        {
            InitializeComponent();

            timer1.Interval = 166;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();
        }

        private void frmSpeed_Load(object sender, EventArgs e)
        {

        }

        private void gaugeControl1_Click(object sender, EventArgs e)
        {

        }

        #region Animation
        int animationLockCounterCore = 0;
        Random random = new Random(DateTime.Now.Millisecond);

        bool IsAnimationLocked { get { return animationLockCounterCore > 0; } }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (IsAnimationLocked)
                return;

            LockAnimation();

            DoAnimation(gaugeControl1);

            UnlockAnimation();
        }

        void UnlockAnimation()
        {
            animationLockCounterCore--;
        }

        void LockAnimation()
        {
            animationLockCounterCore++;
        }

        void DoAnimation(GaugeControl gauge)
        {
            foreach (IGauge gb in gauge.Gauges)
            {
                ICircularGauge cGauge = gb as ICircularGauge;
                if (cGauge != null)
                {
                    foreach (IScale scale in cGauge.Scales)
                    {
                        scale.Value = AnimateScaleValue(scale);
                        textEdit1.Text = scale.Value.ToString();
                    }
                }
            }
        }

        float AnimateScaleValue(IScale scale)
        {
            float deviation = ((float)random.NextDouble() - (scale as IConvertibleScale).Percent);
            return scale.Value + (scale.ScaleLength * 0.025f) * deviation;
        }

        string AnimateStringValue(DigitalGauge dGauge)
        {
            int value = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            return value.ToString();
        }

        #endregion
    }
}
