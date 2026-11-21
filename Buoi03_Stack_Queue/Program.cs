using System;
using System.Collections.Generic;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("============================================================");
Console.WriteLine("BUỔI 03 - BÀI TẬP ÁP DỤNG CHƯƠNG 5: STACK & QUEUE (BÀI 1 - 6)");
Console.WriteLine("Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1");
Console.WriteLine("============================================================\n");

Console.WriteLine("=== Bài tập 1: Kiểm tra tính đúng đắn của biểu thức toán học ===");
C5_BaiTap1();

Console.WriteLine("\n=== Bài tập 2: Mô phỏng lịch sử trình duyệt web (Back / Forward) ===");
C5_BaiTap2();

Console.WriteLine("\n=== Bài tập 3: Mô phỏng quá trình thực thi chương trình (Function Call Stack) ===");
C5_BaiTap3();

Console.WriteLine("\n=== Bài tập 4: Mô phỏng hệ thống in ấn (FIFO Queue) ===");
C5_BaiTap4();

Console.WriteLine("\n=== Bài tập 5: Mô phỏng đường truyền dữ liệu mạng ===");
C5_BaiTap5();

Console.WriteLine("\n=== Bài tập 6: Mô phỏng quản lý hàng đợi tại Ngân hàng ===");
C5_BaiTap6();

Console.WriteLine("\n============================================================");
Console.WriteLine("HOÀN THÀNH TOÀN BỘ BÀI TẬP ÁP DỤNG CHƯƠNG 5 (BUỔI 03)!");
Console.WriteLine("============================================================");

