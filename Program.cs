#region Giao diện
while(true)
{
    Console.WriteLine("Chọn bài muốn thực hiện (1 - 3), gõ 'all' để chạy tất cả hoặc gõ 'exit' để thoát:");
    string choice = Console.ReadLine();
    switch(choice)
    {
        case "1" : Bai01(); break;
        case "2" : Bai02(); break;
        case "3" : Bai03(); break;
        case "all" : 
            for(int i = 1; i <= 3; i++)
            {
                switch(i)
                {
                    case 1 : Bai01(); break;
                    case 2 : Bai02(); break;
                    case 3 : Bai03(); break;
                }
                Console.WriteLine();
            }
            break;
        case "exit" : return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 1 đến 3 hoặc gõ 'all' để chạy tất cả hoặc gõ 'exit' để thoát.");
            break;
    }
}
static void Bai01()
{
    Console.WriteLine("Bài 1: Tìm từ dài nhất");
    Console.Write("Nhập vào một chuỗi: ");
    string input = Console.ReadLine();    
    string ketQua = timTuDaiNhat(input);
    Console.WriteLine($"Từ dài nhất là: {ketQua}");
}
static void Bai02()
{
    Console.WriteLine("Bài 2: Loại bỏ ký tự đặc biệt");
    Console.Write("Nhập vào một chuỗi: ");
    string input = Console.ReadLine();          
    string ketQua = loaiBoKiTuDacBiet(input);
    Console.WriteLine($"Chuỗi sau khi lọc: {ketQua}");
}
static void Bai03()
{
    Console.WriteLine("Bài 3: Từ dài nhất có chứa số");
    Console.Write("Nhập vào một chuỗi: ");
    string input = Console.ReadLine();
    string ketQua = tuDaiNhatCoChuaSo(input);
    Console.WriteLine($"Từ dài nhất có chứa số là: {ketQua}");
}
#endregion




static string timTuDaiNhat(string s)
{
    string tuHienTai = "";
    string tuDaiNhat = "";
    for(int i = 0; i < s.Length; i++)
    {
        if(s[i] != ' ') {tuHienTai += s[i];}
        if(s[i] == ' ' || i == s.Length -1)
        {
            if (tuHienTai.Length > tuDaiNhat.Length)
            {
                tuDaiNhat = tuHienTai;
            }
            tuHienTai = "";
        }
    }
    return tuDaiNhat;
}

static string loaiBoKiTuDacBiet(string s)
{
    string result = "";
    for(int i = 0; i < s.Length; i++)
    {
        bool chuThuong = (s[i] >= 'a' && s[i] <='z');
        bool chuHoa = (s[i] >= 'A' && s[i] <='Z');
        bool khoangTrang = (s[i] == ' ');

        if (chuThuong || chuHoa || khoangTrang)
        {
            result += s[i];
        }
    }
    return result;
}

static string tuDaiNhatCoChuaSo(string s)
{
    string tuDaiNhat = "";
    string tuHienTai = "";
    bool coChuSo = false;
    for(int i = 0; i < s.Length;i++)
    {
        if(s[i] != ' ')
        {
            tuHienTai += s[i];
            if(s[i] >= '0' && s[i] <= '9') {coChuSo = true;}
        }
        if(s[i] == ' ' || i == s.Length - 1)
        {
            if(coChuSo == true && tuHienTai.Length > tuDaiNhat.Length)
            {
                tuDaiNhat = tuHienTai;
            }
            tuHienTai = "";
            coChuSo = false;
        }
    }
    return tuDaiNhat;
}