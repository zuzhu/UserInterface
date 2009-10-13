////////////////////////////////////////////////////////////////////////
// frmMain.cs: the WinForm class for SPINA_UI
// 
// version: 1.0
// description: display the UserInterface and render the text on the textbox
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

public partial class frmMain : Form
{

    StringBuilder sb;
    string content;
    StringBuilder sbOutput;
    bool readflag = false;
    bool endflag = false;

    //----< constructor >------------------------------

    public frmMain()
    {
        InitializeComponent();
        sb = new StringBuilder();
        sbOutput = new StringBuilder();
    }

    //----< "Load" button >------------------------------

    private void button1_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Open SPINA File";
        openFileDialog.Filter = "SPINA Files(*.spi)|*.spi";
        openFileDialog.InitialDirectory = @"C:\";
        openFileDialog.CheckFileExists = true;
        openFileDialog.CheckPathExists = true;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            ShowSourceCode(openFileDialog.FileName);
        }
    }

    //----< "Save" button >------------------------------

    private void button2_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Save SPINA File";
        saveFileDialog.Filter = "SPINA Files(*.spi)|*.spi";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            SaveSourceCode(saveFileDialog.FileName);
        }
    }

    //----< display source code in the textbox >------------------------------

    private void ShowSourceCode(string fileName)
    {
        sb.Remove(0, sb.Length);
        using (StreamReader sr = new StreamReader(fileName))
        {
            String line;
            //StringBuilder sb = new StringBuilder();
            while ((line = sr.ReadLine()) != null)
            {
                sb.AppendLine(line);
            }
            rbtSourceCode.Text = sb.ToString();
        }
    }

    //----< save source code to a file >------------------------------

    private void SaveSourceCode(string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.Write(rbtSourceCode.Text);
            sw.Close();
        }
    }

    //----< "Run" button >------------------------------

    private void button3_Click(object sender, EventArgs e)
    {
        endflag = false;
        sbOutput.Remove(0, sbOutput.Length);
        richTextBox2.Clear();
        WriteBufferDelegate d1 = WriteOutput;
        consoleProgram theprogram = new consoleProgram();
        content = rbtSourceCode.Text;
        //content.Replace('\n', ' ');
        theprogram.setText(content);
        theprogram.setDelegate(d1);
        Thread oThread = new Thread(new ThreadStart(theprogram.VisitLine));
        oThread.Start();
        while (!endflag)
        {
            ReadFromBuffer();
        }
        oThread.Abort();
    }

    //----< producer >------------------------------

    private void WriteOutput(string s)
    {
        lock (this)
        {
            if (readflag)
            {
                try
                {
                    Monitor.Wait(this);
                }
                catch (SynchronizationLockException e)
                {
                    Console.WriteLine(e);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }

            }
            sbOutput.Append(s);
            readflag = true;
            Monitor.Pulse(this);
        }
    }

    //----< consumer >------------------------------

    private void ReadFromBuffer()
    {
        lock (this)
        {
            if (!readflag)
            {
                try
                {
                    Monitor.Wait(this);
                }
                catch (SynchronizationLockException e)
                {
                    Console.WriteLine(e);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
            }
            richTextBox2.AppendText(sbOutput.ToString());
            if (sbOutput.ToString().Equals("END"))
                endflag = true;
            sbOutput.Remove(0, sbOutput.Length);
            readflag = false;    // Reset the state flag to say consuming is done.
            Monitor.Pulse(this);   
        }
    }

}

