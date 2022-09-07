using Interface.GALS;

namespace Interface
{
    public partial class Interface : Form
    {

        private bool isSaved = false;
        private bool isEditing = false;

        public Interface()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();
        }

        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1    
            int line = richTextBox1.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)richTextBox1.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)richTextBox1.Font.Size;
            }
            else
            {
                w = 50 + (int)richTextBox1.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            Point pt = new Point(0, 0);

            // get First Index & First Line from richTextBox1    
            int First_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int First_Line = richTextBox1.GetLineFromCharIndex(First_Index);

            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;

            // get Last Index & Last Line from richTextBox1    
            int Last_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBox1.GetLineFromCharIndex(Last_Index);

            // set Center alignment to LineNumberTextBox    
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Right;

            // set LineNumberTextBox text to null & width to getWidth() function value    
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();

            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 1; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)

        {
            Point pt = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "")
            {
                AddLineNumbers();
            }

            isEditing = true;
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
            AddLineNumbers();
            toolStripStatusLabel1.Text = openFileDialog1.FileName;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            Salvar_Arquivo();
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                if ((MessageBox.Show("Deseja Salvar o arquivo ?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    Salvar_Arquivo();
                }
            }
            // Limpa o editor
            richTextBox1.Clear();
            richTextBox1.Focus();
            // Limpa barra de status
            toolStripStatusLabel1.Text = "";
            // Limpa área de mensagens
            textBox1.Text = "";
            isSaved = false;
        }

        private void Salvar_Arquivo()
        {
            // se o arquivo ainda nao foi salvo, abre o diálogo pra save
            if (!isSaved)
            {
                // sugere um nome padrão ja com a extensão .txt e filtra
                saveFileDialog1.FileName = "programa.txt";
                saveFileDialog1.Filter = "Texts (*.TXT)|*.TXT|" + "All files (*.*)|*.*";
                // Pega o nome do arquivo para salvar
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    escreveArquivo();
                    // Atualiza a barra de status
                    toolStripStatusLabel1.Text = saveFileDialog1.FileName;
                    isSaved = true;
                }
            }
            else if (isEditing) // se o arquivo ja foi salvo e houve alterações no text box, edita o arquivo com as novas alterações
            {
                editaArquivo();
                isEditing = false;
            }
            // Limpa área de mensagens
            textBox1.Text = "";
        }

        private void escreveArquivo()
        {
            // abre um stream para escrita e cria um StreamWriter para implementar o stream
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.Flush();
            // Escreve para o arquivo usando a classe StreamWriter
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
            // escreve no controle richtextbox
            m_streamWriter.Write(richTextBox1.Text);
            // fecha o arquivo
            m_streamWriter.Flush();
            m_streamWriter.Close();
        }

        private void editaArquivo()
        {
            // limpa o arquivo
            FileStream fileStream = File.Open(toolStripStatusLabel1.Text, FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Flush();
            fileStream.Close();

            // escreve conteúdo atual do textbox no arquivo
            StreamWriter writer = new StreamWriter(File.OpenWrite(toolStripStatusLabel1.Text));
            writer.Write(richTextBox1.Text);
            writer.Close();
        }
        private void AbrirArquivo()
        {
            //  possibilitar a seleção de pasta / arquivo, carregar o arquivo selecionado no editor

            //define as propriedades do controle 
            //OpenFileDialog
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Selecionar Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Dados\";
            //filtra para exibir somente arquivos textos
            openFileDialog1.Filter = "Texts (*.TXT)|*.TXT|" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    // Lê o arquivo usando a classe StreamReader
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    // Lê cada linha do stream e faz o parse até a última linha
                    richTextBox1.Text = "";
                    string strLine = m_streamReader.ReadLine();
                    while (strLine != null)
                    {
                        richTextBox1.Text += strLine + "\n";
                        strLine = m_streamReader.ReadLine();
                    }
                    // Fecha o stream
                    m_streamReader.Close();
                    // Atualiza barra de status
                    toolStripStatusLabel1.Text = openFileDialog1.FileName;
                    // Limpar a área de mensagens
                    textBox1.Text = "";
                    isSaved = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
                switch (e.KeyCode)
                {
                    case Keys.N:
                        novaToolStripButton_Click(sender, e);
                        break;
                    case Keys.O:
                        abrirToolStripButton_Click(sender, e);
                        break;
                    case Keys.S:
                        salvarToolStripButton_Click(sender, e);
                        break;
                    case Keys.C:
                        copiarToolStripButton_Click(sender, e);
                        break;
                    case Keys.X:
                        recortarToolStripButton_Click(sender, e);
                        break;
                    default:
                        break;
                }

            else if (e.KeyCode == Keys.F7)
                compilarToolStripButton_Click(sender, e);

            else if (e.KeyCode == Keys.F1)
                infoToolStripButton_Click(sender, e);

        }

        private void compilarToolStripButton_Click(object sender, EventArgs e)
        {
            Lexico lexico = new Lexico();
            lexico.setInput(richTextBox1.Text);
            try
            {
                Token t = null;
                var retorno = "| linha | classe | lexema |";
                while ((t = lexico.nextToken()) != null)
                {
                    retorno += $"\r\n| {t.Line}       | {(Enum.GetName(typeof(EnumConstants), t.Id))} | {t.Lexeme} |";

                    // só escreve o lexema, necessário escrever t.getId, t.getPosition()

                    // t.getId () - retorna o identificador da classe. Olhar Constants.java e adaptar, pois 
                    // deve ser apresentada a classe por extenso
                    // t.getPosition () - retorna a posição inicial do lexema no editor, necessário adaptar 
                    // para mostrar a linha
                    // 	
                    // esse código apresenta os tokens enquanto não ocorrer erro
                    // no entanto, os tokens devem ser apresentados SÓ se não ocorrer erro, necessário adaptar 
                    // para atender o que foi solicitado		   
                }
                textBox1.Text = retorno;
            }
            catch (LexicalError lexicalError)
            {  // tratamento de erros
                Console.WriteLine(lexicalError.Message + " em " + lexicalError.Position);

                textBox1.Text = lexicalError.Message + " em " + lexicalError.Position;

                // e.getMessage() - retorna a mensagem de erro de SCANNER_ERRO (olhar ScannerConstants.java 
                // e adaptar conforme o enunciado da parte 2)
                // e.getPosition() - retorna a posição inicial do erro, tem que adaptar para mostrar a 
                // linha  
            }
        }

        private void infoToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nome dos componentes da equipe: \n\r Felipe Franco Weber, \n\r Maria Eduarda Krutzsch, \n\r Marino Neto";
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox1.SelectedText);
            }
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                var start = richTextBox1.SelectionStart;

                richTextBox1.Text = richTextBox1.Text.Insert(start, (String)iData.GetData(DataFormats.Text));

                richTextBox1.SelectionStart = start;
            }
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            copiarToolStripButton_Click(sender, e);
            richTextBox1.SelectedText = "";
        }
    }
}
