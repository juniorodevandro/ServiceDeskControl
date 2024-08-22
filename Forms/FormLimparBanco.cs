using System.Data;
using System.Data.SqlClient;

namespace Desenvolvimento.Forms
{
    public partial class FormLimparBanco : FormBase
    {
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        private bool _isTransactionActive = false;
        private bool _isConnected = false;

        public FormLimparBanco()
        {
            InitializeComponent();
        }

        private bool VerificarConexao()
        {
            if (String.IsNullOrEmpty(_serverDB))
            {
                MessageBox.Show("O servidor do banco de dados não pode estar vazio.");
                return false;
            }

            if (String.IsNullOrEmpty(_usuarioDB))
            {
                MessageBox.Show("O usuário do banco de dados não pode estar vazio.");
                return false;
            }

            if (String.IsNullOrEmpty(_senhaDB))
            {
                MessageBox.Show("A senha do banco de dados não pode estar vazia.");
                return false;
            }

            if (String.IsNullOrEmpty(_dataBase))
            {
                MessageBox.Show("O nome do banco de dados não pode estar vazio.");
                return false;
            }

            return true;
        }

        private void AtualizarPermissaoBotao()
        {
            buttonExecutar.Enabled = _isConnected;
            buttonTransacao.Enabled = _isConnected;
            buttonRollback.Enabled = _isConnected && _isTransactionActive;
            buttonCommit.Enabled = _isConnected && _isTransactionActive;

            AtualizarVisual();
        }

        private void AtualizarVisual()
        {
            if (_isConnected)
            {
                textBoxConexao.ForeColor = Color.Green;
                textBoxConexao.Text = $"Conectado: {_dataBase.ToUpper()}";
                buttonConectar.Text = "      Desconectar";
            }
            else
            {
                textBoxConexao.ForeColor = Color.Red;
                textBoxConexao.Text = "Desconectado";
                buttonConectar.Text = "      Conectar";
                _isConnected = true;
            }

            if (_isTransactionActive)
            {
                buttonTransacao.BackColor = Color.LightBlue;
            }
            else
            {
                buttonTransacao.BackColor = SystemColors.ControlLight;
            }

        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            LoadIniParams();

            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                try
                {
                    _connection.Close();

                    _isConnected = false;
                }
                catch (Exception ex)
                {
                    _isConnected = true;
                    MessageBox.Show("Erro ao desconectar: " + ex.Message);
                }
            }
            else
            {
                if (!VerificarConexao()) { return; }

                string connectionString = $"Data Source={_serverDB};Initial Catalog={_dataBase};User ID={_usuarioDB};Password={_senhaDB}";
                try
                {
                    _connection = new SqlConnection(connectionString);
                    _connection.Open();

                    _isConnected = true;
                }
                catch (Exception ex)
                {
                    _isConnected = false;
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }

            AtualizarPermissaoBotao();
        }

        private void buttonTransacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (_connection != null && _connection.State == ConnectionState.Open)
                {

                    if (_isTransactionActive)
                    {
                        _transaction.Rollback();
                        _isTransactionActive = false;
                    }
                    else
                    {
                        _transaction = _connection.BeginTransaction();
                        _isTransactionActive = true;
                    }
                }
                else
                {
                    MessageBox.Show("Conexão não estabelecida. Não é possível iniciar a transação.");
                }

            }
            catch (Exception ex)
            {
                _isTransactionActive = false;
                MessageBox.Show("Erro ao iniciar a transação: " + ex.Message);
            }
            
            AtualizarPermissaoBotao();
        }

        private void buttonRollback_Click(object sender, EventArgs e)
        {
            try
            {
                if (_transaction != null)
                {
                    _transaction.Rollback();

                    _isTransactionActive = false;
                }
                else
                {
                    MessageBox.Show("Nenhuma transação ativa para executar rollback.");
                    textBoxOutPut.Text += "Nenhuma transação ativa para executar rollback.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar rollback: " + ex.Message);
                textBoxOutPut.Text += "Erro ao executar rollback: " + ex.Message;
            }

            AtualizarPermissaoBotao();
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            string query = "SUA_QUERY_SQL_AQUI"; // Substitua pela sua consulta SQL

            try
            {
                if (_connection != null && _connection.State == ConnectionState.Open && _transaction != null)
                {
                    using (SqlCommand command = new SqlCommand(query, _connection, _transaction))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Comando executado com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Transação não iniciada ou conexão não estabelecida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }

            base.OnFormClosing(e);
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isTransactionActive)
                {
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
                else
                {
                    MessageBox.Show("Nenhuma transação ativa para confirmar.");
                }
            }
            catch (Exception ex)
            {
                _isTransactionActive = true;
                MessageBox.Show("Erro ao confirmar a transação: " + ex.Message);
            }

            AtualizarPermissaoBotao();
        }
    }
}
