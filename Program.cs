////////using System;
////////using System.Security.Cryptography.X509Certificates;
////////using System.Text;
////////namespace bt
////////{
////////    class Nhap
////////    {
////////        int n;
////////        int[] so;

////////        public void Nhapso()
////////        {
////////            Console.Write("Nhập số lượng phần tử :  ");

////////            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
////////            {
////////                Console.Write("Gía trị ko hợp lệ , nhập lại");
////////            }

////////            so = new int[n];


////////            for (int i = 0; i < n; i++)
////////            {
////////                Console.Write($"Nhập số thứ {i + 1} :");
////////                while (!int.TryParse(Console.ReadLine(), out so[i]))
////////                {
////////                    Console.Write($"sai định dạng , nhập lại số thứ {i + 1}");
////////                }
////////            }
////////        }

////////        public void XuatMang()
////////        {
////////            Console.Write("Danh sách : ");
////////            for (int i = 0; i < n; i++)
////////            {

////////                Console.Write(so[i] + " ");
////////            }
////////            Console.WriteLine();
////////        }

////////        public void Sosanh()
////////        {
////////            int max = so[0];
////////            int min = so[0];
////////            for(int i = 0; i < n-1; i++)
////////            {
////////                if ( so[i]>max)
////////                {
////////                    max= so[i];
////////                }
////////                if (so[i] < min)
////////                {
////////                    min= so[i];
////////                }
////////            }
////////            Console.WriteLine($"Số lớn nhất  {max} "  );
////////            Console.WriteLine($"Số nhỏ nhất  {min} ");
////////        }

////////    }


////////    class Programe
////////    {
////////        public static void Main(string[] args)
////////        {
////////            Console.OutputEncoding = Encoding.UTF8;
////////            Nhap x = new Nhap();
////////            x.Nhapso();
////////            x.XuatMang();
////////            x.Sosanh();
////////        }

////////    }
////////}
//////using System;
//////using System.Text;

//////namespace bt
//////{
//////    // ==========================================
//////    // BÀI TẬP 2: BÀI TOÁN FIZZBUZZ
//////    // ==========================================
//////    class Bai2
//////    {
//////        public void GiaiFizzBuzz()
//////        {
//////            Console.WriteLine("\n--- BÀI 2: FIZZBUZZ TỪ 1 ĐẾN 100 ---");
//////            for (int i = 1; i <= 100; i++)
//////            {
//////                // Phải kiểm tra chia hết cho cả 3 và 5 trước tiên
//////                if (i % 3 == 0 && i % 5 == 0)
//////                {
//////                    Console.Write("FizzBuzz ");
//////                }
//////                else if (i % 3 == 0)
//////                {
//////                    Console.Write("Fizz ");
//////                }
//////                else if (i % 5 == 0)
//////                {
//////                    Console.Write("Buzz ");
//////                }
//////                else
//////                {
//////                    Console.Write(i + " ");
//////                }
//////            }
//////            Console.WriteLine("\n");
//////        }
//////    }

//////    // ==========================================
//////    // BÀI TẬP 3: ĐẢO NGƯỢC CHUỖI
//////    // ==========================================
//////    class Bai3
//////    {
//////        public void DaoNguocChuoi()
//////        {
//////            Console.WriteLine("\n--- BÀI 3: ĐẢO NGƯỢC CHUỖI ---");
//////            Console.Write("Nhập vào một chuỗi bất kỳ: ");

//////            // Dùng ?? "" để tránh cảnh báo null CS8600
//////            string chuoiGoc = Console.ReadLine() ?? "";

//////            char[] mangKyTu = new char[chuoiGoc.Length];
//////            int j = 0;

//////            // Duyệt ngược từ cuối chuỗi về đầu chuỗi
//////            for (int i = chuoiGoc.Length - 1; i >= 0; i--)
//////            {
//////                mangKyTu[j] = chuoiGoc[i];
//////                j++;
//////            }

//////            string chuoiDaoNguoc = new string(mangKyTu);
//////            Console.WriteLine($"Chuỗi đảo ngược là: {chuoiDaoNguoc}\n");
//////        }
//////    }

//////    // ==========================================
//////    // BÀI TẬP 4: MẢNG NGẪU NHIÊN 1000 PHẦN TỬ
//////    // ==========================================
//////    class Bai4
//////    {
//////        int[] arr = new int[1000];

//////        // Sinh ngẫu nhiên 1000 số tự nhiên
//////        public void TaoMangNgauNhien()
//////        {
//////            Random rd = new Random();
//////            for (int i = 0; i < arr.Length; i++)
//////            {
//////                // Sinh số tự nhiên ngẫu nhiên từ 0 đến 9999
//////                arr[i] = rd.Next(0, 10000);
//////            }
//////        }

