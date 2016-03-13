﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace DrinkOMatic
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             {
                 new NewDrink().Show();
	        this.Show();
	      
        }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fInalDataSet19.vwDRINKSearch1' table. You can move, or remove it, as needed.
            this.vwDRINKSearch1TableAdapter.Fill(this.fInalDataSet19.vwDRINKSearch1);
            // TODO: This line of code loads data into the 'fInalDataSet18.cmbIntSearch' table. You can move, or remove it, as needed.
            this.cmbIntSearchTableAdapter.Fill(this.fInalDataSet18.cmbIntSearch);
            // TODO: This line of code loads data into the 'fInalDataSet10.vwDRINKSearch' table. You can move, or remove it, as needed.
            this.vwDRINKSearchTableAdapter.Fill(this.fInalDataSet10.vwDRINKSearch);
            // TODO: This line of code loads data into the 'fInalDataSet4.tblingredients' table. You can move, or remove it, as needed.
            this.tblingredientsTableAdapter3.Fill(this.fInalDataSet4.tblingredients);
            // TODO: This line of code loads data into the 'fInalDataSet3.tblingredients' table. You can move, or remove it, as needed.
            this.tblingredientsTableAdapter2.Fill(this.fInalDataSet3.tblingredients);
            // TODO: This line of code loads data into the 'fInalDataSet2.tblingredients' table. You can move, or remove it, as needed.
            this.tblingredientsTableAdapter1.Fill(this.fInalDataSet2.tblingredients);
            // TODO: This line of code loads data into the 'fInalDataSet1.tblingredients' table. You can move, or remove it, as needed.
            this.tblingredientsTableAdapter.Fill(this.fInalDataSet1.tblingredients);
            // TODO: This line of code loads data into the 'fInalDataSet.tblDrinks' table. You can move, or remove it, as needed.
            this.tblDrinksTableAdapter.Fill(this.fInalDataSet.tblDrinks);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblingredientsTableAdapter.FillBy(this.fInalDataSet1.tblingredients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tblingredientsTableAdapter.FillBy(this.fInalDataSet1.tblingredients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addform_load(object sender, MouseEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tblDrinksTableAdapter.FillBy(this.fInalDataSet.tblDrinks);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblDrinksTableAdapter.FillBy1(this.fInalDataSet.tblDrinks);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblDrinksTableAdapter.FillBy2(this.fInalDataSet.tblDrinks);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (Search_txt.DataBindings.Count > 0)

                Search_txt.DataBindings.RemoveAt(0);
           
            //thecode binds code

            Search_txt.DataBindings.Add(new Binding("Text", dataGridView1[2, e.RowIndex], "Value", false));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
            try
            {
                this.vwDRINKSearchTableAdapter.FillBy(this.fInalDataSet10.vwDRINKSearch, Search_txt.Text);
            } 
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

       

        }

       

        ////Private Sub btnKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShowOSK.Click
        ////        'Create the OSK Process
        ////    OSK = System.Diagnostics.Process.Start("osk.exe")
        ////End Sub

        ////Private Sub btnKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKillOSK.Click
        ////    Try
        ////        OSK.Kill()
        ////    Catch ex As Exception
        ////        Debug.WriteLine(ex.Message)
        ////    End Try
        ////End Sub
        ////End Class
    }


    

