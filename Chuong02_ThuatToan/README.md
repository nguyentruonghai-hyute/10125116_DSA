# Chương 02 – Thuật toán & Tháp Hà Nội

Họ tên: Nguyễn Trường Hải · MSV: 10125116 · Lớp: 10125N.1

## Bài đã làm
- Bài 1: Bài toán Tháp Hà Nội
- Bài 2: So sánh tìm kiếm tuần tự và nhị phân
- Bài 3: Kiểm tra số nguyên tố (2 giải thuật $O(n)$ và $O(\sqrt{n})$)
- Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp
- Bài 5: Các giải thuật tính Fibonacci (đệ quy, vòng lặp, đệ quy có nhớ)

## Cách chạy
```
dotnet run --project Chuong02_ThuatToan
```

## Kết quả chạy
```
============================================================
CHƯƠNG 2 - THUẬT TOÁN & THÁP HÀ NỘI (BÀI 1 ĐẾN 6)
Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1
============================================================

=== Bài 1: Bài toán Tháp Hà Nội ===
Chạy thử Tháp Hà Nội với 3 đĩa:
Chuyển đĩa 1 từ A sang C
Chuyển đĩa 2 từ A sang B
Chuyển đĩa 1 từ C sang B
Chuyển đĩa 3 từ A sang C
Chuyển đĩa 1 từ B sang A
Chuyển đĩa 2 từ B sang C
Chuyển đĩa 1 từ A sang C
Tổng số lần chuyển: 7

=== Bài 2: So sánh tìm kiếm tuần tự và nhị phân ===
n = 1000: Tuần tự = 833 ticks, Nhị phân = 738 ticks
n = 100000: Tuần tự = 14321 ticks, Nhị phân = 12 ticks
n = 1000000: Tuần tự = 142950 ticks, Nhị phân = 11 ticks

=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===
Kiểm tra số 37:
Giải thuật 1 (O(n)): 37 là số nguyên tố
Giải thuật 2 (O(sqrt(n))): 37 là số nguyên tố

=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===
Dãy ban đầu: 63.37  35.7  25.42  98.97  69.35  22.37  94.37  21.61  92.04  91.25
Dãy sắp xếp tăng dần: 21.61  22.37  25.42  35.7  63.37  69.35  91.25  92.04  94.37  98.97

So sánh thời gian chạy 5 thuật toán sắp xếp (ms):
n = 1000: Nổi bọt/Chọn/Chèn/Nhanh/Trộn hoàn thành trong 0 ms
n = 5000: Nổi bọt/Chọn/Chèn/Nhanh/Trộn hoàn thành trong 1 ms

=== Bài 5: 4 giải thuật tính Fibonacci ===
Tính Fibonacci thứ 20:
Giải thuật 1 (đệ quy):        6765
Giải thuật 2 (vòng lặp):      6765
Giải thuật 3 (đệ quy có nhớ): 6765

============================================================
HOÀN THÀNH BÀI TẬP CHƯƠNG 2!
============================================================
```