//////        // Câu a: In mảng ra màn hình
//////        public void InMang()
//////        {
//////            for (int i = 0; i < arr.Length; i++)
//////            {
//////                Console.Write(arr[i] + "\t");
//////            }
//////            Console.WriteLine("\n");
//////        }

//////        // Câu b: Sắp xếp mảng theo chiều tăng dần (Interchange Sort)
//////        public void SapXepTangDan()
//////        {
//////            for (int i = 0; i < arr.Length - 1; i++)
//////            {
//////                for (int j = i + 1; j < arr.Length; j++)
//////                {
//////                    if (arr[i] > arr[j])
//////                    {
//////                        int temp = arr[i];
//////                        arr[i] = arr[j];
//////                        arr[j] = temp;
//////                    }
//////                }
//////            }
//////        }

//////        public void ChayBai4()
//////        {
//////            Console.WriteLine("\n--- BÀI 4: MẢNG NGẪU NHIÊN 1000 SỐ TỰ NHIÊN ---");
//////            TaoMangNgauNhien();

//////            Console.WriteLine("a. Mảng 1000 số ngẫu nhiên ban đầu:");
//////            InMang();

//////            SapXepTangDan();
//////            Console.WriteLine("b. Mảng sau khi sắp xếp tăng dần:");
//////            InMang();
//////        }
//////    }

//////    // ==========================================
//////    // BÀI TẬP 5: TÌM SỐ FIBONACCI THỨ N
//////    // ==========================================
//////    class Bai5
//////    {
//////        public void TimFibonacci()
//////        {
//////            Console.WriteLine("\n--- BÀI 5: TÌM SỐ FIBONACCI THỨ N ---");
//////            int n;
//////            Console.Write("Nhập số nguyên dương n (n >= 1): ");

//////            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
//////            {
//////                Console.Write("Giá trị không hợp lệ! Vui lòng nhập số nguyên dương n: ");
//////            }

//////            // Quy ước theo dãy đề bài: 0, 1, 1, 2, 3, 5, 8...
//////            // Số thứ 1 là 0; số thứ 2 là 1; số thứ 3 là 1...
//////            long f1 = 0;
//////            long f2 = 1;
//////            long fn = 0;

//////            if (n == 1)
//////            {
//////                fn = f1;
//////            }
//////            else if (n == 2)
//////            {
//////                fn = f2;
//////            }
//////            else
//////            {
//////                for (int i = 3; i <= n; i++)
//////                {
//////                    fn = f1 + f2;
//////                    f1 = f2;
//////                    f2 = fn;
//////                }
//////            }

//////            Console.WriteLine($"Số Fibonacci thứ {n} trong dãy là: {fn}\n");
//////        }
//////    }

//////    // ==========================================
//////    // CHƯƠNG TRÌNH CHÍNH (MENU CHỌN BÀI)
//////    // ==========================================
//////    class Program
//////    {
//////        public static void Main(string[] args)
//////        {
//////            // Hỗ trợ nhập và xuất tiếng Việt có dấu chuẩn UTF-8
//////            Console.InputEncoding = Encoding.UTF8;
//////            Console.OutputEncoding = Encoding.UTF8;

//////            int chon;
//////            do
//////            {
//////                Console.WriteLine("=========================================");
//////                Console.WriteLine("   CHỌN BÀI TẬP THỰC HÀNH (BÀI 2 - 5)    ");
//////                Console.WriteLine("=========================================");
//////                Console.WriteLine("2. Bài tập 2: Bài toán FizzBuzz");
//////                Console.WriteLine("3. Bài tập 3: Đảo ngược chuỗi");
//////                Console.WriteLine("4. Bài tập 4: Mảng ngẫu nhiên 1000 số");
//////                Console.WriteLine("5. Bài tập 5: Tìm số Fibonacci thứ n");
//////                Console.WriteLine("0. Thoát chương trình");
//////                Console.Write("Nhập lựa chọn của bạn: ");

//////                while (!int.TryParse(Console.ReadLine(), out chon))
//////                {
//////                    Console.Write("Vui lòng nhập số tương ứng trên menu: ");
//////                }

//////                switch (chon)
//////                {
//////                    case 2:
//////                        new Bai2().GiaiFizzBuzz();
//////                        break;
//////                    case 3:
//////                        new Bai3().DaoNguocChuoi();
//////                        break;
//////                    case 4:
//////                        new Bai4().ChayBai4();
//////                        break;
//////                    case 5:
//////                        new Bai5().TimFibonacci();
//////                        break;
//////                    case 0:
//////                        Console.WriteLine("Đã thoát chương trình!");
//////                        break;
//////                    default:
//////                        Console.WriteLine("Lựa chọn không tồn tại, hãy chọn lại!\n");
//////                        break;
//////                }
//////            } while (chon != 0);
//////        }
//////    }
//////}
////using System;
////using System.Diagnostics;
////using System.Text;