// =========================================================================
// BÀI TẬP 1: KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC TOÁN HỌC (TRANG 215)
// =========================================================================
static void C5_BaiTap1()
{
    string[] danhSachBieuThuc =
    {
        "{[5 + (1 + 2 * 4)] * (3 - 1)}",
        "((2 + 3) * [4 - 1]}",
        "((5 + 2) * 3",
        "5 + 2) * 3"
    };

    foreach (string bt in danhSachBieuThuc)
    {
        bool hopLe = KiemTraDauNgoac(bt);
        Console.WriteLine($"Biểu thức: {bt,-32} -> {(hopLe ? "Hợp lệ (True)" : "Sai cấu trúc ngoặc (False)")}");
    }

    static bool KiemTraDauNgoac(string bieuThuc)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in bieuThuc)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0) return false;

                char dinh = stack.Pop();
                if ((c == ')' && dinh != '(') ||
                    (c == ']' && dinh != '[') ||
                    (c == '}' && dinh != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}

// =========================================================================
// BÀI TẬP 2: MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT WEB (TRANG 215)
// =========================================================================
static void C5_BaiTap2()
{
    TrinhDuyetWeb browser = new TrinhDuyetWeb("https://utehy.edu.vn");

    browser.TruyCapTrangMoi("https://utehy.edu.vn/tin-tuc");
    browser.TruyCapTrangMoi("https://github.com/nguyentruonghai-hyute");
    browser.TruyCapTrangMoi("https://github.com/nguyentruonghai-hyute/10125116_DSA");

    browser.Back();
    browser.Back();
    browser.Forward();

    browser.TruyCapTrangMoi("https://learn.microsoft.com/dotnet/csharp");
    browser.Forward();
}

// =========================================================================
// BÀI TẬP 3: MÔ PHỎNG QUÁ TRÌNH THỰC THI CHƯƠNG TRÌNH - CALL STACK (TRANG 215-216)
// =========================================================================
static void C5_BaiTap3()
{
    CallStackSimulator callStack = new CallStackSimulator();

    callStack.Call("Main()", "args = []", "Hệ điều hành (OS Exit)");
    callStack.Call("TinhTongLuong()", "phongBan = \"Kỹ thuật\"", "Main() : dòng 15");
    callStack.Call("LayDanhSachNV()", "phongBan = \"Kỹ thuật\"", "TinhTongLuong() : dòng 28");

    callStack.HienThiStack();

    callStack.Return();
    callStack.Call("TinhThueTNCN()", "thuNhap = 15,000,000", "TinhTongLuong() : dòng 32");
    callStack.Return();
    callStack.Return();
    callStack.Return();
}

// =========================================================================
// BÀI TẬP 4: MÔ PHỎNG HỆ THỐNG IN ẤN (TRANG 216)
// =========================================================================
static void C5_BaiTap4()
{
    HeThongInAn mayIn = new HeThongInAn();

    mayIn.ThemYeuCauIn("JOB-01", "BaoCao_CTDLGT.pdf", 12);
    mayIn.ThemYeuCauIn("JOB-02", "DeCuong_OnTap.docx", 5);
    mayIn.ThemYeuCauIn("JOB-03", "BangDiem_10125N1.xlsx", 2);

    mayIn.HienThiHangDoi();

    mayIn.XuLyIn();
    mayIn.XuLyIn();

    mayIn.ThemYeuCauIn("JOB-04", "Slide_Chuong5_StackQueue.pptx", 24);
    mayIn.HienThiHangDoi();

    mayIn.XuLyIn();
    mayIn.XuLyIn();
    mayIn.XuLyIn();
}

// =========================================================================
// BÀI TẬP 5: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU (TRANG 216)
// =========================================================================
static void C5_BaiTap5()
{
    DuongTruyenMang network = new DuongTruyenMang();

    network.GuiGoiTin(new DataPacket("PKT-01", "Header SYN", 64, 12, false));
    network.GuiGoiTin(new DataPacket("PKT-02", "User Auth Token", 256, 18, false));
    network.GuiGoiTin(new DataPacket("PKT-03", "Query Payload", 1024, 35, true));
    network.GuiGoiTin(new DataPacket("PKT-04", "Footer FIN", 64, 10, false));

    network.XuLyTatCaGoiTin();
}

// =========================================================================
// BÀI TẬP 6: MÔ PHỎNG QUẢN LÝ HÀNG ĐỢI TẠI NGÂN HÀNG (TRANG 216-217)
// =========================================================================
static void C5_BaiTap6()
{
    NganHangQueue nganHang = new NganHangQueue();

    nganHang.KhachHangDen(new KhachHang(101, "Nguyễn Trường Hải", "08:30", "Mở thẻ sinh viên"));
    nganHang.KhachHangDen(new KhachHang(102, "Đào Minh Vũ", "08:32", "Nộp tiền mặt"));
    nganHang.KhachHangDen(new KhachHang(103, "Luyện Minh Hiếu", "08:35", "Chuyển khoản liên ngân hàng"));
    nganHang.KhachHangDen(new KhachHang(104, "Trần Văn Hiếu", "08:40", "Cấp lại mã PIN"));

    nganHang.HienThiTrangThaiHangDoi();

    nganHang.PhucVuKhachTiepTheo("Quầy số 1");
    nganHang.PhucVuKhachTiepTheo("Quầy số 2");

    nganHang.HienThiTrangThaiHangDoi();

    nganHang.PhucVuKhachTiepTheo("Quầy số 1");
    nganHang.PhucVuKhachTiepTheo("Quầy số 2");
    nganHang.PhucVuKhachTiepTheo("Quầy số 1");
}

// =========================================================================
// CÁC LỚP MÔ PHỎNG CHO BÀI TẬP 2, 3, 4, 5, 6
// =========================================================================

class TrinhDuyetWeb
{
    private Stack<string> backStack = new Stack<string>();
    private Stack<string> forwardStack = new Stack<string>();
    private string trangHienTai;

    public TrinhDuyetWeb(string trangChu)
    {
        trangHienTai = trangChu;
        Console.WriteLine($"[Khởi động] Trang hiện tại: {trangHienTai}");
    }

    public void TruyCapTrangMoi(string url)
    {
        backStack.Push(trangHienTai);
        forwardStack.Clear();
        trangHienTai = url;
        Console.WriteLine($"[Truy cập]  -> {trangHienTai} (Back: {backStack.Count}, Forward: {forwardStack.Count})");
    }

    public void Back()
    {
        if (backStack.Count == 0)
        {
            Console.WriteLine("[Back]      Không thể quay lại (Stack Back rỗng).");
            return;
        }
        forwardStack.Push(trangHienTai);
        trangHienTai = backStack.Pop();
        Console.WriteLine($"[Back]      <- Quay lại: {trangHienTai} (Back: {backStack.Count}, Forward: {forwardStack.Count})");
    }

    public void Forward()
    {
        if (forwardStack.Count == 0)
        {
            Console.WriteLine("[Forward]   Không thể chuyển tiếp (Stack Forward rỗng).");
            return;
        }
        backStack.Push(trangHienTai);
        trangHienTai = forwardStack.Pop();
        Console.WriteLine($"[Forward]   -> Chuyển tiếp: {trangHienTai} (Back: {backStack.Count}, Forward: {forwardStack.Count})");
    }
}

record StackFrame(string TenHam, string ThamSo, string DiaChiTraVe);

class CallStackSimulator
{
    private Stack<StackFrame> stack = new Stack<StackFrame>();

    public void Call(string tenHam, string thamSo, string diaChiTraVe)
    {
        StackFrame frame = new StackFrame(tenHam, thamSo, diaChiTraVe);
        stack.Push(frame);
        Console.WriteLine($"[CALL]   Gọi {tenHam} | Tham số: {thamSo} | Trả về: {diaChiTraVe}");
    }

    public void Return()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("[RETURN] Call Stack rỗng.");
            return;
        }
        StackFrame ketThuc = stack.Pop();
        Console.WriteLine($"[RETURN] Kết thúc {ketThuc.TenHam} -> quay về {ketThuc.DiaChiTraVe} (Còn {stack.Count} khung)");
    }

    public void HienThiStack()
    {
        Console.WriteLine("   --- Trạng thái Call Stack hiện tại (Đỉnh -> Đáy) ---");
        foreach (var f in stack)
        {
            Console.WriteLine($"   | {f.TenHam,-18} | {f.ThamSo,-26} | Ret: {f.DiaChiTraVe}");
        }
        Console.WriteLine("   -----------------------------------------------------");
    }
}

