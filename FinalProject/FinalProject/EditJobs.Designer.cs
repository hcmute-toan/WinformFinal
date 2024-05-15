namespace FinalProject
{
    partial class EditJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJobs));
            this.CbNameCompany = new System.Windows.Forms.ComboBox();
            this.tbDecribeJob = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.CbAddress = new System.Windows.Forms.ComboBox();
            this.tbContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbRecruit = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPositionNeeded = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameJob = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSlary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // CbNameCompany
            // 
            this.CbNameCompany.DisplayMember = "Name";
            this.CbNameCompany.FormattingEnabled = true;
            this.CbNameCompany.Location = new System.Drawing.Point(409, 82);
            this.CbNameCompany.Name = "CbNameCompany";
            this.CbNameCompany.Size = new System.Drawing.Size(385, 24);
            this.CbNameCompany.TabIndex = 158;
            // 
            // tbDecribeJob
            // 
            this.tbDecribeJob.BorderRadius = 20;
            this.tbDecribeJob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDecribeJob.DefaultText = "";
            this.tbDecribeJob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDecribeJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDecribeJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDecribeJob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDecribeJob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDecribeJob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDecribeJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbDecribeJob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDecribeJob.IconRight = ((System.Drawing.Image)(resources.GetObject("tbDecribeJob.IconRight")));
            this.tbDecribeJob.Location = new System.Drawing.Point(399, 552);
            this.tbDecribeJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDecribeJob.Name = "tbDecribeJob";
            this.tbDecribeJob.PasswordChar = '\0';
            this.tbDecribeJob.PlaceholderText = "";
            this.tbDecribeJob.SelectedText = "";
            this.tbDecribeJob.Size = new System.Drawing.Size(395, 49);
            this.tbDecribeJob.TabIndex = 157;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(257, 570);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 16);
            this.label17.TabIndex = 156;
            this.label17.Text = "Describe Job :";
            // 
            // btnPost
            // 
            this.btnPost.BorderRadius = 20;
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(676, 622);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(180, 45);
            this.btnPost.TabIndex = 155;
            this.btnPost.Text = "Update";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click_1);
            // 
            // CbAddress
            // 
            this.CbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CbAddress.FormattingEnabled = true;
            this.CbAddress.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau ",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hồ Chí Minh",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "TP Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc"});
            this.CbAddress.Location = new System.Drawing.Point(399, 472);
            this.CbAddress.Name = "CbAddress";
            this.CbAddress.Size = new System.Drawing.Size(395, 24);
            this.CbAddress.TabIndex = 154;
            // 
            // tbContact
            // 
            this.tbContact.BorderRadius = 20;
            this.tbContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContact.DefaultText = "";
            this.tbContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbContact.IconRight = ((System.Drawing.Image)(resources.GetObject("tbContact.IconRight")));
            this.tbContact.Location = new System.Drawing.Point(399, 405);
            this.tbContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbContact.Name = "tbContact";
            this.tbContact.PasswordChar = '\0';
            this.tbContact.PlaceholderText = "";
            this.tbContact.SelectedText = "";
            this.tbContact.Size = new System.Drawing.Size(395, 49);
            this.tbContact.TabIndex = 153;
            // 
            // tbRecruit
            // 
            this.tbRecruit.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.tbRecruit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbRecruit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbRecruit.BorderRadius = 20;
            this.tbRecruit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRecruit.DefaultText = "";
            this.tbRecruit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRecruit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRecruit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRecruit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRecruit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRecruit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRecruit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbRecruit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRecruit.IconRight = ((System.Drawing.Image)(resources.GetObject("tbRecruit.IconRight")));
            this.tbRecruit.Location = new System.Drawing.Point(399, 332);
            this.tbRecruit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRecruit.Name = "tbRecruit";
            this.tbRecruit.PasswordChar = '\0';
            this.tbRecruit.PlaceholderText = "";
            this.tbRecruit.SelectedText = "";
            this.tbRecruit.Size = new System.Drawing.Size(395, 49);
            this.tbRecruit.TabIndex = 152;
            // 
            // tbPositionNeeded
            // 
            this.tbPositionNeeded.AutoCompleteCustomSource.AddRange(new string[] {
            "Sales Manager",
            "Marketing Coordinator",
            "Human Resources Specialist",
            "Financial Analyst",
            "Customer Service Representative",
            "Project Manager",
            "Software Engineer",
            "Graphic Designer",
            "Accountant",
            "Administrative Assistant",
            "Web Developer",
            "Content Writer",
            "Operations Manager",
            "Data Analyst",
            "Quality Assurance Tester",
            "Business Development Associate",
            "IT Support Specialist",
            "Legal Counsel",
            "Procurement Officer",
            "Social Media Manager",
            "Product Manager",
            "Event Coordinator",
            "Executive Assistant",
            "Research Analyst",
            "Public Relations Specialist",
            "Recruitment Coordinator",
            "Systems Administrator",
            "Marketing Assistant",
            "Financial Controller",
            "Customer Success Manager",
            "Copywriter",
            "Network Engineer",
            "Inventory Manager",
            "HR Coordinator",
            "UX/UI Designer",
            "Compliance Officer",
            "Marketing Associate",
            "Operations Coordinator",
            "Technical Writer",
            "Account Manager",
            "IT Security Analyst",
            "Brand Manager",
            "Training Coordinator",
            "Data Entry Clerk",
            "Payroll Administrator",
            "Internal Auditor",
            "Front End Developer",
            "Supply Chain Manager",
            "Sales Representative",
            "Office Manager",
            "Quản lý Bán hàng",
            "Trợ lý Marketing",
            "Chuyên viên Nhân sự",
            "Phân tích Tài chính",
            "Đại diện Dịch vụ Khách hàng",
            "Quản lý Dự án",
            "Kỹ sư Phần mềm",
            "Nhà Thiết kế Đồ họa",
            "Kế toán",
            "Trợ lý Hành chính",
            "Nhà Phát triển Web",
            "Tác giả Nội dung",
            "Quản lý Hoạt động",
            "Phân tích Dữ liệu",
            "Kiểm tra Chất lượng",
            "Trợ lý Phát triển Kinh doanh",
            "Chuyên viên Hỗ trợ CNTT",
            "Luật sư",
            "Quản lý Mua hàng",
            "Quản lý Mạng xã hội",
            "Quản lý Sản phẩm",
            "Tổ chức Sự kiện",
            "Trợ lý Ban giám đốc",
            "Phân tích Nghiên cứu",
            "Chuyên viên Quan hệ Công chúng",
            "Chuyên viên Tuyển dụng",
            "Quản trị Hệ thống",
            "Trợ lý Marketing",
            "Kiểm soát Tài chính",
            "Quản lý Thành công Khách hàng",
            "Tác giả Nội dung",
            "Kỹ sư Mạng",
            "Quản lý Tồn kho",
            "Trợ lý Nhân sự",
            "Nhà Thiết kế UX/UI",
            "Chuyên viên Tuân thủ",
            "Chuyên viên Marketing",
            "Trợ lý Hoạt động",
            "Tác giả Kỹ thuật",
            "Quản lý Tài khoản",
            "Chuyên viên An ninh Thông tin",
            "Quản lý Thương hiệu",
            "Trợ lý Đào tạo",
            "Nhân viên Nhập liệu",
            "Quản lý Lương",
            "Account Executive",
            "Operations Analyst",
            "Executive Director",
            "Data Scientist",
            "Sales Associate",
            "Financial Planner",
            "Customer Support Specialist",
            "Marketing Manager",
            "Production Supervisor",
            "Social Worker",
            "Software Developer",
            "Brand Ambassador",
            "Public Relations Manager",
            "Recruitment Specialist",
            "Supply Chain Analyst",
            "Research Scientist",
            "Event Planner",
            "Inventory Analyst",
            "Customer Experience Manager",
            "Technical Support Engineer",
            "Legal Assistant",
            "Marketing Analyst",
            "Logistics Coordinator",
            "Quality Control Inspector",
            "Financial Advisor",
            "Administrative Coordinator",
            "Procurement Manager",
            "Content Manager",
            "HR Generalist",
            "Network Administrator",
            "Customer Relations Manager",
            "Operations Coordinator",
            "Technical Consultant",
            "Risk Analyst",
            "Business Development Executive",
            "Media Planner",
            "Web Designer",
            "Executive Secretary",
            "Sales Coordinator",
            "Project Coordinator",
            "Database Administrator",
            "Brand Strategist",
            "Public Relations Specialist",
            "Product Development Manager",
            "Human Resources Coordinator",
            "Customer Service Manager",
            "Market Research Analyst",
            "IT Manager",
            "Business Consultant",
            "Thực thi Tài khoản",
            "Phân tích Hoạt động",
            "Giám đốc Hành chính",
            "Nhà Khoa học Dữ liệu",
            "Đại diện Bán hàng",
            "Kế hoạch Tài chính",
            "Chuyên viên Hỗ trợ Khách hàng",
            "Quản lý Marketing",
            "Giám sát Sản xuất",
            "Công nhân Xã hội",
            "Nhà Phát triển Phần mềm",
            "Đại sứ Thương hiệu",
            "Quản lý Quan hệ Công chúng",
            "Chuyên viên Tuyển dụng",
            "Phân tích Chuỗi cung ứng",
            "Nhà Khoa học Nghiên cứu",
            "Quản lý Sự kiện",
            "Phân tích Tồn kho",
            "Quản lý Trải nghiệm Khách hàng",
            "Kỹ sư Hỗ trợ Kỹ thuật",
            "Trợ lý Luật sư",
            "Phân tích Marketing",
            "Thủ trưởng Vận chuyển",
            "Kiểm tra Chất lượng",
            "Tư vấn Tài chính",
            "Trợ lý Hành chính",
            "Quản lý Mua hàng",
            "Quản lý Nội dung",
            "Chuyên viên Nhân sự",
            "Quản trị Mạng",
            "Quản lý Quan hệ Khách hàng",
            "Trợ lý Hoạt động",
            "Tư vấn Kỹ thuật",
            "Phân tích Rủi ro",
            "Giám đốc Phát triển Kinh doanh",
            "Chuyên viên Lập kế hoạch Truyền thông",
            "Nhà Thiết kế Web",
            "Thư ký Ban điều hành",
            "Trợ lý Bán hàng",
            "Trợ lý Dự án",
            "Quản trị Cơ sở dữ liệu",
            "Chuyên gia Chiến lược Thương hiệu",
            "Kiểm toán Nội bộ",
            "Nhà Phát triển Front-End",
            "Quản lý Chuỗi cung ứng",
            "Đại diện Bán hàng",
            "Quản lý Văn phòng"});
            this.tbPositionNeeded.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbPositionNeeded.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbPositionNeeded.BorderRadius = 20;
            this.tbPositionNeeded.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPositionNeeded.DefaultText = "";
            this.tbPositionNeeded.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPositionNeeded.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPositionNeeded.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPositionNeeded.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPositionNeeded.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPositionNeeded.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPositionNeeded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbPositionNeeded.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPositionNeeded.IconRight = ((System.Drawing.Image)(resources.GetObject("tbPositionNeeded.IconRight")));
            this.tbPositionNeeded.Location = new System.Drawing.Point(399, 139);
            this.tbPositionNeeded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPositionNeeded.Name = "tbPositionNeeded";
            this.tbPositionNeeded.PasswordChar = '\0';
            this.tbPositionNeeded.PlaceholderText = "";
            this.tbPositionNeeded.SelectedText = "";
            this.tbPositionNeeded.Size = new System.Drawing.Size(395, 49);
            this.tbPositionNeeded.TabIndex = 151;
            // 
            // tbNameJob
            // 
            this.tbNameJob.AutoCompleteCustomSource.AddRange(new string[] {
            "Marketing Coordinator",
            "Human Resources Specialist",
            "Financial Analyst",
            "Customer Service Representative",
            "Project Manager",
            "Software Engineer",
            "Graphic Designer",
            "Accountant",
            "Administrative Assistant",
            "Web Developer",
            "Content Writer",
            "Operations Manager",
            "Data Analyst",
            "Quality Assurance Tester",
            "Business Development Associate",
            "IT Support Specialist",
            "Legal Counsel",
            "Procurement Officer",
            "Social Media Manager",
            "Product Manager",
            "Event Coordinator",
            "Executive Assistant",
            "Research Analyst",
            "Public Relations Specialist",
            "Recruitment Coordinator",
            "Systems Administrator",
            "Marketing Assistant",
            "Financial Controller",
            "Customer Success Manager",
            "Copywriter",
            "Network Engineer",
            "Inventory Manager",
            "HR Coordinator",
            "UX/UI Designer",
            "Compliance Officer",
            "Marketing Associate",
            "Operations Coordinator",
            "Technical Writer",
            "Account Manager",
            "IT Security Analyst",
            "Brand Manager",
            "Training Coordinator",
            "Data Entry Clerk",
            "Payroll Administrator",
            "Internal Auditor",
            "Front End Developer",
            "Supply Chain Manager",
            "Sales Representative",
            "Office Manager",
            "Quản lý Bán hàng",
            "Trợ lý Marketing",
            "Chuyên viên Nhân sự",
            "Phân tích Tài chính",
            "Đại diện Dịch vụ Khách hàng",
            "Quản lý Dự án",
            "Kỹ sư Phần mềm",
            "Nhà Thiết kế Đồ họa",
            "Kế toán",
            "Trợ lý Hành chính",
            "Nhà Phát triển Web",
            "Tác giả Nội dung",
            "Quản lý Hoạt động",
            "Phân tích Dữ liệu",
            "Kiểm tra Chất lượng",
            "Trợ lý Phát triển Kinh doanh",
            "Chuyên viên Hỗ trợ CNTT",
            "Luật sư",
            "Quản lý Mua hàng",
            "Quản lý Mạng xã hội",
            "Quản lý Sản phẩm",
            "Tổ chức Sự kiện",
            "Trợ lý Ban giám đốc",
            "Phân tích Nghiên cứu",
            "Chuyên viên Quan hệ Công chúng",
            "Chuyên viên Tuyển dụng",
            "Quản trị Hệ thống",
            "Trợ lý Marketing",
            "Kiểm soát Tài chính",
            "Quản lý Thành công Khách hàng",
            "Tác giả Nội dung",
            "Kỹ sư Mạng",
            "Quản lý Tồn kho",
            "Trợ lý Nhân sự",
            "Nhà Thiết kế UX/UI",
            "Chuyên viên Tuân thủ",
            "Chuyên viên Marketing",
            "Trợ lý Hoạt động",
            "Tác giả Kỹ thuật",
            "Quản lý Tài khoản",
            "Chuyên viên An ninh Thông tin",
            "Quản lý Thương hiệu",
            "Trợ lý Đào tạo",
            "Nhân viên Nhập liệu",
            "Quản lý Lương",
            "Account Executive",
            "Operations Analyst",
            "Executive Director",
            "Data Scientist",
            "Sales Associate",
            "Financial Planner",
            "Customer Support Specialist",
            "Marketing Manager",
            "Production Supervisor",
            "Social Worker",
            "Software Developer",
            "Brand Ambassador",
            "Public Relations Manager",
            "Recruitment Specialist",
            "Supply Chain Analyst",
            "Research Scientist",
            "Event Planner",
            "Inventory Analyst",
            "Customer Experience Manager",
            "Technical Support Engineer",
            "Legal Assistant",
            "Marketing Analyst",
            "Logistics Coordinator",
            "Quality Control Inspector",
            "Financial Advisor",
            "Administrative Coordinator",
            "Procurement Manager",
            "Content Manager",
            "HR Generalist",
            "Network Administrator",
            "Customer Relations Manager",
            "Operations Coordinator",
            "Technical Consultant",
            "Risk Analyst",
            "Business Development Executive",
            "Media Planner",
            "Web Designer",
            "Executive Secretary",
            "Sales Coordinator",
            "Project Coordinator",
            "Database Administrator",
            "Brand Strategist",
            "Public Relations Specialist",
            "Product Development Manager",
            "Human Resources Coordinator",
            "Customer Service Manager",
            "Market Research Analyst",
            "IT Manager",
            "Business Consultant",
            "Thực thi Tài khoản",
            "Phân tích Hoạt động",
            "Giám đốc Hành chính",
            "Nhà Khoa học Dữ liệu",
            "Đại diện Bán hàng",
            "Kế hoạch Tài chính",
            "Chuyên viên Hỗ trợ Khách hàng",
            "Quản lý Marketing",
            "Giám sát Sản xuất",
            "Công nhân Xã hội",
            "Nhà Phát triển Phần mềm",
            "Đại sứ Thương hiệu",
            "Quản lý Quan hệ Công chúng",
            "Chuyên viên Tuyển dụng",
            "Phân tích Chuỗi cung ứng",
            "Nhà Khoa học Nghiên cứu",
            "Quản lý Sự kiện",
            "Phân tích Tồn kho",
            "Quản lý Trải nghiệm Khách hàng",
            "Kỹ sư Hỗ trợ Kỹ thuật",
            "Trợ lý Luật sư",
            "Phân tích Marketing",
            "Thủ trưởng Vận chuyển",
            "Kiểm tra Chất lượng",
            "Tư vấn Tài chính",
            "Trợ lý Hành chính",
            "Quản lý Mua hàng",
            "Quản lý Nội dung",
            "Chuyên viên Nhân sự",
            "Quản trị Mạng",
            "Quản lý Quan hệ Khách hàng",
            "Trợ lý Hoạt động",
            "Tư vấn Kỹ thuật",
            "Phân tích Rủi ro",
            "Giám đốc Phát triển Kinh doanh",
            "Chuyên viên Lập kế hoạch Truyền thông",
            "Nhà Thiết kế Web",
            "Thư ký Ban điều hành",
            "Trợ lý Bán hàng",
            "Trợ lý Dự án",
            "Quản trị Cơ sở dữ liệu",
            "Chuyên gia Chiến lược Thương hiệu",
            "Kiểm toán Nội bộ",
            "Nhà Phát triển Front-End",
            "Quản lý Chuỗi cung ứng",
            "Đại diện Bán hàng",
            "Quản lý Văn phòng"});
            this.tbNameJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNameJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNameJob.BorderRadius = 20;
            this.tbNameJob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameJob.DefaultText = "";
            this.tbNameJob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNameJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNameJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameJob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameJob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameJob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNameJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbNameJob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameJob.IconRight = ((System.Drawing.Image)(resources.GetObject("tbNameJob.IconRight")));
            this.tbNameJob.Location = new System.Drawing.Point(399, 205);
            this.tbNameJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNameJob.Name = "tbNameJob";
            this.tbNameJob.PasswordChar = '\0';
            this.tbNameJob.PlaceholderText = "";
            this.tbNameJob.SelectedText = "";
            this.tbNameJob.Size = new System.Drawing.Size(395, 49);
            this.tbNameJob.TabIndex = 150;
            // 
            // tbSlary
            // 
            this.tbSlary.AutoCompleteCustomSource.AddRange(new string[] {
            "8.000.000 VND",
            "12.500.000 VND",
            "15.000.000 VND",
            "20.000.000 VND",
            "25.000.000 VND",
            "30.000.000 VND",
            "35.000.000 VND",
            "40.000.000 VND",
            "45.000.000 VND",
            "50.000.000 VND",
            "55.000.000 VND",
            "60.000.000 VND",
            "65.000.000 VND",
            "70.000.000 VND",
            "75.000.000 VND",
            "80.000.000 VND",
            "85.000.000 VND",
            "90.000.000 VND",
            "95.000.000 VND",
            "100.000.000 VND",
            "110.000.000 VND",
            "120.000.000 VND",
            "130.000.000 VND",
            "140.000.000 VND",
            "150.000.000 VND",
            "160.000.000 VND",
            "170.000.000 VND",
            "180.000.000 VND",
            "190.000.000 VND",
            "200.000.000 VND",
            "4  000 USD",
            "4  500 USD",
            "5  000 USD",
            "5  500 USD",
            "6  000 USD",
            "6  500 USD",
            "7  000 USD",
            "7  500 USD",
            "8  000 USD",
            "8  500 USD",
            "9  000 USD",
            "9  500 USD",
            "10  000 USD",
            "10  500 USD",
            "11  000 USD",
            "11  500 USD",
            "12  000 USD",
            "12  500 USD",
            "13  000 USD",
            "13  500 USD"});
            this.tbSlary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSlary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSlary.BorderRadius = 20;
            this.tbSlary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSlary.DefaultText = "";
            this.tbSlary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSlary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSlary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSlary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSlary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSlary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSlary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbSlary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSlary.IconRight = ((System.Drawing.Image)(resources.GetObject("tbSlary.IconRight")));
            this.tbSlary.Location = new System.Drawing.Point(399, 268);
            this.tbSlary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSlary.Name = "tbSlary";
            this.tbSlary.PasswordChar = '\0';
            this.tbSlary.PlaceholderText = "";
            this.tbSlary.SelectedText = "";
            this.tbSlary.Size = new System.Drawing.Size(395, 49);
            this.tbSlary.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(257, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 142;
            this.label4.Text = "Name Company :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(257, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 146;
            this.label7.Text = "Number Of Recruit :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(260, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 147;
            this.label10.Text = "Contact :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(260, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 143;
            this.label13.Text = "Position Needed :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(257, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 145;
            this.label14.Text = "Salary :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(257, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 144;
            this.label15.Text = "Name Job :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(257, 480);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 148;
            this.label16.Text = "Address :";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(235, 622);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 159;
            this.guna2Button1.Text = "Delete";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // EditJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 737);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.CbNameCompany);
            this.Controls.Add(this.tbDecribeJob);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.CbAddress);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbRecruit);
            this.Controls.Add(this.tbPositionNeeded);
            this.Controls.Add(this.tbNameJob);
            this.Controls.Add(this.tbSlary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Name = "EditJobs";
            this.Text = "EditJobs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CbNameCompany;
        public Guna.UI2.WinForms.Guna2TextBox tbDecribeJob;
        public System.Windows.Forms.Label label17;
        public Guna.UI2.WinForms.Guna2Button btnPost;
        public System.Windows.Forms.ComboBox CbAddress;
        public Guna.UI2.WinForms.Guna2TextBox tbContact;
        public Guna.UI2.WinForms.Guna2TextBox tbRecruit;
        public Guna.UI2.WinForms.Guna2TextBox tbPositionNeeded;
        public Guna.UI2.WinForms.Guna2TextBox tbNameJob;
        public Guna.UI2.WinForms.Guna2TextBox tbSlary;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}