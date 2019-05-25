﻿using System;
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
    public partial class frmRPM : DevExpress.XtraEditors.XtraUserControl
    {
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

            timer1.Interval = 166;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();
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
            var currValue = trackBarControl1.Value;
            var error = (currValue > 10) ? currValue - 10 : 0;

            var value = ((float)random.Next(error, currValue)) / 100.0f;
            float deviation = ((float)value - (scale as IConvertibleScale).Percent);
            return scale.Value + (scale.ScaleLength * 0.075f) * deviation;
        }

        #endregion

    }
}