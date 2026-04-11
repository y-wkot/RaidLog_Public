namespace RaidLog
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "MT",
            "ピクトマンサー",
            "Hugahugahuga Hogeogegoge",
            "欠員補充"}, -1);
            this.calendarLog = new System.Windows.Forms.MonthCalendar();
            this.rdoRegist = new System.Windows.Forms.RadioButton();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.username = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnptmember = new System.Windows.Forms.Button();
            this.groupcontents = new System.Windows.Forms.GroupBox();
            this.lblContentstotal = new System.Windows.Forms.Label();
            this.groupmain = new System.Windows.Forms.GroupBox();
            this.txtNextPhase = new System.Windows.Forms.TextBox();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.lblNextDay = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.MaskedTextBox();
            this.txtStartTime = new System.Windows.Forms.MaskedTextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblFflogs = new System.Windows.Forms.Label();
            this.txtFflogs = new System.Windows.Forms.TextBox();
            this.lblYoutube = new System.Windows.Forms.Label();
            this.txtYoutube = new System.Windows.Forms.TextBox();
            this.labelPtList = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblNextPhase = new System.Windows.Forms.Label();
            this.lblPhaseDetail = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.cmbPhaseDetail = new System.Windows.Forms.ComboBox();
            this.cmbPhase = new System.Windows.Forms.ComboBox();
            this.cmbContent = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCalcTotalTime = new System.Windows.Forms.Button();
            this.groupmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarLog
            // 
            this.calendarLog.Location = new System.Drawing.Point(12, 167);
            this.calendarLog.Name = "calendarLog";
            this.calendarLog.TabIndex = 0;
            this.calendarLog.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarLog_DateSelected);
            // 
            // rdoRegist
            // 
            this.rdoRegist.AutoSize = true;
            this.rdoRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoRegist.Location = new System.Drawing.Point(30, 97);
            this.rdoRegist.Name = "rdoRegist";
            this.rdoRegist.Size = new System.Drawing.Size(127, 26);
            this.rdoRegist.TabIndex = 1;
            this.rdoRegist.TabStop = true;
            this.rdoRegist.Text = "登録・編集";
            this.rdoRegist.UseVisualStyleBackColor = true;
            this.rdoRegist.CheckedChanged += new System.EventHandler(this.rdoRegist_CheckedChanged);
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoDelete.Location = new System.Drawing.Point(30, 129);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(72, 26);
            this.rdoDelete.TabIndex = 2;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "削除";
            this.rdoDelete.UseVisualStyleBackColor = true;
            this.rdoDelete.CheckedChanged += new System.EventHandler(this.rdoDelete_CheckedChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.username.Location = new System.Drawing.Point(476, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(231, 33);
            this.username.TabIndex = 4;
            this.username.Text = "〇〇のマイページ";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogout.Location = new System.Drawing.Point(1086, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 38);
            this.btnLogout.TabIndex = 34;
            this.btnLogout.Text = "ログアウト";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExecute.Location = new System.Drawing.Point(992, 778);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(215, 38);
            this.btnExecute.TabIndex = 33;
            this.btnExecute.Text = "登録";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdmin.Location = new System.Drawing.Point(12, 16);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(199, 61);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "管理者用画面へ";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 734);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 82);
            this.button1.TabIndex = 8;
            this.button1.Text = "コンテンツ別累計画面へ（未実装）";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnptmember
            // 
            this.btnptmember.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnptmember.Location = new System.Drawing.Point(12, 363);
            this.btnptmember.Name = "btnptmember";
            this.btnptmember.Size = new System.Drawing.Size(199, 49);
            this.btnptmember.TabIndex = 22;
            this.btnptmember.Text = "PTメンバー編集";
            this.btnptmember.UseVisualStyleBackColor = true;
            this.btnptmember.Click += new System.EventHandler(this.btnptmember_Click);
            // 
            // groupcontents
            // 
            this.groupcontents.Location = new System.Drawing.Point(12, 623);
            this.groupcontents.Name = "groupcontents";
            this.groupcontents.Size = new System.Drawing.Size(199, 91);
            this.groupcontents.TabIndex = 10;
            this.groupcontents.TabStop = false;
            this.groupcontents.Text = "コンテンツ別（未実装）";
            // 
            // lblContentstotal
            // 
            this.lblContentstotal.AutoSize = true;
            this.lblContentstotal.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblContentstotal.Location = new System.Drawing.Point(9, 571);
            this.lblContentstotal.Name = "lblContentstotal";
            this.lblContentstotal.Size = new System.Drawing.Size(210, 16);
            this.lblContentstotal.TabIndex = 11;
            this.lblContentstotal.Text = "コンテンツ別結果選択（未実装）";
            // 
            // groupmain
            // 
            this.groupmain.Controls.Add(this.btnCalcTotalTime);
            this.groupmain.Controls.Add(this.lblTotalTime);
            this.groupmain.Controls.Add(this.txtNextPhase);
            this.groupmain.Controls.Add(this.lblSelectedId);
            this.groupmain.Controls.Add(this.lblNextDay);
            this.groupmain.Controls.Add(this.txtEndTime);
            this.groupmain.Controls.Add(this.txtStartTime);
            this.groupmain.Controls.Add(this.lblOther);
            this.groupmain.Controls.Add(this.txtOther);
            this.groupmain.Controls.Add(this.lblFflogs);
            this.groupmain.Controls.Add(this.txtFflogs);
            this.groupmain.Controls.Add(this.lblYoutube);
            this.groupmain.Controls.Add(this.txtYoutube);
            this.groupmain.Controls.Add(this.labelPtList);
            this.groupmain.Controls.Add(this.lblMemo);
            this.groupmain.Controls.Add(this.txtMemo);
            this.groupmain.Controls.Add(this.lblNextPhase);
            this.groupmain.Controls.Add(this.lblPhaseDetail);
            this.groupmain.Controls.Add(this.lblPhase);
            this.groupmain.Controls.Add(this.lblContent);
            this.groupmain.Controls.Add(this.cmbPhaseDetail);
            this.groupmain.Controls.Add(this.cmbPhase);
            this.groupmain.Controls.Add(this.cmbContent);
            this.groupmain.Controls.Add(this.lblEndTime);
            this.groupmain.Controls.Add(this.lblStartTime);
            this.groupmain.Controls.Add(this.lblSelectedDate);
            this.groupmain.Controls.Add(this.listView1);
            this.groupmain.Location = new System.Drawing.Point(223, 84);
            this.groupmain.Name = "groupmain";
            this.groupmain.Size = new System.Drawing.Size(984, 688);
            this.groupmain.TabIndex = 12;
            this.groupmain.TabStop = false;
            this.groupmain.Text = "攻略詳細";
            // 
            // txtNextPhase
            // 
            this.txtNextPhase.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNextPhase.Location = new System.Drawing.Point(206, 288);
            this.txtNextPhase.Name = "txtNextPhase";
            this.txtNextPhase.Size = new System.Drawing.Size(289, 29);
            this.txtNextPhase.TabIndex = 28;
            this.txtNextPhase.Text = "クリア目的！";
            // 
            // lblSelectedId
            // 
            this.lblSelectedId.AutoSize = true;
            this.lblSelectedId.Location = new System.Drawing.Point(62, 343);
            this.lblSelectedId.Name = "lblSelectedId";
            this.lblSelectedId.Size = new System.Drawing.Size(0, 12);
            this.lblSelectedId.TabIndex = 26;
            this.lblSelectedId.Visible = false;
            // 
            // lblNextDay
            // 
            this.lblNextDay.AutoSize = true;
            this.lblNextDay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNextDay.Location = new System.Drawing.Point(295, 102);
            this.lblNextDay.Name = "lblNextDay";
            this.lblNextDay.Size = new System.Drawing.Size(0, 22);
            this.lblNextDay.TabIndex = 25;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtEndTime.Location = new System.Drawing.Point(206, 99);
            this.txtEndTime.Mask = "00:00";
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(83, 29);
            this.txtEndTime.TabIndex = 24;
            this.txtEndTime.TextChanged += new System.EventHandler(this.OnTimeChanged);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtStartTime.Location = new System.Drawing.Point(206, 59);
            this.txtStartTime.Mask = "00:00";
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(83, 29);
            this.txtStartTime.TabIndex = 23;
            this.txtStartTime.TextChanged += new System.EventHandler(this.OnTimeChanged);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOther.Location = new System.Drawing.Point(17, 639);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(69, 22);
            this.lblOther.TabIndex = 22;
            this.lblOther.Text = "その他";
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtOther.Location = new System.Drawing.Point(206, 636);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(412, 29);
            this.txtOther.TabIndex = 32;
            this.txtOther.Text = "23:00";
            // 
            // lblFflogs
            // 
            this.lblFflogs.AutoSize = true;
            this.lblFflogs.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFflogs.Location = new System.Drawing.Point(17, 604);
            this.lblFflogs.Name = "lblFflogs";
            this.lblFflogs.Size = new System.Drawing.Size(76, 22);
            this.lblFflogs.TabIndex = 20;
            this.lblFflogs.Text = "FFlogs";
            // 
            // txtFflogs
            // 
            this.txtFflogs.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFflogs.Location = new System.Drawing.Point(206, 601);
            this.txtFflogs.Name = "txtFflogs";
            this.txtFflogs.Size = new System.Drawing.Size(412, 29);
            this.txtFflogs.TabIndex = 31;
            this.txtFflogs.Text = "hugahuga";
            // 
            // lblYoutube
            // 
            this.lblYoutube.AutoSize = true;
            this.lblYoutube.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblYoutube.Location = new System.Drawing.Point(17, 569);
            this.lblYoutube.Name = "lblYoutube";
            this.lblYoutube.Size = new System.Drawing.Size(99, 22);
            this.lblYoutube.TabIndex = 18;
            this.lblYoutube.Text = "配信URL";
            // 
            // txtYoutube
            // 
            this.txtYoutube.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtYoutube.Location = new System.Drawing.Point(206, 566);
            this.txtYoutube.Name = "txtYoutube";
            this.txtYoutube.Size = new System.Drawing.Size(412, 29);
            this.txtYoutube.TabIndex = 30;
            this.txtYoutube.Text = "hogehoge.youtube.com";
            // 
            // labelPtList
            // 
            this.labelPtList.AutoSize = true;
            this.labelPtList.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPtList.Location = new System.Drawing.Point(497, 17);
            this.labelPtList.Name = "labelPtList";
            this.labelPtList.Size = new System.Drawing.Size(111, 22);
            this.labelPtList.TabIndex = 16;
            this.labelPtList.Text = "PTメンバー";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMemo.Location = new System.Drawing.Point(17, 371);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(125, 22);
            this.lblMemo.TabIndex = 15;
            this.lblMemo.Text = "自由記入欄";
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMemo.Location = new System.Drawing.Point(21, 399);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(957, 154);
            this.txtMemo.TabIndex = 29;
            this.txtMemo.Text = "予定より早くギミックをパスすることができた。";
            // 
            // lblNextPhase
            // 
            this.lblNextPhase.AutoSize = true;
            this.lblNextPhase.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNextPhase.Location = new System.Drawing.Point(17, 291);
            this.lblNextPhase.Name = "lblNextPhase";
            this.lblNextPhase.Size = new System.Drawing.Size(148, 22);
            this.lblNextPhase.TabIndex = 13;
            this.lblNextPhase.Text = "次回攻略予定";
            // 
            // lblPhaseDetail
            // 
            this.lblPhaseDetail.AutoSize = true;
            this.lblPhaseDetail.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPhaseDetail.Location = new System.Drawing.Point(17, 245);
            this.lblPhaseDetail.Name = "lblPhaseDetail";
            this.lblPhaseDetail.Size = new System.Drawing.Size(124, 22);
            this.lblPhaseDetail.TabIndex = 12;
            this.lblPhaseDetail.Text = "フェーズ詳細";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPhase.Location = new System.Drawing.Point(17, 198);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(124, 22);
            this.lblPhase.TabIndex = 11;
            this.lblPhase.Text = "攻略フェーズ";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblContent.Location = new System.Drawing.Point(17, 146);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(141, 22);
            this.lblContent.TabIndex = 10;
            this.lblContent.Text = "攻略コンテンツ";
            // 
            // cmbPhaseDetail
            // 
            this.cmbPhaseDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhaseDetail.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbPhaseDetail.FormattingEnabled = true;
            this.cmbPhaseDetail.ItemHeight = 21;
            this.cmbPhaseDetail.Location = new System.Drawing.Point(206, 242);
            this.cmbPhaseDetail.Name = "cmbPhaseDetail";
            this.cmbPhaseDetail.Size = new System.Drawing.Size(289, 29);
            this.cmbPhaseDetail.TabIndex = 8;
            // 
            // cmbPhase
            // 
            this.cmbPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhase.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbPhase.FormattingEnabled = true;
            this.cmbPhase.ItemHeight = 21;
            this.cmbPhase.Location = new System.Drawing.Point(206, 195);
            this.cmbPhase.Name = "cmbPhase";
            this.cmbPhase.Size = new System.Drawing.Size(289, 29);
            this.cmbPhase.TabIndex = 7;
            this.cmbPhase.SelectedIndexChanged += new System.EventHandler(this.cmbPhase_SelectedIndexChanged);
            // 
            // cmbContent
            // 
            this.cmbContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContent.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbContent.FormattingEnabled = true;
            this.cmbContent.ItemHeight = 21;
            this.cmbContent.Location = new System.Drawing.Point(206, 143);
            this.cmbContent.Name = "cmbContent";
            this.cmbContent.Size = new System.Drawing.Size(289, 29);
            this.cmbContent.TabIndex = 6;
            this.cmbContent.SelectedIndexChanged += new System.EventHandler(this.cmbContent_SelectedIndexChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEndTime.Location = new System.Drawing.Point(17, 102);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(102, 22);
            this.lblEndTime.TabIndex = 5;
            this.lblEndTime.Text = "終了時間";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStartTime.Location = new System.Drawing.Point(17, 62);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(102, 22);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "開始時間";
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSelectedDate.Location = new System.Drawing.Point(60, 17);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(181, 22);
            this.lblSelectedDate.TabIndex = 1;
            this.lblSelectedDate.Text = "yyyy年mm月dd日";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTotalTime.Location = new System.Drawing.Point(247, 17);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(235, 22);
            this.lblTotalTime.TabIndex = 28;
            this.lblTotalTime.Text = "現在：0回と00時間00分";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ロール";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ジョブ";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "キャラクター名";
            this.columnHeader3.Width = 182;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "メモ";
            this.columnHeader4.Width = 113;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(501, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 348);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnCalcTotalTime
            // 
            this.btnCalcTotalTime.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCalcTotalTime.Location = new System.Drawing.Point(361, 45);
            this.btnCalcTotalTime.Name = "btnCalcTotalTime";
            this.btnCalcTotalTime.Size = new System.Drawing.Size(121, 30);
            this.btnCalcTotalTime.TabIndex = 29;
            this.btnCalcTotalTime.Text = "累計攻略時間計算";
            this.btnCalcTotalTime.UseVisualStyleBackColor = true;
            this.btnCalcTotalTime.Click += new System.EventHandler(this.btnCalcTotalTime_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 828);
            this.Controls.Add(this.groupmain);
            this.Controls.Add(this.lblContentstotal);
            this.Controls.Add(this.groupcontents);
            this.Controls.Add(this.btnptmember);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.username);
            this.Controls.Add(this.rdoDelete);
            this.Controls.Add(this.rdoRegist);
            this.Controls.Add(this.calendarLog);
            this.Name = "MenuForm";
            this.Text = "マイページ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.groupmain.ResumeLayout(false);
            this.groupmain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarLog;
        private System.Windows.Forms.RadioButton rdoRegist;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnptmember;
        private System.Windows.Forms.GroupBox groupcontents;
        private System.Windows.Forms.Label lblContentstotal;
        private System.Windows.Forms.GroupBox groupmain;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.ComboBox cmbPhase;
        private System.Windows.Forms.ComboBox cmbContent;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblNextPhase;
        private System.Windows.Forms.Label lblPhaseDetail;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.ComboBox cmbPhaseDetail;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblFflogs;
        private System.Windows.Forms.TextBox txtFflogs;
        private System.Windows.Forms.Label lblYoutube;
        private System.Windows.Forms.TextBox txtYoutube;
        private System.Windows.Forms.Label labelPtList;
        private System.Windows.Forms.MaskedTextBox txtEndTime;
        private System.Windows.Forms.MaskedTextBox txtStartTime;
        private System.Windows.Forms.Label lblNextDay;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.TextBox txtNextPhase;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCalcTotalTime;
    }
}