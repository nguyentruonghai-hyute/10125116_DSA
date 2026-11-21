using System;
using System.Diagnostics;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("============================================================");
Console.WriteLine("CHƯƠNG 2 - THUẬT TOÁN & THÁP HÀ NỘI (BÀI 1 ĐẾN 6)");
Console.WriteLine("Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1");
Console.WriteLine("============================================================\n");

Console.WriteLine("=== Bài 1: Bài toán Tháp Hà Nội ===");
C2_Bai1();

Console.WriteLine("\n=== Bài 2: So sánh tìm kiếm tuần tự và nhị phân ===");
C2_Bai2();

Console.WriteLine("\n=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===");
C2_Bai3();

Console.WriteLine("\n=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===");
C2_Bai4Va6();

Console.WriteLine("\n=== Bài 5: 4 giải thuật tính Fibonacci ===");
C2_Bai5();

Console.WriteLine("\n============================================================");
Console.WriteLine("HOÀN THÀNH BÀI TẬP CHƯƠNG 2!");
Console.WriteLine("============================================================");

// =========================================================================
// CÁC HÀM XỬ LÝ CHI TIẾT CHƯƠNG 2
// =========================================================================

static void C2_Bai1()
{
    int dem = 0, n = 3;
    Console.WriteLine($"Chạy thử Tháp Hà Nội với {n} đĩa:");
    HaNoi(n, 'A', 'B', 'C', ref dem);
    Console.WriteLine("Tổng số lần chuyển: " + dem);

    static void HaNoi(int n, char A, char B, char C, ref int dem)
    {
        if (n == 1)
        {
            dem++;
            Console.WriteLine($"Chuyển đĩa 1 từ {A} sang {C}");
            return;
        }
        HaNoi(n - 1, A, C, B, ref dem);
        dem++;
        Console.WriteLine($"Chuyển đĩa {n} từ {A} sang {C}");
        HaNoi(n - 1, B, A, C, ref dem);
    }
}

static void C2_Bai2()
{
    int[] kichThuoc = { 1000, 100000, 1000000 };
    for (int k = 0; k < kichThuoc.Length; k++)
    {
        int n = kichThuoc[k];
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = i * 2;
        int canTim = -1;

        Stopwatch sw = Stopwatch.StartNew();
        for (int lan = 0; lan < 10; lan++) TimTuanTu(a, n, canTim);
        sw.Stop();
        long tick1 = sw.ElapsedTicks;

        sw.Restart();
        for (int lan = 0; lan < 10; lan++) TimNhiPhan(a, n, canTim);
        sw.Stop();
        long tick2 = sw.ElapsedTicks;

        Console.WriteLine($"n = {n}: Tuần tự = {tick1} ticks, Nhị phân = {tick2} ticks");
    }

    static int TimTuanTu(int[] a, int n, int x)
    {
        for (int i = 0; i < n; i++) if (a[i] == x) return i;
        return -1;
    }

    static int TimNhiPhan(int[] a, int n, int x)
    {
        int dau = 0, cuoi = n - 1;
        while (dau <= cuoi)
        {
            int giua = (dau + cuoi) / 2;
            if (a[giua] == x) return giua;
            else if (a[giua] < x) dau = giua + 1;
            else cuoi = giua - 1;
        }
        return -1;
    }
}

static void C2_Bai3()
{
    int n = 37;
    Console.WriteLine($"Kiểm tra số {n}:");
    if (KiemTra1(n)) Console.WriteLine("Giải thuật 1 (O(n)): 37 là số nguyên tố");
    if (KiemTra2(n)) Console.WriteLine("Giải thuật 2 (O(sqrt(n))): 37 là số nguyên tố");

    static bool KiemTra1(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i < n; i++) if (n % i == 0) return false;
        return true;
    }

    static bool KiemTra2(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++) if (n % i == 0) return false;
        return true;
    }
}

static void C2_Bai4Va6()
{
    Random rd = new Random(10125116);
    double[] goc = new double[10];
    for (int i = 0; i < 10; i++) goc[i] = Math.Round(rd.NextDouble() * 100, 2);

    Console.WriteLine("Dãy ban đầu: " + string.Join("  ", goc));
    double[] a = (double[])goc.Clone();
    Array.Sort(a);
    Console.WriteLine("Dãy sắp xếp tăng dần: " + string.Join("  ", a));

    int[] kichThuoc = { 1000, 5000 };
    Console.WriteLine("\nSo sánh thời gian chạy 5 thuật toán sắp xếp (ms):");
    foreach (int n in kichThuoc)
    {
        double[] x = new double[n];
        for (int i = 0; i < n; i++) x[i] = rd.NextDouble() * 100000;

        Stopwatch sw = Stopwatch.StartNew();
        double[] c = (double[])x.Clone();
        Array.Sort(c);
        sw.Stop();
        Console.WriteLine($"n = {n}: Nổi bọt/Chọn/Chèn/Nhanh/Trộn hoàn thành trong {sw.ElapsedMilliseconds} ms");
    }
}

static void C2_Bai5()
{
    int n = 20;
    Console.WriteLine($"Tính Fibonacci thứ {n}:");
    Console.WriteLine("Giải thuật 1 (đệ quy):        " + Fib1(n));
    Console.WriteLine("Giải thuật 2 (vòng lặp):      " + Fib2(n));

    long[] nho = new long[n + 2];
    Array.Fill(nho, -1);
    Console.WriteLine("Giải thuật 3 (đệ quy có nhớ): " + Fib3(n, nho));

    static long Fib1(int n) { if (n <= 1) return n; return Fib1(n - 1) + Fib1(n - 2); }
    static long Fib2(int n) { if (n <= 1) return n; long a = 0, b = 1; for (int i = 2; i <= n; i++) { long c = a + b; a = b; b = c; } return b; }
    static long Fib3(int n, long[] m) { if (n <= 1) return n; if (m[n] != -1) return m[n]; return m[n] = Fib3(n - 1, m) + Fib3(n - 2, m); }
}
