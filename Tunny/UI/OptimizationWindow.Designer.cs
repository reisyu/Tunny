﻿
namespace Tunny.UI
{
    partial class OptimizationWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptimizationWindow));
            this.optimizeRunButton = new System.Windows.Forms.Button();
            this.optimizeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.optimizeStopButton = new System.Windows.Forms.Button();
            this.nTrialNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.nTrialText = new System.Windows.Forms.Label();
            this.continueStudyCheckBox = new System.Windows.Forms.CheckBox();
            this.optimizeProgressBar = new System.Windows.Forms.ProgressBar();
            this.samplerComboBox = new System.Windows.Forms.ComboBox();
            this.samplerTypeText = new System.Windows.Forms.Label();
            this.studyNameLabel = new System.Windows.Forms.Label();
            this.studyNameTextBox = new System.Windows.Forms.TextBox();
            this.optimizeTabControl = new System.Windows.Forms.TabControl();
            this.optimizeTabPage = new System.Windows.Forms.TabPage();
            this.ShowRealtimeResultCheckBox = new System.Windows.Forms.CheckBox();
            this.EstimatedTimeRemainingLabel = new System.Windows.Forms.Label();
            this.optimizeBestValueLabel = new System.Windows.Forms.Label();
            this.optimizeTrialNumLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inMemoryCheckBox = new System.Windows.Forms.CheckBox();
            this.existedStudyNameLabel = new System.Windows.Forms.Label();
            this.existingStudyComboBox = new System.Windows.Forms.ComboBox();
            this.copyStudyCheckBox = new System.Windows.Forms.CheckBox();
            this.timeoutNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.Timeout = new System.Windows.Forms.Label();
            this.visualizeTabPage = new System.Windows.Forms.TabPage();
            this.visualizeIncludeDominatedCheckBox = new System.Windows.Forms.CheckBox();
            this.visualizeTypeLabel = new System.Windows.Forms.Label();
            this.visualizeTargetStudyNameLabel = new System.Windows.Forms.Label();
            this.visualizeObjectiveListBox = new System.Windows.Forms.ListBox();
            this.visualizeTargetStudyComboBox = new System.Windows.Forms.ComboBox();
            this.visualizeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.visualizeVariableListBox = new System.Windows.Forms.ListBox();
            this.visualizeTargetVariableLabel = new System.Windows.Forms.Label();
            this.visualizeClusterNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.visualizeTargetObjectiveLabel = new System.Windows.Forms.Label();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.visualizeNumClusterLabel = new System.Windows.Forms.Label();
            this.visualizeShowPlotButton = new System.Windows.Forms.Button();
            this.visualizeSavePlotButton = new System.Windows.Forms.Button();
            this.outputTabPage = new System.Windows.Forms.TabPage();
            this.outputUseModelNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.outputModelNumTextBox = new System.Windows.Forms.TextBox();
            this.outputModelNumberButton = new System.Windows.Forms.Button();
            this.reflectToSliderButton = new System.Windows.Forms.Button();
            this.outputTargetStudyComboBox = new System.Windows.Forms.ComboBox();
            this.outputTargetStudyLabel = new System.Windows.Forms.Label();
            this.outputAllTrialsButton = new System.Windows.Forms.Button();
            this.outputParatoSolutionButton = new System.Windows.Forms.Button();
            this.outputStopButton = new System.Windows.Forms.Button();
            this.outputProgressBar = new System.Windows.Forms.ProgressBar();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.TPE = new System.Windows.Forms.TabPage();
            this.tpeDefaultButton = new System.Windows.Forms.Button();
            this.tpeNEICandidatesLabel = new System.Windows.Forms.Label();
            this.tpeNStartupTrialsLabel = new System.Windows.Forms.Label();
            this.tpePriorWeightLabel = new System.Windows.Forms.Label();
            this.tpeEINumUpDown = new System.Windows.Forms.NumericUpDown();
            this.tpeStartupNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.tpePriorNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.tpeConstantLiarCheckBox = new System.Windows.Forms.CheckBox();
            this.tpeWarnIndependentSamplingCheckBox = new System.Windows.Forms.CheckBox();
            this.tpeGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.tpeMultivariateCheckBox = new System.Windows.Forms.CheckBox();
            this.tpeConsiderEndpointsCheckBox = new System.Windows.Forms.CheckBox();
            this.tpeConsiderMagicClipCheckBox = new System.Windows.Forms.CheckBox();
            this.tpeConsiderPriorCheckBox = new System.Windows.Forms.CheckBox();
            this.GP = new System.Windows.Forms.TabPage();
            this.boTorchDefaultButton = new System.Windows.Forms.Button();
            this.boTorchNStartupTrialsLabel = new System.Windows.Forms.Label();
            this.boTorchStartupNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.NSGAII = new System.Windows.Forms.TabPage();
            this.nsga2CrossoverComboBox = new System.Windows.Forms.ComboBox();
            this.nsga2CrossoverCheckBox = new System.Windows.Forms.CheckBox();
            this.nsga2DefaultButton = new System.Windows.Forms.Button();
            this.nsga2MutationProbCheckBox = new System.Windows.Forms.CheckBox();
            this.nsga2PopulationSizeLabel = new System.Windows.Forms.Label();
            this.nsga2PopulationSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.nsga2SwappingProbLabel = new System.Windows.Forms.Label();
            this.nsga2SwappingProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.nsga2CrossoverProbLabel = new System.Windows.Forms.Label();
            this.nsga2CrossoverProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.nsga2MutationProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.NSGAIII = new System.Windows.Forms.TabPage();
            this.nsga3CrossoverComboBox = new System.Windows.Forms.ComboBox();
            this.nsga3CrossoverCheckBox = new System.Windows.Forms.CheckBox();
            this.nsga3DefaultButton = new System.Windows.Forms.Button();
            this.nsga3MutationProbCheckBox = new System.Windows.Forms.CheckBox();
            this.nsga3PopulationSizeLabel = new System.Windows.Forms.Label();
            this.nsga3PopulationSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.nsga3SwappingProbLabel = new System.Windows.Forms.Label();
            this.nsga3SwappingProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.nsga3CrossoverProbLabel = new System.Windows.Forms.Label();
            this.nsga3CrossoverProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.nsga3MutationProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.CMAES = new System.Windows.Forms.TabPage();
            this.cmaEsWithMarginCheckBox = new System.Windows.Forms.CheckBox();
            this.cmaEsWarmStartComboBox = new System.Windows.Forms.ComboBox();
            this.cmaEsWarmStartCmaEsCheckBox = new System.Windows.Forms.CheckBox();
            this.cmaEsPopulationSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.cmaEsPopulationSizeLabel = new System.Windows.Forms.Label();
            this.cmaEsDefaultButton = new System.Windows.Forms.Button();
            this.cmaEsRestartCheckBox = new System.Windows.Forms.CheckBox();
            this.cmaEsUseSaparableCmaCheckBox = new System.Windows.Forms.CheckBox();
            this.cmaEsNStartupTrialsLabel = new System.Windows.Forms.Label();
            this.cmaEsStartupNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.cmaEsConsiderPruneTrialsCheckBox = new System.Windows.Forms.CheckBox();
            this.cmaEsWarnIndependentSamplingCheckBox = new System.Windows.Forms.CheckBox();
            this.cmaEsIncPopsizeLabel = new System.Windows.Forms.Label();
            this.cmaEsIncPopSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.cmaEsSigmaCheckBox = new System.Windows.Forms.CheckBox();
            this.cmaEsSigmaNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.QMC = new System.Windows.Forms.TabPage();
            this.qmcDefaultButton = new System.Windows.Forms.Button();
            this.qmcTypeComboBox = new System.Windows.Forms.ComboBox();
            this.qmcTypeLabel = new System.Windows.Forms.Label();
            this.qmcWarnAsyncSeedingCheckBox = new System.Windows.Forms.CheckBox();
            this.qmcScrambleCheckBox = new System.Windows.Forms.CheckBox();
            this.qmcWarnIndependentSamplingCheckBox = new System.Windows.Forms.CheckBox();
            this.Misc = new System.Windows.Forms.TabPage();
            this.checkPythonLibrariesCheckBox = new System.Windows.Forms.CheckBox();
            this.miscDefaultButton = new System.Windows.Forms.Button();
            this.runGarbageCollectionComboBox = new System.Windows.Forms.ComboBox();
            this.runGarbageCollectionLabel = new System.Windows.Forms.Label();
            this.fileTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setResultFilePathButton = new System.Windows.Forms.Button();
            this.clearResultButton = new System.Windows.Forms.Button();
            this.openResultFolderButton = new System.Windows.Forms.Button();
            this.licenseGroupBox = new System.Windows.Forms.GroupBox();
            this.showThirdPartyLicenseButton = new System.Windows.Forms.Button();
            this.showTunnyLicenseButton = new System.Windows.Forms.Button();
            this.outputResultBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.outputDebugLogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nTrialNumUpDown)).BeginInit();
            this.optimizeTabControl.SuspendLayout();
            this.optimizeTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumUpDown)).BeginInit();
            this.visualizeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualizeClusterNumUpDown)).BeginInit();
            this.outputTabPage.SuspendLayout();
            this.outputUseModelNumberGroupBox.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.TPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpeEINumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpeStartupNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpePriorNumUpDown)).BeginInit();
            this.GP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boTorchStartupNumUpDown)).BeginInit();
            this.NSGAII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2PopulationSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2SwappingProbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2CrossoverProbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2MutationProbUpDown)).BeginInit();
            this.NSGAIII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3PopulationSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3SwappingProbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3CrossoverProbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3MutationProbUpDown)).BeginInit();
            this.CMAES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsPopulationSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsStartupNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsIncPopSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsSigmaNumUpDown)).BeginInit();
            this.QMC.SuspendLayout();
            this.Misc.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.licenseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // optimizeRunButton
            // 
            this.optimizeRunButton.Location = new System.Drawing.Point(48, 296);
            this.optimizeRunButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optimizeRunButton.Name = "optimizeRunButton";
            this.optimizeRunButton.Size = new System.Drawing.Size(153, 34);
            this.optimizeRunButton.TabIndex = 0;
            this.optimizeRunButton.Text = "RunOptimize";
            this.optimizeRunButton.UseVisualStyleBackColor = true;
            this.optimizeRunButton.Click += new System.EventHandler(this.OptimizeRunButton_Click);
            // 
            // optimizeStopButton
            // 
            this.optimizeStopButton.Enabled = false;
            this.optimizeStopButton.Location = new System.Drawing.Point(246, 296);
            this.optimizeStopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optimizeStopButton.Name = "optimizeStopButton";
            this.optimizeStopButton.Size = new System.Drawing.Size(126, 34);
            this.optimizeStopButton.TabIndex = 1;
            this.optimizeStopButton.Text = "Stop";
            this.optimizeStopButton.UseVisualStyleBackColor = true;
            this.optimizeStopButton.Click += new System.EventHandler(this.OptimizeStopButton_Click);
            // 
            // nTrialNumUpDown
            // 
            this.nTrialNumUpDown.Location = new System.Drawing.Point(246, 52);
            this.nTrialNumUpDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nTrialNumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nTrialNumUpDown.Name = "nTrialNumUpDown";
            this.nTrialNumUpDown.Size = new System.Drawing.Size(165, 30);
            this.nTrialNumUpDown.TabIndex = 2;
            this.nTrialNumUpDown.ThousandsSeparator = true;
            this.nTrialNumUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nTrialText
            // 
            this.nTrialText.AutoSize = true;
            this.nTrialText.Location = new System.Drawing.Point(15, 56);
            this.nTrialText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nTrialText.Name = "nTrialText";
            this.nTrialText.Size = new System.Drawing.Size(151, 23);
            this.nTrialText.TabIndex = 3;
            this.nTrialText.Text = "Number of trials";
            // 
            // continueStudyCheckBox
            // 
            this.continueStudyCheckBox.AutoSize = true;
            this.continueStudyCheckBox.Location = new System.Drawing.Point(164, 72);
            this.continueStudyCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.continueStudyCheckBox.Name = "continueStudyCheckBox";
            this.continueStudyCheckBox.Size = new System.Drawing.Size(114, 27);
            this.continueStudyCheckBox.TabIndex = 5;
            this.continueStudyCheckBox.Text = "Continue";
            this.continueStudyCheckBox.UseVisualStyleBackColor = true;
            this.continueStudyCheckBox.CheckedChanged += new System.EventHandler(this.ContinueStudyCheckBox_CheckedChanged);
            // 
            // optimizeProgressBar
            // 
            this.optimizeProgressBar.Location = new System.Drawing.Point(20, 340);
            this.optimizeProgressBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optimizeProgressBar.Name = "optimizeProgressBar";
            this.optimizeProgressBar.Size = new System.Drawing.Size(388, 24);
            this.optimizeProgressBar.TabIndex = 6;
            // 
            // samplerComboBox
            // 
            this.samplerComboBox.FormattingEnabled = true;
            this.samplerComboBox.Items.AddRange(new object[] {
            "BayesianOptimization (TPE)",
            "BayesianOptimization (GP)",
            "GeneticAlgorithm (NSGA-II)",
            "GeneticAlgorithm (NSGA-III)",
            "EvolutionStrategy (CMA-ES)",
            "Quasi-MonteCarlo",
            "Random"});
            this.samplerComboBox.Location = new System.Drawing.Point(104, 14);
            this.samplerComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.samplerComboBox.Name = "samplerComboBox";
            this.samplerComboBox.Size = new System.Drawing.Size(306, 31);
            this.samplerComboBox.TabIndex = 7;
            // 
            // samplerTypeText
            // 
            this.samplerTypeText.AutoSize = true;
            this.samplerTypeText.Location = new System.Drawing.Point(15, 16);
            this.samplerTypeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.samplerTypeText.Name = "samplerTypeText";
            this.samplerTypeText.Size = new System.Drawing.Size(81, 23);
            this.samplerTypeText.TabIndex = 8;
            this.samplerTypeText.Text = "Sampler";
            // 
            // studyNameLabel
            // 
            this.studyNameLabel.AutoSize = true;
            this.studyNameLabel.Location = new System.Drawing.Point(8, 30);
            this.studyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studyNameLabel.Name = "studyNameLabel";
            this.studyNameLabel.Size = new System.Drawing.Size(166, 23);
            this.studyNameLabel.TabIndex = 9;
            this.studyNameLabel.Text = "Create New Study";
            // 
            // studyNameTextBox
            // 
            this.studyNameTextBox.Location = new System.Drawing.Point(202, 30);
            this.studyNameTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.studyNameTextBox.Name = "studyNameTextBox";
            this.studyNameTextBox.Size = new System.Drawing.Size(180, 30);
            this.studyNameTextBox.TabIndex = 10;
            this.studyNameTextBox.Text = "study1";
            // 
            // optimizeTabControl
            // 
            this.optimizeTabControl.Controls.Add(this.optimizeTabPage);
            this.optimizeTabControl.Controls.Add(this.visualizeTabPage);
            this.optimizeTabControl.Controls.Add(this.outputTabPage);
            this.optimizeTabControl.Controls.Add(this.settingsTabPage);
            this.optimizeTabControl.Controls.Add(this.fileTabPage);
            this.optimizeTabControl.Location = new System.Drawing.Point(0, -2);
            this.optimizeTabControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optimizeTabControl.Name = "optimizeTabControl";
            this.optimizeTabControl.SelectedIndex = 0;
            this.optimizeTabControl.Size = new System.Drawing.Size(436, 478);
            this.optimizeTabControl.TabIndex = 11;
            // 
            // optimizeTabPage
            // 
            this.optimizeTabPage.Controls.Add(this.ShowRealtimeResultCheckBox);
            this.optimizeTabPage.Controls.Add(this.EstimatedTimeRemainingLabel);
            this.optimizeTabPage.Controls.Add(this.optimizeBestValueLabel);
            this.optimizeTabPage.Controls.Add(this.optimizeTrialNumLabel);
            this.optimizeTabPage.Controls.Add(this.groupBox2);
            this.optimizeTabPage.Controls.Add(this.timeoutNumUpDown);
            this.optimizeTabPage.Controls.Add(this.Timeout);
            this.optimizeTabPage.Controls.Add(this.samplerComboBox);
            this.optimizeTabPage.Controls.Add(this.optimizeRunButton);
            this.optimizeTabPage.Controls.Add(this.samplerTypeText);
            this.optimizeTabPage.Controls.Add(this.optimizeStopButton);
            this.optimizeTabPage.Controls.Add(this.nTrialNumUpDown);
            this.optimizeTabPage.Controls.Add(this.optimizeProgressBar);
            this.optimizeTabPage.Controls.Add(this.nTrialText);
            this.optimizeTabPage.Location = new System.Drawing.Point(4, 32);
            this.optimizeTabPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optimizeTabPage.Name = "optimizeTabPage";
            this.optimizeTabPage.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optimizeTabPage.Size = new System.Drawing.Size(428, 442);
            this.optimizeTabPage.TabIndex = 0;
            this.optimizeTabPage.Text = "Optimize";
            this.optimizeTabPage.UseVisualStyleBackColor = true;
            // 
            // ShowRealtimeResultCheckBox
            // 
            this.ShowRealtimeResultCheckBox.AutoSize = true;
            this.ShowRealtimeResultCheckBox.Location = new System.Drawing.Point(141, 382);
            this.ShowRealtimeResultCheckBox.Name = "ShowRealtimeResultCheckBox";
            this.ShowRealtimeResultCheckBox.Size = new System.Drawing.Size(22, 21);
            this.ShowRealtimeResultCheckBox.TabIndex = 17;
            this.toolTip1.SetToolTip(this.ShowRealtimeResultCheckBox, "Enable real-time display of BestValue during optimization.\r\nIf enabled, optimizat" +
        "ion will slow down as the number of trials increases.");
            this.ShowRealtimeResultCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstimatedTimeRemainingLabel
            // 
            this.EstimatedTimeRemainingLabel.AutoSize = true;
            this.EstimatedTimeRemainingLabel.Location = new System.Drawing.Point(21, 411);
            this.EstimatedTimeRemainingLabel.Name = "EstimatedTimeRemainingLabel";
            this.EstimatedTimeRemainingLabel.Size = new System.Drawing.Size(272, 23);
            this.EstimatedTimeRemainingLabel.TabIndex = 16;
            this.EstimatedTimeRemainingLabel.Text = "Estimated Time Remaining: #";
            // 
            // optimizeBestValueLabel
            // 
            this.optimizeBestValueLabel.AutoSize = true;
            this.optimizeBestValueLabel.Location = new System.Drawing.Point(170, 380);
            this.optimizeBestValueLabel.Name = "optimizeBestValueLabel";
            this.optimizeBestValueLabel.Size = new System.Drawing.Size(129, 23);
            this.optimizeBestValueLabel.TabIndex = 15;
            this.optimizeBestValueLabel.Text = "BestValue: # ";
            // 
            // optimizeTrialNumLabel
            // 
            this.optimizeTrialNumLabel.AutoSize = true;
            this.optimizeTrialNumLabel.Location = new System.Drawing.Point(21, 380);
            this.optimizeTrialNumLabel.Name = "optimizeTrialNumLabel";
            this.optimizeTrialNumLabel.Size = new System.Drawing.Size(80, 23);
            this.optimizeTrialNumLabel.TabIndex = 14;
            this.optimizeTrialNumLabel.Text = "Trial: # ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inMemoryCheckBox);
            this.groupBox2.Controls.Add(this.existedStudyNameLabel);
            this.groupBox2.Controls.Add(this.existingStudyComboBox);
            this.groupBox2.Controls.Add(this.copyStudyCheckBox);
            this.groupBox2.Controls.Add(this.studyNameLabel);
            this.groupBox2.Controls.Add(this.continueStudyCheckBox);
            this.groupBox2.Controls.Add(this.studyNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(20, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 153);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Study Name";
            // 
            // inMemoryCheckBox
            // 
            this.inMemoryCheckBox.AutoSize = true;
            this.inMemoryCheckBox.Location = new System.Drawing.Point(12, 69);
            this.inMemoryCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inMemoryCheckBox.Name = "inMemoryCheckBox";
            this.inMemoryCheckBox.Size = new System.Drawing.Size(124, 27);
            this.inMemoryCheckBox.TabIndex = 15;
            this.inMemoryCheckBox.Text = "InMemory";
            this.inMemoryCheckBox.UseVisualStyleBackColor = true;
            this.inMemoryCheckBox.CheckedChanged += new System.EventHandler(this.InMemoryCheckBox_CheckedChanged);
            // 
            // existedStudyNameLabel
            // 
            this.existedStudyNameLabel.AutoSize = true;
            this.existedStudyNameLabel.Location = new System.Drawing.Point(8, 111);
            this.existedStudyNameLabel.Name = "existedStudyNameLabel";
            this.existedStudyNameLabel.Size = new System.Drawing.Size(135, 23);
            this.existedStudyNameLabel.TabIndex = 14;
            this.existedStudyNameLabel.Text = "Existing Study";
            // 
            // existingStudyComboBox
            // 
            this.existingStudyComboBox.FormattingEnabled = true;
            this.existingStudyComboBox.Location = new System.Drawing.Point(202, 108);
            this.existingStudyComboBox.Name = "existingStudyComboBox";
            this.existingStudyComboBox.Size = new System.Drawing.Size(180, 31);
            this.existingStudyComboBox.TabIndex = 13;
            // 
            // copyStudyCheckBox
            // 
            this.copyStudyCheckBox.AutoSize = true;
            this.copyStudyCheckBox.Location = new System.Drawing.Point(304, 72);
            this.copyStudyCheckBox.Name = "copyStudyCheckBox";
            this.copyStudyCheckBox.Size = new System.Drawing.Size(80, 27);
            this.copyStudyCheckBox.TabIndex = 12;
            this.copyStudyCheckBox.Text = "Copy";
            this.copyStudyCheckBox.UseVisualStyleBackColor = true;
            this.copyStudyCheckBox.CheckedChanged += new System.EventHandler(this.CopyStudyCheckBox_CheckedChanged);
            // 
            // timeoutNumUpDown
            // 
            this.timeoutNumUpDown.Location = new System.Drawing.Point(246, 94);
            this.timeoutNumUpDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.timeoutNumUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeoutNumUpDown.Name = "timeoutNumUpDown";
            this.timeoutNumUpDown.Size = new System.Drawing.Size(164, 30);
            this.timeoutNumUpDown.TabIndex = 12;
            this.timeoutNumUpDown.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.timeoutNumUpDown, "After this time has elapsed, optimization stops.\r\nIf 0 is entered, no stop by tim" +
        "e is performed.");
            // 
            // Timeout
            // 
            this.Timeout.AutoSize = true;
            this.Timeout.Location = new System.Drawing.Point(15, 94);
            this.Timeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(132, 23);
            this.Timeout.TabIndex = 11;
            this.Timeout.Text = "Timeout (sec)";
            // 
            // visualizeTabPage
            // 
            this.visualizeTabPage.Controls.Add(this.visualizeIncludeDominatedCheckBox);
            this.visualizeTabPage.Controls.Add(this.visualizeTypeLabel);
            this.visualizeTabPage.Controls.Add(this.visualizeTargetStudyNameLabel);
            this.visualizeTabPage.Controls.Add(this.visualizeObjectiveListBox);
            this.visualizeTabPage.Controls.Add(this.visualizeTargetStudyComboBox);
            this.visualizeTabPage.Controls.Add(this.visualizeTypeComboBox);
            this.visualizeTabPage.Controls.Add(this.visualizeVariableListBox);
            this.visualizeTabPage.Controls.Add(this.visualizeTargetVariableLabel);
            this.visualizeTabPage.Controls.Add(this.visualizeClusterNumUpDown);
            this.visualizeTabPage.Controls.Add(this.visualizeTargetObjectiveLabel);
            this.visualizeTabPage.Controls.Add(this.dashboardButton);
            this.visualizeTabPage.Controls.Add(this.visualizeNumClusterLabel);
            this.visualizeTabPage.Controls.Add(this.visualizeShowPlotButton);
            this.visualizeTabPage.Controls.Add(this.visualizeSavePlotButton);
            this.visualizeTabPage.Location = new System.Drawing.Point(4, 32);
            this.visualizeTabPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.visualizeTabPage.Name = "visualizeTabPage";
            this.visualizeTabPage.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.visualizeTabPage.Size = new System.Drawing.Size(428, 442);
            this.visualizeTabPage.TabIndex = 1;
            this.visualizeTabPage.Text = "Visualize";
            this.visualizeTabPage.UseVisualStyleBackColor = true;
            // 
            // visualizeIncludeDominatedCheckBox
            // 
            this.visualizeIncludeDominatedCheckBox.AutoSize = true;
            this.visualizeIncludeDominatedCheckBox.Checked = true;
            this.visualizeIncludeDominatedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.visualizeIncludeDominatedCheckBox.Enabled = false;
            this.visualizeIncludeDominatedCheckBox.Location = new System.Drawing.Point(26, 404);
            this.visualizeIncludeDominatedCheckBox.Name = "visualizeIncludeDominatedCheckBox";
            this.visualizeIncludeDominatedCheckBox.Size = new System.Drawing.Size(380, 27);
            this.visualizeIncludeDominatedCheckBox.TabIndex = 27;
            this.visualizeIncludeDominatedCheckBox.Text = "Include dominated trials in pareto front";
            this.visualizeIncludeDominatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // visualizeTypeLabel
            // 
            this.visualizeTypeLabel.AutoSize = true;
            this.visualizeTypeLabel.Location = new System.Drawing.Point(22, 110);
            this.visualizeTypeLabel.Name = "visualizeTypeLabel";
            this.visualizeTypeLabel.Size = new System.Drawing.Size(132, 23);
            this.visualizeTypeLabel.TabIndex = 22;
            this.visualizeTypeLabel.Text = "Visualize Type";
            // 
            // visualizeTargetStudyNameLabel
            // 
            this.visualizeTargetStudyNameLabel.AutoSize = true;
            this.visualizeTargetStudyNameLabel.Location = new System.Drawing.Point(22, 62);
            this.visualizeTargetStudyNameLabel.Name = "visualizeTargetStudyNameLabel";
            this.visualizeTargetStudyNameLabel.Size = new System.Drawing.Size(120, 23);
            this.visualizeTargetStudyNameLabel.TabIndex = 21;
            this.visualizeTargetStudyNameLabel.Text = "Target Study";
            // 
            // visualizeObjectiveListBox
            // 
            this.visualizeObjectiveListBox.FormattingEnabled = true;
            this.visualizeObjectiveListBox.ItemHeight = 23;
            this.visualizeObjectiveListBox.Location = new System.Drawing.Point(222, 200);
            this.visualizeObjectiveListBox.Name = "visualizeObjectiveListBox";
            this.visualizeObjectiveListBox.ScrollAlwaysVisible = true;
            this.visualizeObjectiveListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.visualizeObjectiveListBox.Size = new System.Drawing.Size(190, 96);
            this.visualizeObjectiveListBox.TabIndex = 26;
            // 
            // visualizeTargetStudyComboBox
            // 
            this.visualizeTargetStudyComboBox.FormattingEnabled = true;
            this.visualizeTargetStudyComboBox.Location = new System.Drawing.Point(184, 58);
            this.visualizeTargetStudyComboBox.Name = "visualizeTargetStudyComboBox";
            this.visualizeTargetStudyComboBox.Size = new System.Drawing.Size(216, 31);
            this.visualizeTargetStudyComboBox.TabIndex = 20;
            this.visualizeTargetStudyComboBox.SelectedIndexChanged += new System.EventHandler(this.VisualizeTargetStudy_Changed);
            // 
            // visualizeTypeComboBox
            // 
            this.visualizeTypeComboBox.FormattingEnabled = true;
            this.visualizeTypeComboBox.Items.AddRange(new object[] {
            "contour",
            "EDF",
            "optimization history",
            "parallel coordinate",
            "param importances",
            "pareto front",
            "slice",
            "hypervolume",
            "clustering"});
            this.visualizeTypeComboBox.Location = new System.Drawing.Point(184, 110);
            this.visualizeTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.visualizeTypeComboBox.Name = "visualizeTypeComboBox";
            this.visualizeTypeComboBox.Size = new System.Drawing.Size(216, 31);
            this.visualizeTypeComboBox.TabIndex = 0;
            this.visualizeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.VisualizeType_Changed);
            // 
            // visualizeVariableListBox
            // 
            this.visualizeVariableListBox.FormattingEnabled = true;
            this.visualizeVariableListBox.ItemHeight = 23;
            this.visualizeVariableListBox.Location = new System.Drawing.Point(26, 200);
            this.visualizeVariableListBox.Name = "visualizeVariableListBox";
            this.visualizeVariableListBox.ScrollAlwaysVisible = true;
            this.visualizeVariableListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.visualizeVariableListBox.Size = new System.Drawing.Size(190, 96);
            this.visualizeVariableListBox.TabIndex = 25;
            // 
            // visualizeTargetVariableLabel
            // 
            this.visualizeTargetVariableLabel.AutoSize = true;
            this.visualizeTargetVariableLabel.Location = new System.Drawing.Point(218, 162);
            this.visualizeTargetVariableLabel.Name = "visualizeTargetVariableLabel";
            this.visualizeTargetVariableLabel.Size = new System.Drawing.Size(139, 23);
            this.visualizeTargetVariableLabel.TabIndex = 24;
            this.visualizeTargetVariableLabel.Text = "Target Variable";
            // 
            // visualizeClusterNumUpDown
            // 
            this.visualizeClusterNumUpDown.Enabled = false;
            this.visualizeClusterNumUpDown.Location = new System.Drawing.Point(308, 358);
            this.visualizeClusterNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.visualizeClusterNumUpDown.Name = "visualizeClusterNumUpDown";
            this.visualizeClusterNumUpDown.Size = new System.Drawing.Size(93, 30);
            this.visualizeClusterNumUpDown.TabIndex = 13;
            this.visualizeClusterNumUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // visualizeTargetObjectiveLabel
            // 
            this.visualizeTargetObjectiveLabel.AutoSize = true;
            this.visualizeTargetObjectiveLabel.Location = new System.Drawing.Point(22, 162);
            this.visualizeTargetObjectiveLabel.Name = "visualizeTargetObjectiveLabel";
            this.visualizeTargetObjectiveLabel.Size = new System.Drawing.Size(152, 23);
            this.visualizeTargetObjectiveLabel.TabIndex = 23;
            this.visualizeTargetObjectiveLabel.Text = "Target Objective";
            // 
            // dashboardButton
            // 
            this.dashboardButton.Location = new System.Drawing.Point(81, 10);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(267, 33);
            this.dashboardButton.TabIndex = 11;
            this.dashboardButton.Text = "Open Optuna-Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // visualizeNumClusterLabel
            // 
            this.visualizeNumClusterLabel.AutoSize = true;
            this.visualizeNumClusterLabel.Location = new System.Drawing.Point(22, 366);
            this.visualizeNumClusterLabel.Name = "visualizeNumClusterLabel";
            this.visualizeNumClusterLabel.Size = new System.Drawing.Size(166, 23);
            this.visualizeNumClusterLabel.TabIndex = 14;
            this.visualizeNumClusterLabel.Text = "Number of cluster";
            // 
            // visualizeShowPlotButton
            // 
            this.visualizeShowPlotButton.Location = new System.Drawing.Point(36, 304);
            this.visualizeShowPlotButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.visualizeShowPlotButton.Name = "visualizeShowPlotButton";
            this.visualizeShowPlotButton.Size = new System.Drawing.Size(165, 34);
            this.visualizeShowPlotButton.TabIndex = 2;
            this.visualizeShowPlotButton.Text = "Show";
            this.visualizeShowPlotButton.UseVisualStyleBackColor = true;
            this.visualizeShowPlotButton.Click += new System.EventHandler(this.VisualizeShowPlotButton_Click);
            // 
            // visualizeSavePlotButton
            // 
            this.visualizeSavePlotButton.Location = new System.Drawing.Point(236, 304);
            this.visualizeSavePlotButton.Name = "visualizeSavePlotButton";
            this.visualizeSavePlotButton.Size = new System.Drawing.Size(165, 34);
            this.visualizeSavePlotButton.TabIndex = 3;
            this.visualizeSavePlotButton.Text = "Save";
            this.visualizeSavePlotButton.UseVisualStyleBackColor = true;
            this.visualizeSavePlotButton.Click += new System.EventHandler(this.VisualizeSavePlotButton_Click);
            // 
            // outputTabPage
            // 
            this.outputTabPage.Controls.Add(this.outputUseModelNumberGroupBox);
            this.outputTabPage.Controls.Add(this.outputTargetStudyComboBox);
            this.outputTabPage.Controls.Add(this.outputTargetStudyLabel);
            this.outputTabPage.Controls.Add(this.outputAllTrialsButton);
            this.outputTabPage.Controls.Add(this.outputParatoSolutionButton);
            this.outputTabPage.Controls.Add(this.outputStopButton);
            this.outputTabPage.Controls.Add(this.outputProgressBar);
            this.outputTabPage.Location = new System.Drawing.Point(4, 32);
            this.outputTabPage.Name = "outputTabPage";
            this.outputTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.outputTabPage.Size = new System.Drawing.Size(428, 442);
            this.outputTabPage.TabIndex = 3;
            this.outputTabPage.Text = "Output";
            this.outputTabPage.UseVisualStyleBackColor = true;
            // 
            // outputUseModelNumberGroupBox
            // 
            this.outputUseModelNumberGroupBox.Controls.Add(this.outputModelNumTextBox);
            this.outputUseModelNumberGroupBox.Controls.Add(this.outputModelNumberButton);
            this.outputUseModelNumberGroupBox.Controls.Add(this.reflectToSliderButton);
            this.outputUseModelNumberGroupBox.Location = new System.Drawing.Point(8, 146);
            this.outputUseModelNumberGroupBox.Name = "outputUseModelNumberGroupBox";
            this.outputUseModelNumberGroupBox.Size = new System.Drawing.Size(393, 202);
            this.outputUseModelNumberGroupBox.TabIndex = 21;
            this.outputUseModelNumberGroupBox.TabStop = false;
            this.outputUseModelNumberGroupBox.Text = "Use Model Number";
            // 
            // outputModelNumTextBox
            // 
            this.outputModelNumTextBox.Location = new System.Drawing.Point(21, 45);
            this.outputModelNumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputModelNumTextBox.Name = "outputModelNumTextBox";
            this.outputModelNumTextBox.Size = new System.Drawing.Size(360, 30);
            this.outputModelNumTextBox.TabIndex = 12;
            this.outputModelNumTextBox.Text = "0";
            // 
            // outputModelNumberButton
            // 
            this.outputModelNumberButton.Location = new System.Drawing.Point(206, 94);
            this.outputModelNumberButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputModelNumberButton.Name = "outputModelNumberButton";
            this.outputModelNumberButton.Size = new System.Drawing.Size(176, 82);
            this.outputModelNumberButton.TabIndex = 13;
            this.outputModelNumberButton.Text = "Output the above number models";
            this.outputModelNumberButton.UseVisualStyleBackColor = true;
            this.outputModelNumberButton.Click += new System.EventHandler(this.OutputModelNumberButton_Click);
            // 
            // reflectToSliderButton
            // 
            this.reflectToSliderButton.Location = new System.Drawing.Point(21, 94);
            this.reflectToSliderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reflectToSliderButton.Name = "reflectToSliderButton";
            this.reflectToSliderButton.Size = new System.Drawing.Size(176, 82);
            this.reflectToSliderButton.TabIndex = 16;
            this.reflectToSliderButton.Text = "Reflect the result on the sliders";
            this.reflectToSliderButton.UseVisualStyleBackColor = true;
            this.reflectToSliderButton.Click += new System.EventHandler(this.ReflectToSliderButton_Click);
            // 
            // outputTargetStudyComboBox
            // 
            this.outputTargetStudyComboBox.FormattingEnabled = true;
            this.outputTargetStudyComboBox.Location = new System.Drawing.Point(170, 24);
            this.outputTargetStudyComboBox.Name = "outputTargetStudyComboBox";
            this.outputTargetStudyComboBox.Size = new System.Drawing.Size(220, 31);
            this.outputTargetStudyComboBox.TabIndex = 20;
            // 
            // outputTargetStudyLabel
            // 
            this.outputTargetStudyLabel.AutoSize = true;
            this.outputTargetStudyLabel.Location = new System.Drawing.Point(34, 27);
            this.outputTargetStudyLabel.Name = "outputTargetStudyLabel";
            this.outputTargetStudyLabel.Size = new System.Drawing.Size(120, 23);
            this.outputTargetStudyLabel.TabIndex = 19;
            this.outputTargetStudyLabel.Text = "Target Study";
            // 
            // outputAllTrialsButton
            // 
            this.outputAllTrialsButton.Location = new System.Drawing.Point(214, 84);
            this.outputAllTrialsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputAllTrialsButton.Name = "outputAllTrialsButton";
            this.outputAllTrialsButton.Size = new System.Drawing.Size(176, 34);
            this.outputAllTrialsButton.TabIndex = 18;
            this.outputAllTrialsButton.Text = "All trials";
            this.outputAllTrialsButton.UseVisualStyleBackColor = true;
            this.outputAllTrialsButton.Click += new System.EventHandler(this.OutputAllTrialsButton_Click);
            // 
            // outputParatoSolutionButton
            // 
            this.outputParatoSolutionButton.Location = new System.Drawing.Point(28, 84);
            this.outputParatoSolutionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputParatoSolutionButton.Name = "outputParatoSolutionButton";
            this.outputParatoSolutionButton.Size = new System.Drawing.Size(176, 34);
            this.outputParatoSolutionButton.TabIndex = 17;
            this.outputParatoSolutionButton.Text = "Pareto solutions";
            this.outputParatoSolutionButton.UseVisualStyleBackColor = true;
            this.outputParatoSolutionButton.Click += new System.EventHandler(this.OutputParatoSolutionButton_Click);
            // 
            // outputStopButton
            // 
            this.outputStopButton.Enabled = false;
            this.outputStopButton.Location = new System.Drawing.Point(326, 372);
            this.outputStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputStopButton.Name = "outputStopButton";
            this.outputStopButton.Size = new System.Drawing.Size(75, 34);
            this.outputStopButton.TabIndex = 15;
            this.outputStopButton.Text = "Stop";
            this.outputStopButton.UseVisualStyleBackColor = true;
            this.outputStopButton.Click += new System.EventHandler(this.OutputStopButton_Click);
            // 
            // outputProgressBar
            // 
            this.outputProgressBar.Location = new System.Drawing.Point(28, 372);
            this.outputProgressBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.outputProgressBar.Name = "outputProgressBar";
            this.outputProgressBar.Size = new System.Drawing.Size(273, 34);
            this.outputProgressBar.TabIndex = 14;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.settingsTabControl);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 32);
            this.settingsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(428, 442);
            this.settingsTabPage.TabIndex = 2;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.TPE);
            this.settingsTabControl.Controls.Add(this.GP);
            this.settingsTabControl.Controls.Add(this.NSGAII);
            this.settingsTabControl.Controls.Add(this.NSGAIII);
            this.settingsTabControl.Controls.Add(this.CMAES);
            this.settingsTabControl.Controls.Add(this.QMC);
            this.settingsTabControl.Controls.Add(this.Misc);
            this.settingsTabControl.Location = new System.Drawing.Point(3, 3);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(420, 429);
            this.settingsTabControl.TabIndex = 0;
            // 
            // TPE
            // 
            this.TPE.Controls.Add(this.tpeDefaultButton);
            this.TPE.Controls.Add(this.tpeNEICandidatesLabel);
            this.TPE.Controls.Add(this.tpeNStartupTrialsLabel);
            this.TPE.Controls.Add(this.tpePriorWeightLabel);
            this.TPE.Controls.Add(this.tpeEINumUpDown);
            this.TPE.Controls.Add(this.tpeStartupNumUpDown);
            this.TPE.Controls.Add(this.tpePriorNumUpDown);
            this.TPE.Controls.Add(this.tpeConstantLiarCheckBox);
            this.TPE.Controls.Add(this.tpeWarnIndependentSamplingCheckBox);
            this.TPE.Controls.Add(this.tpeGroupCheckBox);
            this.TPE.Controls.Add(this.tpeMultivariateCheckBox);
            this.TPE.Controls.Add(this.tpeConsiderEndpointsCheckBox);
            this.TPE.Controls.Add(this.tpeConsiderMagicClipCheckBox);
            this.TPE.Controls.Add(this.tpeConsiderPriorCheckBox);
            this.TPE.Location = new System.Drawing.Point(4, 32);
            this.TPE.Name = "TPE";
            this.TPE.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TPE.Size = new System.Drawing.Size(412, 393);
            this.TPE.TabIndex = 0;
            this.TPE.Text = "TPE";
            this.TPE.UseVisualStyleBackColor = true;
            // 
            // tpeDefaultButton
            // 
            this.tpeDefaultButton.Location = new System.Drawing.Point(300, 350);
            this.tpeDefaultButton.Name = "tpeDefaultButton";
            this.tpeDefaultButton.Size = new System.Drawing.Size(100, 38);
            this.tpeDefaultButton.TabIndex = 13;
            this.tpeDefaultButton.Text = "Default";
            this.toolTip1.SetToolTip(this.tpeDefaultButton, "Set to Optuna\'s default value.");
            this.tpeDefaultButton.UseVisualStyleBackColor = true;
            this.tpeDefaultButton.Click += new System.EventHandler(this.TpeDefaultButton_Click);
            // 
            // tpeNEICandidatesLabel
            // 
            this.tpeNEICandidatesLabel.AutoSize = true;
            this.tpeNEICandidatesLabel.Location = new System.Drawing.Point(4, 44);
            this.tpeNEICandidatesLabel.Name = "tpeNEICandidatesLabel";
            this.tpeNEICandidatesLabel.Size = new System.Drawing.Size(225, 23);
            this.tpeNEICandidatesLabel.TabIndex = 12;
            this.tpeNEICandidatesLabel.Text = "Number of EI candidates";
            this.toolTip1.SetToolTip(this.tpeNEICandidatesLabel, "Number of candidate samples used to calculate\r\nthe expected improvement.");
            // 
            // tpeNStartupTrialsLabel
            // 
            this.tpeNStartupTrialsLabel.AutoSize = true;
            this.tpeNStartupTrialsLabel.Location = new System.Drawing.Point(4, 8);
            this.tpeNStartupTrialsLabel.Name = "tpeNStartupTrialsLabel";
            this.tpeNStartupTrialsLabel.Size = new System.Drawing.Size(219, 23);
            this.tpeNStartupTrialsLabel.TabIndex = 11;
            this.tpeNStartupTrialsLabel.Text = "Number of startup trials";
            this.toolTip1.SetToolTip(this.tpeNStartupTrialsLabel, "The random sampling is used instead of the TPE algorithm\r\nuntil the given number " +
        "of trials finish in the same study.");
            // 
            // tpePriorWeightLabel
            // 
            this.tpePriorWeightLabel.AutoSize = true;
            this.tpePriorWeightLabel.Location = new System.Drawing.Point(4, 80);
            this.tpePriorWeightLabel.Name = "tpePriorWeightLabel";
            this.tpePriorWeightLabel.Size = new System.Drawing.Size(118, 23);
            this.tpePriorWeightLabel.TabIndex = 10;
            this.tpePriorWeightLabel.Text = "Prior Weight";
            this.toolTip1.SetToolTip(this.tpePriorWeightLabel, "The weight of the prior.");
            // 
            // tpeEINumUpDown
            // 
            this.tpeEINumUpDown.Location = new System.Drawing.Point(306, 42);
            this.tpeEINumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tpeEINumUpDown.Name = "tpeEINumUpDown";
            this.tpeEINumUpDown.Size = new System.Drawing.Size(94, 30);
            this.tpeEINumUpDown.TabIndex = 9;
            this.tpeEINumUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // tpeStartupNumUpDown
            // 
            this.tpeStartupNumUpDown.Location = new System.Drawing.Point(306, 6);
            this.tpeStartupNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tpeStartupNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tpeStartupNumUpDown.Name = "tpeStartupNumUpDown";
            this.tpeStartupNumUpDown.Size = new System.Drawing.Size(94, 30);
            this.tpeStartupNumUpDown.TabIndex = 8;
            this.tpeStartupNumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tpePriorNumUpDown
            // 
            this.tpePriorNumUpDown.DecimalPlaces = 1;
            this.tpePriorNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tpePriorNumUpDown.Location = new System.Drawing.Point(306, 78);
            this.tpePriorNumUpDown.Name = "tpePriorNumUpDown";
            this.tpePriorNumUpDown.Size = new System.Drawing.Size(94, 30);
            this.tpePriorNumUpDown.TabIndex = 7;
            this.tpePriorNumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // tpeConstantLiarCheckBox
            // 
            this.tpeConstantLiarCheckBox.AutoSize = true;
            this.tpeConstantLiarCheckBox.Location = new System.Drawing.Point(242, 202);
            this.tpeConstantLiarCheckBox.Name = "tpeConstantLiarCheckBox";
            this.tpeConstantLiarCheckBox.Size = new System.Drawing.Size(152, 27);
            this.tpeConstantLiarCheckBox.TabIndex = 6;
            this.tpeConstantLiarCheckBox.Text = "Constant Liar";
            this.toolTip1.SetToolTip(this.tpeConstantLiarCheckBox, "If True, \r\npenalize running trials to avoid suggesting parameter configurations n" +
        "earby.");
            this.tpeConstantLiarCheckBox.UseVisualStyleBackColor = true;
            // 
            // tpeWarnIndependentSamplingCheckBox
            // 
            this.tpeWarnIndependentSamplingCheckBox.AutoSize = true;
            this.tpeWarnIndependentSamplingCheckBox.Checked = true;
            this.tpeWarnIndependentSamplingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tpeWarnIndependentSamplingCheckBox.Enabled = false;
            this.tpeWarnIndependentSamplingCheckBox.Location = new System.Drawing.Point(4, 238);
            this.tpeWarnIndependentSamplingCheckBox.Name = "tpeWarnIndependentSamplingCheckBox";
            this.tpeWarnIndependentSamplingCheckBox.Size = new System.Drawing.Size(284, 27);
            this.tpeWarnIndependentSamplingCheckBox.TabIndex = 5;
            this.tpeWarnIndependentSamplingCheckBox.Text = "Warn Independent Sampling";
            this.toolTip1.SetToolTip(this.tpeWarnIndependentSamplingCheckBox, "If this is True and multivariate=True, \r\na warning message is emitted\r\nwhen the v" +
        "alue of a parameter is sampled by using an independent sampler. \r\nIf multivariat" +
        "e=False, this flag has no effect.");
            this.tpeWarnIndependentSamplingCheckBox.UseVisualStyleBackColor = true;
            // 
            // tpeGroupCheckBox
            // 
            this.tpeGroupCheckBox.AutoSize = true;
            this.tpeGroupCheckBox.Location = new System.Drawing.Point(242, 170);
            this.tpeGroupCheckBox.Name = "tpeGroupCheckBox";
            this.tpeGroupCheckBox.Size = new System.Drawing.Size(89, 27);
            this.tpeGroupCheckBox.TabIndex = 4;
            this.tpeGroupCheckBox.Text = "Group";
            this.toolTip1.SetToolTip(this.tpeGroupCheckBox, "If this and multivariate are True,\r\nthe multivariate TPE with the group decompose" +
        "d search space\r\nis used when suggesting parameters. ");
            this.tpeGroupCheckBox.UseVisualStyleBackColor = true;
            // 
            // tpeMultivariateCheckBox
            // 
            this.tpeMultivariateCheckBox.AutoSize = true;
            this.tpeMultivariateCheckBox.Checked = true;
            this.tpeMultivariateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tpeMultivariateCheckBox.Location = new System.Drawing.Point(242, 136);
            this.tpeMultivariateCheckBox.Name = "tpeMultivariateCheckBox";
            this.tpeMultivariateCheckBox.Size = new System.Drawing.Size(138, 27);
            this.tpeMultivariateCheckBox.TabIndex = 3;
            this.tpeMultivariateCheckBox.Text = "Multivariate";
            this.toolTip1.SetToolTip(this.tpeMultivariateCheckBox, "If this is True, \r\nthe multivariate TPE is used when suggesting parameters. \r\nThe" +
        " multivariate TPE is reported to outperform the independent TPE.");
            this.tpeMultivariateCheckBox.UseVisualStyleBackColor = true;
            // 
            // tpeConsiderEndpointsCheckBox
            // 
            this.tpeConsiderEndpointsCheckBox.AutoSize = true;
            this.tpeConsiderEndpointsCheckBox.Location = new System.Drawing.Point(4, 170);
            this.tpeConsiderEndpointsCheckBox.Name = "tpeConsiderEndpointsCheckBox";
            this.tpeConsiderEndpointsCheckBox.Size = new System.Drawing.Size(205, 27);
            this.tpeConsiderEndpointsCheckBox.TabIndex = 2;
            this.tpeConsiderEndpointsCheckBox.Text = "Consider Endpoints";
            this.toolTip1.SetToolTip(this.tpeConsiderEndpointsCheckBox, "Take endpoints of domains into account\r\nwhen calculating variances of Gaussians i" +
        "n Parzen estimator.");
            this.tpeConsiderEndpointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tpeConsiderMagicClipCheckBox
            // 
            this.tpeConsiderMagicClipCheckBox.AutoSize = true;
            this.tpeConsiderMagicClipCheckBox.Checked = true;
            this.tpeConsiderMagicClipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tpeConsiderMagicClipCheckBox.Location = new System.Drawing.Point(4, 202);
            this.tpeConsiderMagicClipCheckBox.Name = "tpeConsiderMagicClipCheckBox";
            this.tpeConsiderMagicClipCheckBox.Size = new System.Drawing.Size(207, 27);
            this.tpeConsiderMagicClipCheckBox.TabIndex = 1;
            this.tpeConsiderMagicClipCheckBox.Text = "Consider Magic Clip";
            this.toolTip1.SetToolTip(this.tpeConsiderMagicClipCheckBox, "Enable a heuristic to limit the smallest variances of Gaussians used in the Parze" +
        "n estimator.");
            this.tpeConsiderMagicClipCheckBox.UseVisualStyleBackColor = true;
            // 
            // tpeConsiderPriorCheckBox
            // 
            this.tpeConsiderPriorCheckBox.AutoSize = true;
            this.tpeConsiderPriorCheckBox.Checked = true;
            this.tpeConsiderPriorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tpeConsiderPriorCheckBox.Location = new System.Drawing.Point(4, 136);
            this.tpeConsiderPriorCheckBox.Name = "tpeConsiderPriorCheckBox";
            this.tpeConsiderPriorCheckBox.Size = new System.Drawing.Size(159, 27);
            this.tpeConsiderPriorCheckBox.TabIndex = 0;
            this.tpeConsiderPriorCheckBox.Text = "Consider Prior";
            this.toolTip1.SetToolTip(this.tpeConsiderPriorCheckBox, "Enhance the stability of Parzen estimator by imposing a Gaussian prior when True." +
        "");
            this.tpeConsiderPriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // GP
            // 
            this.GP.Controls.Add(this.boTorchDefaultButton);
            this.GP.Controls.Add(this.boTorchNStartupTrialsLabel);
            this.GP.Controls.Add(this.boTorchStartupNumUpDown);
            this.GP.Location = new System.Drawing.Point(4, 32);
            this.GP.Name = "GP";
            this.GP.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.GP.Size = new System.Drawing.Size(412, 393);
            this.GP.TabIndex = 1;
            this.GP.Text = "GP";
            this.GP.UseVisualStyleBackColor = true;
            // 
            // boTorchDefaultButton
            // 
            this.boTorchDefaultButton.Location = new System.Drawing.Point(300, 350);
            this.boTorchDefaultButton.Name = "boTorchDefaultButton";
            this.boTorchDefaultButton.Size = new System.Drawing.Size(100, 38);
            this.boTorchDefaultButton.TabIndex = 14;
            this.boTorchDefaultButton.Text = "Default";
            this.toolTip1.SetToolTip(this.boTorchDefaultButton, "Set to Optuna\'s default value.");
            this.boTorchDefaultButton.UseVisualStyleBackColor = true;
            this.boTorchDefaultButton.Click += new System.EventHandler(this.BoTorchDefaultButton_Click);
            // 
            // boTorchNStartupTrialsLabel
            // 
            this.boTorchNStartupTrialsLabel.AutoSize = true;
            this.boTorchNStartupTrialsLabel.Location = new System.Drawing.Point(6, 8);
            this.boTorchNStartupTrialsLabel.Name = "boTorchNStartupTrialsLabel";
            this.boTorchNStartupTrialsLabel.Size = new System.Drawing.Size(219, 23);
            this.boTorchNStartupTrialsLabel.TabIndex = 13;
            this.boTorchNStartupTrialsLabel.Text = "Number of startup trials";
            this.toolTip1.SetToolTip(this.boTorchNStartupTrialsLabel, "Number of initial trials, that is the number of trials to resort to independent s" +
        "ampling.");
            // 
            // boTorchStartupNumUpDown
            // 
            this.boTorchStartupNumUpDown.Location = new System.Drawing.Point(306, 6);
            this.boTorchStartupNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.boTorchStartupNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boTorchStartupNumUpDown.Name = "boTorchStartupNumUpDown";
            this.boTorchStartupNumUpDown.Size = new System.Drawing.Size(94, 30);
            this.boTorchStartupNumUpDown.TabIndex = 12;
            this.boTorchStartupNumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NSGAII
            // 
            this.NSGAII.Controls.Add(this.nsga2CrossoverComboBox);
            this.NSGAII.Controls.Add(this.nsga2CrossoverCheckBox);
            this.NSGAII.Controls.Add(this.nsga2DefaultButton);
            this.NSGAII.Controls.Add(this.nsga2MutationProbCheckBox);
            this.NSGAII.Controls.Add(this.nsga2PopulationSizeLabel);
            this.NSGAII.Controls.Add(this.nsga2PopulationSizeUpDown);
            this.NSGAII.Controls.Add(this.nsga2SwappingProbLabel);
            this.NSGAII.Controls.Add(this.nsga2SwappingProbUpDown);
            this.NSGAII.Controls.Add(this.nsga2CrossoverProbLabel);
            this.NSGAII.Controls.Add(this.nsga2CrossoverProbUpDown);
            this.NSGAII.Controls.Add(this.nsga2MutationProbUpDown);
            this.NSGAII.Location = new System.Drawing.Point(4, 32);
            this.NSGAII.Name = "NSGAII";
            this.NSGAII.Size = new System.Drawing.Size(412, 393);
            this.NSGAII.TabIndex = 3;
            this.NSGAII.Text = "NSGAII";
            this.NSGAII.UseVisualStyleBackColor = true;
            // 
            // nsga2CrossoverComboBox
            // 
            this.nsga2CrossoverComboBox.Enabled = false;
            this.nsga2CrossoverComboBox.FormattingEnabled = true;
            this.nsga2CrossoverComboBox.Items.AddRange(new object[] {
            "Uniform",
            "BLXAlpha",
            "SPX",
            "SBX",
            "VSBX",
            "UNDX"});
            this.nsga2CrossoverComboBox.Location = new System.Drawing.Point(266, 154);
            this.nsga2CrossoverComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nsga2CrossoverComboBox.Name = "nsga2CrossoverComboBox";
            this.nsga2CrossoverComboBox.Size = new System.Drawing.Size(134, 31);
            this.nsga2CrossoverComboBox.TabIndex = 33;
            this.nsga2CrossoverComboBox.Text = "Uniform";
            // 
            // nsga2CrossoverCheckBox
            // 
            this.nsga2CrossoverCheckBox.AutoSize = true;
            this.nsga2CrossoverCheckBox.Location = new System.Drawing.Point(14, 154);
            this.nsga2CrossoverCheckBox.Name = "nsga2CrossoverCheckBox";
            this.nsga2CrossoverCheckBox.Size = new System.Drawing.Size(122, 27);
            this.nsga2CrossoverCheckBox.TabIndex = 24;
            this.nsga2CrossoverCheckBox.Text = "Crossover";
            this.toolTip1.SetToolTip(this.nsga2CrossoverCheckBox, "Crossover to be applied when creating child individuals. ");
            this.nsga2CrossoverCheckBox.UseVisualStyleBackColor = true;
            this.nsga2CrossoverCheckBox.CheckedChanged += new System.EventHandler(this.Nsga2CrossoverCheckBox_CheckedChanged);
            // 
            // nsga2DefaultButton
            // 
            this.nsga2DefaultButton.Location = new System.Drawing.Point(300, 350);
            this.nsga2DefaultButton.Name = "nsga2DefaultButton";
            this.nsga2DefaultButton.Size = new System.Drawing.Size(100, 38);
            this.nsga2DefaultButton.TabIndex = 23;
            this.nsga2DefaultButton.Text = "Default";
            this.toolTip1.SetToolTip(this.nsga2DefaultButton, "Set to Optuna\'s default value.");
            this.nsga2DefaultButton.UseVisualStyleBackColor = true;
            this.nsga2DefaultButton.Click += new System.EventHandler(this.Nsga2DefaultButton_Click);
            // 
            // nsga2MutationProbCheckBox
            // 
            this.nsga2MutationProbCheckBox.AutoSize = true;
            this.nsga2MutationProbCheckBox.Location = new System.Drawing.Point(14, 8);
            this.nsga2MutationProbCheckBox.Name = "nsga2MutationProbCheckBox";
            this.nsga2MutationProbCheckBox.Size = new System.Drawing.Size(212, 27);
            this.nsga2MutationProbCheckBox.TabIndex = 22;
            this.nsga2MutationProbCheckBox.Text = "Mutation Probability";
            this.toolTip1.SetToolTip(this.nsga2MutationProbCheckBox, "If False, \r\nthe solver automatically calculates mutation probability.");
            this.nsga2MutationProbCheckBox.UseVisualStyleBackColor = true;
            this.nsga2MutationProbCheckBox.CheckedChanged += new System.EventHandler(this.Nsga2MutationProbCheckedChanged);
            // 
            // nsga2PopulationSizeLabel
            // 
            this.nsga2PopulationSizeLabel.AutoSize = true;
            this.nsga2PopulationSizeLabel.Location = new System.Drawing.Point(9, 117);
            this.nsga2PopulationSizeLabel.Name = "nsga2PopulationSizeLabel";
            this.nsga2PopulationSizeLabel.Size = new System.Drawing.Size(144, 23);
            this.nsga2PopulationSizeLabel.TabIndex = 21;
            this.nsga2PopulationSizeLabel.Text = "Population Size";
            this.toolTip1.SetToolTip(this.nsga2PopulationSizeLabel, "Number of individuals (trials) in a generation.");
            // 
            // nsga2PopulationSizeUpDown
            // 
            this.nsga2PopulationSizeUpDown.Location = new System.Drawing.Point(309, 116);
            this.nsga2PopulationSizeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nsga2PopulationSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga2PopulationSizeUpDown.Name = "nsga2PopulationSizeUpDown";
            this.nsga2PopulationSizeUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga2PopulationSizeUpDown.TabIndex = 20;
            this.nsga2PopulationSizeUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nsga2SwappingProbLabel
            // 
            this.nsga2SwappingProbLabel.AutoSize = true;
            this.nsga2SwappingProbLabel.Location = new System.Drawing.Point(9, 81);
            this.nsga2SwappingProbLabel.Name = "nsga2SwappingProbLabel";
            this.nsga2SwappingProbLabel.Size = new System.Drawing.Size(194, 23);
            this.nsga2SwappingProbLabel.TabIndex = 19;
            this.nsga2SwappingProbLabel.Text = "Swapping Probability";
            this.toolTip1.SetToolTip(this.nsga2SwappingProbLabel, "Probability of swapping each parameter of the parents during crossover.");
            // 
            // nsga2SwappingProbUpDown
            // 
            this.nsga2SwappingProbUpDown.DecimalPlaces = 2;
            this.nsga2SwappingProbUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nsga2SwappingProbUpDown.Location = new System.Drawing.Point(309, 80);
            this.nsga2SwappingProbUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga2SwappingProbUpDown.Name = "nsga2SwappingProbUpDown";
            this.nsga2SwappingProbUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga2SwappingProbUpDown.TabIndex = 18;
            this.nsga2SwappingProbUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // nsga2CrossoverProbLabel
            // 
            this.nsga2CrossoverProbLabel.AutoSize = true;
            this.nsga2CrossoverProbLabel.Location = new System.Drawing.Point(9, 45);
            this.nsga2CrossoverProbLabel.Name = "nsga2CrossoverProbLabel";
            this.nsga2CrossoverProbLabel.Size = new System.Drawing.Size(195, 23);
            this.nsga2CrossoverProbLabel.TabIndex = 17;
            this.nsga2CrossoverProbLabel.Text = "Crossover Probability";
            this.toolTip1.SetToolTip(this.nsga2CrossoverProbLabel, "Probability that a crossover (parameters swapping between parents)\r\nwill occur wh" +
        "en creating a new individual.");
            // 
            // nsga2CrossoverProbUpDown
            // 
            this.nsga2CrossoverProbUpDown.DecimalPlaces = 2;
            this.nsga2CrossoverProbUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nsga2CrossoverProbUpDown.Location = new System.Drawing.Point(309, 44);
            this.nsga2CrossoverProbUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga2CrossoverProbUpDown.Name = "nsga2CrossoverProbUpDown";
            this.nsga2CrossoverProbUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga2CrossoverProbUpDown.TabIndex = 16;
            this.nsga2CrossoverProbUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // nsga2MutationProbUpDown
            // 
            this.nsga2MutationProbUpDown.DecimalPlaces = 2;
            this.nsga2MutationProbUpDown.Enabled = false;
            this.nsga2MutationProbUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nsga2MutationProbUpDown.Location = new System.Drawing.Point(309, 8);
            this.nsga2MutationProbUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga2MutationProbUpDown.Name = "nsga2MutationProbUpDown";
            this.nsga2MutationProbUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga2MutationProbUpDown.TabIndex = 14;
            // 
            // NSGAIII
            // 
            this.NSGAIII.Controls.Add(this.nsga3CrossoverComboBox);
            this.NSGAIII.Controls.Add(this.nsga3CrossoverCheckBox);
            this.NSGAIII.Controls.Add(this.nsga3DefaultButton);
            this.NSGAIII.Controls.Add(this.nsga3MutationProbCheckBox);
            this.NSGAIII.Controls.Add(this.nsga3PopulationSizeLabel);
            this.NSGAIII.Controls.Add(this.nsga3PopulationSizeUpDown);
            this.NSGAIII.Controls.Add(this.nsga3SwappingProbLabel);
            this.NSGAIII.Controls.Add(this.nsga3SwappingProbUpDown);
            this.NSGAIII.Controls.Add(this.nsga3CrossoverProbLabel);
            this.NSGAIII.Controls.Add(this.nsga3CrossoverProbUpDown);
            this.NSGAIII.Controls.Add(this.nsga3MutationProbUpDown);
            this.NSGAIII.Location = new System.Drawing.Point(4, 32);
            this.NSGAIII.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NSGAIII.Name = "NSGAIII";
            this.NSGAIII.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NSGAIII.Size = new System.Drawing.Size(412, 393);
            this.NSGAIII.TabIndex = 6;
            this.NSGAIII.Text = "NSGAIII";
            this.NSGAIII.UseVisualStyleBackColor = true;
            // 
            // nsga3CrossoverComboBox
            // 
            this.nsga3CrossoverComboBox.Enabled = false;
            this.nsga3CrossoverComboBox.FormattingEnabled = true;
            this.nsga3CrossoverComboBox.Items.AddRange(new object[] {
            "Uniform",
            "BLXAlpha",
            "SPX",
            "SBX",
            "VSBX",
            "UNDX"});
            this.nsga3CrossoverComboBox.Location = new System.Drawing.Point(264, 152);
            this.nsga3CrossoverComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nsga3CrossoverComboBox.Name = "nsga3CrossoverComboBox";
            this.nsga3CrossoverComboBox.Size = new System.Drawing.Size(134, 31);
            this.nsga3CrossoverComboBox.TabIndex = 44;
            this.nsga3CrossoverComboBox.Text = "Uniform";
            // 
            // nsga3CrossoverCheckBox
            // 
            this.nsga3CrossoverCheckBox.AutoSize = true;
            this.nsga3CrossoverCheckBox.Location = new System.Drawing.Point(12, 152);
            this.nsga3CrossoverCheckBox.Name = "nsga3CrossoverCheckBox";
            this.nsga3CrossoverCheckBox.Size = new System.Drawing.Size(122, 27);
            this.nsga3CrossoverCheckBox.TabIndex = 43;
            this.nsga3CrossoverCheckBox.Text = "Crossover";
            this.toolTip1.SetToolTip(this.nsga3CrossoverCheckBox, "Crossover to be applied when creating child individuals. ");
            this.nsga3CrossoverCheckBox.UseVisualStyleBackColor = true;
            this.nsga3CrossoverCheckBox.CheckedChanged += new System.EventHandler(this.Nsga3CrossoverCheckBox_CheckedChanged);
            // 
            // nsga3DefaultButton
            // 
            this.nsga3DefaultButton.Location = new System.Drawing.Point(298, 346);
            this.nsga3DefaultButton.Name = "nsga3DefaultButton";
            this.nsga3DefaultButton.Size = new System.Drawing.Size(100, 38);
            this.nsga3DefaultButton.TabIndex = 42;
            this.nsga3DefaultButton.Text = "Default";
            this.toolTip1.SetToolTip(this.nsga3DefaultButton, "Set to Optuna\'s default value.");
            this.nsga3DefaultButton.UseVisualStyleBackColor = true;
            this.nsga3DefaultButton.Click += new System.EventHandler(this.Nsga3DefaultButton_Click);
            // 
            // nsga3MutationProbCheckBox
            // 
            this.nsga3MutationProbCheckBox.AutoSize = true;
            this.nsga3MutationProbCheckBox.Location = new System.Drawing.Point(12, 4);
            this.nsga3MutationProbCheckBox.Name = "nsga3MutationProbCheckBox";
            this.nsga3MutationProbCheckBox.Size = new System.Drawing.Size(212, 27);
            this.nsga3MutationProbCheckBox.TabIndex = 41;
            this.nsga3MutationProbCheckBox.Text = "Mutation Probability";
            this.toolTip1.SetToolTip(this.nsga3MutationProbCheckBox, "If False, \r\nthe solver automatically calculates mutation probability.");
            this.nsga3MutationProbCheckBox.UseVisualStyleBackColor = true;
            this.nsga3MutationProbCheckBox.CheckedChanged += new System.EventHandler(this.Nsga3MutationProbCheckedChanged);
            // 
            // nsga3PopulationSizeLabel
            // 
            this.nsga3PopulationSizeLabel.AutoSize = true;
            this.nsga3PopulationSizeLabel.Location = new System.Drawing.Point(8, 114);
            this.nsga3PopulationSizeLabel.Name = "nsga3PopulationSizeLabel";
            this.nsga3PopulationSizeLabel.Size = new System.Drawing.Size(144, 23);
            this.nsga3PopulationSizeLabel.TabIndex = 40;
            this.nsga3PopulationSizeLabel.Text = "Population Size";
            this.toolTip1.SetToolTip(this.nsga3PopulationSizeLabel, "Number of individuals (trials) in a generation.");
            // 
            // nsga3PopulationSizeUpDown
            // 
            this.nsga3PopulationSizeUpDown.Location = new System.Drawing.Point(308, 112);
            this.nsga3PopulationSizeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nsga3PopulationSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga3PopulationSizeUpDown.Name = "nsga3PopulationSizeUpDown";
            this.nsga3PopulationSizeUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga3PopulationSizeUpDown.TabIndex = 39;
            this.nsga3PopulationSizeUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nsga3SwappingProbLabel
            // 
            this.nsga3SwappingProbLabel.AutoSize = true;
            this.nsga3SwappingProbLabel.Location = new System.Drawing.Point(8, 78);
            this.nsga3SwappingProbLabel.Name = "nsga3SwappingProbLabel";
            this.nsga3SwappingProbLabel.Size = new System.Drawing.Size(194, 23);
            this.nsga3SwappingProbLabel.TabIndex = 38;
            this.nsga3SwappingProbLabel.Text = "Swapping Probability";
            this.toolTip1.SetToolTip(this.nsga3SwappingProbLabel, "Probability of swapping each parameter of the parents during crossover.");
            // 
            // nsga3SwappingProbUpDown
            // 
            this.nsga3SwappingProbUpDown.DecimalPlaces = 2;
            this.nsga3SwappingProbUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nsga3SwappingProbUpDown.Location = new System.Drawing.Point(308, 76);
            this.nsga3SwappingProbUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga3SwappingProbUpDown.Name = "nsga3SwappingProbUpDown";
            this.nsga3SwappingProbUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga3SwappingProbUpDown.TabIndex = 37;
            this.nsga3SwappingProbUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // nsga3CrossoverProbLabel
            // 
            this.nsga3CrossoverProbLabel.AutoSize = true;
            this.nsga3CrossoverProbLabel.Location = new System.Drawing.Point(8, 42);
            this.nsga3CrossoverProbLabel.Name = "nsga3CrossoverProbLabel";
            this.nsga3CrossoverProbLabel.Size = new System.Drawing.Size(195, 23);
            this.nsga3CrossoverProbLabel.TabIndex = 36;
            this.nsga3CrossoverProbLabel.Text = "Crossover Probability";
            this.toolTip1.SetToolTip(this.nsga3CrossoverProbLabel, "Probability that a crossover (parameters swapping between parents)\r\nwill occur wh" +
        "en creating a new individual.");
            // 
            // nsga3CrossoverProbUpDown
            // 
            this.nsga3CrossoverProbUpDown.DecimalPlaces = 2;
            this.nsga3CrossoverProbUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nsga3CrossoverProbUpDown.Location = new System.Drawing.Point(308, 40);
            this.nsga3CrossoverProbUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga3CrossoverProbUpDown.Name = "nsga3CrossoverProbUpDown";
            this.nsga3CrossoverProbUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga3CrossoverProbUpDown.TabIndex = 35;
            this.nsga3CrossoverProbUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // nsga3MutationProbUpDown
            // 
            this.nsga3MutationProbUpDown.DecimalPlaces = 2;
            this.nsga3MutationProbUpDown.Enabled = false;
            this.nsga3MutationProbUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nsga3MutationProbUpDown.Location = new System.Drawing.Point(308, 4);
            this.nsga3MutationProbUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nsga3MutationProbUpDown.Name = "nsga3MutationProbUpDown";
            this.nsga3MutationProbUpDown.Size = new System.Drawing.Size(94, 30);
            this.nsga3MutationProbUpDown.TabIndex = 34;
            // 
            // CMAES
            // 
            this.CMAES.Controls.Add(this.cmaEsWithMarginCheckBox);
            this.CMAES.Controls.Add(this.cmaEsWarmStartComboBox);
            this.CMAES.Controls.Add(this.cmaEsWarmStartCmaEsCheckBox);
            this.CMAES.Controls.Add(this.cmaEsPopulationSizeUpDown);
            this.CMAES.Controls.Add(this.cmaEsPopulationSizeLabel);
            this.CMAES.Controls.Add(this.cmaEsDefaultButton);
            this.CMAES.Controls.Add(this.cmaEsRestartCheckBox);
            this.CMAES.Controls.Add(this.cmaEsUseSaparableCmaCheckBox);
            this.CMAES.Controls.Add(this.cmaEsNStartupTrialsLabel);
            this.CMAES.Controls.Add(this.cmaEsStartupNumUpDown);
            this.CMAES.Controls.Add(this.cmaEsConsiderPruneTrialsCheckBox);
            this.CMAES.Controls.Add(this.cmaEsWarnIndependentSamplingCheckBox);
            this.CMAES.Controls.Add(this.cmaEsIncPopsizeLabel);
            this.CMAES.Controls.Add(this.cmaEsIncPopSizeUpDown);
            this.CMAES.Controls.Add(this.cmaEsSigmaCheckBox);
            this.CMAES.Controls.Add(this.cmaEsSigmaNumUpDown);
            this.CMAES.Location = new System.Drawing.Point(4, 32);
            this.CMAES.Name = "CMAES";
            this.CMAES.Size = new System.Drawing.Size(412, 393);
            this.CMAES.TabIndex = 2;
            this.CMAES.Text = "CMA-ES";
            this.CMAES.UseVisualStyleBackColor = true;
            // 
            // cmaEsWithMarginCheckBox
            // 
            this.cmaEsWithMarginCheckBox.AutoSize = true;
            this.cmaEsWithMarginCheckBox.Checked = true;
            this.cmaEsWithMarginCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmaEsWithMarginCheckBox.Location = new System.Drawing.Point(260, 75);
            this.cmaEsWithMarginCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmaEsWithMarginCheckBox.Name = "cmaEsWithMarginCheckBox";
            this.cmaEsWithMarginCheckBox.Size = new System.Drawing.Size(144, 27);
            this.cmaEsWithMarginCheckBox.TabIndex = 38;
            this.cmaEsWithMarginCheckBox.Text = "With margin";
            this.cmaEsWithMarginCheckBox.UseVisualStyleBackColor = true;
            this.cmaEsWithMarginCheckBox.CheckedChanged += new System.EventHandler(this.CmaEsWithMarginCheckBox_CheckedChanged);
            // 
            // cmaEsWarmStartComboBox
            // 
            this.cmaEsWarmStartComboBox.Enabled = false;
            this.cmaEsWarmStartComboBox.FormattingEnabled = true;
            this.cmaEsWarmStartComboBox.Location = new System.Drawing.Point(218, 252);
            this.cmaEsWarmStartComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmaEsWarmStartComboBox.Name = "cmaEsWarmStartComboBox";
            this.cmaEsWarmStartComboBox.Size = new System.Drawing.Size(180, 31);
            this.cmaEsWarmStartComboBox.TabIndex = 37;
            // 
            // cmaEsWarmStartCmaEsCheckBox
            // 
            this.cmaEsWarmStartCmaEsCheckBox.AutoSize = true;
            this.cmaEsWarmStartCmaEsCheckBox.Location = new System.Drawing.Point(10, 222);
            this.cmaEsWarmStartCmaEsCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmaEsWarmStartCmaEsCheckBox.Name = "cmaEsWarmStartCmaEsCheckBox";
            this.cmaEsWarmStartCmaEsCheckBox.Size = new System.Drawing.Size(210, 27);
            this.cmaEsWarmStartCmaEsCheckBox.TabIndex = 36;
            this.cmaEsWarmStartCmaEsCheckBox.Text = "Warm Start CMA-ES";
            this.cmaEsWarmStartCmaEsCheckBox.UseVisualStyleBackColor = true;
            this.cmaEsWarmStartCmaEsCheckBox.CheckedChanged += new System.EventHandler(this.CmaEsWarmStartCmaEsCheckBox_CheckedChanged);
            // 
            // cmaEsPopulationSizeUpDown
            // 
            this.cmaEsPopulationSizeUpDown.Enabled = false;
            this.cmaEsPopulationSizeUpDown.Location = new System.Drawing.Point(303, 140);
            this.cmaEsPopulationSizeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmaEsPopulationSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmaEsPopulationSizeUpDown.Name = "cmaEsPopulationSizeUpDown";
            this.cmaEsPopulationSizeUpDown.Size = new System.Drawing.Size(94, 30);
            this.cmaEsPopulationSizeUpDown.TabIndex = 35;
            this.cmaEsPopulationSizeUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmaEsPopulationSizeLabel
            // 
            this.cmaEsPopulationSizeLabel.AutoSize = true;
            this.cmaEsPopulationSizeLabel.Location = new System.Drawing.Point(6, 146);
            this.cmaEsPopulationSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmaEsPopulationSizeLabel.Name = "cmaEsPopulationSizeLabel";
            this.cmaEsPopulationSizeLabel.Size = new System.Drawing.Size(144, 23);
            this.cmaEsPopulationSizeLabel.TabIndex = 34;
            this.cmaEsPopulationSizeLabel.Text = "Population Size";
            this.toolTip1.SetToolTip(this.cmaEsPopulationSizeLabel, "A population size of CMA-ES. \r\nWhen set restart_strategy is checked,\r\nthis is use" +
        "d as the initial population size.");
            // 
            // cmaEsDefaultButton
            // 
            this.cmaEsDefaultButton.Location = new System.Drawing.Point(300, 350);
            this.cmaEsDefaultButton.Name = "cmaEsDefaultButton";
            this.cmaEsDefaultButton.Size = new System.Drawing.Size(100, 38);
            this.cmaEsDefaultButton.TabIndex = 33;
            this.cmaEsDefaultButton.Text = "Default";
            this.toolTip1.SetToolTip(this.cmaEsDefaultButton, "Set to Optuna\'s default value.");
            this.cmaEsDefaultButton.UseVisualStyleBackColor = true;
            this.cmaEsDefaultButton.Click += new System.EventHandler(this.CmaEsDefaultButton_Click);
            // 
            // cmaEsRestartCheckBox
            // 
            this.cmaEsRestartCheckBox.AutoSize = true;
            this.cmaEsRestartCheckBox.Location = new System.Drawing.Point(10, 108);
            this.cmaEsRestartCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmaEsRestartCheckBox.Name = "cmaEsRestartCheckBox";
            this.cmaEsRestartCheckBox.Size = new System.Drawing.Size(171, 27);
            this.cmaEsRestartCheckBox.TabIndex = 32;
            this.cmaEsRestartCheckBox.Text = "RestartStrategy";
            this.toolTip1.SetToolTip(this.cmaEsRestartCheckBox, "If given False, \r\nCMA-ES will not restart.\r\nStrategy for restarting CMA-ES optimi" +
        "zation when converges to a local minimum. ");
            this.cmaEsRestartCheckBox.UseVisualStyleBackColor = true;
            this.cmaEsRestartCheckBox.CheckedChanged += new System.EventHandler(this.CmaEsRestartStrategyCheckedChanged);
            // 
            // cmaEsUseSaparableCmaCheckBox
            // 
            this.cmaEsUseSaparableCmaCheckBox.AutoSize = true;
            this.cmaEsUseSaparableCmaCheckBox.Enabled = false;
            this.cmaEsUseSaparableCmaCheckBox.Location = new System.Drawing.Point(10, 74);
            this.cmaEsUseSaparableCmaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmaEsUseSaparableCmaCheckBox.Name = "cmaEsUseSaparableCmaCheckBox";
            this.cmaEsUseSaparableCmaCheckBox.Size = new System.Drawing.Size(204, 27);
            this.cmaEsUseSaparableCmaCheckBox.TabIndex = 31;
            this.cmaEsUseSaparableCmaCheckBox.Text = "Use Separable CMA";
            this.toolTip1.SetToolTip(this.cmaEsUseSaparableCmaCheckBox, resources.GetString("cmaEsUseSaparableCmaCheckBox.ToolTip"));
            this.cmaEsUseSaparableCmaCheckBox.UseVisualStyleBackColor = true;
            this.cmaEsUseSaparableCmaCheckBox.CheckedChanged += new System.EventHandler(this.CmaEsUseSaparableCmaCheckBox_CheckedChanged);
            // 
            // cmaEsNStartupTrialsLabel
            // 
            this.cmaEsNStartupTrialsLabel.AutoSize = true;
            this.cmaEsNStartupTrialsLabel.Location = new System.Drawing.Point(8, 4);
            this.cmaEsNStartupTrialsLabel.Name = "cmaEsNStartupTrialsLabel";
            this.cmaEsNStartupTrialsLabel.Size = new System.Drawing.Size(219, 23);
            this.cmaEsNStartupTrialsLabel.TabIndex = 30;
            this.cmaEsNStartupTrialsLabel.Text = "Number of startup trials";
            this.toolTip1.SetToolTip(this.cmaEsNStartupTrialsLabel, "The independent sampling is used instead of the CMA-ES algorithm\r\nuntil the given" +
        " number of trials finish in the same study.");
            // 
            // cmaEsStartupNumUpDown
            // 
            this.cmaEsStartupNumUpDown.Location = new System.Drawing.Point(309, 4);
            this.cmaEsStartupNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cmaEsStartupNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmaEsStartupNumUpDown.Name = "cmaEsStartupNumUpDown";
            this.cmaEsStartupNumUpDown.Size = new System.Drawing.Size(94, 30);
            this.cmaEsStartupNumUpDown.TabIndex = 29;
            this.cmaEsStartupNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmaEsConsiderPruneTrialsCheckBox
            // 
            this.cmaEsConsiderPruneTrialsCheckBox.AutoSize = true;
            this.cmaEsConsiderPruneTrialsCheckBox.Enabled = false;
            this.cmaEsConsiderPruneTrialsCheckBox.Location = new System.Drawing.Point(15, 536);
            this.cmaEsConsiderPruneTrialsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmaEsConsiderPruneTrialsCheckBox.Name = "cmaEsConsiderPruneTrialsCheckBox";
            this.cmaEsConsiderPruneTrialsCheckBox.Size = new System.Drawing.Size(230, 27);
            this.cmaEsConsiderPruneTrialsCheckBox.TabIndex = 28;
            this.cmaEsConsiderPruneTrialsCheckBox.Text = "Consider Pruned Trials";
            this.toolTip1.SetToolTip(this.cmaEsConsiderPruneTrialsCheckBox, "If this is True, \r\nthe PRUNED trials are considered for sampling.");
            this.cmaEsConsiderPruneTrialsCheckBox.UseVisualStyleBackColor = true;
            // 
            // cmaEsWarnIndependentSamplingCheckBox
            // 
            this.cmaEsWarnIndependentSamplingCheckBox.AutoSize = true;
            this.cmaEsWarnIndependentSamplingCheckBox.Checked = true;
            this.cmaEsWarnIndependentSamplingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmaEsWarnIndependentSamplingCheckBox.Enabled = false;
            this.cmaEsWarnIndependentSamplingCheckBox.Location = new System.Drawing.Point(10, 308);
            this.cmaEsWarnIndependentSamplingCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmaEsWarnIndependentSamplingCheckBox.Name = "cmaEsWarnIndependentSamplingCheckBox";
            this.cmaEsWarnIndependentSamplingCheckBox.Size = new System.Drawing.Size(284, 27);
            this.cmaEsWarnIndependentSamplingCheckBox.TabIndex = 27;
            this.cmaEsWarnIndependentSamplingCheckBox.Text = "Warn Independent Sampling";
            this.toolTip1.SetToolTip(this.cmaEsWarnIndependentSamplingCheckBox, "If this is True, \r\na warning message is emitted when the value of a parameter is " +
        "sampled by using an independent sampler.");
            this.cmaEsWarnIndependentSamplingCheckBox.UseVisualStyleBackColor = true;
            // 
            // cmaEsIncPopsizeLabel
            // 
            this.cmaEsIncPopsizeLabel.AutoSize = true;
            this.cmaEsIncPopsizeLabel.Location = new System.Drawing.Point(6, 182);
            this.cmaEsIncPopsizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmaEsIncPopsizeLabel.Name = "cmaEsIncPopsizeLabel";
            this.cmaEsIncPopsizeLabel.Size = new System.Drawing.Size(240, 23);
            this.cmaEsIncPopsizeLabel.TabIndex = 26;
            this.cmaEsIncPopsizeLabel.Text = "Increasing Population Size";
            this.toolTip1.SetToolTip(this.cmaEsIncPopsizeLabel, "Multiplier for increasing population size before each restart.");
            // 
            // cmaEsIncPopSizeUpDown
            // 
            this.cmaEsIncPopSizeUpDown.Enabled = false;
            this.cmaEsIncPopSizeUpDown.Location = new System.Drawing.Point(303, 182);
            this.cmaEsIncPopSizeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmaEsIncPopSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmaEsIncPopSizeUpDown.Name = "cmaEsIncPopSizeUpDown";
            this.cmaEsIncPopSizeUpDown.Size = new System.Drawing.Size(94, 30);
            this.cmaEsIncPopSizeUpDown.TabIndex = 25;
            this.cmaEsIncPopSizeUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cmaEsSigmaCheckBox
            // 
            this.cmaEsSigmaCheckBox.AutoSize = true;
            this.cmaEsSigmaCheckBox.Location = new System.Drawing.Point(10, 39);
            this.cmaEsSigmaCheckBox.Name = "cmaEsSigmaCheckBox";
            this.cmaEsSigmaCheckBox.Size = new System.Drawing.Size(101, 27);
            this.cmaEsSigmaCheckBox.TabIndex = 24;
            this.cmaEsSigmaCheckBox.Text = "Sigma0";
            this.toolTip1.SetToolTip(this.cmaEsSigmaCheckBox, "Initial standard deviation of CMA-ES. By default, sigma0 is set to min_range / 6," +
        "\r\nwhere min_range denotes the minimum range of the distributions in the search s" +
        "pace.");
            this.cmaEsSigmaCheckBox.UseVisualStyleBackColor = true;
            this.cmaEsSigmaCheckBox.CheckedChanged += new System.EventHandler(this.CmaEsSigmaCheckedChanged);
            // 
            // cmaEsSigmaNumUpDown
            // 
            this.cmaEsSigmaNumUpDown.DecimalPlaces = 2;
            this.cmaEsSigmaNumUpDown.Enabled = false;
            this.cmaEsSigmaNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cmaEsSigmaNumUpDown.Location = new System.Drawing.Point(309, 38);
            this.cmaEsSigmaNumUpDown.Name = "cmaEsSigmaNumUpDown";
            this.cmaEsSigmaNumUpDown.Size = new System.Drawing.Size(94, 30);
            this.cmaEsSigmaNumUpDown.TabIndex = 23;
            // 
            // QMC
            // 
            this.QMC.Controls.Add(this.qmcDefaultButton);
            this.QMC.Controls.Add(this.qmcTypeComboBox);
            this.QMC.Controls.Add(this.qmcTypeLabel);
            this.QMC.Controls.Add(this.qmcWarnAsyncSeedingCheckBox);
            this.QMC.Controls.Add(this.qmcScrambleCheckBox);
            this.QMC.Controls.Add(this.qmcWarnIndependentSamplingCheckBox);
            this.QMC.Location = new System.Drawing.Point(4, 32);
            this.QMC.Name = "QMC";
            this.QMC.Size = new System.Drawing.Size(412, 393);
            this.QMC.TabIndex = 4;
            this.QMC.Text = "QMC";
            this.QMC.UseVisualStyleBackColor = true;
            // 
            // qmcDefaultButton
            // 
            this.qmcDefaultButton.Location = new System.Drawing.Point(300, 350);
            this.qmcDefaultButton.Name = "qmcDefaultButton";
            this.qmcDefaultButton.Size = new System.Drawing.Size(100, 38);
            this.qmcDefaultButton.TabIndex = 33;
            this.qmcDefaultButton.Text = "Default";
            this.toolTip1.SetToolTip(this.qmcDefaultButton, "Set to Optuna\'s default value.");
            this.qmcDefaultButton.UseVisualStyleBackColor = true;
            this.qmcDefaultButton.Click += new System.EventHandler(this.QmcDefaultButton_Click);
            // 
            // qmcTypeComboBox
            // 
            this.qmcTypeComboBox.FormattingEnabled = true;
            this.qmcTypeComboBox.Items.AddRange(new object[] {
            "sobol",
            "halton"});
            this.qmcTypeComboBox.Location = new System.Drawing.Point(267, 10);
            this.qmcTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.qmcTypeComboBox.Name = "qmcTypeComboBox";
            this.qmcTypeComboBox.Size = new System.Drawing.Size(134, 31);
            this.qmcTypeComboBox.TabIndex = 32;
            this.qmcTypeComboBox.Text = "sobol";
            // 
            // qmcTypeLabel
            // 
            this.qmcTypeLabel.AutoSize = true;
            this.qmcTypeLabel.Location = new System.Drawing.Point(3, 14);
            this.qmcTypeLabel.Name = "qmcTypeLabel";
            this.qmcTypeLabel.Size = new System.Drawing.Size(97, 23);
            this.qmcTypeLabel.TabIndex = 31;
            this.qmcTypeLabel.Text = "QMC Type";
            this.toolTip1.SetToolTip(this.qmcTypeLabel, "The type of QMC sequence to be sampled.\r\n");
            // 
            // qmcWarnAsyncSeedingCheckBox
            // 
            this.qmcWarnAsyncSeedingCheckBox.AutoSize = true;
            this.qmcWarnAsyncSeedingCheckBox.Checked = true;
            this.qmcWarnAsyncSeedingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qmcWarnAsyncSeedingCheckBox.Enabled = false;
            this.qmcWarnAsyncSeedingCheckBox.Location = new System.Drawing.Point(8, 122);
            this.qmcWarnAsyncSeedingCheckBox.Name = "qmcWarnAsyncSeedingCheckBox";
            this.qmcWarnAsyncSeedingCheckBox.Size = new System.Drawing.Size(284, 27);
            this.qmcWarnAsyncSeedingCheckBox.TabIndex = 30;
            this.qmcWarnAsyncSeedingCheckBox.Text = "Warn Asynchronous Seeding";
            this.toolTip1.SetToolTip(this.qmcWarnAsyncSeedingCheckBox, "If this is True, \r\na warning message is emitted \r\nwhen the scrambling (randomizat" +
        "ion) is applied to the QMC sequence\r\nand the random seed of the sampler is not s" +
        "et manually.");
            this.qmcWarnAsyncSeedingCheckBox.UseVisualStyleBackColor = true;
            // 
            // qmcScrambleCheckBox
            // 
            this.qmcScrambleCheckBox.AutoSize = true;
            this.qmcScrambleCheckBox.Location = new System.Drawing.Point(8, 56);
            this.qmcScrambleCheckBox.Name = "qmcScrambleCheckBox";
            this.qmcScrambleCheckBox.Size = new System.Drawing.Size(116, 27);
            this.qmcScrambleCheckBox.TabIndex = 29;
            this.qmcScrambleCheckBox.Text = "Scramble";
            this.toolTip1.SetToolTip(this.qmcScrambleCheckBox, "If this option is True, \r\nscrambling (randomization) is applied to the QMC sequen" +
        "ces.");
            this.qmcScrambleCheckBox.UseVisualStyleBackColor = true;
            // 
            // qmcWarnIndependentSamplingCheckBox
            // 
            this.qmcWarnIndependentSamplingCheckBox.AutoSize = true;
            this.qmcWarnIndependentSamplingCheckBox.Checked = true;
            this.qmcWarnIndependentSamplingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qmcWarnIndependentSamplingCheckBox.Enabled = false;
            this.qmcWarnIndependentSamplingCheckBox.Location = new System.Drawing.Point(8, 88);
            this.qmcWarnIndependentSamplingCheckBox.Name = "qmcWarnIndependentSamplingCheckBox";
            this.qmcWarnIndependentSamplingCheckBox.Size = new System.Drawing.Size(284, 27);
            this.qmcWarnIndependentSamplingCheckBox.TabIndex = 28;
            this.qmcWarnIndependentSamplingCheckBox.Text = "Warn Independent Sampling";
            this.toolTip1.SetToolTip(this.qmcWarnIndependentSamplingCheckBox, "If this is True, \r\na warning message is emitted when the value of a parameter\r\nis" +
        " sampled by using an independent sampler.");
            this.qmcWarnIndependentSamplingCheckBox.UseVisualStyleBackColor = true;
            // 
            // Misc
            // 
            this.Misc.Controls.Add(this.checkPythonLibrariesCheckBox);
            this.Misc.Controls.Add(this.miscDefaultButton);
            this.Misc.Controls.Add(this.runGarbageCollectionComboBox);
            this.Misc.Controls.Add(this.runGarbageCollectionLabel);
            this.Misc.Location = new System.Drawing.Point(4, 32);
            this.Misc.Name = "Misc";
            this.Misc.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Misc.Size = new System.Drawing.Size(412, 393);
            this.Misc.TabIndex = 5;
            this.Misc.Text = "Misc";
            this.Misc.UseVisualStyleBackColor = true;
            // 
            // checkPythonLibrariesCheckBox
            // 
            this.checkPythonLibrariesCheckBox.AutoSize = true;
            this.checkPythonLibrariesCheckBox.Location = new System.Drawing.Point(10, 69);
            this.checkPythonLibrariesCheckBox.Name = "checkPythonLibrariesCheckBox";
            this.checkPythonLibrariesCheckBox.Size = new System.Drawing.Size(377, 27);
            this.checkPythonLibrariesCheckBox.TabIndex = 37;
            this.checkPythonLibrariesCheckBox.Text = "Run Python installer at window startup";
            this.checkPythonLibrariesCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscDefaultButton
            // 
            this.miscDefaultButton.Location = new System.Drawing.Point(300, 350);
            this.miscDefaultButton.Name = "miscDefaultButton";
            this.miscDefaultButton.Size = new System.Drawing.Size(100, 38);
            this.miscDefaultButton.TabIndex = 36;
            this.miscDefaultButton.Text = "Default";
            this.toolTip1.SetToolTip(this.miscDefaultButton, "Set to Tunny\'s default value.");
            this.miscDefaultButton.UseVisualStyleBackColor = true;
            // 
            // runGarbageCollectionComboBox
            // 
            this.runGarbageCollectionComboBox.FormattingEnabled = true;
            this.runGarbageCollectionComboBox.Items.AddRange(new object[] {
            "Always",
            "HasGeometry",
            "NoExecute"});
            this.runGarbageCollectionComboBox.Location = new System.Drawing.Point(236, 14);
            this.runGarbageCollectionComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.runGarbageCollectionComboBox.Name = "runGarbageCollectionComboBox";
            this.runGarbageCollectionComboBox.Size = new System.Drawing.Size(169, 31);
            this.runGarbageCollectionComboBox.TabIndex = 34;
            this.runGarbageCollectionComboBox.Text = "HasGeometry";
            this.runGarbageCollectionComboBox.SelectedIndexChanged += new System.EventHandler(this.RunGarbageCollectionComboBox_SelectedIndexChanged);
            // 
            // runGarbageCollectionLabel
            // 
            this.runGarbageCollectionLabel.AutoSize = true;
            this.runGarbageCollectionLabel.Location = new System.Drawing.Point(6, 16);
            this.runGarbageCollectionLabel.Name = "runGarbageCollectionLabel";
            this.runGarbageCollectionLabel.Size = new System.Drawing.Size(214, 23);
            this.runGarbageCollectionLabel.TabIndex = 33;
            this.runGarbageCollectionLabel.Text = "Run Garbage Collection";
            this.toolTip1.SetToolTip(this.runGarbageCollectionLabel, "Setting whether or not per-trial data is targeted for garbage collection");
            // 
            // fileTabPage
            // 
            this.fileTabPage.Controls.Add(this.outputDebugLogButton);
            this.fileTabPage.Controls.Add(this.groupBox1);
            this.fileTabPage.Controls.Add(this.licenseGroupBox);
            this.fileTabPage.Location = new System.Drawing.Point(4, 32);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.fileTabPage.Size = new System.Drawing.Size(428, 442);
            this.fileTabPage.TabIndex = 4;
            this.fileTabPage.Text = "File";
            this.fileTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setResultFilePathButton);
            this.groupBox1.Controls.Add(this.clearResultButton);
            this.groupBox1.Controls.Add(this.openResultFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(22, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // setResultFilePathButton
            // 
            this.setResultFilePathButton.Location = new System.Drawing.Point(58, 34);
            this.setResultFilePathButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.setResultFilePathButton.Name = "setResultFilePathButton";
            this.setResultFilePathButton.Size = new System.Drawing.Size(264, 39);
            this.setResultFilePathButton.TabIndex = 7;
            this.setResultFilePathButton.Text = "Set file path";
            this.setResultFilePathButton.UseVisualStyleBackColor = true;
            this.setResultFilePathButton.Click += new System.EventHandler(this.SetResultFilePathButton_Click);
            // 
            // clearResultButton
            // 
            this.clearResultButton.Location = new System.Drawing.Point(58, 136);
            this.clearResultButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearResultButton.Name = "clearResultButton";
            this.clearResultButton.Size = new System.Drawing.Size(264, 42);
            this.clearResultButton.TabIndex = 5;
            this.clearResultButton.Text = "Clear file";
            this.clearResultButton.UseVisualStyleBackColor = true;
            this.clearResultButton.Click += new System.EventHandler(this.ClearResultButton_Click);
            // 
            // openResultFolderButton
            // 
            this.openResultFolderButton.Location = new System.Drawing.Point(58, 86);
            this.openResultFolderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openResultFolderButton.Name = "openResultFolderButton";
            this.openResultFolderButton.Size = new System.Drawing.Size(264, 39);
            this.openResultFolderButton.TabIndex = 6;
            this.openResultFolderButton.Text = "Open folder";
            this.openResultFolderButton.UseVisualStyleBackColor = true;
            this.openResultFolderButton.Click += new System.EventHandler(this.OpenResultFolderButton_Click);
            // 
            // licenseGroupBox
            // 
            this.licenseGroupBox.Controls.Add(this.showThirdPartyLicenseButton);
            this.licenseGroupBox.Controls.Add(this.showTunnyLicenseButton);
            this.licenseGroupBox.Location = new System.Drawing.Point(22, 212);
            this.licenseGroupBox.Name = "licenseGroupBox";
            this.licenseGroupBox.Size = new System.Drawing.Size(378, 157);
            this.licenseGroupBox.TabIndex = 8;
            this.licenseGroupBox.TabStop = false;
            this.licenseGroupBox.Text = "License";
            // 
            // showThirdPartyLicenseButton
            // 
            this.showThirdPartyLicenseButton.Location = new System.Drawing.Point(58, 98);
            this.showThirdPartyLicenseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showThirdPartyLicenseButton.Name = "showThirdPartyLicenseButton";
            this.showThirdPartyLicenseButton.Size = new System.Drawing.Size(264, 42);
            this.showThirdPartyLicenseButton.TabIndex = 8;
            this.showThirdPartyLicenseButton.Text = "Show Third Party License";
            this.showThirdPartyLicenseButton.UseVisualStyleBackColor = true;
            this.showThirdPartyLicenseButton.Click += new System.EventHandler(this.ShowThirdPartyLicenseButton_Click);
            // 
            // showTunnyLicenseButton
            // 
            this.showTunnyLicenseButton.Location = new System.Drawing.Point(58, 44);
            this.showTunnyLicenseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showTunnyLicenseButton.Name = "showTunnyLicenseButton";
            this.showTunnyLicenseButton.Size = new System.Drawing.Size(264, 42);
            this.showTunnyLicenseButton.TabIndex = 7;
            this.showTunnyLicenseButton.Text = "Show Tunny License";
            this.showTunnyLicenseButton.UseVisualStyleBackColor = true;
            this.showTunnyLicenseButton.Click += new System.EventHandler(this.ShowTunnyLicenseButton_Click);
            // 
            // outputDebugLogButton
            // 
            this.outputDebugLogButton.Location = new System.Drawing.Point(80, 388);
            this.outputDebugLogButton.Name = "outputDebugLogButton";
            this.outputDebugLogButton.Size = new System.Drawing.Size(264, 37);
            this.outputDebugLogButton.TabIndex = 10;
            this.outputDebugLogButton.Text = "Output Debug Log";
            this.outputDebugLogButton.UseVisualStyleBackColor = true;
            this.outputDebugLogButton.Click += new System.EventHandler(this.OutputDebugLogButton_Click);
            // 
            // OptimizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(434, 484);
            this.Controls.Add(this.optimizeTabControl);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "OptimizationWindow";
            this.Text = "Tunny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingXButton);
            this.Load += new System.EventHandler(this.OptimizationWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nTrialNumUpDown)).EndInit();
            this.optimizeTabControl.ResumeLayout(false);
            this.optimizeTabPage.ResumeLayout(false);
            this.optimizeTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumUpDown)).EndInit();
            this.visualizeTabPage.ResumeLayout(false);
            this.visualizeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualizeClusterNumUpDown)).EndInit();
            this.outputTabPage.ResumeLayout(false);
            this.outputTabPage.PerformLayout();
            this.outputUseModelNumberGroupBox.ResumeLayout(false);
            this.outputUseModelNumberGroupBox.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabControl.ResumeLayout(false);
            this.TPE.ResumeLayout(false);
            this.TPE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpeEINumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpeStartupNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpePriorNumUpDown)).EndInit();
            this.GP.ResumeLayout(false);
            this.GP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boTorchStartupNumUpDown)).EndInit();
            this.NSGAII.ResumeLayout(false);
            this.NSGAII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2PopulationSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2SwappingProbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2CrossoverProbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga2MutationProbUpDown)).EndInit();
            this.NSGAIII.ResumeLayout(false);
            this.NSGAIII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3PopulationSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3SwappingProbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3CrossoverProbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsga3MutationProbUpDown)).EndInit();
            this.CMAES.ResumeLayout(false);
            this.CMAES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsPopulationSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsStartupNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsIncPopSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmaEsSigmaNumUpDown)).EndInit();
            this.QMC.ResumeLayout(false);
            this.QMC.PerformLayout();
            this.Misc.ResumeLayout(false);
            this.Misc.PerformLayout();
            this.fileTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.licenseGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optimizeRunButton;
        private System.ComponentModel.BackgroundWorker optimizeBackgroundWorker;
        private System.Windows.Forms.Button optimizeStopButton;
        private System.Windows.Forms.NumericUpDown nTrialNumUpDown;
        private System.Windows.Forms.CheckBox continueStudyCheckBox;
        private System.Windows.Forms.ProgressBar optimizeProgressBar;
        private System.Windows.Forms.ComboBox samplerComboBox;
        private System.Windows.Forms.Label samplerTypeText;
        private System.Windows.Forms.Label nTrialText;
        private System.Windows.Forms.Label studyNameLabel;
        private System.Windows.Forms.TextBox studyNameTextBox;
        private System.Windows.Forms.TabControl optimizeTabControl;
        private System.Windows.Forms.TabPage optimizeTabPage;
        private System.Windows.Forms.TabPage visualizeTabPage;
        private System.Windows.Forms.Button visualizeShowPlotButton;
        private System.Windows.Forms.ComboBox visualizeTypeComboBox;
        private System.ComponentModel.BackgroundWorker outputResultBackgroundWorker;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.TabPage outputTabPage;
        private System.Windows.Forms.Button outputAllTrialsButton;
        private System.Windows.Forms.Button outputParatoSolutionButton;
        private System.Windows.Forms.Button reflectToSliderButton;
        private System.Windows.Forms.Button outputStopButton;
        private System.Windows.Forms.ProgressBar outputProgressBar;
        private System.Windows.Forms.Button outputModelNumberButton;
        private System.Windows.Forms.TextBox outputModelNumTextBox;
        private System.Windows.Forms.TabPage fileTabPage;
        private System.Windows.Forms.Button openResultFolderButton;
        private System.Windows.Forms.Button clearResultButton;
        private System.Windows.Forms.NumericUpDown timeoutNumUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Timeout;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage TPE;
        private System.Windows.Forms.TabPage GP;
        private System.Windows.Forms.TabPage NSGAII;
        private System.Windows.Forms.TabPage CMAES;
        private System.Windows.Forms.TabPage QMC;
        private System.Windows.Forms.Label tpeNEICandidatesLabel;
        private System.Windows.Forms.Label tpeNStartupTrialsLabel;
        private System.Windows.Forms.Label tpePriorWeightLabel;
        private System.Windows.Forms.NumericUpDown tpeEINumUpDown;
        private System.Windows.Forms.NumericUpDown tpeStartupNumUpDown;
        private System.Windows.Forms.NumericUpDown tpePriorNumUpDown;
        private System.Windows.Forms.CheckBox tpeConstantLiarCheckBox;
        private System.Windows.Forms.CheckBox tpeWarnIndependentSamplingCheckBox;
        private System.Windows.Forms.CheckBox tpeGroupCheckBox;
        private System.Windows.Forms.CheckBox tpeMultivariateCheckBox;
        private System.Windows.Forms.CheckBox tpeConsiderEndpointsCheckBox;
        private System.Windows.Forms.CheckBox tpeConsiderMagicClipCheckBox;
        private System.Windows.Forms.CheckBox tpeConsiderPriorCheckBox;
        private System.Windows.Forms.Label boTorchNStartupTrialsLabel;
        private System.Windows.Forms.NumericUpDown boTorchStartupNumUpDown;
        private System.Windows.Forms.CheckBox nsga2MutationProbCheckBox;
        private System.Windows.Forms.Label nsga2PopulationSizeLabel;
        private System.Windows.Forms.NumericUpDown nsga2PopulationSizeUpDown;
        private System.Windows.Forms.Label nsga2SwappingProbLabel;
        private System.Windows.Forms.NumericUpDown nsga2SwappingProbUpDown;
        private System.Windows.Forms.Label nsga2CrossoverProbLabel;
        private System.Windows.Forms.NumericUpDown nsga2CrossoverProbUpDown;
        private System.Windows.Forms.NumericUpDown nsga2MutationProbUpDown;
        private System.Windows.Forms.CheckBox cmaEsRestartCheckBox;
        private System.Windows.Forms.CheckBox cmaEsUseSaparableCmaCheckBox;
        private System.Windows.Forms.Label cmaEsNStartupTrialsLabel;
        private System.Windows.Forms.NumericUpDown cmaEsStartupNumUpDown;
        private System.Windows.Forms.CheckBox cmaEsConsiderPruneTrialsCheckBox;
        private System.Windows.Forms.CheckBox cmaEsWarnIndependentSamplingCheckBox;
        private System.Windows.Forms.Label cmaEsIncPopsizeLabel;
        private System.Windows.Forms.NumericUpDown cmaEsIncPopSizeUpDown;
        private System.Windows.Forms.CheckBox cmaEsSigmaCheckBox;
        private System.Windows.Forms.NumericUpDown cmaEsSigmaNumUpDown;
        private System.Windows.Forms.CheckBox qmcWarnIndependentSamplingCheckBox;
        private System.Windows.Forms.ComboBox qmcTypeComboBox;
        private System.Windows.Forms.Label qmcTypeLabel;
        private System.Windows.Forms.CheckBox qmcWarnAsyncSeedingCheckBox;
        private System.Windows.Forms.CheckBox qmcScrambleCheckBox;
        private System.Windows.Forms.Button tpeDefaultButton;
        private System.Windows.Forms.Button boTorchDefaultButton;
        private System.Windows.Forms.Button nsga2DefaultButton;
        private System.Windows.Forms.Button cmaEsDefaultButton;
        private System.Windows.Forms.Button qmcDefaultButton;
        private System.Windows.Forms.Label visualizeNumClusterLabel;
        private System.Windows.Forms.NumericUpDown visualizeClusterNumUpDown;
        private System.Windows.Forms.ComboBox nsga2CrossoverComboBox;
        private System.Windows.Forms.CheckBox nsga2CrossoverCheckBox;
        private System.Windows.Forms.NumericUpDown cmaEsPopulationSizeUpDown;
        private System.Windows.Forms.Label cmaEsPopulationSizeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox licenseGroupBox;
        private System.Windows.Forms.Button showThirdPartyLicenseButton;
        private System.Windows.Forms.Button showTunnyLicenseButton;
        private System.Windows.Forms.Button visualizeSavePlotButton;
        private System.Windows.Forms.TabPage Misc;
        private System.Windows.Forms.Button miscDefaultButton;
        private System.Windows.Forms.ComboBox runGarbageCollectionComboBox;
        private System.Windows.Forms.Label runGarbageCollectionLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label optimizeBestValueLabel;
        private System.Windows.Forms.Label optimizeTrialNumLabel;
        private System.Windows.Forms.CheckBox copyStudyCheckBox;
        private System.Windows.Forms.Button setResultFilePathButton;
        private System.Windows.Forms.Label existedStudyNameLabel;
        private System.Windows.Forms.ComboBox existingStudyComboBox;
        private System.Windows.Forms.Label visualizeTargetVariableLabel;
        private System.Windows.Forms.Label visualizeTargetObjectiveLabel;
        private System.Windows.Forms.Label visualizeTypeLabel;
        private System.Windows.Forms.Label visualizeTargetStudyNameLabel;
        private System.Windows.Forms.ComboBox visualizeTargetStudyComboBox;
        private System.Windows.Forms.ListBox visualizeVariableListBox;
        private System.Windows.Forms.ListBox visualizeObjectiveListBox;
        private System.Windows.Forms.CheckBox visualizeIncludeDominatedCheckBox;
        private System.Windows.Forms.GroupBox outputUseModelNumberGroupBox;
        private System.Windows.Forms.ComboBox outputTargetStudyComboBox;
        private System.Windows.Forms.Label outputTargetStudyLabel;
        private System.Windows.Forms.ComboBox cmaEsWarmStartComboBox;
        private System.Windows.Forms.CheckBox cmaEsWarmStartCmaEsCheckBox;
        private System.Windows.Forms.Label EstimatedTimeRemainingLabel;
        private System.Windows.Forms.CheckBox inMemoryCheckBox;
        private System.Windows.Forms.CheckBox checkPythonLibrariesCheckBox;
        private System.Windows.Forms.CheckBox ShowRealtimeResultCheckBox;
        private System.Windows.Forms.CheckBox cmaEsWithMarginCheckBox;
        private System.Windows.Forms.TabPage NSGAIII;
        private System.Windows.Forms.ComboBox nsga3CrossoverComboBox;
        private System.Windows.Forms.CheckBox nsga3CrossoverCheckBox;
        private System.Windows.Forms.Button nsga3DefaultButton;
        private System.Windows.Forms.CheckBox nsga3MutationProbCheckBox;
        private System.Windows.Forms.Label nsga3PopulationSizeLabel;
        private System.Windows.Forms.NumericUpDown nsga3PopulationSizeUpDown;
        private System.Windows.Forms.Label nsga3SwappingProbLabel;
        private System.Windows.Forms.NumericUpDown nsga3SwappingProbUpDown;
        private System.Windows.Forms.Label nsga3CrossoverProbLabel;
        private System.Windows.Forms.NumericUpDown nsga3CrossoverProbUpDown;
        private System.Windows.Forms.NumericUpDown nsga3MutationProbUpDown;
        private System.Windows.Forms.Button outputDebugLogButton;
    }
}