record PrintJob(string MaLenh, string TenTaiLieu, int SoTrang);

class HeThongInAn
{
    private Queue<PrintJob> printQueue = new Queue<PrintJob>();

    public void ThemYeuCauIn(string ma, string tenFile, int soTrang)
    {
        PrintJob job = new PrintJob(ma, tenFile, soTrang);
        printQueue.Enqueue(job);
        Console.WriteLine($"[Enqueue] Thêm lệnh in {job.MaLenh}: {job.TenTaiLieu} ({job.SoTrang} trang)");
    }

    public void XuLyIn()
    {
        if (printQueue.Count == 0)
        {
            Console.WriteLine("[Dequeue] Hàng đợi in trống, không có tài liệu chờ.");
            return;
        }
        PrintJob dangIn = printQueue.Dequeue();
        Console.WriteLine($"[Dequeue] Đang in xong {dangIn.MaLenh}: {dangIn.TenTaiLieu} ({dangIn.SoTrang} trang)");
    }

    public void HienThiHangDoi()
    {
        Console.Write("   >> Hàng đợi chờ in hiện tại: ");
        if (printQueue.Count == 0)
        {
            Console.WriteLine("(Trống)");
            return;
        }
        List<string> ds = new List<string>();
        foreach (var j in printQueue) ds.Add($"{j.MaLenh} ({j.TenTaiLieu})");
        Console.WriteLine(string.Join(" <- ", ds));
    }
}

class DataPacket
{
    public string MaGoi { get; }
    public string NoiDung { get; }
    public int KichThuocByte { get; }
    public int DoTreMs { get; }
    public bool BiLoiTruyen { get; set; }

    public DataPacket(string maGoi, string noiDung, int kichThuocByte, int doTreMs, bool biLoiTruyen)
    {
        MaGoi = maGoi;
        NoiDung = noiDung;
        KichThuocByte = kichThuocByte;
        DoTreMs = doTreMs;
        BiLoiTruyen = biLoiTruyen;
    }
}

class DuongTruyenMang
{
    private Queue<DataPacket> bufferQueue = new Queue<DataPacket>();

    public void GuiGoiTin(DataPacket pkt)
    {
        bufferQueue.Enqueue(pkt);
        Console.WriteLine($"[Gửi]   Đưa gói {pkt.MaGoi} ({pkt.NoiDung}, {pkt.KichThuocByte}B, trễ {pkt.DoTreMs}ms) vào hàng đợi truyền.");
    }

    public void XuLyTatCaGoiTin()
    {
        Console.WriteLine("   --- Bắt đầu xử lý gói tin theo thứ tự FIFO ---");
        while (bufferQueue.Count > 0)
        {
            DataPacket pkt = bufferQueue.Dequeue();
            if (pkt.BiLoiTruyen)
            {
                Console.WriteLine($"[LỖI]   Gói {pkt.MaGoi} bị lỗi checksum trên đường truyền! Đưa vào cuối hàng đợi để gửi lại...");
                pkt.BiLoiTruyen = false;
                bufferQueue.Enqueue(pkt);
            }
            else
            {
                Console.WriteLine($"[NHẬN]  Đã xử lý thành công gói {pkt.MaGoi}: \"{pkt.NoiDung}\" ({pkt.KichThuocByte}B, độ trễ {pkt.DoTreMs}ms)");
            }
        }
    }
}

record KhachHang(int SoThuTu, string HoTen, string ThoiGianDen, string LoaiDichVu);

class NganHangQueue
{
    private Queue<KhachHang> hangDoi = new Queue<KhachHang>();

    public void KhachHangDen(KhachHang kh)
    {
        hangDoi.Enqueue(kh);
        Console.WriteLine($"[Khách đến] Số {kh.SoThuTu} - {kh.HoTen} ({kh.ThoiGianDen}) | Dịch vụ: {kh.LoaiDichVu}");
    }

    public void PhucVuKhachTiepTheo(string tenQuay)
    {
        if (hangDoi.Count == 0)
        {
            Console.WriteLine($"[{tenQuay}]  Hiện không còn khách hàng nào đang chờ.");
            return;
        }
        KhachHang kh = hangDoi.Dequeue();
        Console.WriteLine($"[{tenQuay}]  Mời khách số {kh.SoThuTu} ({kh.HoTen}) vào giao dịch: {kh.LoaiDichVu}");
    }

    public void HienThiTrangThaiHangDoi()
    {
        Console.WriteLine($"   --- Trạng thái hàng đợi ngân hàng (Đang chờ: {hangDoi.Count} khách) ---");
        if (hangDoi.Count == 0)
        {
            Console.WriteLine("   (Hàng đợi trống)");
        }
        else
        {
            foreach (var kh in hangDoi)
            {
                Console.WriteLine($"   * STT {kh.SoThuTu} | {kh.HoTen,-18} | Đến lúc: {kh.ThoiGianDen} | {kh.LoaiDichVu}");
            }
        }
        Console.WriteLine("   -------------------------------------------------------------");
    }
}