////namespace bt
////{
////    // ========================================================
////    // BÀI TẬP 1: THÁP HÀ NỘI (ĐỆ QUY & ĐO THỜI GIAN)
////    // ========================================================
////    class Bai1_ThapHaNoi
////    {
////        long soBuoc = 0;

////        void ChuyenDia(int n, char cotNguon, char cotTrungGian, char cotDich, bool inChiTiet)
////        {
////            if (n == 1)
////            {
////                soBuoc++;
////                if (inChiTiet)
////                    Console.WriteLine($"  Bước {soBuoc}: Chuyển đĩa 1 từ {cotNguon} -> {cotDich}");
////                return;
////            }
////            ChuyenDia(n - 1, cotNguon, cotDich, cotTrungGian, inChiTiet);
////            soBuoc++;
////            if (inChiTiet)
////                Console.WriteLine($"  Bước {soBuoc}: Chuyển đĩa {n} từ {cotNguon} -> {cotDich}");
////            ChuyenDia(n - 1, cotTrungGian, cotNguon, cotDich, inChiTiet);
////        }

////        public void Chay()
////        {
////            Console.WriteLine("\n--- BÀI 1: THÁP HÀ NỘI ---");
////            Console.Write("Nhập số đĩa n (nhập <= 5 để xem chi tiết bước, nhập 20-28 để đo thời gian): ");
////            int n;
////            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 30)
////            {
////                Console.Write("Vui lòng nhập số nguyên n (1 <= n <= 30): ");
////            }

////            soBuoc = 0;
////            bool inChiTiet = (n <= 5);

////            Stopwatch sw = Stopwatch.StartNew();
////            ChuyenDia(n, 'A', 'B', 'C', inChiTiet);
////            sw.Stop();

////            Console.WriteLine($"Tổng số bước di chuyển (2^n - 1): {soBuoc}");
////            Console.WriteLine($"Thời gian thực thi: {sw.Elapsed.TotalMilliseconds:F4} ms\n");
////        }
////    }

////    // ========================================================
////    // BÀI TẬP 2: TÌM KIẾM NHỊ PHÂN (BINARY SEARCH)
////    // ========================================================
////    class Bai2_TimKiemNhiPhan
////    {
////        int BinarySearch(int[] arr, int x)
////        {
////            int left = 0, right = arr.Length - 1;
////            while (left <= right)
////            {
////                int mid = left + (right - left) / 2;
////                if (arr[mid] == x) return mid;
////                if (arr[mid] < x) left = mid + 1;
////                else right = mid - 1;
////            }
////            return -1;
////        }

////        public void Chay()
////        {
////            Console.WriteLine("\n--- BÀI 2: TÌM KIẾM NHỊ PHÂN ---");
////            int n = 10_000_000; // Mảng 10 triệu phần tử đã sắp xếp
////            int[] arr = new int[n];
////            for (int i = 0; i < n; i++) arr[i] = i * 2; // 0, 2, 4, ..., 19999998

////            Console.Write($"Nhập số nguyên cần tìm trong mảng {n:N0} phần tử chẵn: ");
////            int x;
////            while (!int.TryParse(Console.ReadLine(), out x))
////            {
////                Console.Write("Sai định dạng, nhập lại số nguyên: ");
////            }

////            Stopwatch sw = Stopwatch.StartNew();
////            int viTri = BinarySearch(arr, x);
////            sw.Stop();

////            if (viTri != -1)
////                Console.WriteLine($"Tìm thấy {x} tại chỉ số index = {viTri}");
////            else
////                Console.WriteLine($"Không tìm thấy {x} trong mảng.");

////            Console.WriteLine($"Thời gian tìm kiếm (O(log n)): {sw.Elapsed.TotalMilliseconds:F6} ms ({sw.ElapsedTicks} ticks)\n");
////        }
////    }

////    // ========================================================
////    // BÀI TẬP 3: KIỂM TRA SỐ NGUYÊN TỐ (2 GIẢI THUẬT)
////    // ========================================================
////    class Bai3_SoNguyenTo
////    {
////        // Giải thuật 1: Duyệt từ 2 đến n - 1 -> O(n)
////        bool LaNguyenTo_CoBan(long n)
////        {
////            if (n < 2) return false;
////            for (long i = 2; i <= n - 1; i++)
////            {
////                if (n % i == 0) return false;
////            }
////            return true;
////        }

