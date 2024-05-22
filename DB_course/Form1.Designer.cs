namespace DB_course
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEstateId = new System.Windows.Forms.NumericUpDown();
            this.txtAgentId = new System.Windows.Forms.NumericUpDown();
            this.txtClientId = new System.Windows.Forms.NumericUpDown();
            this.txtContractId = new System.Windows.Forms.NumericUpDown();
            this.btnGetEstate = new System.Windows.Forms.Button();
            this.btnGetAgent = new System.Windows.Forms.Button();
            this.btnGetClient = new System.Windows.Forms.Button();
            this.btnGetContract = new System.Windows.Forms.Button();
            this.btnGetPreference = new System.Windows.Forms.Button();
            this.txtPreferenceId = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnGetClientByPhoneNumber = new System.Windows.Forms.Button();
            this.btnGetAgentByLastName = new System.Windows.Forms.Button();
            this.txtAgentLastName = new System.Windows.Forms.TextBox();
            this.txtClientNumber = new System.Windows.Forms.NumericUpDown();
            this.btnGetPreferenceById = new System.Windows.Forms.Button();
            this.btnGetClientById = new System.Windows.Forms.Button();
            this.btnGetContractById = new System.Windows.Forms.Button();
            this.btnGetAgentById = new System.Windows.Forms.Button();
            this.btnGetEstateById = new System.Windows.Forms.Button();
            this.dataGridViewPreferences = new System.Windows.Forms.DataGridView();
            this.preferences_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preference_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approx_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wish_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preference_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewContracts = new System.Windows.Forms.DataGridView();
            this.contract_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estate_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAgents = new System.Windows.Forms.DataGridView();
            this.agentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEstates = new System.Windows.Forms.DataGridView();
            this.estate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_floors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bathroom_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAddAgentContact = new System.Windows.Forms.NumericUpDown();
            this.txtAddClientPreference = new System.Windows.Forms.NumericUpDown();
            this.txtAddClientContact = new System.Windows.Forms.NumericUpDown();
            this.txtAddAppPrice = new System.Windows.Forms.NumericUpDown();
            this.txtAddContractEstate = new System.Windows.Forms.NumericUpDown();
            this.txtAddContractClient = new System.Windows.Forms.NumericUpDown();
            this.txtAddContractAgent = new System.Windows.Forms.NumericUpDown();
            this.txtAddContractDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddContractPrice = new System.Windows.Forms.NumericUpDown();
            this.txtAddEstateAgent = new System.Windows.Forms.NumericUpDown();
            this.txtAddEstateTotal = new System.Windows.Forms.NumericUpDown();
            this.txtAddEstateFloor = new System.Windows.Forms.NumericUpDown();
            this.txtAddEstateRooms = new System.Windows.Forms.NumericUpDown();
            this.txtAddEstatePrice = new System.Windows.Forms.NumericUpDown();
            this.txtAddEstateArea = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddEstateAddress = new System.Windows.Forms.TextBox();
            this.txtAddAgentJob = new System.Windows.Forms.TextBox();
            this.txtAddAgentName = new System.Windows.Forms.TextBox();
            this.txtAddType = new System.Windows.Forms.TextBox();
            this.txtAddClientName = new System.Windows.Forms.TextBox();
            this.txtAddEstateBath = new System.Windows.Forms.TextBox();
            this.txtAddEstateType = new System.Windows.Forms.TextBox();
            this.btnAddEstate = new System.Windows.Forms.Button();
            this.btnAddAgent = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnAddPreference = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtAddPreference = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUpdateContractDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateContractEstate = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateContractClient = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateContractAgent = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateContractPrice = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateApproxPrice = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateContact = new System.Windows.Forms.NumericUpDown();
            this.txtUpdatePreferenceId = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateEstateAgent = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateEstatePrice = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateEstateTotal = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateEstateFloor = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateEstateRoom = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateEstateArea = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtUpdateAgentId = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateContractId = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.txtUpdateAgentJob = new System.Windows.Forms.TextBox();
            this.txtUpdateAgentName = new System.Windows.Forms.TextBox();
            this.btnUpdateAgent = new System.Windows.Forms.Button();
            this.btnUpdateContract = new System.Windows.Forms.Button();
            this.txtPreferenceIdUpdate = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.btnUpdatePreference = new System.Windows.Forms.Button();
            this.txtUpdatePreference = new System.Windows.Forms.TextBox();
            this.txtEstateIdUpdate = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtUpdateEstateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateEstateBath = new System.Windows.Forms.TextBox();
            this.txtUpdateEstateType = new System.Windows.Forms.TextBox();
            this.btnUpdateEstate = new System.Windows.Forms.Button();
            this.txtClientIdUpdate = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtUpdateType = new System.Windows.Forms.TextBox();
            this.txtUpdateClientName = new System.Windows.Forms.TextBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnArchiveEstate = new System.Windows.Forms.Button();
            this.btnArchiveClient = new System.Windows.Forms.Button();
            this.btnArchiveAgent = new System.Windows.Forms.Button();
            this.txtEstateArchId = new System.Windows.Forms.NumericUpDown();
            this.txtAgentArchId = new System.Windows.Forms.NumericUpDown();
            this.txtClientArchId = new System.Windows.Forms.NumericUpDown();
            this.btnClearContract = new System.Windows.Forms.Button();
            this.btnClearEstate = new System.Windows.Forms.Button();
            this.btnClearPreference = new System.Windows.Forms.Button();
            this.btnClearClient = new System.Windows.Forms.Button();
            this.btnClearAgent = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtUpdateAgentContact = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreferenceId)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstates)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAgentContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddClientPreference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddClientContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAppPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractEstate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstatePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateArea)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractEstate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateApproxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdatePreferenceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstatePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateAgentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreferenceIdUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstateIdUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientIdUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstateArchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgentArchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientArchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateAgentContact)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstateId
            // 
            this.txtEstateId.Location = new System.Drawing.Point(100, 34);
            this.txtEstateId.Name = "txtEstateId";
            this.txtEstateId.Size = new System.Drawing.Size(154, 21);
            this.txtEstateId.TabIndex = 0;
            // 
            // txtAgentId
            // 
            this.txtAgentId.Location = new System.Drawing.Point(100, 314);
            this.txtAgentId.Name = "txtAgentId";
            this.txtAgentId.Size = new System.Drawing.Size(154, 21);
            this.txtAgentId.TabIndex = 1;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(836, 314);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(154, 21);
            this.txtClientId.TabIndex = 2;
            // 
            // txtContractId
            // 
            this.txtContractId.Location = new System.Drawing.Point(836, 34);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Size = new System.Drawing.Size(154, 21);
            this.txtContractId.TabIndex = 3;
            // 
            // btnGetEstate
            // 
            this.btnGetEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetEstate.Location = new System.Drawing.Point(100, 222);
            this.btnGetEstate.Name = "btnGetEstate";
            this.btnGetEstate.Size = new System.Drawing.Size(121, 53);
            this.btnGetEstate.TabIndex = 8;
            this.btnGetEstate.Text = "Список об\'єктів";
            this.btnGetEstate.UseVisualStyleBackColor = true;
            this.btnGetEstate.Click += new System.EventHandler(this.btnGetEstate_Click);
            // 
            // btnGetAgent
            // 
            this.btnGetAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetAgent.Location = new System.Drawing.Point(100, 497);
            this.btnGetAgent.Name = "btnGetAgent";
            this.btnGetAgent.Size = new System.Drawing.Size(121, 53);
            this.btnGetAgent.TabIndex = 9;
            this.btnGetAgent.Text = "Список агентів";
            this.btnGetAgent.UseVisualStyleBackColor = true;
            this.btnGetAgent.Click += new System.EventHandler(this.btnGetAgent_Click);
            // 
            // btnGetClient
            // 
            this.btnGetClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetClient.Location = new System.Drawing.Point(836, 497);
            this.btnGetClient.Name = "btnGetClient";
            this.btnGetClient.Size = new System.Drawing.Size(121, 53);
            this.btnGetClient.TabIndex = 10;
            this.btnGetClient.Text = "Список клієнтів";
            this.btnGetClient.UseVisualStyleBackColor = true;
            this.btnGetClient.Click += new System.EventHandler(this.btnGetClient_Click);
            // 
            // btnGetContract
            // 
            this.btnGetContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetContract.Location = new System.Drawing.Point(836, 222);
            this.btnGetContract.Name = "btnGetContract";
            this.btnGetContract.Size = new System.Drawing.Size(121, 53);
            this.btnGetContract.TabIndex = 11;
            this.btnGetContract.Text = "Список договорів";
            this.btnGetContract.UseVisualStyleBackColor = true;
            this.btnGetContract.Click += new System.EventHandler(this.btnGetContract_Click);
            // 
            // btnGetPreference
            // 
            this.btnGetPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPreference.Location = new System.Drawing.Point(100, 765);
            this.btnGetPreference.Name = "btnGetPreference";
            this.btnGetPreference.Size = new System.Drawing.Size(121, 53);
            this.btnGetPreference.TabIndex = 14;
            this.btnGetPreference.Text = "Список побажань";
            this.btnGetPreference.UseVisualStyleBackColor = true;
            this.btnGetPreference.Click += new System.EventHandler(this.btnGetPreference_Click);
            // 
            // txtPreferenceId
            // 
            this.txtPreferenceId.Location = new System.Drawing.Point(100, 591);
            this.txtPreferenceId.Name = "txtPreferenceId";
            this.txtPreferenceId.Size = new System.Drawing.Size(154, 21);
            this.txtPreferenceId.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1600, 931);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.btnGetClientByPhoneNumber);
            this.tabPage1.Controls.Add(this.btnGetAgentByLastName);
            this.tabPage1.Controls.Add(this.txtAgentLastName);
            this.tabPage1.Controls.Add(this.txtClientNumber);
            this.tabPage1.Controls.Add(this.btnGetPreferenceById);
            this.tabPage1.Controls.Add(this.btnGetClientById);
            this.tabPage1.Controls.Add(this.btnGetContractById);
            this.tabPage1.Controls.Add(this.btnGetAgentById);
            this.tabPage1.Controls.Add(this.btnGetEstateById);
            this.tabPage1.Controls.Add(this.dataGridViewPreferences);
            this.tabPage1.Controls.Add(this.dataGridViewClients);
            this.tabPage1.Controls.Add(this.dataGridViewContracts);
            this.tabPage1.Controls.Add(this.dataGridViewAgents);
            this.tabPage1.Controls.Add(this.dataGridViewEstates);
            this.tabPage1.Controls.Add(this.btnGetPreference);
            this.tabPage1.Controls.Add(this.txtPreferenceId);
            this.tabPage1.Controls.Add(this.txtEstateId);
            this.tabPage1.Controls.Add(this.btnGetEstate);
            this.tabPage1.Controls.Add(this.btnGetContract);
            this.tabPage1.Controls.Add(this.btnGetClient);
            this.tabPage1.Controls.Add(this.txtContractId);
            this.tabPage1.Controls.Add(this.txtAgentId);
            this.tabPage1.Controls.Add(this.btnGetAgent);
            this.tabPage1.Controls.Add(this.txtClientId);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1592, 905);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Перегляд";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(1042, 298);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(132, 15);
            this.label30.TabIndex = 48;
            this.label30.Text = "Ваш номер телефону";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(304, 298);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 15);
            this.label29.TabIndex = 47;
            this.label29.Text = "Введіть прізвище";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(97, 575);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 15);
            this.label28.TabIndex = 46;
            this.label28.Text = "Номер запису";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(833, 298);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 15);
            this.label27.TabIndex = 45;
            this.label27.Text = "Номер запису";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(97, 298);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 15);
            this.label26.TabIndex = 44;
            this.label26.Text = "Номер запису";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(833, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 15);
            this.label25.TabIndex = 43;
            this.label25.Text = "Номер запису";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(97, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 15);
            this.label24.TabIndex = 42;
            this.label24.Text = "Номер запису";
            // 
            // btnGetClientByPhoneNumber
            // 
            this.btnGetClientByPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetClientByPhoneNumber.Location = new System.Drawing.Point(1155, 497);
            this.btnGetClientByPhoneNumber.Name = "btnGetClientByPhoneNumber";
            this.btnGetClientByPhoneNumber.Size = new System.Drawing.Size(121, 53);
            this.btnGetClientByPhoneNumber.TabIndex = 25;
            this.btnGetClientByPhoneNumber.Text = "Пошук за номером телефону";
            this.btnGetClientByPhoneNumber.UseVisualStyleBackColor = true;
            this.btnGetClientByPhoneNumber.Click += new System.EventHandler(this.btnGetClientByPhoneNumber_Click_1);
            // 
            // btnGetAgentByLastName
            // 
            this.btnGetAgentByLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetAgentByLastName.Location = new System.Drawing.Point(422, 497);
            this.btnGetAgentByLastName.Name = "btnGetAgentByLastName";
            this.btnGetAgentByLastName.Size = new System.Drawing.Size(121, 53);
            this.btnGetAgentByLastName.TabIndex = 24;
            this.btnGetAgentByLastName.Text = "Пошук за прізвищем";
            this.btnGetAgentByLastName.UseVisualStyleBackColor = true;
            this.btnGetAgentByLastName.Click += new System.EventHandler(this.btnGetAgentByLastName_Click_1);
            // 
            // txtAgentLastName
            // 
            this.txtAgentLastName.Location = new System.Drawing.Point(307, 314);
            this.txtAgentLastName.Name = "txtAgentLastName";
            this.txtAgentLastName.Size = new System.Drawing.Size(169, 21);
            this.txtAgentLastName.TabIndex = 23;
            this.txtAgentLastName.TextChanged += new System.EventHandler(this.txtAgentLastName_TextChanged);
            // 
            // txtClientNumber
            // 
            this.txtClientNumber.Location = new System.Drawing.Point(1045, 314);
            this.txtClientNumber.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtClientNumber.Name = "txtClientNumber";
            this.txtClientNumber.Size = new System.Drawing.Size(154, 21);
            this.txtClientNumber.TabIndex = 22;
            this.txtClientNumber.ValueChanged += new System.EventHandler(this.txtClientNumber_ValueChanged);
            // 
            // btnGetPreferenceById
            // 
            this.btnGetPreferenceById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPreferenceById.Location = new System.Drawing.Point(257, 765);
            this.btnGetPreferenceById.Name = "btnGetPreferenceById";
            this.btnGetPreferenceById.Size = new System.Drawing.Size(121, 53);
            this.btnGetPreferenceById.TabIndex = 21;
            this.btnGetPreferenceById.Text = "Пошук по ID";
            this.btnGetPreferenceById.UseVisualStyleBackColor = true;
            this.btnGetPreferenceById.Click += new System.EventHandler(this.btnGetPreferenceById_Click);
            // 
            // btnGetClientById
            // 
            this.btnGetClientById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetClientById.Location = new System.Drawing.Point(993, 497);
            this.btnGetClientById.Name = "btnGetClientById";
            this.btnGetClientById.Size = new System.Drawing.Size(121, 53);
            this.btnGetClientById.TabIndex = 20;
            this.btnGetClientById.Text = "Пошук по ID";
            this.btnGetClientById.UseVisualStyleBackColor = true;
            this.btnGetClientById.Click += new System.EventHandler(this.btnGetClientById_Click);
            // 
            // btnGetContractById
            // 
            this.btnGetContractById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetContractById.Location = new System.Drawing.Point(993, 222);
            this.btnGetContractById.Name = "btnGetContractById";
            this.btnGetContractById.Size = new System.Drawing.Size(121, 53);
            this.btnGetContractById.TabIndex = 19;
            this.btnGetContractById.Text = "Пошук по ID";
            this.btnGetContractById.UseVisualStyleBackColor = true;
            this.btnGetContractById.Click += new System.EventHandler(this.btnGetContractById_Click);
            // 
            // btnGetAgentById
            // 
            this.btnGetAgentById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetAgentById.Location = new System.Drawing.Point(257, 497);
            this.btnGetAgentById.Name = "btnGetAgentById";
            this.btnGetAgentById.Size = new System.Drawing.Size(121, 53);
            this.btnGetAgentById.TabIndex = 18;
            this.btnGetAgentById.Text = "Пошук по ID";
            this.btnGetAgentById.UseVisualStyleBackColor = true;
            this.btnGetAgentById.Click += new System.EventHandler(this.btnGetAgentById_Click);
            // 
            // btnGetEstateById
            // 
            this.btnGetEstateById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetEstateById.Location = new System.Drawing.Point(257, 222);
            this.btnGetEstateById.Name = "btnGetEstateById";
            this.btnGetEstateById.Size = new System.Drawing.Size(121, 53);
            this.btnGetEstateById.TabIndex = 17;
            this.btnGetEstateById.Text = "Пошук по ID";
            this.btnGetEstateById.UseVisualStyleBackColor = true;
            this.btnGetEstateById.Click += new System.EventHandler(this.btnGetEstateById_Click_1);
            // 
            // dataGridViewPreferences
            // 
            this.dataGridViewPreferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreferences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preferences_id,
            this.preference_text});
            this.dataGridViewPreferences.Location = new System.Drawing.Point(100, 629);
            this.dataGridViewPreferences.Name = "dataGridViewPreferences";
            this.dataGridViewPreferences.Size = new System.Drawing.Size(462, 120);
            this.dataGridViewPreferences.TabIndex = 16;
            // 
            // preferences_id
            // 
            this.preferences_id.HeaderText = "PreferenceID";
            this.preferences_id.Name = "preferences_id";
            this.preferences_id.ReadOnly = true;
            // 
            // preference_text
            // 
            this.preference_text.FillWeight = 300F;
            this.preference_text.HeaderText = "PreferenceText";
            this.preference_text.Name = "preference_text";
            this.preference_text.ReadOnly = true;
            this.preference_text.Width = 300;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client_id,
            this.client_name,
            this.approx_price,
            this.wish_type,
            this.client_contact,
            this.preference_id});
            this.dataGridViewClients.Location = new System.Drawing.Point(836, 357);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(661, 125);
            this.dataGridViewClients.TabIndex = 11;
            // 
            // client_id
            // 
            this.client_id.HeaderText = "ClientID";
            this.client_id.Name = "client_id";
            this.client_id.ReadOnly = true;
            // 
            // client_name
            // 
            this.client_name.HeaderText = "ClientName";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // approx_price
            // 
            this.approx_price.HeaderText = "ApproximatePrice";
            this.approx_price.Name = "approx_price";
            this.approx_price.ReadOnly = true;
            // 
            // wish_type
            // 
            this.wish_type.HeaderText = "BewishedType";
            this.wish_type.Name = "wish_type";
            this.wish_type.ReadOnly = true;
            // 
            // client_contact
            // 
            this.client_contact.HeaderText = "PhoneNumber";
            this.client_contact.Name = "client_contact";
            this.client_contact.ReadOnly = true;
            // 
            // preference_id
            // 
            this.preference_id.HeaderText = "PreferenceID";
            this.preference_id.Name = "preference_id";
            this.preference_id.ReadOnly = true;
            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contract_id,
            this.priceContract,
            this.sign_date,
            this.contract_agent,
            this.client_contract,
            this.estate_contract});
            this.dataGridViewContracts.Location = new System.Drawing.Point(836, 72);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.Size = new System.Drawing.Size(661, 126);
            this.dataGridViewContracts.TabIndex = 12;
            // 
            // contract_id
            // 
            this.contract_id.HeaderText = "ContractID";
            this.contract_id.Name = "contract_id";
            this.contract_id.ReadOnly = true;
            // 
            // priceContract
            // 
            this.priceContract.HeaderText = "Price";
            this.priceContract.Name = "priceContract";
            this.priceContract.ReadOnly = true;
            // 
            // sign_date
            // 
            this.sign_date.HeaderText = "SignDate";
            this.sign_date.Name = "sign_date";
            this.sign_date.ReadOnly = true;
            // 
            // contract_agent
            // 
            this.contract_agent.HeaderText = "AgentID";
            this.contract_agent.Name = "contract_agent";
            this.contract_agent.ReadOnly = true;
            // 
            // client_contract
            // 
            this.client_contract.HeaderText = "ClientID";
            this.client_contract.Name = "client_contract";
            this.client_contract.ReadOnly = true;
            // 
            // estate_contract
            // 
            this.estate_contract.HeaderText = "EstateID";
            this.estate_contract.Name = "estate_contract";
            this.estate_contract.ReadOnly = true;
            // 
            // dataGridViewAgents
            // 
            this.dataGridViewAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentID,
            this.full_name,
            this.job,
            this.contact});
            this.dataGridViewAgents.Location = new System.Drawing.Point(100, 357);
            this.dataGridViewAgents.Name = "dataGridViewAgents";
            this.dataGridViewAgents.Size = new System.Drawing.Size(628, 125);
            this.dataGridViewAgents.TabIndex = 10;
            // 
            // agentID
            // 
            this.agentID.HeaderText = "AgentID";
            this.agentID.Name = "agentID";
            this.agentID.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.HeaderText = "FullName";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // job
            // 
            this.job.HeaderText = "Job";
            this.job.Name = "job";
            this.job.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.HeaderText = "PhoneNumber";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // dataGridViewEstates
            // 
            this.dataGridViewEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estate_id,
            this.address,
            this.type,
            this.area,
            this.rooms,
            this.floor,
            this.total_floors,
            this.bathroom_type,
            this.price,
            this.agent_id});
            this.dataGridViewEstates.Location = new System.Drawing.Point(100, 72);
            this.dataGridViewEstates.Name = "dataGridViewEstates";
            this.dataGridViewEstates.Size = new System.Drawing.Size(628, 126);
            this.dataGridViewEstates.TabIndex = 9;
            // 
            // estate_id
            // 
            this.estate_id.HeaderText = "EstateID";
            this.estate_id.Name = "estate_id";
            this.estate_id.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // rooms
            // 
            this.rooms.HeaderText = "Rooms";
            this.rooms.Name = "rooms";
            this.rooms.ReadOnly = true;
            // 
            // floor
            // 
            this.floor.HeaderText = "Floor";
            this.floor.Name = "floor";
            this.floor.ReadOnly = true;
            // 
            // total_floors
            // 
            this.total_floors.HeaderText = "TotalFloors";
            this.total_floors.Name = "total_floors";
            this.total_floors.ReadOnly = true;
            // 
            // bathroom_type
            // 
            this.bathroom_type.HeaderText = "BathroomType";
            this.bathroom_type.Name = "bathroom_type";
            this.bathroom_type.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // agent_id
            // 
            this.agent_id.HeaderText = "AgentID";
            this.agent_id.Name = "agent_id";
            this.agent_id.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAddAgentContact);
            this.tabPage2.Controls.Add(this.txtAddClientPreference);
            this.tabPage2.Controls.Add(this.txtAddClientContact);
            this.tabPage2.Controls.Add(this.txtAddAppPrice);
            this.tabPage2.Controls.Add(this.txtAddContractEstate);
            this.tabPage2.Controls.Add(this.txtAddContractClient);
            this.tabPage2.Controls.Add(this.txtAddContractAgent);
            this.tabPage2.Controls.Add(this.txtAddContractDate);
            this.tabPage2.Controls.Add(this.txtAddContractPrice);
            this.tabPage2.Controls.Add(this.txtAddEstateAgent);
            this.tabPage2.Controls.Add(this.txtAddEstateTotal);
            this.tabPage2.Controls.Add(this.txtAddEstateFloor);
            this.tabPage2.Controls.Add(this.txtAddEstateRooms);
            this.tabPage2.Controls.Add(this.txtAddEstatePrice);
            this.tabPage2.Controls.Add(this.txtAddEstateArea);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtAddEstateAddress);
            this.tabPage2.Controls.Add(this.txtAddAgentJob);
            this.tabPage2.Controls.Add(this.txtAddAgentName);
            this.tabPage2.Controls.Add(this.txtAddType);
            this.tabPage2.Controls.Add(this.txtAddClientName);
            this.tabPage2.Controls.Add(this.txtAddEstateBath);
            this.tabPage2.Controls.Add(this.txtAddEstateType);
            this.tabPage2.Controls.Add(this.btnAddEstate);
            this.tabPage2.Controls.Add(this.btnAddAgent);
            this.tabPage2.Controls.Add(this.btnAddContract);
            this.tabPage2.Controls.Add(this.btnAddPreference);
            this.tabPage2.Controls.Add(this.btnAddClient);
            this.tabPage2.Controls.Add(this.txtAddPreference);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1592, 905);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додати запис";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAddAgentContact
            // 
            this.txtAddAgentContact.Location = new System.Drawing.Point(819, 682);
            this.txtAddAgentContact.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtAddAgentContact.Name = "txtAddAgentContact";
            this.txtAddAgentContact.Size = new System.Drawing.Size(162, 21);
            this.txtAddAgentContact.TabIndex = 82;
            // 
            // txtAddClientPreference
            // 
            this.txtAddClientPreference.Location = new System.Drawing.Point(819, 280);
            this.txtAddClientPreference.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtAddClientPreference.Name = "txtAddClientPreference";
            this.txtAddClientPreference.Size = new System.Drawing.Size(162, 21);
            this.txtAddClientPreference.TabIndex = 81;
            // 
            // txtAddClientContact
            // 
            this.txtAddClientContact.Location = new System.Drawing.Point(819, 219);
            this.txtAddClientContact.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtAddClientContact.Name = "txtAddClientContact";
            this.txtAddClientContact.Size = new System.Drawing.Size(162, 21);
            this.txtAddClientContact.TabIndex = 80;
            // 
            // txtAddAppPrice
            // 
            this.txtAddAppPrice.Location = new System.Drawing.Point(819, 99);
            this.txtAddAppPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtAddAppPrice.Name = "txtAddAppPrice";
            this.txtAddAppPrice.Size = new System.Drawing.Size(162, 21);
            this.txtAddAppPrice.TabIndex = 79;
            // 
            // txtAddContractEstate
            // 
            this.txtAddContractEstate.Location = new System.Drawing.Point(289, 682);
            this.txtAddContractEstate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAddContractEstate.Name = "txtAddContractEstate";
            this.txtAddContractEstate.Size = new System.Drawing.Size(162, 21);
            this.txtAddContractEstate.TabIndex = 78;
            // 
            // txtAddContractClient
            // 
            this.txtAddContractClient.Location = new System.Drawing.Point(289, 619);
            this.txtAddContractClient.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtAddContractClient.Name = "txtAddContractClient";
            this.txtAddContractClient.Size = new System.Drawing.Size(162, 21);
            this.txtAddContractClient.TabIndex = 77;
            // 
            // txtAddContractAgent
            // 
            this.txtAddContractAgent.Location = new System.Drawing.Point(289, 561);
            this.txtAddContractAgent.Name = "txtAddContractAgent";
            this.txtAddContractAgent.Size = new System.Drawing.Size(162, 21);
            this.txtAddContractAgent.TabIndex = 76;
            // 
            // txtAddContractDate
            // 
            this.txtAddContractDate.Location = new System.Drawing.Point(270, 503);
            this.txtAddContractDate.Name = "txtAddContractDate";
            this.txtAddContractDate.Size = new System.Drawing.Size(200, 21);
            this.txtAddContractDate.TabIndex = 75;
            // 
            // txtAddContractPrice
            // 
            this.txtAddContractPrice.Location = new System.Drawing.Point(289, 444);
            this.txtAddContractPrice.Name = "txtAddContractPrice";
            this.txtAddContractPrice.Size = new System.Drawing.Size(162, 21);
            this.txtAddContractPrice.TabIndex = 74;
            // 
            // txtAddEstateAgent
            // 
            this.txtAddEstateAgent.Location = new System.Drawing.Point(396, 214);
            this.txtAddEstateAgent.Name = "txtAddEstateAgent";
            this.txtAddEstateAgent.Size = new System.Drawing.Size(162, 21);
            this.txtAddEstateAgent.TabIndex = 73;
            // 
            // txtAddEstateTotal
            // 
            this.txtAddEstateTotal.Location = new System.Drawing.Point(396, 37);
            this.txtAddEstateTotal.Name = "txtAddEstateTotal";
            this.txtAddEstateTotal.Size = new System.Drawing.Size(162, 21);
            this.txtAddEstateTotal.TabIndex = 72;
            // 
            // txtAddEstateFloor
            // 
            this.txtAddEstateFloor.Location = new System.Drawing.Point(194, 280);
            this.txtAddEstateFloor.Name = "txtAddEstateFloor";
            this.txtAddEstateFloor.Size = new System.Drawing.Size(162, 21);
            this.txtAddEstateFloor.TabIndex = 71;
            // 
            // txtAddEstateRooms
            // 
            this.txtAddEstateRooms.Location = new System.Drawing.Point(194, 214);
            this.txtAddEstateRooms.Name = "txtAddEstateRooms";
            this.txtAddEstateRooms.Size = new System.Drawing.Size(162, 21);
            this.txtAddEstateRooms.TabIndex = 70;
            // 
            // txtAddEstatePrice
            // 
            this.txtAddEstatePrice.Location = new System.Drawing.Point(396, 158);
            this.txtAddEstatePrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtAddEstatePrice.Name = "txtAddEstatePrice";
            this.txtAddEstatePrice.Size = new System.Drawing.Size(162, 21);
            this.txtAddEstatePrice.TabIndex = 69;
            // 
            // txtAddEstateArea
            // 
            this.txtAddEstateArea.Location = new System.Drawing.Point(194, 157);
            this.txtAddEstateArea.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtAddEstateArea.Name = "txtAddEstateArea";
            this.txtAddEstateArea.Size = new System.Drawing.Size(162, 21);
            this.txtAddEstateArea.TabIndex = 68;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(1202, 64);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(213, 93);
            this.textBox3.TabIndex = 67;
            this.textBox3.Text = "ПРИМІТКА!\r\n---------------------\r\nПриклад побажання: \"З ремонтом, просторова спал" +
    "ьна кімната\"";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(625, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(128, 186);
            this.textBox2.TabIndex = 66;
            this.textBox2.Text = "ПРИМІТКА!\r\n---------------------\r\nДля поля \"номер побажання\" ви можете використат" +
    "и номер будь-якого побажання зі списку або внести нове та додати його номер";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(849, 656);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 15);
            this.label23.TabIndex = 65;
            this.label23.Text = "Номер телефону";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(874, 595);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 15);
            this.label22.TabIndex = 64;
            this.label22.Text = "Посада";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(885, 537);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 15);
            this.label21.TabIndex = 63;
            this.label21.Text = "ПІБ";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(324, 656);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 15);
            this.label20.TabIndex = 62;
            this.label20.Text = "Номер об\'єкта";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(324, 593);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 15);
            this.label19.TabIndex = 61;
            this.label19.Text = "Номер клієнта";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(326, 535);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 15);
            this.label18.TabIndex = 60;
            this.label18.Text = "Номер агента";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(321, 475);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 15);
            this.label17.TabIndex = 59;
            this.label17.Text = "Дата підписання";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(327, 416);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 15);
            this.label16.TabIndex = 58;
            this.label16.Text = "Ціна договору";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(844, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "Номер побажання";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(823, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 15);
            this.label14.TabIndex = 56;
            this.label14.Text = "Номер телефону (без \"+\")";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(822, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 15);
            this.label13.TabIndex = 55;
            this.label13.Text = "Бажаний тип приміщення";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(849, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 15);
            this.label12.TabIndex = 54;
            this.label12.Text = "Орієнтовна ціна";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(885, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "ПІБ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1209, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "Запишіть сюди ваше побажання";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(28, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 156);
            this.textBox1.TabIndex = 51;
            this.textBox1.Text = "ПРИМІТКА!\r\n---------------------\r\nЗалиште поле \"номер агента\" порожнім або постав" +
    "те прочерк, якщо клієнт ще не визначився з агентом";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Номер агента";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(461, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Ціна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(434, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Тип вбиральні";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(428, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Усього поверхів";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(250, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Поверх";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(226, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Кількість кімнат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(253, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Площа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Тип приміщення";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Адреса";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddEstateAddress
            // 
            this.txtAddEstateAddress.Location = new System.Drawing.Point(194, 32);
            this.txtAddEstateAddress.Multiline = true;
            this.txtAddEstateAddress.Name = "txtAddEstateAddress";
            this.txtAddEstateAddress.Size = new System.Drawing.Size(162, 29);
            this.txtAddEstateAddress.TabIndex = 40;
            this.txtAddEstateAddress.TextChanged += new System.EventHandler(this.txtAddEstateAddress_TextChanged);
            // 
            // txtAddAgentJob
            // 
            this.txtAddAgentJob.Location = new System.Drawing.Point(819, 611);
            this.txtAddAgentJob.Multiline = true;
            this.txtAddAgentJob.Name = "txtAddAgentJob";
            this.txtAddAgentJob.Size = new System.Drawing.Size(162, 29);
            this.txtAddAgentJob.TabIndex = 38;
            // 
            // txtAddAgentName
            // 
            this.txtAddAgentName.Location = new System.Drawing.Point(819, 553);
            this.txtAddAgentName.Multiline = true;
            this.txtAddAgentName.Name = "txtAddAgentName";
            this.txtAddAgentName.Size = new System.Drawing.Size(162, 29);
            this.txtAddAgentName.TabIndex = 37;
            // 
            // txtAddType
            // 
            this.txtAddType.Location = new System.Drawing.Point(819, 148);
            this.txtAddType.Multiline = true;
            this.txtAddType.Name = "txtAddType";
            this.txtAddType.Size = new System.Drawing.Size(162, 29);
            this.txtAddType.TabIndex = 29;
            // 
            // txtAddClientName
            // 
            this.txtAddClientName.Location = new System.Drawing.Point(819, 29);
            this.txtAddClientName.Multiline = true;
            this.txtAddClientName.Name = "txtAddClientName";
            this.txtAddClientName.Size = new System.Drawing.Size(162, 29);
            this.txtAddClientName.TabIndex = 27;
            // 
            // txtAddEstateBath
            // 
            this.txtAddEstateBath.Location = new System.Drawing.Point(396, 91);
            this.txtAddEstateBath.Multiline = true;
            this.txtAddEstateBath.Name = "txtAddEstateBath";
            this.txtAddEstateBath.Size = new System.Drawing.Size(162, 29);
            this.txtAddEstateBath.TabIndex = 24;
            this.txtAddEstateBath.TextChanged += new System.EventHandler(this.txtAddEstateBath_TextChanged);
            // 
            // txtAddEstateType
            // 
            this.txtAddEstateType.Location = new System.Drawing.Point(194, 91);
            this.txtAddEstateType.Multiline = true;
            this.txtAddEstateType.Name = "txtAddEstateType";
            this.txtAddEstateType.Size = new System.Drawing.Size(162, 29);
            this.txtAddEstateType.TabIndex = 19;
            this.txtAddEstateType.TextChanged += new System.EventHandler(this.txtAddEstateType_TextChanged);
            // 
            // btnAddEstate
            // 
            this.btnAddEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEstate.Location = new System.Drawing.Point(298, 336);
            this.btnAddEstate.Name = "btnAddEstate";
            this.btnAddEstate.Size = new System.Drawing.Size(146, 49);
            this.btnAddEstate.TabIndex = 11;
            this.btnAddEstate.Text = "Додати об\'єкт";
            this.btnAddEstate.UseVisualStyleBackColor = true;
            this.btnAddEstate.Click += new System.EventHandler(this.btnAddEstate_Click);
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAgent.Location = new System.Drawing.Point(827, 745);
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(146, 49);
            this.btnAddAgent.TabIndex = 10;
            this.btnAddAgent.Text = "Додати агента";
            this.btnAddAgent.UseVisualStyleBackColor = true;
            this.btnAddAgent.Click += new System.EventHandler(this.btnAddAgent_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddContract.Location = new System.Drawing.Point(298, 745);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(146, 49);
            this.btnAddContract.TabIndex = 9;
            this.btnAddContract.Text = "Додати договір";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // btnAddPreference
            // 
            this.btnAddPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPreference.Location = new System.Drawing.Point(1238, 336);
            this.btnAddPreference.Name = "btnAddPreference";
            this.btnAddPreference.Size = new System.Drawing.Size(146, 49);
            this.btnAddPreference.TabIndex = 8;
            this.btnAddPreference.Text = "Додати побажання";
            this.btnAddPreference.UseVisualStyleBackColor = true;
            this.btnAddPreference.Click += new System.EventHandler(this.btnAddPreference_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClient.Location = new System.Drawing.Point(827, 336);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(146, 49);
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.Text = "Додати клієнта";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtAddPreference
            // 
            this.txtAddPreference.Location = new System.Drawing.Point(1163, 207);
            this.txtAddPreference.Multiline = true;
            this.txtAddPreference.Name = "txtAddPreference";
            this.txtAddPreference.Size = new System.Drawing.Size(292, 94);
            this.txtAddPreference.TabIndex = 2;
            this.txtAddPreference.TextChanged += new System.EventHandler(this.txtAddPreference_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtUpdateContractDate);
            this.tabPage3.Controls.Add(this.txtUpdateAgentContact);
            this.tabPage3.Controls.Add(this.txtUpdateContractEstate);
            this.tabPage3.Controls.Add(this.txtUpdateContractClient);
            this.tabPage3.Controls.Add(this.txtUpdateContractAgent);
            this.tabPage3.Controls.Add(this.txtUpdateContractPrice);
            this.tabPage3.Controls.Add(this.txtUpdateApproxPrice);
            this.tabPage3.Controls.Add(this.txtUpdateContact);
            this.tabPage3.Controls.Add(this.txtUpdatePreferenceId);
            this.tabPage3.Controls.Add(this.txtUpdateEstateAgent);
            this.tabPage3.Controls.Add(this.txtUpdateEstatePrice);
            this.tabPage3.Controls.Add(this.txtUpdateEstateTotal);
            this.tabPage3.Controls.Add(this.txtUpdateEstateFloor);
            this.tabPage3.Controls.Add(this.txtUpdateEstateRoom);
            this.tabPage3.Controls.Add(this.txtUpdateEstateArea);
            this.tabPage3.Controls.Add(this.label58);
            this.tabPage3.Controls.Add(this.label57);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.label55);
            this.tabPage3.Controls.Add(this.label54);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.txtUpdateAgentId);
            this.tabPage3.Controls.Add(this.txtUpdateContractId);
            this.tabPage3.Controls.Add(this.label46);
            this.tabPage3.Controls.Add(this.label47);
            this.tabPage3.Controls.Add(this.label48);
            this.tabPage3.Controls.Add(this.label49);
            this.tabPage3.Controls.Add(this.label50);
            this.tabPage3.Controls.Add(this.label51);
            this.tabPage3.Controls.Add(this.label52);
            this.tabPage3.Controls.Add(this.label53);
            this.tabPage3.Controls.Add(this.txtUpdateAgentJob);
            this.tabPage3.Controls.Add(this.txtUpdateAgentName);
            this.tabPage3.Controls.Add(this.btnUpdateAgent);
            this.tabPage3.Controls.Add(this.btnUpdateContract);
            this.tabPage3.Controls.Add(this.txtPreferenceIdUpdate);
            this.tabPage3.Controls.Add(this.label45);
            this.tabPage3.Controls.Add(this.btnUpdatePreference);
            this.tabPage3.Controls.Add(this.txtUpdatePreference);
            this.tabPage3.Controls.Add(this.txtEstateIdUpdate);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.label38);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.label44);
            this.tabPage3.Controls.Add(this.txtUpdateEstateAddress);
            this.tabPage3.Controls.Add(this.txtUpdateEstateBath);
            this.tabPage3.Controls.Add(this.txtUpdateEstateType);
            this.tabPage3.Controls.Add(this.btnUpdateEstate);
            this.tabPage3.Controls.Add(this.txtClientIdUpdate);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.txtUpdateType);
            this.tabPage3.Controls.Add(this.txtUpdateClientName);
            this.tabPage3.Controls.Add(this.btnUpdateClient);
            this.tabPage3.Controls.Add(this.btnArchiveEstate);
            this.tabPage3.Controls.Add(this.btnArchiveClient);
            this.tabPage3.Controls.Add(this.btnArchiveAgent);
            this.tabPage3.Controls.Add(this.txtEstateArchId);
            this.tabPage3.Controls.Add(this.txtAgentArchId);
            this.tabPage3.Controls.Add(this.txtClientArchId);
            this.tabPage3.Controls.Add(this.btnClearContract);
            this.tabPage3.Controls.Add(this.btnClearEstate);
            this.tabPage3.Controls.Add(this.btnClearPreference);
            this.tabPage3.Controls.Add(this.btnClearClient);
            this.tabPage3.Controls.Add(this.btnClearAgent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1592, 905);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Редагування / видалення";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUpdateContractDate
            // 
            this.txtUpdateContractDate.Location = new System.Drawing.Point(136, 540);
            this.txtUpdateContractDate.Name = "txtUpdateContractDate";
            this.txtUpdateContractDate.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateContractDate.TabIndex = 134;
            // 
            // txtUpdateContractEstate
            // 
            this.txtUpdateContractEstate.Location = new System.Drawing.Point(162, 722);
            this.txtUpdateContractEstate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtUpdateContractEstate.Name = "txtUpdateContractEstate";
            this.txtUpdateContractEstate.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateContractEstate.TabIndex = 132;
            // 
            // txtUpdateContractClient
            // 
            this.txtUpdateContractClient.Location = new System.Drawing.Point(162, 659);
            this.txtUpdateContractClient.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtUpdateContractClient.Name = "txtUpdateContractClient";
            this.txtUpdateContractClient.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateContractClient.TabIndex = 131;
            // 
            // txtUpdateContractAgent
            // 
            this.txtUpdateContractAgent.Location = new System.Drawing.Point(162, 601);
            this.txtUpdateContractAgent.Name = "txtUpdateContractAgent";
            this.txtUpdateContractAgent.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateContractAgent.TabIndex = 130;
            // 
            // txtUpdateContractPrice
            // 
            this.txtUpdateContractPrice.Location = new System.Drawing.Point(162, 481);
            this.txtUpdateContractPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtUpdateContractPrice.Name = "txtUpdateContractPrice";
            this.txtUpdateContractPrice.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateContractPrice.TabIndex = 129;
            // 
            // txtUpdateApproxPrice
            // 
            this.txtUpdateApproxPrice.Location = new System.Drawing.Point(813, 100);
            this.txtUpdateApproxPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtUpdateApproxPrice.Name = "txtUpdateApproxPrice";
            this.txtUpdateApproxPrice.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateApproxPrice.TabIndex = 128;
            // 
            // txtUpdateContact
            // 
            this.txtUpdateContact.Location = new System.Drawing.Point(813, 215);
            this.txtUpdateContact.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtUpdateContact.Name = "txtUpdateContact";
            this.txtUpdateContact.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateContact.TabIndex = 127;
            // 
            // txtUpdatePreferenceId
            // 
            this.txtUpdatePreferenceId.Location = new System.Drawing.Point(813, 281);
            this.txtUpdatePreferenceId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtUpdatePreferenceId.Name = "txtUpdatePreferenceId";
            this.txtUpdatePreferenceId.Size = new System.Drawing.Size(146, 20);
            this.txtUpdatePreferenceId.TabIndex = 126;
            // 
            // txtUpdateEstateAgent
            // 
            this.txtUpdateEstateAgent.Location = new System.Drawing.Point(541, 215);
            this.txtUpdateEstateAgent.Name = "txtUpdateEstateAgent";
            this.txtUpdateEstateAgent.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateEstateAgent.TabIndex = 125;
            // 
            // txtUpdateEstatePrice
            // 
            this.txtUpdateEstatePrice.Location = new System.Drawing.Point(541, 160);
            this.txtUpdateEstatePrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtUpdateEstatePrice.Name = "txtUpdateEstatePrice";
            this.txtUpdateEstatePrice.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateEstatePrice.TabIndex = 124;
            // 
            // txtUpdateEstateTotal
            // 
            this.txtUpdateEstateTotal.Location = new System.Drawing.Point(541, 41);
            this.txtUpdateEstateTotal.Name = "txtUpdateEstateTotal";
            this.txtUpdateEstateTotal.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateEstateTotal.TabIndex = 123;
            // 
            // txtUpdateEstateFloor
            // 
            this.txtUpdateEstateFloor.Location = new System.Drawing.Point(339, 281);
            this.txtUpdateEstateFloor.Name = "txtUpdateEstateFloor";
            this.txtUpdateEstateFloor.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateEstateFloor.TabIndex = 122;
            // 
            // txtUpdateEstateRoom
            // 
            this.txtUpdateEstateRoom.Location = new System.Drawing.Point(339, 215);
            this.txtUpdateEstateRoom.Name = "txtUpdateEstateRoom";
            this.txtUpdateEstateRoom.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateEstateRoom.TabIndex = 121;
            // 
            // txtUpdateEstateArea
            // 
            this.txtUpdateEstateArea.Location = new System.Drawing.Point(339, 160);
            this.txtUpdateEstateArea.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtUpdateEstateArea.Name = "txtUpdateEstateArea";
            this.txtUpdateEstateArea.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateEstateArea.TabIndex = 120;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label58.Location = new System.Drawing.Point(512, 764);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(87, 15);
            this.label58.TabIndex = 119;
            this.label58.Text = "Номер запису";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label57.Location = new System.Drawing.Point(190, 763);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(87, 15);
            this.label57.TabIndex = 118;
            this.label57.Text = "Номер запису";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label56.Location = new System.Drawing.Point(1172, 318);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(87, 15);
            this.label56.TabIndex = 117;
            this.label56.Text = "Номер запису";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label55.Location = new System.Drawing.Point(842, 318);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(87, 15);
            this.label55.TabIndex = 116;
            this.label55.Text = "Номер запису";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label54.Location = new System.Drawing.Point(482, 319);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(87, 15);
            this.label54.TabIndex = 115;
            this.label54.Text = "Номер запису";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(72, 115);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(193, 109);
            this.textBox4.TabIndex = 114;
            this.textBox4.Text = "ПРИМІТКА!\r\n---------------------\r\nЗалиште поле порожнім, якщо зміна не потрібна";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUpdateAgentId
            // 
            this.txtUpdateAgentId.Location = new System.Drawing.Point(485, 783);
            this.txtUpdateAgentId.Name = "txtUpdateAgentId";
            this.txtUpdateAgentId.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateAgentId.TabIndex = 113;
            // 
            // txtUpdateContractId
            // 
            this.txtUpdateContractId.Location = new System.Drawing.Point(162, 782);
            this.txtUpdateContractId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtUpdateContractId.Name = "txtUpdateContractId";
            this.txtUpdateContractId.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateContractId.TabIndex = 112;
            this.txtUpdateContractId.ValueChanged += new System.EventHandler(this.txtUpdateContractId_ValueChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(507, 695);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(92, 13);
            this.label46.TabIndex = 111;
            this.label46.Text = "Номер телефону";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(532, 634);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(45, 13);
            this.label47.TabIndex = 110;
            this.label47.Text = "Посада";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(543, 576);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(25, 13);
            this.label48.TabIndex = 109;
            this.label48.Text = "ПІБ";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(188, 695);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(81, 13);
            this.label49.TabIndex = 108;
            this.label49.Text = "Номер об\'єкта";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(188, 632);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(81, 13);
            this.label50.TabIndex = 107;
            this.label50.Text = "Номер клієнта";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(190, 574);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(78, 13);
            this.label51.TabIndex = 106;
            this.label51.Text = "Номер агента";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(185, 514);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(92, 13);
            this.label52.TabIndex = 105;
            this.label52.Text = "Дата підписання";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(194, 455);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(78, 13);
            this.label53.TabIndex = 104;
            this.label53.Text = "Ціна договору";
            // 
            // txtUpdateAgentJob
            // 
            this.txtUpdateAgentJob.Location = new System.Drawing.Point(477, 650);
            this.txtUpdateAgentJob.Multiline = true;
            this.txtUpdateAgentJob.Name = "txtUpdateAgentJob";
            this.txtUpdateAgentJob.Size = new System.Drawing.Size(162, 29);
            this.txtUpdateAgentJob.TabIndex = 102;
            // 
            // txtUpdateAgentName
            // 
            this.txtUpdateAgentName.Location = new System.Drawing.Point(477, 592);
            this.txtUpdateAgentName.Multiline = true;
            this.txtUpdateAgentName.Name = "txtUpdateAgentName";
            this.txtUpdateAgentName.Size = new System.Drawing.Size(162, 29);
            this.txtUpdateAgentName.TabIndex = 101;
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateAgent.Location = new System.Drawing.Point(485, 826);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(146, 49);
            this.btnUpdateAgent.TabIndex = 95;
            this.btnUpdateAgent.Text = "Редагувати агента";
            this.btnUpdateAgent.UseVisualStyleBackColor = true;
            this.btnUpdateAgent.Click += new System.EventHandler(this.btnUpdateAgent_Click_1);
            // 
            // btnUpdateContract
            // 
            this.btnUpdateContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateContract.Location = new System.Drawing.Point(162, 826);
            this.btnUpdateContract.Name = "btnUpdateContract";
            this.btnUpdateContract.Size = new System.Drawing.Size(146, 49);
            this.btnUpdateContract.TabIndex = 94;
            this.btnUpdateContract.Text = "Редагувати договір";
            this.btnUpdateContract.UseVisualStyleBackColor = true;
            this.btnUpdateContract.Click += new System.EventHandler(this.btnUpdateContract_Click);
            // 
            // txtPreferenceIdUpdate
            // 
            this.txtPreferenceIdUpdate.Location = new System.Drawing.Point(1141, 337);
            this.txtPreferenceIdUpdate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPreferenceIdUpdate.Name = "txtPreferenceIdUpdate";
            this.txtPreferenceIdUpdate.Size = new System.Drawing.Size(146, 20);
            this.txtPreferenceIdUpdate.TabIndex = 93;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1166, 190);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 13);
            this.label45.TabIndex = 92;
            this.label45.Text = "Текст побажання";
            // 
            // btnUpdatePreference
            // 
            this.btnUpdatePreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdatePreference.Location = new System.Drawing.Point(1141, 384);
            this.btnUpdatePreference.Name = "btnUpdatePreference";
            this.btnUpdatePreference.Size = new System.Drawing.Size(146, 49);
            this.btnUpdatePreference.TabIndex = 91;
            this.btnUpdatePreference.Text = "Редагувати побажання";
            this.btnUpdatePreference.UseVisualStyleBackColor = true;
            this.btnUpdatePreference.Click += new System.EventHandler(this.btnUpdatePreference_Click);
            // 
            // txtUpdatePreference
            // 
            this.txtUpdatePreference.Location = new System.Drawing.Point(1069, 209);
            this.txtUpdatePreference.Multiline = true;
            this.txtUpdatePreference.Name = "txtUpdatePreference";
            this.txtUpdatePreference.Size = new System.Drawing.Size(292, 94);
            this.txtUpdatePreference.TabIndex = 90;
            // 
            // txtEstateIdUpdate
            // 
            this.txtEstateIdUpdate.Location = new System.Drawing.Point(453, 337);
            this.txtEstateIdUpdate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtEstateIdUpdate.Name = "txtEstateIdUpdate";
            this.txtEstateIdUpdate.Size = new System.Drawing.Size(146, 20);
            this.txtEstateIdUpdate.TabIndex = 89;
            this.txtEstateIdUpdate.ValueChanged += new System.EventHandler(this.txtEstateIdUpdate_ValueChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(578, 190);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(89, 15);
            this.label36.TabIndex = 88;
            this.label36.Text = "Номер агента";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(606, 135);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(33, 15);
            this.label37.TabIndex = 87;
            this.label37.Text = "Ціна";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(579, 75);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 15);
            this.label38.TabIndex = 86;
            this.label38.Text = "Тип вбиральні";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(573, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(101, 15);
            this.label39.TabIndex = 85;
            this.label39.Text = "Усього поверхів";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.Location = new System.Drawing.Point(395, 254);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 15);
            this.label40.TabIndex = 84;
            this.label40.Text = "Поверх";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(371, 190);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(103, 15);
            this.label41.TabIndex = 83;
            this.label41.Text = "Кількість кімнат";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.Location = new System.Drawing.Point(398, 135);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(46, 15);
            this.label42.TabIndex = 82;
            this.label42.Text = "Площа";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(373, 75);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(101, 15);
            this.label43.TabIndex = 81;
            this.label43.Text = "Тип приміщення";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.Location = new System.Drawing.Point(398, 16);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(48, 15);
            this.label44.TabIndex = 80;
            this.label44.Text = "Адреса";
            // 
            // txtUpdateEstateAddress
            // 
            this.txtUpdateEstateAddress.Location = new System.Drawing.Point(339, 32);
            this.txtUpdateEstateAddress.Multiline = true;
            this.txtUpdateEstateAddress.Name = "txtUpdateEstateAddress";
            this.txtUpdateEstateAddress.Size = new System.Drawing.Size(162, 29);
            this.txtUpdateEstateAddress.TabIndex = 79;
            // 
            // txtUpdateEstateBath
            // 
            this.txtUpdateEstateBath.Location = new System.Drawing.Point(541, 91);
            this.txtUpdateEstateBath.Multiline = true;
            this.txtUpdateEstateBath.Name = "txtUpdateEstateBath";
            this.txtUpdateEstateBath.Size = new System.Drawing.Size(162, 29);
            this.txtUpdateEstateBath.TabIndex = 76;
            // 
            // txtUpdateEstateType
            // 
            this.txtUpdateEstateType.Location = new System.Drawing.Point(339, 91);
            this.txtUpdateEstateType.Multiline = true;
            this.txtUpdateEstateType.Name = "txtUpdateEstateType";
            this.txtUpdateEstateType.Size = new System.Drawing.Size(162, 29);
            this.txtUpdateEstateType.TabIndex = 71;
            // 
            // btnUpdateEstate
            // 
            this.btnUpdateEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateEstate.Location = new System.Drawing.Point(453, 384);
            this.btnUpdateEstate.Name = "btnUpdateEstate";
            this.btnUpdateEstate.Size = new System.Drawing.Size(146, 49);
            this.btnUpdateEstate.TabIndex = 70;
            this.btnUpdateEstate.Text = "Редагувати об\'єкт";
            this.btnUpdateEstate.UseVisualStyleBackColor = true;
            this.btnUpdateEstate.Click += new System.EventHandler(this.btnUpdateEstate_Click_1);
            // 
            // txtClientIdUpdate
            // 
            this.txtClientIdUpdate.Location = new System.Drawing.Point(812, 336);
            this.txtClientIdUpdate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtClientIdUpdate.Name = "txtClientIdUpdate";
            this.txtClientIdUpdate.Size = new System.Drawing.Size(146, 20);
            this.txtClientIdUpdate.TabIndex = 69;
            this.txtClientIdUpdate.ValueChanged += new System.EventHandler(this.txtClientIdUpdate_ValueChanged_1);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(836, 256);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 13);
            this.label31.TabIndex = 68;
            this.label31.Text = "Номер побажання";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(818, 193);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(138, 13);
            this.label32.TabIndex = 67;
            this.label32.Text = "Номер телефону (без \"+\")";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(820, 135);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(136, 13);
            this.label33.TabIndex = 66;
            this.label33.Text = "Бажаний тип приміщення";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(843, 75);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(87, 13);
            this.label34.TabIndex = 65;
            this.label34.Text = "Орієнтовна ціна";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(872, 16);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(25, 13);
            this.label35.TabIndex = 64;
            this.label35.Text = "ПІБ";
            // 
            // txtUpdateType
            // 
            this.txtUpdateType.Location = new System.Drawing.Point(806, 151);
            this.txtUpdateType.Multiline = true;
            this.txtUpdateType.Name = "txtUpdateType";
            this.txtUpdateType.Size = new System.Drawing.Size(162, 29);
            this.txtUpdateType.TabIndex = 61;
            // 
            // txtUpdateClientName
            // 
            this.txtUpdateClientName.Location = new System.Drawing.Point(806, 32);
            this.txtUpdateClientName.Multiline = true;
            this.txtUpdateClientName.Name = "txtUpdateClientName";
            this.txtUpdateClientName.Size = new System.Drawing.Size(162, 29);
            this.txtUpdateClientName.TabIndex = 59;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateClient.Location = new System.Drawing.Point(813, 384);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(146, 49);
            this.btnUpdateClient.TabIndex = 58;
            this.btnUpdateClient.Text = "Редагувати клієнта";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnArchiveEstate
            // 
            this.btnArchiveEstate.Location = new System.Drawing.Point(813, 683);
            this.btnArchiveEstate.Name = "btnArchiveEstate";
            this.btnArchiveEstate.Size = new System.Drawing.Size(179, 36);
            this.btnArchiveEstate.TabIndex = 13;
            this.btnArchiveEstate.Text = "Архівувати об\'єкт";
            this.btnArchiveEstate.UseVisualStyleBackColor = true;
            this.btnArchiveEstate.Click += new System.EventHandler(this.btnArchiveEstate_Click_1);
            // 
            // btnArchiveClient
            // 
            this.btnArchiveClient.Location = new System.Drawing.Point(1328, 683);
            this.btnArchiveClient.Name = "btnArchiveClient";
            this.btnArchiveClient.Size = new System.Drawing.Size(179, 36);
            this.btnArchiveClient.TabIndex = 11;
            this.btnArchiveClient.Text = "Архівувати клієнта";
            this.btnArchiveClient.UseVisualStyleBackColor = true;
            this.btnArchiveClient.Click += new System.EventHandler(this.btnArchiveClient_Click_1);
            // 
            // btnArchiveAgent
            // 
            this.btnArchiveAgent.Location = new System.Drawing.Point(1069, 683);
            this.btnArchiveAgent.Name = "btnArchiveAgent";
            this.btnArchiveAgent.Size = new System.Drawing.Size(179, 36);
            this.btnArchiveAgent.TabIndex = 10;
            this.btnArchiveAgent.Text = "Архівувати агента";
            this.btnArchiveAgent.UseVisualStyleBackColor = true;
            this.btnArchiveAgent.Click += new System.EventHandler(this.btnArchiveAgent_Click_1);
            // 
            // txtEstateArchId
            // 
            this.txtEstateArchId.Location = new System.Drawing.Point(813, 649);
            this.txtEstateArchId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtEstateArchId.Name = "txtEstateArchId";
            this.txtEstateArchId.Size = new System.Drawing.Size(179, 20);
            this.txtEstateArchId.TabIndex = 8;
            // 
            // txtAgentArchId
            // 
            this.txtAgentArchId.Location = new System.Drawing.Point(1069, 647);
            this.txtAgentArchId.Name = "txtAgentArchId";
            this.txtAgentArchId.Size = new System.Drawing.Size(179, 20);
            this.txtAgentArchId.TabIndex = 6;
            // 
            // txtClientArchId
            // 
            this.txtClientArchId.Location = new System.Drawing.Point(1328, 648);
            this.txtClientArchId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtClientArchId.Name = "txtClientArchId";
            this.txtClientArchId.Size = new System.Drawing.Size(179, 20);
            this.txtClientArchId.TabIndex = 5;
            // 
            // btnClearContract
            // 
            this.btnClearContract.Location = new System.Drawing.Point(958, 774);
            this.btnClearContract.Name = "btnClearContract";
            this.btnClearContract.Size = new System.Drawing.Size(109, 45);
            this.btnClearContract.TabIndex = 4;
            this.btnClearContract.Text = "Очистити договори";
            this.btnClearContract.UseVisualStyleBackColor = true;
            this.btnClearContract.Click += new System.EventHandler(this.btnClearContract_Click);
            // 
            // btnClearEstate
            // 
            this.btnClearEstate.Location = new System.Drawing.Point(813, 774);
            this.btnClearEstate.Name = "btnClearEstate";
            this.btnClearEstate.Size = new System.Drawing.Size(109, 45);
            this.btnClearEstate.TabIndex = 3;
            this.btnClearEstate.Text = "Очистити об\'єкти";
            this.btnClearEstate.UseVisualStyleBackColor = true;
            this.btnClearEstate.Click += new System.EventHandler(this.btnClearEstate_Click);
            // 
            // btnClearPreference
            // 
            this.btnClearPreference.Location = new System.Drawing.Point(1398, 774);
            this.btnClearPreference.Name = "btnClearPreference";
            this.btnClearPreference.Size = new System.Drawing.Size(109, 45);
            this.btnClearPreference.TabIndex = 2;
            this.btnClearPreference.Text = "Очистити побажання";
            this.btnClearPreference.UseVisualStyleBackColor = true;
            this.btnClearPreference.Click += new System.EventHandler(this.btnClearPreference_Click);
            // 
            // btnClearClient
            // 
            this.btnClearClient.Location = new System.Drawing.Point(1253, 774);
            this.btnClearClient.Name = "btnClearClient";
            this.btnClearClient.Size = new System.Drawing.Size(109, 45);
            this.btnClearClient.TabIndex = 1;
            this.btnClearClient.Text = "Очистити клієнтів";
            this.btnClearClient.UseVisualStyleBackColor = true;
            this.btnClearClient.Click += new System.EventHandler(this.btnClearClient_Click_1);
            // 
            // btnClearAgent
            // 
            this.btnClearAgent.Location = new System.Drawing.Point(1106, 774);
            this.btnClearAgent.Name = "btnClearAgent";
            this.btnClearAgent.Size = new System.Drawing.Size(109, 45);
            this.btnClearAgent.TabIndex = 0;
            this.btnClearAgent.Text = "Очистити агентів";
            this.btnClearAgent.UseVisualStyleBackColor = true;
            this.btnClearAgent.Click += new System.EventHandler(this.btnClearAgent_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtUpdateAgentContact
            // 
            this.txtUpdateAgentContact.Location = new System.Drawing.Point(485, 722);
            this.txtUpdateAgentContact.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtUpdateAgentContact.Name = "txtUpdateAgentContact";
            this.txtUpdateAgentContact.Size = new System.Drawing.Size(146, 20);
            this.txtUpdateAgentContact.TabIndex = 133;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 910);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtEstateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreferenceId)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstates)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAgentContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddClientPreference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddClientContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddAppPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractEstate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddContractPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstatePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEstateArea)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractEstate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateApproxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdatePreferenceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstatePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateEstateArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateAgentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateContractId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreferenceIdUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstateIdUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientIdUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstateArchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgentArchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientArchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateAgentContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtEstateId;
        private System.Windows.Forms.NumericUpDown txtAgentId;
        private System.Windows.Forms.NumericUpDown txtClientId;
        private System.Windows.Forms.NumericUpDown txtContractId;
        private System.Windows.Forms.Button btnGetEstate;
        private System.Windows.Forms.Button btnGetAgent;
        private System.Windows.Forms.Button btnGetClient;
        private System.Windows.Forms.Button btnGetContract;
        private System.Windows.Forms.Button btnGetPreference;
        private System.Windows.Forms.NumericUpDown txtPreferenceId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewEstates;
        private System.Windows.Forms.DataGridView dataGridViewAgents;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewPreferences;
        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn estate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_floors;
        private System.Windows.Forms.DataGridViewTextBoxColumn bathroom_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn approx_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn wish_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn preference_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn estate_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferences_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn preference_text;
        private System.Windows.Forms.Button btnGetEstateById;
        private System.Windows.Forms.Button btnGetPreferenceById;
        private System.Windows.Forms.Button btnGetClientById;
        private System.Windows.Forms.Button btnGetContractById;
        private System.Windows.Forms.Button btnGetAgentById;
        private System.Windows.Forms.TextBox txtAgentLastName;
        private System.Windows.Forms.NumericUpDown txtClientNumber;
        private System.Windows.Forms.Button btnGetClientByPhoneNumber;
        private System.Windows.Forms.Button btnGetAgentByLastName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtAddPreference;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnAddAgent;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnAddPreference;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddEstate;
        private System.Windows.Forms.TextBox txtAddType;
        private System.Windows.Forms.TextBox txtAddClientName;
        private System.Windows.Forms.TextBox txtAddEstateBath;
        private System.Windows.Forms.TextBox txtAddEstateType;
        private System.Windows.Forms.TextBox txtAddAgentJob;
        private System.Windows.Forms.TextBox txtAddAgentName;
        private System.Windows.Forms.TextBox txtAddEstateAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnClearAgent;
        private System.Windows.Forms.Button btnClearClient;
        private System.Windows.Forms.Button btnClearPreference;
        private System.Windows.Forms.Button btnClearContract;
        private System.Windows.Forms.Button btnClearEstate;
        private System.Windows.Forms.NumericUpDown txtClientArchId;
        private System.Windows.Forms.Button btnArchiveAgent;
        private System.Windows.Forms.NumericUpDown txtEstateArchId;
        private System.Windows.Forms.NumericUpDown txtAgentArchId;
        private System.Windows.Forms.Button btnArchiveEstate;
        private System.Windows.Forms.Button btnArchiveClient;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtUpdateType;
        private System.Windows.Forms.TextBox txtUpdateClientName;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.NumericUpDown txtClientIdUpdate;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtUpdateEstateAddress;
        private System.Windows.Forms.TextBox txtUpdateEstateBath;
        private System.Windows.Forms.TextBox txtUpdateEstateType;
        private System.Windows.Forms.Button btnUpdateEstate;
        private System.Windows.Forms.NumericUpDown txtEstateIdUpdate;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnUpdatePreference;
        private System.Windows.Forms.TextBox txtUpdatePreference;
        private System.Windows.Forms.NumericUpDown txtPreferenceIdUpdate;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtUpdateAgentJob;
        private System.Windows.Forms.TextBox txtUpdateAgentName;
        private System.Windows.Forms.Button btnUpdateAgent;
        private System.Windows.Forms.Button btnUpdateContract;
        private System.Windows.Forms.NumericUpDown txtUpdateContractId;
        private System.Windows.Forms.NumericUpDown txtUpdateAgentId;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown txtAddEstateArea;
        private System.Windows.Forms.NumericUpDown txtAddEstatePrice;
        private System.Windows.Forms.NumericUpDown txtAddEstateFloor;
        private System.Windows.Forms.NumericUpDown txtAddEstateRooms;
        private System.Windows.Forms.NumericUpDown txtAddEstateTotal;
        private System.Windows.Forms.NumericUpDown txtAddEstateAgent;
        private System.Windows.Forms.NumericUpDown txtAddContractPrice;
        private System.Windows.Forms.NumericUpDown txtAddContractAgent;
        private System.Windows.Forms.DateTimePicker txtAddContractDate;
        private System.Windows.Forms.NumericUpDown txtAddContractEstate;
        private System.Windows.Forms.NumericUpDown txtAddContractClient;
        private System.Windows.Forms.NumericUpDown txtAddClientPreference;
        private System.Windows.Forms.NumericUpDown txtAddClientContact;
        private System.Windows.Forms.NumericUpDown txtAddAppPrice;
        private System.Windows.Forms.NumericUpDown txtAddAgentContact;
        private System.Windows.Forms.NumericUpDown txtUpdateEstateArea;
        private System.Windows.Forms.NumericUpDown txtUpdateEstateRoom;
        private System.Windows.Forms.NumericUpDown txtUpdateEstateFloor;
        private System.Windows.Forms.NumericUpDown txtUpdateEstateAgent;
        private System.Windows.Forms.NumericUpDown txtUpdateEstatePrice;
        private System.Windows.Forms.NumericUpDown txtUpdateEstateTotal;
        private System.Windows.Forms.NumericUpDown txtUpdateContact;
        private System.Windows.Forms.NumericUpDown txtUpdatePreferenceId;
        private System.Windows.Forms.NumericUpDown txtUpdateApproxPrice;
        private System.Windows.Forms.NumericUpDown txtUpdateContractClient;
        private System.Windows.Forms.NumericUpDown txtUpdateContractAgent;
        private System.Windows.Forms.NumericUpDown txtUpdateContractPrice;
        private System.Windows.Forms.NumericUpDown txtUpdateContractEstate;
        private System.Windows.Forms.DateTimePicker txtUpdateContractDate;
        private System.Windows.Forms.NumericUpDown txtUpdateAgentContact;
    }
}

