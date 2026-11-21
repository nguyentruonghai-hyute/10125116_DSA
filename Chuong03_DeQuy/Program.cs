using System;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("============================================================");
Console.WriteLine("CHƯƠNG 3 - CÁC BÀI TOÁN ĐỆ QUY KINH ĐIỂN (BÀI 1 ĐẾN 8)");
Console.WriteLine("Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1");
Console.WriteLine("============================================================\n");

Console.WriteLine("=== Bài 1: Tính S(n) = 1 + 2 + ... + n ===");
C3_Bai1();

Console.WriteLine("\n=== Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2 ===");
C3_Bai2();

Console.WriteLine("\n=== Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n ===");
C3_Bai3();

Console.WriteLine("\n=== Bài 4: Tính x^n ===");
C3_Bai4();

Console.WriteLine("\n=== Bài 5: Tìm ước số lẻ lớn nhất của n ===");
C3_Bai5();

Console.WriteLine("\n=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===");
C3_Bai6();

Console.WriteLine("\n=== Bài 7: Đếm số lượng chữ số của n ===");
C3_Bai7();

Console.WriteLine("\n=== Bài 8: Tính căn bậc 2 lồng nhau S(n) ===");
C3_Bai8();

Console.WriteLine("\n============================================================");
Console.WriteLine("HOÀN THÀNH BÀI TẬP CHƯƠNG 3!");
Console.WriteLine("============================================================");

// =========================================================================
// CÁC HÀM XỬ LÝ CHI TIẾT CHƯƠNG 3
// =========================================================================

static void C3_Bai1()
{
    int n = 10;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S1(n)}");
    static int S1(int n) => n == 1 ? 1 : S1(n - 1) + n;
}

static void C3_Bai2()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S2(n)}");
    static int S2(int n) => n == 1 ? 1 : S2(n - 1) + n * n;
}

static void C3_Bai3()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S3(n):F4}");
    static double S3(int n) => n == 1 ? 1 : S3(n - 1) + 1.0 / n;
}

static void C3_Bai4()
{
    double x = 2.0; int n = 5;
    Console.WriteLine($"Nhập x: {x}, n: {n} -> {x}^{n} = {Pow(x, n)}");
    static double Pow(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0) return 1.0 / Pow(x, -n);
        return Pow(x, n - 1) * x;
    }
}

static void C3_Bai5()
{
    int n = 100;
    Console.WriteLine($"Nhập n: {n} -> Ước lẻ lớn nhất của {n} là: {UocLe(n)}");
    static int UocLe(int n) => (n % 2 == 1) ? n : UocLe(n / 2);
}

static void C3_Bai6()
{
    int a = 48, b = 18;
    Console.WriteLine($"Nhập a: {a}, b: {b} -> UCLN({a}, {b}) = {UCLN(a, b)}");
    static int UCLN(int a, int b) => (a % b == 0) ? b : UCLN(b, a % b);
}

static void C3_Bai7()
{
    long n = 10125116;
    Console.WriteLine($"Nhập n: {n} -> Số {n} có {SoCS(n)} chữ số");
    static int SoCS(long n) => (n == 0) ? 0 : SoCS(n / 10) + 1;
}

static void C3_Bai8()
{
    int n = 4;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {Can(1, n):F4}");
    static double Can(int i, int n) => (i == n) ? Math.Sqrt(n) : Math.Sqrt(i + Can(i + 1, n));
}