////        // Giải thuật 2: Duyệt từ 2 đến căn bậc hai của n -> O(sqrt(n))
////        bool LaNguyenTo_CaiTien(long n)
////        {
////            if (n < 2) return false;
////            long can = (long)Math.Sqrt(n);
////            for (long i = 2; i <= can; i++)
////            {
////                if (n % i == 0) return false;
////            }
////            return true;
////        }

////        public void Chay()
////        {
////            Console.WriteLine("\n--- BÀI 3: KIỂM TRA SỐ NGUYÊN TỐ ---");
////            Console.Write("Nhập số nguyên dương n (gợi ý thử số nguyên tố lớn như 100000007): ");
////            long n;
////            while (!long.TryParse(Console.ReadLine(), out n) || n <= 0)
////            {
////                Console.Write("Vui lòng nhập số nguyên dương n > 0: ");
////            }

////            Stopwatch sw1 = Stopwatch.StartNew();
////            bool kq1 = LaNguyenTo_CoBan(n);
////            sw1.Stop();

////            Stopwatch sw2 = Stopwatch.StartNew();
////            bool kq2 = LaNguyenTo_CaiTien(n);
////            sw2.Stop();

////            Console.WriteLine($"\nKết quả: {n} {(kq2 ? "LÀ" : "KHÔNG PHẢI")} số nguyên tố.");
////            Console.WriteLine("------------------------------------------------------------------");
////            Console.WriteLine($"{"Giải thuật",-32} | {"Độ phức tạp",-12} | {"Thời gian (ms)",-15}");
////            Console.WriteLine("------------------------------------------------------------------");
////            Console.WriteLine($"{"1. Cơ bản (2 -> n-1)",-32} | {"O(n)",-12} | {sw1.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine($"{"2. Cải tiến (2 -> sqrt(n))",-32} | {"O(sqrt(n))",-12} | {sw2.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine("------------------------------------------------------------------\n");
////        }
////    }

////    // ========================================================
////    // BÀI TẬP 4: LIỆT KÊ SỐ HOÀN HẢO NHỎ HƠN N (2 GIẢI THUẬT)
////    // ========================================================
////    class Bai4_SoHoanHao
////    {
////        // Giải thuật 1: Tìm ước từ 1 đến k - 1 -> O(N^2)
////        bool LaSoHoanHao_CoBan(int k)
////        {
////            if (k < 2) return false;
////            int tongUoc = 0;
////            for (int i = 1; i <= k - 1; i++)
////            {
////                if (k % i == 0) tongUoc += i;
////            }
////            return tongUoc == k;
////        }

////        // Giải thuật 2: Tìm ước đến sqrt(k) -> O(N * sqrt(N))
////        bool LaSoHoanHao_CaiTien(int k)
////        {
////            if (k < 2) return false;
////            int tongUoc = 1; // 1 luôn là ước của mọi số k >= 2
////            int can = (int)Math.Sqrt(k);
////            for (int i = 2; i <= can; i++)
////            {
////                if (k % i == 0)
////                {
////                    tongUoc += i;
////                    if (i != k / i) tongUoc += (k / i);
////                }
////            }
////            return tongUoc == k;
////        }

////        public void Chay()
////        {
////            Console.WriteLine("\n--- BÀI 4: LIỆT KÊ SỐ HOÀN HẢO NHỎ HƠN N ---");
////            Console.Write("Nhập số nguyên dương N (gợi ý N = 10000 hoặc 30000): ");
////            int N;
////            while (!int.TryParse(Console.ReadLine(), out N) || N <= 1)
////            {
////                Console.Write("Vui lòng nhập N > 1: ");
////            }

////            // Đo Giải thuật 1
////            Stopwatch sw1 = Stopwatch.StartNew();
////            for (int k = 2; k < N; k++) LaSoHoanHao_CoBan(k);
////            sw1.Stop();

////            // Đo Giải thuật 2 và lưu kết quả in ra màn hình
////            string ketQua = "";
////            Stopwatch sw2 = Stopwatch.StartNew();
////            for (int k = 2; k < N; k++)
////            {
////                if (LaSoHoanHao_CaiTien(k)) ketQua += k + " ";
////            }
////            sw2.Stop();

////            Console.WriteLine($"\nCác số hoàn hảo nhỏ hơn {N}: {(ketQua == "" ? "Không có" : ketQua)}");
////            Console.WriteLine("------------------------------------------------------------------");
////            Console.WriteLine($"{"Giải thuật",-32} | {"Độ phức tạp",-12} | {"Thời gian (ms)",-15}");
////            Console.WriteLine("------------------------------------------------------------------");
////            Console.WriteLine($"{"1. Cơ bản (ước 1 -> k-1)",-32} | {"O(N^2)",-12} | {sw1.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine($"{"2. Cải tiến (ước 2 -> sqrt(k))",-32} | {"O(N*sqrt(N))",-12} | {sw2.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine("------------------------------------------------------------------\n");
////        }
////    }

