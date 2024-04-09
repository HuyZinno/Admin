using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Admin
{

    public partial class Home : Form
    {
        private string connectionString = "Server=DESKTOP-K5J4U41\\HUYSQL;Database=KHOAHOC;Integrated Security=True;";
      
        public Home()
        {
            InitializeComponent();
            LoadGridViewCourse();
            LoadGridViewTrainer();
            LoadGridViewAccount();
            LoadTrainersIntoComboBox();
            AddButtonColumns();
            AddDeleteButtonTrainer();
            AddButtonAccount();
            GridViewTrainer.CellContentClick += GridViewTrainer_CellContentClick; // Đăng ký sự kiện CellContentClick
            GridViewCourse.Size = PreferredSize;

            // Thiết lập chữ mờ (placeholder) trong ô txtSearch
            txtSearch.Text = "Nhập ID để tìm kiếm...";
            txtSearch.ForeColor = Color.Gray;
            txtSearch.GotFocus += RemovePlaceholder;
            txtSearch.LostFocus += AddPlaceholder;

        }
        private void AddButtonColumns()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteColumn";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0); // Để căn lề nút Delete về phía bên phải
            GridViewCourse.Columns.Add(deleteButtonColumn);          
        }
        private void AddDeleteButtonTrainer()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteColumn";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            GridViewTrainer.Columns.Add(deleteButtonColumn);
        }

        private void AddButtonAccount()
        {
            DataGridViewButtonColumn activeButtonColumn = new DataGridViewButtonColumn();
            activeButtonColumn.Name = "ActiveColumn";
            activeButtonColumn.HeaderText = "Active";
            activeButtonColumn.Text = "Active";
            activeButtonColumn.UseColumnTextForButtonValue = true;
            GridViewAccount.Columns.Add(activeButtonColumn);

          /*  DataGridViewButtonColumn deactiveButtonColumn = new DataGridViewButtonColumn();
            deactiveButtonColumn.Name = "DeactiveColumn";
            deactiveButtonColumn.HeaderText = "Deactive";
            deactiveButtonColumn.Text = "Deactive";
            deactiveButtonColumn.UseColumnTextForButtonValue = true;
            GridViewAccount.Columns.Add(deactiveButtonColumn);
          */

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteColumn";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            GridViewAccount.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn resetPasswordButtonColumn = new DataGridViewButtonColumn();
            resetPasswordButtonColumn.Name = "ResetPasswordColumn";
            resetPasswordButtonColumn.HeaderText = "Reset Password";
            resetPasswordButtonColumn.Text = "ResetPassword";
            resetPasswordButtonColumn.UseColumnTextForButtonValue = true;
            GridViewAccount.Columns.Add(resetPasswordButtonColumn);
            GridViewAccount.CellContentClick += GridViewAccount_CellContentClick;
        }

        
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập ID để tìm kiếm...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
               
            }
        }
        private void AddPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Nhập ID để tìm kiếm...";
                txtSearch.ForeColor = Color.Gray;

            }
        }
        private void LoadGridViewCourse()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CourseId, CourseName, StartTime, EndTime, DayOfWeek, TrainerName FROM Course";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    GridViewCourse.DataSource = dataTable;
                }
            }
        }
        private void LoadGridViewTrainer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TrainerId, TrainerName, " +
                       "CASE WHEN Gender = 1 THEN 'Female' ELSE 'Male' END AS Gender, " +
                       "Birth, PhoneNumber " +
                       "FROM Trainer";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    GridViewTrainer.DataSource = dataTable;
                }
            }
        }
        private void LoadGridViewAccount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId, UserName, PassWord, " +
                        "CASE WHEN IsApprove IS NULL THEN 'Not Active' " +
                        "     WHEN IsApprove = 0 THEN 'Not Active' " +
                        "     ELSE 'Active' END AS IsApprove " +
                        "FROM Logins";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    GridViewAccount.DataSource = dataTable;
                }
            }
        }
        private void LoadTrainersIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TrainerName FROM Trainer";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string trainerName = reader["TrainerName"].ToString();
                        comboTrainer.Items.Add(trainerName);
                    }
                }
            }
        }


        private void GridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && GridViewCourse.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (GridViewCourse.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    DeleteCourse(e.RowIndex);
                }
            }

        }
        private void DeleteCourse(int rowIndex)
        {
            string courseId = GridViewCourse.Rows[rowIndex].Cells["CourseId"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học này?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa khóa học từ CSDL và cập nhật GridViewCourse
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Course WHERE CourseId = @CourseId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@CourseId", courseId);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                // Cập nhật lại dữ liệu trong GridViewCourse
                LoadGridViewCourse();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string courseId = txtID.Text;
            string courseName = txtName.Text;
            DateTime startTime = dateStart.Value;
            DateTime endTime = dateEnd.Value;
            string dayOfWeek = comboDayOfWeek.Text;
            string trainerName = comboTrainer.Text;

            if (string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseName) ||
                string.IsNullOrEmpty(dayOfWeek) || string.IsNullOrEmpty(trainerName))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM Course WHERE CourseId = @CourseId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@CourseId", courseId);
                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (existingCount > 0)
                    {
                        DialogResult result = MessageBox.Show("CourseId đã tồn tại. Bạn có muốn cập nhật?", "Xác nhận",
                                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            UpdateCourse(courseId, courseName, startTime, endTime, dayOfWeek, trainerName);
                            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadGridViewCourse();
                        }
                        else
                        {
                            if (existingCount > 0)
                            {
                                MessageBox.Show("Không thể thêm vì CourseId đã tồn tại.");
                                return;
                            }
                        }    
                        return;
                    }
                }

                string insertQuery = "INSERT INTO Course (CourseId, CourseName, StartTime, EndTime, DayOfWeek, TrainerName) " +
                                     "VALUES (@CourseId, @CourseName, @StartTime, @EndTime, @DayOfWeek, @TrainerName)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@CourseId", courseId);
                    insertCommand.Parameters.AddWithValue("@CourseName", courseName);
                    insertCommand.Parameters.AddWithValue("@StartTime", startTime);
                    insertCommand.Parameters.AddWithValue("@EndTime", endTime);
                    insertCommand.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    insertCommand.Parameters.AddWithValue("@TrainerName", trainerName);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công.");
                    ClearForm();
                    LoadGridViewCourse();
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword == "Nhập ID để tìm kiếm..." || string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Chưa nhập ID!");
                LoadGridViewCourse();
                return;
            }
            
            // Thực hiện tìm kiếm và cập nhật dữ liệu trong DataGridView
            LoadSearchResults(keyword);
        }
        private void LoadSearchResults(string courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CourseId, CourseName, StartTime, EndTime, DayOfWeek, TrainerName " +
                               "FROM Course " +
                               "WHERE CourseId = @CourseId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", courseId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Xóa dữ liệu cũ trong GridViewCourse và thêm dữ liệu mới
                    GridViewCourse.DataSource = null;
                    GridViewCourse.Rows.Clear();
                    GridViewCourse.DataSource = dataTable;


                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            comboDayOfWeek.SelectedIndex = -1;
            comboTrainer.SelectedIndex = -1;
        }
        private void ClearForm()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            comboDayOfWeek.SelectedIndex = -1;
            comboTrainer.SelectedIndex = -1;
        }
        private void UpdateCourse(string courseId, string courseName, DateTime startTime, DateTime endTime, string dayOfWeek, string trainerName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Course SET CourseName = @CourseName, StartTime = @StartTime, " +
                                     "EndTime = @EndTime, DayOfWeek = @DayOfWeek, TrainerName = @TrainerName " +
                                     "WHERE CourseId = @CourseId";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@CourseId", courseId);
                    updateCommand.Parameters.AddWithValue("@CourseName", courseName);
                    updateCommand.Parameters.AddWithValue("@StartTime", startTime);
                    updateCommand.Parameters.AddWithValue("@EndTime", endTime);
                    updateCommand.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    updateCommand.Parameters.AddWithValue("@TrainerName", trainerName);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string courseId = txtID.Text;
            string courseName = txtName.Text;
            DateTime startTime = dateStart.Value;
            DateTime endTime = dateEnd.Value;
            string dayOfWeek = comboDayOfWeek.Text;
            string trainerName = comboTrainer.Text;

            if (string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseName) ||
                string.IsNullOrEmpty(dayOfWeek) || string.IsNullOrEmpty(trainerName))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin khóa học này?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdateCourse(courseId, courseName, startTime, endTime, dayOfWeek, trainerName);
                LoadGridViewCourse(); // Cập nhật lại GridViewCourse sau khi cập nhật
                MessageBox.Show("Cập nhật thành công.");

                ClearForm();
            }
        }
        
        
        //Trang Trainer
        private void ClearFormTrainer()
        {
            txtIDTrainer.Text = string.Empty;
            txtNameTrainer.Text = string.Empty;
            checkGenderTrainer.Checked = false;
            dateTrainer.Value = DateTime.Now;         
            txtPhoneTrainer.Text= string.Empty;
        }
        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            string trainerId = txtIDTrainer.Text;
            string trainerName = txtNameTrainer.Text;
            bool isMale = checkGenderTrainer.Checked;
            DateTime birthDate = dateTrainer.Value;
            string phoneNumber = txtPhoneTrainer.Text;

            if (string.IsNullOrEmpty(trainerId) || string.IsNullOrEmpty(trainerName) ||
                string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM Trainer WHERE TrainerId = @TrainerId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@TrainerId", trainerId);
                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (existingCount > 0)
                    {
                        if (btnAddTrainer.Text == "Update")
                        {
                            DialogResult result = MessageBox.Show("Trainer có TrainerId đã tồn tại. Bạn có muốn cập nhật thông tin?", "Xác nhận",
                                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                InsertTrainer(trainerId, trainerName, isMale, birthDate, phoneNumber);
                                LoadGridViewTrainer();
                                MessageBox.Show("Cập nhật Trainer thành công.");
                                ClearFormTrainer();
                                btnAddTrainer.Text = "Add"; // Chuyển về chế độ Add
                            }
                        }
                        else
                        {
                            MessageBox.Show("Trainer có TrainerId đã tồn tại. Không thể thêm mới.");
                        }
                    }
                    else
                    {
                        InsertTrainer(trainerId, trainerName, isMale, birthDate, phoneNumber);
                        LoadGridViewTrainer();
                        MessageBox.Show("Thêm Trainer thành công.");
                        ClearFormTrainer();
                    }
                }
            }
        }

        private void InsertTrainer(string trainerId, string trainerName, bool isMale, DateTime birthDate, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Trainer (TrainerId, TrainerName, Gender, Birth, PhoneNumber) " +
                                     "VALUES (@TrainerId, @TrainerName, @Gender, @Birth, @PhoneNumber)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@TrainerId", trainerId);
                    insertCommand.Parameters.AddWithValue("@TrainerName", trainerName);
                    insertCommand.Parameters.AddWithValue("@Gender", isMale);
                    insertCommand.Parameters.AddWithValue("@Birth", birthDate);
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private void btnClearTrainer_Click(object sender, EventArgs e)
        {
            txtIDTrainer.Text = string.Empty;
            txtNameTrainer.Text = string.Empty;
            checkGenderTrainer.Checked = false;
            dateTrainer.Value = DateTime.Now;
            txtPhoneTrainer.Text = string.Empty;
        }
        private void checkGenderTrainer_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void TrainerTab_Click(object sender, EventArgs e)
        {

        }
        private void GridViewTrainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && GridViewTrainer.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (e.RowIndex >= 0 && GridViewTrainer.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (GridViewTrainer.Columns[e.ColumnIndex].Name == "DeleteColumn")
                    {
                        string trainerId = GridViewTrainer.Rows[e.RowIndex].Cells["TrainerId"].Value?.ToString();
                        if (!string.IsNullOrEmpty(trainerId))
                        {
                            DeleteTrainer(trainerId);
                        }
                    }
                }
            }
        }
        private void DeleteTrainer(string trainerId)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Trainer này?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Trainer WHERE TrainerId = @TrainerId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@TrainerId", trainerId);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                LoadGridViewTrainer();
                MessageBox.Show("Xóa Trainer thành công.");
            }
        }

        private void btnUpdateTrainer_Click(object sender, EventArgs e)
        {
            string trainerId = txtIDTrainer.Text;
            string trainerName = txtNameTrainer.Text;
            bool isMale = checkGenderTrainer.Checked;
            DateTime birthDate = dateTrainer.Value;
            string phoneNumber = txtPhoneTrainer.Text;

            if (string.IsNullOrEmpty(trainerId) || string.IsNullOrEmpty(trainerName) ||
                string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Trainer SET TrainerName = @TrainerName, Gender = @Gender, " +
                                     "Birth = @Birth, PhoneNumber = @PhoneNumber WHERE TrainerId = @TrainerId";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@TrainerName", trainerName);
                    updateCommand.Parameters.AddWithValue("@Gender", isMale);
                    updateCommand.Parameters.AddWithValue("@Birth", birthDate);
                    updateCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    updateCommand.Parameters.AddWithValue("@TrainerId", trainerId);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công.");

                    LoadGridViewTrainer();
                    ClearFormTrainer();
                    btnAddTrainer.Text = "Add"; // Chuyển về chế độ Add
                }
            }
        }

        //Account

        private void GridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && GridViewAccount.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (GridViewAccount.Columns[e.ColumnIndex].Name == "ActiveColumn")
                {
                    ActiveButton(e.RowIndex);
                    LoadGridViewAccount();
                }

               /* if(GridViewAccount.Columns[e.ColumnIndex].Name == "DeactivateColum")
                {
                    DeactivateButton(e.RowIndex);
                }
               */
                if (GridViewAccount.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    DeleteAccount(e.RowIndex);
                    LoadGridViewAccount();
                }

                if (GridViewAccount.Columns[e.ColumnIndex].Name == "ResetPasswordColumn")
                {
                    ResetPassword(e.RowIndex);
                }
            }
        }
      
        private void DeleteAccount(int rowIndex)
        {
            int userId = Convert.ToInt32(GridViewAccount.Rows[rowIndex].Cells["UserId"].Value);
           
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa tài khoản từ CSDL và cập nhật GridViewAccount
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Logins WHERE UserId = @UserId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@UserId", userId);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                // Cập nhật lại dữ liệu trong GridViewAccount
                LoadGridViewAccount();
            }
        }

        private void ActiveButton(int rowIndex)
        {
            int userId = Convert.ToInt32(GridViewAccount.Rows[rowIndex].Cells["UserId"].Value);
            bool isApproved = GridViewAccount.Rows[rowIndex].Cells["IsApprove"].Value.ToString().ToLower() == "true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Chuyển đổi giá trị hiện tại của IsApprove
                bool newIsApproved = !isApproved;

                string updateQuery = "UPDATE Logins SET IsApprove = @IsApprove WHERE UserId = @UserId";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@UserId", userId);
                    updateCommand.Parameters.AddWithValue("@IsApprove", newIsApproved);
                    updateCommand.ExecuteNonQuery();
                }
            }

            // Tải lại dữ liệu tài khoản sau khi cập nhật
            MessageBox.Show("Active thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridViewAccount();
        }

        /*private void DeactivateButton(int rowIndex)
        {
            int userId = Convert.ToInt32(GridViewAccount.Rows[rowIndex].Cells["UserId"].Value);
            bool isApproved = GridViewAccount.Rows[rowIndex].Cells["IsApprove"].Value.ToString().ToLower() == "true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Chuyển đổi giá trị hiện tại của IsApprove
                bool newIsApproved = False;

                string updateQuery = "UPDATE Logins SET IsApprove = @IsApprove WHERE UserId = @UserId";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@UserId", userId);
                    updateCommand.Parameters.AddWithValue("@IsApprove", newIsApproved);
                    updateCommand.ExecuteNonQuery();
                }
            }

            // Tải lại dữ liệu tài khoản sau khi cập nhật
            LoadGridViewAccount();

        }*/
        private void ResetPassword(int rowIndex)
        {
            string userId = GridViewAccount.Rows[rowIndex].Cells["UserId"].Value.ToString();

            // Thực hiện cập nhật mật khẩu trong CSDL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Logins SET PassWord = @Password WHERE UserId = @UserId";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Password", "12345678");
                    updateCommand.Parameters.AddWithValue("@UserId", userId);
                    updateCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Reset Password thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridViewAccount();
        }

        private void btnSearchTrainer_Click(object sender, EventArgs e)
        {
            string trainerId = txtSearchTrainer.Text;

            if (string.IsNullOrEmpty(trainerId) || trainerId == "")
            {
                MessageBox.Show("Vui lòng nhập Trainer ID để tìm kiếm.");
                LoadGridViewTrainer();
                return;
            }

            SearchTrainerById(trainerId);
        }
        private void SearchTrainerById(string trainerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TrainerId, TrainerName, Gender, Birth, PhoneNumber FROM Trainer WHERE TrainerId = @TrainerId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TrainerId", trainerId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        GridViewTrainer.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Trainer ID này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridViewTrainer(); // Tải lại tất cả dữ liệu
                    }
                }
            }
        }

        private void btnSearchAcc_Click(object sender, EventArgs e)
        {
            // Lấy giá trị UserId từ ô txtSearchAcc
            int userIdToSearch;
            if (int.TryParse(txtSearchAcc.Text, out userIdToSearch))
            {
                // Gọi hàm để tìm kiếm và hiển thị kết quả
                SearchAccountById(userIdToSearch);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Id để tìm kiếm.");
                LoadGridViewAccount();
            }
        }
        private void SearchAccountById(int userId)
        {
            // Thực hiện truy vấn tìm kiếm dựa trên UserId
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId, UserName, PassWord, " +
                        "CASE WHEN IsApprove IS NULL THEN 'Not Active' " +
                        "     WHEN IsApprove = 0 THEN 'Not Active' " +
                        "     ELSE 'Active' END AS IsApprove " +
                        "FROM Logins WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Kiểm tra xem có dữ liệu tìm kiếm hay không
                    if (dataTable.Rows.Count > 0)
                    {
                        // Hiển thị kết quả tìm kiếm trong GridViewAccount
                        GridViewAccount.DataSource = dataTable;
                    }
                    else
                    {
                        // Nếu không tìm thấy kết quả, thông báo cho người dùng
                        MessageBox.Show("Không tìm thấy tài khoản với UserId này.");
                        LoadGridViewAccount();
                    }
                }
            }
        }

    }
}