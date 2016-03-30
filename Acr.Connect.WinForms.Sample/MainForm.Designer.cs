﻿using Acr.Connect.Security.Gui;

namespace Acr.Connect.WinForms.Sample
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RealmUrl = new System.Windows.Forms.TextBox();
            this.ClientId = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.Scope = new System.Windows.Forms.TextBox();
            this.RedirectUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IdToken = new System.Windows.Forms.TextBox();
            this.IdpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JwtToken = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SignInUser = new System.Windows.Forms.CheckBox();
            this.ClientSecret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RequestTokens = new System.Windows.Forms.CheckBox();
            this.AuthCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AccessToken = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GetTokensButton = new System.Windows.Forms.Button();
            this._acrConnectOidcLogOnControl = new AcrConnectOidcLogOnControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realm URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client ID:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scope:";
            // 
            // RealmUrl
            // 
            this.RealmUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RealmUrl.Location = new System.Drawing.Point(83, 12);
            this.RealmUrl.Name = "RealmUrl";
            this.RealmUrl.Size = new System.Drawing.Size(282, 20);
            this.RealmUrl.TabIndex = 1;
            this.RealmUrl.Text = "https://acr-id-test.acr.org/secureauth7/";
            // 
            // ClientId
            // 
            this.ClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientId.Location = new System.Drawing.Point(83, 35);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(282, 20);
            this.ClientId.TabIndex = 3;
            this.ClientId.Text = "03b6dd32d0624705b8f2426da9a2fbca";
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInButton.Location = new System.Drawing.Point(695, 12);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(80, 23);
            this.SignInButton.TabIndex = 14;
            this.SignInButton.Text = "Sing In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Scope
            // 
            this.Scope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scope.Location = new System.Drawing.Point(447, 35);
            this.Scope.Name = "Scope";
            this.Scope.Size = new System.Drawing.Size(242, 20);
            this.Scope.TabIndex = 10;
            this.Scope.Text = "openid email";
            // 
            // RedirectUrl
            // 
            this.RedirectUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RedirectUrl.Location = new System.Drawing.Point(447, 57);
            this.RedirectUrl.Name = "RedirectUrl";
            this.RedirectUrl.Size = new System.Drawing.Size(242, 20);
            this.RedirectUrl.TabIndex = 12;
            this.RedirectUrl.Text = "https://localhost:44310/signin-secureauth-oidc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Redirect URL:";
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignOutButton.Location = new System.Drawing.Point(695, 41);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(80, 23);
            this.SignOutButton.TabIndex = 20;
            this.SignOutButton.Text = "SignOut";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID Token:";
            // 
            // IdToken
            // 
            this.IdToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdToken.Location = new System.Drawing.Point(83, 150);
            this.IdToken.Name = "IdToken";
            this.IdToken.Size = new System.Drawing.Size(606, 20);
            this.IdToken.TabIndex = 18;
            // 
            // IdpName
            // 
            this.IdpName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdpName.Location = new System.Drawing.Point(447, 12);
            this.IdpName.Name = "IdpName";
            this.IdpName.Size = new System.Drawing.Size(242, 20);
            this.IdpName.TabIndex = 8;
            this.IdpName.Text = "https://acr-id-test.acr.org/SecureAuth7";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "IDP Name:";
            // 
            // JwtToken
            // 
            this.JwtToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JwtToken.Location = new System.Drawing.Point(83, 176);
            this.JwtToken.Name = "JwtToken";
            this.JwtToken.Size = new System.Drawing.Size(606, 20);
            this.JwtToken.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Jwt Token:";
            // 
            // SignInUser
            // 
            this.SignInUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInUser.AutoSize = true;
            this.SignInUser.Checked = true;
            this.SignInUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SignInUser.Location = new System.Drawing.Point(447, 83);
            this.SignInUser.Name = "SignInUser";
            this.SignInUser.Size = new System.Drawing.Size(145, 17);
            this.SignInUser.TabIndex = 13;
            this.SignInUser.Text = "Sign-in user automatically";
            this.SignInUser.UseVisualStyleBackColor = true;
            // 
            // ClientSecret
            // 
            this.ClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSecret.Location = new System.Drawing.Point(83, 57);
            this.ClientSecret.Name = "ClientSecret";
            this.ClientSecret.Size = new System.Drawing.Size(282, 20);
            this.ClientSecret.TabIndex = 5;
            this.ClientSecret.Text = "711acbb5fd554be9ae62aa70d4c05818";
            this.ClientSecret.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Client Secret:";
            // 
            // RequestTokens
            // 
            this.RequestTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestTokens.AutoSize = true;
            this.RequestTokens.Checked = true;
            this.RequestTokens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RequestTokens.Location = new System.Drawing.Point(83, 83);
            this.RequestTokens.Name = "RequestTokens";
            this.RequestTokens.Size = new System.Drawing.Size(183, 17);
            this.RequestTokens.TabIndex = 6;
            this.RequestTokens.Text = "Request the tokens automatically";
            this.RequestTokens.UseVisualStyleBackColor = true;
            // 
            // AuthCode
            // 
            this.AuthCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthCode.Location = new System.Drawing.Point(83, 106);
            this.AuthCode.Name = "AuthCode";
            this.AuthCode.Size = new System.Drawing.Size(606, 20);
            this.AuthCode.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Auth Code:";
            // 
            // AccessToken
            // 
            this.AccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessToken.Location = new System.Drawing.Point(83, 128);
            this.AccessToken.Name = "AccessToken";
            this.AccessToken.Size = new System.Drawing.Size(606, 20);
            this.AccessToken.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-2, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Access Token:";
            // 
            // GetTokensButton
            // 
            this.GetTokensButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetTokensButton.Location = new System.Drawing.Point(695, 106);
            this.GetTokensButton.Name = "GetTokensButton";
            this.GetTokensButton.Size = new System.Drawing.Size(80, 23);
            this.GetTokensButton.TabIndex = 16;
            this.GetTokensButton.Text = "Get Tokens";
            this.GetTokensButton.UseVisualStyleBackColor = true;
            // 
            // AcrConnectOidcLogOnControl
            // 
            this._acrConnectOidcLogOnControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._acrConnectOidcLogOnControl.ClientId = "03b6dd32d0624705b8f2426da9a2fbca";
            this._acrConnectOidcLogOnControl.ClientSecret = null;
            this._acrConnectOidcLogOnControl.IdentityProviderName = "ACR ID TESTING";
            this._acrConnectOidcLogOnControl.Location = new System.Drawing.Point(12, 202);
            this._acrConnectOidcLogOnControl.Name = "AcrConnectOidcLogOnControl";
            this._acrConnectOidcLogOnControl.RedirectUrl = new System.Uri("http://localhost", System.UriKind.Absolute);
            this._acrConnectOidcLogOnControl.RequestTokens = true;
            this._acrConnectOidcLogOnControl.Scope = "openid email";
            this._acrConnectOidcLogOnControl.AuthenticationServiceBaseUrl = new System.Uri("https://acrid.acr.org", System.UriKind.Absolute);
            this._acrConnectOidcLogOnControl.SignInUser = false;
            this._acrConnectOidcLogOnControl.Size = new System.Drawing.Size(763, 419);
            this._acrConnectOidcLogOnControl.TabIndex = 21;
            this._acrConnectOidcLogOnControl.AuthCodeReceived += new System.EventHandler<AuthCodeReceivedEventArgs>(this.AcrConnectOidcLogonControl_AuthCodeReceived);
            this._acrConnectOidcLogOnControl.Authenticated += new System.EventHandler<AuthenticatedEventArgs>(this.AcrConnectOidcLogonControl_Authenticated);
            this._acrConnectOidcLogOnControl.TokenReceived += new System.EventHandler<TokenReceivedEventArgs>(this.AcrConnectOidcLogonControl_TokenReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 633);
            this.Controls.Add(this.GetTokensButton);
            this.Controls.Add(this.AccessToken);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AuthCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RequestTokens);
            this.Controls.Add(this.ClientSecret);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SignInUser);
            this.Controls.Add(this.JwtToken);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdpName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdToken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._acrConnectOidcLogOnControl);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.RedirectUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.Scope);
            this.Controls.Add(this.ClientId);
            this.Controls.Add(this.RealmUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "ACR ID WinForms Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RealmUrl;
        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox Scope;
        private System.Windows.Forms.TextBox RedirectUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SignOutButton;
        private AcrConnectOidcLogOnControl _acrConnectOidcLogOnControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdToken;
        private System.Windows.Forms.TextBox IdpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JwtToken;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox SignInUser;
        private System.Windows.Forms.TextBox ClientSecret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox RequestTokens;
        private System.Windows.Forms.TextBox AuthCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AccessToken;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button GetTokensButton;
    }
}