////    // ========================================================
////    // BÀI TẬP 5: TÌM SỐ FIBONACCI THỨ N (3 GIẢI THUẬT)
////    // ========================================================
////    class Bai5_Fibonacci
////    {
////        // Giải thuật 1: Đệ quy trực tiếp -> O(2^n)
////        long Fib_DeQuy(int n)
////        {
////            if (n == 0) return 0;
////            if (n == 1) return 1;
////            return Fib_DeQuy(n - 1) + Fib_DeQuy(n - 2);
////        }

////        // Giải thuật 2: Đệ quy có nhớ (Memoization) -> O(n)
////        long Fib_CoNho(int n, long[] memo)
////        {
////            if (n == 0) return 0;
////            if (n == 1) return 1;
////            if (memo[n] != -1) return memo[n];
////            memo[n] = Fib_CoNho(n - 1, memo) + Fib_CoNho(n - 2, memo);
////            return memo[n];
////        }

////        // Giải thuật 3: Vòng lặp (Bottom-Up) -> O(n)
////        long Fib_VongLap(int n)
////        {
////            if (n == 0) return 0;
////            if (n == 1) return 1;
////            long f0 = 0, f1 = 1, fn = 0;
////            for (int i = 2; i <= n; i++)
////            {
////                fn = f0 + f1;
////                f0 = f1;
////                f1 = fn;
////            }
////            return fn;
////        }

////        public void Chay()
////        {
////            Console.WriteLine("\n--- BÀI 5: TÌM SỐ FIBONACCI THỨ N (F0=0, F1=1) ---");
////            Console.Write("Nhập số nguyên n >= 0 (gợi ý thử n = 38 hoặc 42 để thấy rõ chênh lệch): ");
////            int n;
////            while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 90)
////            {
////                Console.Write("Vui lòng nhập n trong khoảng [0..90]: ");
////            }

////            // 1. Đo Đệ quy trực tiếp (chỉ chạy nếu n <= 43 để tránh treo máy quá lâu)
////            string timeDeQuy = "Bỏ qua (n > 43 quá lâu)";
////            if (n <= 43)
////            {
////                Stopwatch sw1 = Stopwatch.StartNew();
////                Fib_DeQuy(n);
////                sw1.Stop();
////                timeDeQuy = $"{sw1.Elapsed.TotalMilliseconds:F4} ms";
////            }

////            // 2. Đo Đệ quy có nhớ
////            long[] memo = new long[n + 1];
////            Array.Fill(memo, -1);
////            Stopwatch sw2 = Stopwatch.StartNew();
////            long kq2 = Fib_CoNho(n, memo);
////            sw2.Stop();

////            // 3. Đo Vòng lặp
////            Stopwatch sw3 = Stopwatch.StartNew();
////            long kq3 = Fib_VongLap(n);
////            sw3.Stop();

////            Console.WriteLine($"\nGiá trị Fibonacci F({n}) = {kq3}");
////            Console.WriteLine("-----------------------------------------------------------------------");
////            Console.WriteLine($"{"Giải thuật",-32} | {"Độ phức tạp",-12} | {"Thời gian (ms)",-20}");
////            Console.WriteLine("-----------------------------------------------------------------------");
////            Console.WriteLine($"{"1. Đệ quy trực tiếp",-32} | {"O(2^n)",-12} | {timeDeQuy}");
////            Console.WriteLine($"{"2. Đệ quy có nhớ (Memoization)",-32} | {"O(n)",-12} | {sw2.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine($"{"3. Vòng lặp (Iteration)",-32} | {"O(n)",-12} | {sw3.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine("-----------------------------------------------------------------------\n");
////        }
////    }

////    // ========================================================
////    // BÀI TẬP 6: SẮP XẾP DÃY N SỐ THỰC (3 GIẢI THUẬT)
////    // ========================================================
////    class Bai6_SapXep
////    {
////        // Giải thuật 1: Bubble Sort -> O(n^2)
////        void BubbleSort(double[] a)
////        {
////            int n = a.Length;
////            for (int i = 0; i < n - 1; i++)
////            {
////                bool swapped = false;
////                for (int j = 0; j < n - i - 1; j++)
////                {
////                    if (a[j] > a[j + 1])
////                    {
////                        double temp = a[j];
////                        a[j] = a[j + 1];
////                        a[j + 1] = temp;
////                        swapped = true;
////                    }
////                }
////                if (!swapped) break;
////            }
////        }

