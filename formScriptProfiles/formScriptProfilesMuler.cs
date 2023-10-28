﻿using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;


namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesMuler : Form
    {

        // Initialize Instances
        private formMainForm MainForm;

        public formScriptProfilesMuler(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize variables

        // Form load
        public void formScriptProfiles_Muler_Load(object sender, EventArgs e)
        {
            // Add 27 rows to the DataGridView
            for (int i = 0; i < 27; i++)
            {
                dataGridViewScriptProfiles_Muler_Mule.Rows.Add();
                dataGridViewScriptProfiles_Muler_Bot.Rows.Add();
            }
        }

        // Cancel Non-Numbers from textbox input
        public void GlobalMethod_CancelNonNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_KeyPress(sender, e);
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Button Click - Save Profile
        public void btnScriptProfiles_Muler_SaveButton_Click(object sender, EventArgs e)
        {

            // Intialize Variables - Strings
            string filepathProfileMulerBot = Path.Combine(@"C:\\Users\\" + MainForm.pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMuler-Bot.txt");
            string filepathProfileMulerMule = Path.Combine(@"C:\\Users\\" + MainForm.pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMuler-Mule.txt");
            string enableManualMule = "<Find>Yes/*/No</Find><Replace>No</Replace>";
            string muleWorld = "<Find>499</Find><Replace>" + textBoxScriptProfiles_Muler_Mule_World.Text + "</Replace>";
            string muleCoordX = textBoxScriptProfiles_Muler_Mule_X.Text;
            string muleCoordY = textBoxScriptProfiles_Muler_Mule_Y.Text;
            string muleCoordZ = textBoxScriptProfiles_Muler_Mule_Z.Text;
            string muleCoords = "<Find>3210,9621,0</Find><Replace>" + muleCoordX + "," + muleCoordY + "," + muleCoordZ + "</Replace>";
            string muleItem0 = "<Find>Item001</Find><Replace>Item001</Replace>";
            string muleItem1 = "<Find>Item002</Find><Replace>Item002</Replace>";
            string muleItem2 = "<Find>Item003</Find><Replace>Item003</Replace>";
            string muleItem3 = "<Find>Item004</Find><Replace>Item004</Replace>";
            string muleItem4 = "<Find>Item005</Find><Replace>Item005</Replace>";
            string muleItem5 = "<Find>Item006</Find><Replace>Item006</Replace>";
            string muleItem6 = "<Find>Item007</Find><Replace>Item007</Replace>";
            string muleItem7 = "<Find>Item008</Find><Replace>Item008</Replace>";
            string muleItem8 = "<Find>Item009</Find><Replace>Item009</Replace>";
            string muleItem9 = "<Find>Item010</Find><Replace>Item010</Replace>";
            string muleItem10 = "<Find>Item011</Find><Replace>Item011</Replace>";
            string muleItem11 = "<Find>Item012</Find><Replace>Item012</Replace>";
            string muleItem12 = "<Find>Item013</Find><Replace>Item013</Replace>";
            string muleItem13 = "<Find>Item014</Find><Replace>Item014</Replace>";
            string muleItem14 = "<Find>Item015</Find><Replace>Item015</Replace>";
            string muleItem15 = "<Find>Item016</Find><Replace>Item016</Replace>";
            string muleItem16 = "<Find>Item017</Find><Replace>Item017</Replace>";
            string muleItem17 = "<Find>Item018</Find><Replace>Item018</Replace>";
            string muleItem18 = "<Find>Item019</Find><Replace>Item019</Replace>";
            string muleItem19 = "<Find>Item020</Find><Replace>Item020</Replace>";
            string muleItem20 = "<Find>Item021</Find><Replace>Item021</Replace>";
            string muleItem21 = "<Find>Item022</Find><Replace>Item022</Replace>";
            string muleItem22 = "<Find>Item023</Find><Replace>Item023</Replace>";
            string muleItem23 = "<Find>Item024</Find><Replace>Item024</Replace>";
            string muleItem24 = "<Find>Item025</Find><Replace>Item025</Replace>";
            string muleItem25 = "<Find>Item026</Find><Replace>Item026</Replace>";
            string muleItem26 = "<Find>Item027</Find><Replace>Item027</Replace>";
            string muleQuantity0 = "<Find>987654321</Find><Replace>987654321</Replace>";
            string muleQuantity1 = "<Find>528974613</Find><Replace>528974613</Replace>";
            string muleQuantity2 = "<Find>369874125</Find><Replace>369874125</Replace>";
            string muleQuantity3 = "<Find>648912537</Find><Replace>648912537</Replace>";
            string muleQuantity4 = "<Find>784365219</Find><Replace>784365219</Replace>";
            string muleQuantity5 = "<Find>315496728</Find><Replace>315496728</Replace>";
            string muleQuantity6 = "<Find>426839517</Find><Replace>426839517</Replace>";
            string muleQuantity7 = "<Find>259137468</Find><Replace>259137468</Replace>";
            string muleQuantity8 = "<Find>614285739</Find><Replace>614285739</Replace>";
            string muleQuantity9 = "<Find>138947526</Find><Replace>138947526</Replace>";
            string muleQuantity10 = "<Find>976814352</Find><Replace>976814352</Replace>";
            string muleQuantity11 = "<Find>825496173</Find><Replace>825496173</Replace>";
            string muleQuantity12 = "<Find>741639825</Find><Replace>741639825</Replace>";
            string muleQuantity13 = "<Find>217986534</Find><Replace>217986534</Replace>";
            string muleQuantity14 = "<Find>352987416</Find><Replace>352987416</Replace>";
            string muleQuantity15 = "<Find>694283751</Find><Replace>694283751</Replace>";
            string muleQuantity16 = "<Find>578913246</Find><Replace>578913246</Replace>";
            string muleQuantity17 = "<Find>463589127</Find><Replace>463589127</Replace>";
            string muleQuantity18 = "<Find>893217564</Find><Replace>893217564</Replace>";
            string muleQuantity19 = "<Find>751843926</Find><Replace>751843926</Replace>";
            string muleQuantity20 = "<Find>437568219</Find><Replace>437568219</Replace>";
            string muleQuantity21 = "<Find>618357492</Find><Replace>618357492</Replace>";
            string muleQuantity22 = "<Find>924167583</Find><Replace>924167583</Replace>";
            string muleQuantity23 = "<Find>796851432</Find><Replace>796851432</Replace>";
            string muleQuantity24 = "<Find>135294678</Find><Replace>135294678</Replace>";
            string muleQuantity25 = "<Find>317458926</Find><Replace>317458926</Replace>";
            string muleQuantity26 = "<Find>689317524</Find><Replace>689317524</Replace>";

            // Intialize bot variables
            string botMuleName = "<Find>MulerMuleName</Find><Replace>" + textBoxScriptProfiles_Muler_Bot_MuleName.Text + "</Replace>";
            string botWorld = "<Find>499</Find><Replace>" + textBoxScriptProfiles_Muler_Bot_World.Text + "</Replace>";
            string botCoordX = textBoxScriptProfiles_Muler_Bot_X.Text;
            string botCoordY = textBoxScriptProfiles_Muler_Bot_Y.Text;
            string botCoordZ = textBoxScriptProfiles_Muler_Bot_Z.Text;
            string botCoords = "<Find>3211,9621,0</Find><Replace>" + botCoordX + "," + botCoordY + "," + botCoordZ + "</Replace>";
            string botItem0 = "<Find>Item001</Find><Replace>Item001</Replace>";
            string botItem1 = "<Find>Item002</Find><Replace>Item002</Replace>";
            string botItem2 = "<Find>Item003</Find><Replace>Item003</Replace>";
            string botItem3 = "<Find>Item004</Find><Replace>Item004</Replace>";
            string botItem4 = "<Find>Item005</Find><Replace>Item005</Replace>";
            string botItem5 = "<Find>Item006</Find><Replace>Item006</Replace>";
            string botItem6 = "<Find>Item007</Find><Replace>Item007</Replace>";
            string botItem7 = "<Find>Item008</Find><Replace>Item008</Replace>";
            string botItem8 = "<Find>Item009</Find><Replace>Item009</Replace>";
            string botItem9 = "<Find>Item010</Find><Replace>Item010</Replace>";
            string botItem10 = "<Find>Item011</Find><Replace>Item011</Replace>";
            string botItem11 = "<Find>Item012</Find><Replace>Item012</Replace>";
            string botItem12 = "<Find>Item013</Find><Replace>Item013</Replace>";
            string botItem13 = "<Find>Item014</Find><Replace>Item014</Replace>";
            string botItem14 = "<Find>Item015</Find><Replace>Item015</Replace>";
            string botItem15 = "<Find>Item016</Find><Replace>Item016</Replace>";
            string botItem16 = "<Find>Item017</Find><Replace>Item017</Replace>";
            string botItem17 = "<Find>Item018</Find><Replace>Item018</Replace>";
            string botItem18 = "<Find>Item019</Find><Replace>Item019</Replace>";
            string botItem19 = "<Find>Item020</Find><Replace>Item020</Replace>";
            string botItem20 = "<Find>Item021</Find><Replace>Item021</Replace>";
            string botItem21 = "<Find>Item022</Find><Replace>Item022</Replace>";
            string botItem22 = "<Find>Item023</Find><Replace>Item023</Replace>";
            string botItem23 = "<Find>Item024</Find><Replace>Item024</Replace>";
            string botItem24 = "<Find>Item025</Find><Replace>Item025</Replace>";
            string botItem25 = "<Find>Item026</Find><Replace>Item026</Replace>";
            string botItem26 = "<Find>Item027</Find><Replace>Item027</Replace>";


            // Enable manual muling checkbox
            if (checkBoxScriptProfiles_Muler_Mule_ManualMode.Checked)
            {
                enableManualMule = "<Find>Yes/*/No</Find><Replace>Yes</Replace>";
            }

            // Mule items
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[0].Cells[0] != null)
            {
                muleItem0 = "<Find>Item001</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[0].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[1].Cells[0] != null)
            {
                muleItem1 = "<Find>Item002</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[1].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[2].Cells[0] != null)
            {
                muleItem2 = "<Find>Item003</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[2].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[3].Cells[0] != null)
            {
                muleItem3 = "<Find>Item004</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[3].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[4].Cells[0] != null)
            {
                muleItem4 = "<Find>Item005</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[4].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[5].Cells[0] != null)
            {
                muleItem5 = "<Find>Item006</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[5].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[6].Cells[0] != null)
            {
                muleItem6 = "<Find>Item007</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[6].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[7].Cells[0] != null)
            {
                muleItem7 = "<Find>Item008</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[7].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[8].Cells[0] != null)
            {
                muleItem8 = "<Find>Item009</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[8].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[9].Cells[0] != null)
            {
                muleItem9 = "<Find>Item010</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[9].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[10].Cells[0] != null)
            {
                muleItem10 = "<Find>Item011</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[10].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[11].Cells[0] != null)
            {
                muleItem11 = "<Find>Item012</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[11].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[12].Cells[0] != null)
            {
                muleItem12 = "<Find>Item013</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[12].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[13].Cells[0] != null)
            {
                muleItem13 = "<Find>Item014</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[13].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[14].Cells[0] != null)
            {
                muleItem14 = "<Find>Item015</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[14].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[15].Cells[0] != null)
            {
                muleItem15 = "<Find>Item016</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[15].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[16].Cells[0] != null)
            {
                muleItem16 = "<Find>Item017</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[16].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[17].Cells[0] != null)
            {
                muleItem17 = "<Find>Item018</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[17].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[18].Cells[0] != null)
            {
                muleItem18 = "<Find>Item019</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[18].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[19].Cells[0] != null)
            {
                muleItem19 = "<Find>Item020</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[19].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[20].Cells[0] != null)
            {
                muleItem20 = "<Find>Item021</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[20].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[21].Cells[0] != null)
            {
                muleItem21 = "<Find>Item022</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[21].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[22].Cells[0] != null)
            {
                muleItem22 = "<Find>Item023</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[22].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[23].Cells[0] != null)
            {
                muleItem23 = "<Find>Item024</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[23].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[24].Cells[0] != null)
            {
                muleItem24 = "<Find>Item025</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[24].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[25].Cells[0] != null)
            {
                muleItem25 = "<Find>Item026</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[25].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[26].Cells[0] != null)
            {
                muleItem26 = "<Find>Item027</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[26].Cells[0].Value?.ToString() + "</Replace>";
            }

            // Mule Quantities
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[0].Cells[1] != null)
            {
                muleQuantity0 = "<Find>987654321</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[0].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[1].Cells[1] != null)
            {
                muleQuantity1 = "<Find>528974613</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[1].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[2].Cells[1] != null)
            {
                muleQuantity2 = "<Find>369874125</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[2].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[3].Cells[1] != null)
            {
                muleQuantity3 = "<Find>648912537</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[3].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[4].Cells[1] != null)
            {
                muleQuantity4 = "<Find>784365219</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[4].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[5].Cells[1] != null)
            {
                muleQuantity5 = "<Find>315496728</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[5].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[6].Cells[1] != null)
            {
                muleQuantity6 = "<Find>426839517</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[6].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[7].Cells[1] != null)
            {
                muleQuantity7 = "<Find>259137468</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[7].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[8].Cells[1] != null)
            {
                muleQuantity8 = "<Find>614285739</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[8].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[9].Cells[1] != null)
            {
                muleQuantity9 = "<Find>138947526</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[9].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[10].Cells[1] != null)
            {
                muleQuantity10 = "<Find>976814352</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[10].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[11].Cells[1] != null)
            {
                muleQuantity11 = "<Find>825496173</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[11].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[12].Cells[1] != null)
            {
                muleQuantity12 = "<Find>741639825</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[12].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[13].Cells[1] != null)
            {
                muleQuantity13 = "<Find>217986534</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[13].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[14].Cells[1] != null)
            {
                muleQuantity14 = "<Find>352987416</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[14].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[15].Cells[1] != null)
            {
                muleQuantity15 = "<Find>694283751</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[15].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[16].Cells[1] != null)
            {
                muleQuantity16 = "<Find>578913246</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[16].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[17].Cells[1] != null)
            {
                muleQuantity17 = "<Find>463589127</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[17].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[18].Cells[1] != null)
            {
                muleQuantity18 = "<Find>893217564</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[18].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[19].Cells[1] != null)
            {
                muleQuantity19 = "<Find>751843926</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[19].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[20].Cells[1] != null)
            {
                muleQuantity20 = "<Find>437568219</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[20].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[21].Cells[1] != null)
            {
                muleQuantity21 = "<Find>618357492</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[21].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[22].Cells[1] != null)
            {
                muleQuantity22 = "<Find>924167583</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[22].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[23].Cells[1] != null)
            {
                muleQuantity23 = "<Find>796851432</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[23].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[24].Cells[1] != null)
            {
                muleQuantity24 = "<Find>135294678</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[24].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[25].Cells[1] != null)
            {
                muleQuantity25 = "<Find>317458926</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[25].Cells[1].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Mule.Rows[26].Cells[1] != null)
            {
                muleQuantity26 = "<Find>689317524</Find><Replace>" + dataGridViewScriptProfiles_Muler_Mule.Rows[26].Cells[1].Value?.ToString() + "</Replace>";
            }

            // Bot items
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[0].Cells[0] != null)
            {
                botItem0 = "<Find>Item001</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[0].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[1].Cells[0] != null)
            {
                botItem1 = "<Find>Item002</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[1].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[2].Cells[0] != null)
            {
                botItem2 = "<Find>Item003</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[2].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[3].Cells[0] != null)
            {
                botItem3 = "<Find>Item004</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[3].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[4].Cells[0] != null)
            {
                botItem4 = "<Find>Item005</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[4].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[5].Cells[0] != null)
            {
                botItem5 = "<Find>Item006</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[5].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[6].Cells[0] != null)
            {
                botItem6 = "<Find>Item007</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[6].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[7].Cells[0] != null)
            {
                botItem7 = "<Find>Item008</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[7].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[8].Cells[0] != null)
            {
                botItem8 = "<Find>Item009</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[8].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[9].Cells[0] != null)
            {
                botItem9 = "<Find>Item010</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[9].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[10].Cells[0] != null)
            {
                botItem10 = "<Find>Item011</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[10].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[11].Cells[0] != null)
            {
                botItem11 = "<Find>Item012</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[11].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[12].Cells[0] != null)
            {
                botItem12 = "<Find>Item013</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[12].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[13].Cells[0] != null)
            {
                botItem13 = "<Find>Item014</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[13].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[14].Cells[0] != null)
            {
                botItem14 = "<Find>Item015</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[14].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[15].Cells[0] != null)
            {
                botItem15 = "<Find>Item016</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[15].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[16].Cells[0] != null)
            {
                botItem16 = "<Find>Item017</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[16].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[17].Cells[0] != null)
            {
                botItem17 = "<Find>Item018</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[17].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[18].Cells[0] != null)
            {
                botItem18 = "<Find>Item019</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[18].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[19].Cells[0] != null)
            {
                botItem19 = "<Find>Item020</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[19].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[20].Cells[0] != null)
            {
                botItem20 = "<Find>Item021</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[20].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[21].Cells[0] != null)
            {
                botItem21 = "<Find>Item022</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[21].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[22].Cells[0] != null)
            {
                botItem22 = "<Find>Item023</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[22].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[23].Cells[0] != null)
            {
                botItem23 = "<Find>Item024</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[23].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[24].Cells[0] != null)
            {
                botItem24 = "<Find>Item025</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[24].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[25].Cells[0] != null)
            {
                botItem25 = "<Find>Item026</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[25].Cells[0].Value?.ToString() + "</Replace>";
            }
            if (dataGridViewScriptProfiles_Muler_Bot.Rows[26].Cells[0] != null)
            {
                botItem26 = "<Find>Item027</Find><Replace>" + dataGridViewScriptProfiles_Muler_Bot.Rows[26].Cells[0].Value?.ToString() + "</Replace>";
            }



            // Write to file bot
            using (StreamWriter writer = new StreamWriter(filepathProfileMulerBot))
            {
                writer.WriteLine(botMuleName);
                writer.WriteLine(botWorld);
                writer.WriteLine(botCoords);
                writer.WriteLine(botItem0);
                writer.WriteLine(botItem1);
                writer.WriteLine(botItem2);
                writer.WriteLine(botItem3);
                writer.WriteLine(botItem4);
                writer.WriteLine(botItem5);
                writer.WriteLine(botItem6);
                writer.WriteLine(botItem7);
                writer.WriteLine(botItem8);
                writer.WriteLine(botItem9);
                writer.WriteLine(botItem10);
                writer.WriteLine(botItem11);
                writer.WriteLine(botItem12);
                writer.WriteLine(botItem13);
                writer.WriteLine(botItem14);
                writer.WriteLine(botItem15);
                writer.WriteLine(botItem16);
                writer.WriteLine(botItem17);
                writer.WriteLine(botItem18);
                writer.WriteLine(botItem19);
                writer.WriteLine(botItem20);
                writer.WriteLine(botItem21);
                writer.WriteLine(botItem22);
                writer.WriteLine(botItem23);
                writer.WriteLine(botItem24);
                writer.WriteLine(botItem25);
                writer.WriteLine(botItem26);

            }

            // Write to file mule
            using (StreamWriter writer = new StreamWriter(filepathProfileMulerMule))
            {
                writer.WriteLine(enableManualMule);
                writer.WriteLine(muleWorld);
                writer.WriteLine(muleCoords);
                writer.WriteLine(muleItem0);
                writer.WriteLine(muleItem1);
                writer.WriteLine(muleItem2);
                writer.WriteLine(muleItem3);
                writer.WriteLine(muleItem4);
                writer.WriteLine(muleItem5);
                writer.WriteLine(muleItem6);
                writer.WriteLine(muleItem7);
                writer.WriteLine(muleItem8);
                writer.WriteLine(muleItem9);
                writer.WriteLine(muleItem10);
                writer.WriteLine(muleItem11);
                writer.WriteLine(muleItem12);
                writer.WriteLine(muleItem13);
                writer.WriteLine(muleItem14);
                writer.WriteLine(muleItem15);
                writer.WriteLine(muleItem16);
                writer.WriteLine(muleItem17);
                writer.WriteLine(muleItem18);
                writer.WriteLine(muleItem19);
                writer.WriteLine(muleItem20);
                writer.WriteLine(muleItem21);
                writer.WriteLine(muleItem22);
                writer.WriteLine(muleItem23);
                writer.WriteLine(muleItem24);
                writer.WriteLine(muleItem25);
                writer.WriteLine(muleItem26);
                writer.WriteLine(muleQuantity0);
                writer.WriteLine(muleQuantity1);
                writer.WriteLine(muleQuantity2);
                writer.WriteLine(muleQuantity3);
                writer.WriteLine(muleQuantity4);
                writer.WriteLine(muleQuantity5);
                writer.WriteLine(muleQuantity6);
                writer.WriteLine(muleQuantity7);
                writer.WriteLine(muleQuantity8);
                writer.WriteLine(muleQuantity9);
                writer.WriteLine(muleQuantity10);
                writer.WriteLine(muleQuantity11);
                writer.WriteLine(muleQuantity12);
                writer.WriteLine(muleQuantity13);
                writer.WriteLine(muleQuantity14);
                writer.WriteLine(muleQuantity15);
                writer.WriteLine(muleQuantity16);
                writer.WriteLine(muleQuantity17);
                writer.WriteLine(muleQuantity18);
                writer.WriteLine(muleQuantity19);
                writer.WriteLine(muleQuantity20);
                writer.WriteLine(muleQuantity21);
                writer.WriteLine(muleQuantity22);
                writer.WriteLine(muleQuantity23);
                writer.WriteLine(muleQuantity24);
                writer.WriteLine(muleQuantity25);
                writer.WriteLine(muleQuantity26);
            }

            MessageBox.Show("Profile successfully created.");

        }

        public void DataGridViewScriptProfiles_Mule_OneClickEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a TextBoxCell
            if (dataGridViewScriptProfiles_Muler_Mule.CurrentCell is DataGridViewTextBoxCell)
            {
                // Set the EditMode to EditOnEnter
                dataGridViewScriptProfiles_Muler_Mule.BeginEdit(true);
            }
        }

        public void DataGridViewScriptProfiles_Bot_OneClickEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a TextBoxCell
            if (dataGridViewScriptProfiles_Muler_Bot.CurrentCell is DataGridViewTextBoxCell)
            {
                // Set the EditMode to EditOnEnter
                dataGridViewScriptProfiles_Muler_Bot.BeginEdit(true);
            }
        }
    }
}
