using System;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Base;
using System.Threading;

namespace Teste
{
    public partial class frmRPM : DevExpress.XtraEditors.XtraUserControl
    {
        SynchronizationContext sync = null;
        private static frmRPM _instance;
        public static frmRPM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmRPM();

                return _instance;
            }
        }

        public frmRPM()
        {
            InitializeComponent();

            sync = SynchronizationContext.Current;

            timer1.Interval = 166;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();

            trackBarControl1.Enabled = false;
        }

        #region Animation
        int animationLockCounterCore = 0;
        Random random = new Random(DateTime.Now.Millisecond);

        public double currentRPM = 0;

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
                        scale.Value = frmConnection.Instance.RPM;
                        textEdit1.Text = frmConnection.Instance.RPM.ToString();
                    }
                }
            }
        }

        float AnimateScaleValue(IScale scale)
        {
            var currValue = trackBarControl1.Value;
            var error = (currValue > 10) ? currValue - 10 : 0;

            var value = (random.Next(error, currValue)) / 100.0f;
            float deviation = (value - (scale as IConvertibleScale).Percent);
            //return scale.Value + (scale.ScaleLength * 0.075f) * deviation;

            return trackBarControl1.Value;
        }

        #endregion

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            sync.Post(f =>
            {
                textEdit2.Text = trackBarControl1.Value.ToString();
            }, trackBarControl1.Value);

            if (frmConnection.Instance.connected)
                frmConnection.Instance.SendRPM(trackBarControl1.Value);
        }

        public void EnableTrackBar(bool enable)
        {
            trackBarControl1.Enabled = enable;
        }
    }
}
