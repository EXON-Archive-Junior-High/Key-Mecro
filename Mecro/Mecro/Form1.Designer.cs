namespace Mecro
{
    partial class Mecro
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.content = new Guna.UI2.WinForms.Guna2TextBox();
            this.time = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.start = new Guna.UI2.WinForms.Guna2Button();
            this.stop = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(31, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "내용";
            // 
            // content
            // 
            this.content.BorderRadius = 10;
            this.content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.content.DefaultText = "";
            this.content.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.content.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.content.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.content.DisabledState.Parent = this.content;
            this.content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.content.FocusedState.Parent = this.content;
            this.content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.content.HoverState.Parent = this.content;
            this.content.Location = new System.Drawing.Point(15, 27);
            this.content.Name = "content";
            this.content.PasswordChar = '\0';
            this.content.PlaceholderText = "";
            this.content.SelectedText = "";
            this.content.ShadowDecoration.Parent = this.content;
            this.content.Size = new System.Drawing.Size(233, 33);
            this.content.TabIndex = 1;
            // 
            // time
            // 
            this.time.BorderRadius = 10;
            this.time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time.DefaultText = "";
            this.time.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.time.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.time.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.time.DisabledState.Parent = this.time;
            this.time.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.time.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.time.FocusedState.Parent = this.time;
            this.time.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.time.HoverState.Parent = this.time;
            this.time.Location = new System.Drawing.Point(263, 27);
            this.time.Name = "time";
            this.time.PasswordChar = '\0';
            this.time.PlaceholderText = "";
            this.time.SelectedText = "";
            this.time.ShadowDecoration.Parent = this.time;
            this.time.Size = new System.Drawing.Size(111, 33);
            this.time.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(260, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(235, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "시간 간격 ([밀리초 단위] 1000밀리초 = 1초)";
            // 
            // start
            // 
            this.start.BorderRadius = 10;
            this.start.CheckedState.Parent = this.start;
            this.start.CustomImages.Parent = this.start;
            this.start.FillColor = System.Drawing.Color.Gray;
            this.start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.HoverState.Parent = this.start;
            this.start.Location = new System.Drawing.Point(15, 66);
            this.start.Name = "start";
            this.start.ShadowDecoration.Parent = this.start;
            this.start.Size = new System.Drawing.Size(131, 45);
            this.start.TabIndex = 4;
            this.start.Text = "시작";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BorderRadius = 10;
            this.stop.CheckedState.Parent = this.stop;
            this.stop.CustomImages.Parent = this.stop;
            this.stop.FillColor = System.Drawing.Color.Gray;
            this.stop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stop.ForeColor = System.Drawing.Color.White;
            this.stop.HoverState.Parent = this.stop;
            this.stop.Location = new System.Drawing.Point(162, 66);
            this.stop.Name = "stop";
            this.stop.ShadowDecoration.Parent = this.stop;
            this.stop.Size = new System.Drawing.Size(131, 45);
            this.stop.TabIndex = 5;
            this.stop.Text = "정지";
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Mecro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 156);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.time);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.content);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Mecro";
            this.Text = "매크로";
            this.Load += new System.EventHandler(this.Mecro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox content;
        private Guna.UI2.WinForms.Guna2TextBox time;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button start;
        private Guna.UI2.WinForms.Guna2Button stop;
    }
}