////        // Giải thuật 2: Insertion Sort -> O(n^2)
////        void InsertionSort(double[] a)
////        {
////            int n = a.Length;
////            for (int i = 1; i < n; i++)
////            {
////                double key = a[i];
////                int j = i - 1;
////                while (j >= 0 && a[j] > key)
////                {
////                    a[j + 1] = a[j];
////                    j--;
////                }
////                a[j + 1] = key;
////            }
////        }

////        // Giải thuật 3: Quick Sort -> O(n log n)
////        void QuickSort(double[] a, int left, int right)
////        {
////            int i = left, j = right;
////            double pivot = a[left + (right - left) / 2];

////            while (i <= j)
////            {
////                while (a[i] < pivot) i++;
////                while (a[j] > pivot) j--;
////                if (i <= j)
////                {
////                    double temp = a[i];
////                    a[i] = a[j];
////                    a[j] = temp;
////                    i++;
////                    j--;
////                }
////            }
////            if (left < j) QuickSort(a, left, j);
////            if (i < right) QuickSort(a, i, right);
////        }

////        public void Chay()
////        {
////            Console.WriteLine("\n--- BÀI 6: SẮP XẾP DÃY N SỐ THỰC TĂNG DẦN ---");
////            Console.Write("Nhập số lượng phần tử n (gợi ý n = 10000 hoặc 20000 để so sánh): ");
////            int n;
////            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
////            {
////                Console.Write("Vui lòng nhập số nguyên dương n > 0: ");
////            }

////            // Sinh ngẫu nhiên n số thực
////            Random rd = new Random();
////            double[] mangGoc = new double[n];
////            for (int i = 0; i < n; i++)
////            {
////                mangGoc[i] = Math.Round(rd.NextDouble() * 1000, 2);
////            }

////            // Nhân bản 3 mảng giống hệt nhau để so sánh công bằng
////            double[] arr1 = (double[])mangGoc.Clone();
////            double[] arr2 = (double[])mangGoc.Clone();
////            double[] arr3 = (double[])mangGoc.Clone();

////            Stopwatch sw1 = Stopwatch.StartNew();
////            BubbleSort(arr1);
////            sw1.Stop();

////            Stopwatch sw2 = Stopwatch.StartNew();
////            InsertionSort(arr2);
////            sw2.Stop();

////            Stopwatch sw3 = Stopwatch.StartNew();
////            QuickSort(arr3, 0, arr3.Length - 1);
////            sw3.Stop();

////            if (n <= 20)
////            {
////                Console.WriteLine("Mảng gốc:     " + string.Join(" | ", mangGoc));
////                Console.WriteLine("Sau sắp xếp:  " + string.Join(" | ", arr3));
////            }

////            Console.WriteLine($"\nBảng so sánh thời gian sắp xếp {n:N0} số thực:");
////            Console.WriteLine("------------------------------------------------------------------");
////            Console.WriteLine($"{"Giải thuật",-32} | {"Độ phức tạp",-12} | {"Thời gian (ms)",-15}");
////            Console.WriteLine("------------------------------------------------------------------");
////            Console.WriteLine($"{"1. Bubble Sort (Nổi bọt)",-32} | {"O(n^2)",-12} | {sw1.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine($"{"2. Insertion Sort (Chèn)",-32} | {"O(n^2)",-12} | {sw2.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine($"{"3. Quick Sort (Nhanh)",-32} | {"O(n log n)",-12} | {sw3.Elapsed.TotalMilliseconds:F4} ms");
////            Console.WriteLine("------------------------------------------------------------------\n");
////        }
////    }

////    // ========================================================
////    // CHƯƠNG TRÌNH CHÍNH (MENU CHỌN BÀI 1 - 6)
////    // ========================================================
////    class Program
////    {
////        public static void Main(string[] args)
////        {
////            Console.InputEncoding = Encoding.UTF8;
////            Console.OutputEncoding = Encoding.UTF8;

////            int chon;
////            do
////            {
////                Console.WriteLine("======================================================");
////                Console.WriteLine("   BÀI TẬP ÁP DỤNG 2.5.2 (BÀI 1 ĐẾN BÀI 6 - C#)       ");
////                Console.WriteLine("======================================================");
////                Console.WriteLine("1. Bài tập 1: Tháp Hà Nội");
////                Console.WriteLine("2. Bài tập 2: Tìm kiếm nhị phân (Binary Search)");
////                Console.WriteLine("3. Bài tập 3: Kiểm tra số nguyên tố");
////                Console.WriteLine("4. Bài tập 4: Liệt kê số hoàn hảo nhỏ hơn N");
////                Console.WriteLine("5. Bài tập 5: Tìm số Fibonacci thứ n");
////                Console.WriteLine("6. Bài tập 6: Sắp xếp dãy n số thực");
////                Console.WriteLine("0. Thoát chương trình");
////                Console.Write("Chọn bài muốn chạy: ");

