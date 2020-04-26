using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace BackgroundWorkerSample
{
    public partial class Form1 : Form
    {
        BackgroundWorker m_oWorker;

        public Form1() {
            InitializeComponent();
            m_oWorker = new BackgroundWorker();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;
        }

        void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled) {
                lblStatus.Text = "Anulowano.";
            }
            else if (e.Error != null) {
                lblStatus.Text = "Błąd podczas wykonywania operacji w tle.";
            }
            else {
                lblStatus.Text = "Udało się !!!";
            }
            btnStartAsyncOperation.Enabled = true;
            btnCancel.Enabled = false;
        }

        void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = "W trakcie ......" + progressBar1.Value.ToString() + "%";
        }

        void m_oWorker_DoWork(object sender, DoWorkEventArgs e) {
            int liczba;
            float iloscLiczb = Int32.Parse(ileLiczb.Text); 
            int dzielnik = Int32.Parse(Dzielnik.Text); 
            int poczPrzedzialu = Int32.Parse(Od.Text); 
            int konPrzedzialu = Int32.Parse(Do.Text);
            double progress = 0;
            int genLiczby = 0;

            while (true) {
                Thread.Sleep(700);
                Random rand = new Random();
                liczba = rand.Next(poczPrzedzialu, konPrzedzialu);

                if (liczba % dzielnik == 0) {
                    genLiczby++;
                    progress = genLiczby / iloscLiczb;
                    progress *= 100;

                    if(progress > 99.9) {
                        m_oWorker.ReportProgress(100);
                        return;
                    }
                }
                m_oWorker.ReportProgress((int)progress);

                if (m_oWorker.CancellationPending) {
                    e.Cancel = true;
                    m_oWorker.ReportProgress(0);
                    return;
                }

            }
            m_oWorker.ReportProgress(100);
        }

        private void btnStartAsyncOperation_Click(object sender, EventArgs e)
        {
            btnStartAsyncOperation.Enabled  = false;
            btnCancel.Enabled               = true;
            m_oWorker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_oWorker.IsBusy)
            {
                m_oWorker.CancelAsync();
            }
        }
    }
}