////                while (!int.TryParse(Console.ReadLine(), out chon))
////                {
////                    Console.Write("Vui lòng nhập số từ 0 đến 6: ");
////                }

////                switch (chon)
////                {
////                    case 1: new Bai1_ThapHaNoi().Chay(); break;
////                    case 2: new Bai2_TimKiemNhiPhan().Chay(); break;
////                    case 3: new Bai3_SoNguyenTo().Chay(); break;
////                    case 4: new Bai4_SoHoanHao().Chay(); break;
////                    case 5: new Bai5_Fibonacci().Chay(); break;
////                    case 6: new Bai6_SapXep().Chay(); break;
////                    case 0: Console.WriteLine("Đã thoát chương trình!"); break;
////                    default: Console.WriteLine("Lựa chọn không hợp lệ!\n"); break;
////                }
////            } while (chon != 0);
////        }
////    }
////}
//using System;
//using System.Text;

//namespace bt
//{
//    class BaiTapDeQuy
//    {
//        // ========================================================
//        // BÀI TẬP 1: S(n) = 1 + 2 + 3 + ... + n
//        // ========================================================
//        public long Bai1_TongN(int n)
//        {
//            if (n == 1) return 1;
//            return Bai1_TongN(n - 1) + n;
//        }

//        // ========================================================
//        // BÀI TẬP 2: S(n) = 1 + 2^2 + 3^2 + ... + n^2
//        // ========================================================
//        public long Bai2_TongBinhPhuong(int n)
//        {
//            if (n == 1) return 1;
//            return Bai2_TongBinhPhuong(n - 1) + (long)n * n;
//        }

//        // ========================================================
//        // BÀI TẬP 3: S(n) = 1 + 1/2 + 1/3 + ... + 1/n
//        // ========================================================
//        public double Bai3_TongPhanSo(int n)
//        {
//            if (n == 1) return 1.0;
//            return Bai3_TongPhanSo(n - 1) + 1.0 / n;
//        }

//        // ========================================================
//        // BÀI TẬP 4: S(x, n) = x^n (Hỗ trợ cả số mũ âm và dương)
//        // ========================================================
//        private double LuyThua(double x, int N)
//        {
//            if (N == 0) return 1.0;
//            return LuyThua(x, N - 1) * x;
//        }

//        public double Bai4_TinhMu(double x, int n)
//        {
//            if (n < 0) return 1.0 / LuyThua(x, -n);
//            return LuyThua(x, n);
//        }

//        // ========================================================
//        // BÀI TẬP 5: TÌM ƯỚC SỐ LẺ LỚN NHẤT CỦA N
//        // ========================================================
//        public int Bai5_UocLeMax(int n)
//        {
//            if (n % 2 == 1) return n;
//            return Bai5_UocLeMax(n / 2);
//        }

//        // ========================================================
//        // BÀI TẬP 6: TÌM ƯỚC CHUNG LỚN NHẤT (EUCLID)
//        // ========================================================
//        public int Bai6_UCLN(int a, int b)
//        {
//            if (a % b == 0) return b;
//            return Bai6_UCLN(b, a % b);
//        }

//        // ========================================================
//        // BÀI TẬP 7: ĐẾM SỐ CHỮ SỐ CỦA SỐ NGUYÊN DƯƠNG N
//        // ========================================================
//        public int Bai7_SoChuSo(long n)
//        {
//            if (n == 0) return 0;
//            return Bai7_SoChuSo(n / 10) + 1;
//        }

//        // ========================================================
//        // BÀI TẬP 8: TÍNH TỔNG CĂN LỒNG NHAU S(n)
//        // ========================================================
//        private double Can(int i, int n)
//        {
//            if (i == n) return Math.Sqrt(n);
//            return Math.Sqrt(i + Can(i + 1, n));
//        }

//        public double Bai8_TongCan(int n)
//        {
//            return Can(1, n);
//        }
//    }

//    class Program
//    {
//        // Hàm hỗ trợ nhập số nguyên dương an toàn
//        static int NhapNguyenDuong(string thongBao)
//        {
//            int n;
//            Console.Write(thongBao);
//            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
//            {
//                Console.Write("Giá trị không hợp lệ! Vui lòng nhập số nguyên dương (> 0): ");
//            }
//            return n;
//        }

//        public static void Main(string[] args)
//        {
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;

//            BaiTapDeQuy dq = new BaiTapDeQuy();
//            int chon;

//            do
//            {
//                Console.WriteLine("======================================================");
//                Console.WriteLine("      BÀI TẬP ÁP DỤNG 3.7.2 - ĐỆ QUY (BÀI 1 - 8)      ");
//                Console.WriteLine("======================================================");
//                Console.WriteLine("1. Bài 1: Tính S(n) = 1 + 2 + ... + n");
//                Console.WriteLine("2. Bài 2: Tính S(n) = 1 + 2^2 + ... + n^2");
//                Console.WriteLine("3. Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n");
//                Console.WriteLine("4. Bài 4: Tính S(x, n) = x^n");
//                Console.WriteLine("5. Bài 5: Tìm ước số lẻ lớn nhất của n");
//                Console.WriteLine("6. Bài 6: Tìm ước chung lớn nhất của a và b");
//                Console.WriteLine("7. Bài 7: Đếm số chữ số của số nguyên dương n");
//                Console.WriteLine("8. Bài 8: Tính tổng căn bậc hai lồng nhau S(n)");
//                Console.WriteLine("0. Thoát chương trình");
//                Console.Write("Chọn bài muốn chạy: ");

//                while (!int.TryParse(Console.ReadLine(), out chon))
//                {
//                    Console.Write("Vui lòng nhập số từ 0 đến 8: ");
//                }

//                switch (chon)
//                {
//                    case 1:
//                        {
//                            int n = NhapNguyenDuong("Nhập số nguyên dương n: ");
//                            Console.WriteLine($"-> Kết quả S({n}) = {dq.Bai1_TongN(n)}\n");
//                            break;
//                        }
//                    case 2:
//                        {
//                            int n = NhapNguyenDuong("Nhập số nguyên dương n: ");
//                            Console.WriteLine($"-> Kết quả S({n}) = {dq.Bai2_TongBinhPhuong(n)}\n");
//                            break;
//                        }
//                    case 3:
//                        {
//                            int n = NhapNguyenDuong("Nhập số nguyên dương n: ");
//                            Console.WriteLine($"-> Kết quả S({n}) = {dq.Bai3_TongPhanSo(n):F6}\n");
//                            break;
//                        }
//                    case 4:
//                        {
//                            double x;
//                            Console.Write("Nhập cơ số thực x: ");
//                            while (!double.TryParse(Console.ReadLine(), out x))
//                            {
//                                Console.Write("Sai định dạng, nhập lại số thực x: ");
//                            }

//                            int n;
//                            Console.Write("Nhập số mũ nguyên n: ");
//                            while (!int.TryParse(Console.ReadLine(), out n) || (x == 0 && n < 0))
//                            {
//                                Console.Write("Số mũ không hợp lệ (lưu ý x = 0 không nhận mũ âm), nhập lại n: ");
//                            }

//                            Console.WriteLine($"-> Kết quả {x}^{n} = {dq.Bai4_TinhMu(x, n)}\n");
//                            break;
//                        }
//                    case 5:
//                        {
//                            int n = NhapNguyenDuong("Nhập số nguyên dương n (ví dụ 100): ");
//                            Console.WriteLine($"-> Ước số lẻ lớn nhất của {n} là: {dq.Bai5_UocLeMax(n)}\n");
//                            break;
//                        }
//                    case 6:
//                        {
//                            int a = NhapNguyenDuong("Nhập số nguyên dương a: ");
//                            int b = NhapNguyenDuong("Nhập số nguyên dương b: ");
//                            Console.WriteLine($"-> UCLN({a}, {b}) = {dq.Bai6_UCLN(a, b)}\n");
//                            break;
//                        }
//                    case 7:
//                        {
//                            long n;
//                            Console.Write("Nhập số nguyên dương n: ");
//                            while (!long.TryParse(Console.ReadLine(), out n) || n <= 0)
//                            {
//                                Console.Write("Vui lòng nhập số nguyên dương n > 0: ");
//                            }
//                            Console.WriteLine($"-> Số {n} có {dq.Bai7_SoChuSo(n)} chữ số.\n");
//                            break;
//                        }
//                    case 8:
//                        {
//                            int n = NhapNguyenDuong("Nhập số nguyên dương n: ");
//                            Console.WriteLine($"-> Kết quả tổng căn S({n}) = {dq.Bai8_TongCan(n):F6}\n");
//                            break;
//                        }
//                    case 0:
//                        Console.WriteLine("Đã thoát chương trình!");
//                        break;
//                    default:
//                        Console.WriteLine("Lựa chọn không hợp lệ, hãy nhập từ 0 đến 8!\n");
//                        break;
//                }
//            } while (chon != 0);
//        }
//    }
//}