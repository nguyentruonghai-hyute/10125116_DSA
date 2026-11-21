# Buổi 04 – Cây (Bài tập áp dụng Chương 6: Cây nhị phân)

Họ tên: Nguyễn Trường Hải · MSV: 10125116 · Lớp: 10125N.1

## Bài đã làm (Mục 6.7.2 – Bài tập 1 đến 8)
- **Bài tập 1:** Cài đặt thuật toán đếm số nút trên cây nhị phân (`DemSoNut`)
- **Bài tập 2:** Cài đặt thuật toán tính tổng giá trị các nút trên cây nhị phân (`TinhTongGiaTri`)
- **Bài tập 3:** Cài đặt thuật toán hiển thị giá trị các nút trên cây nhị phân (`HienThiCacNut`)
- **Bài tập 4:** Cài đặt thuật toán hiển thị giá trị các nút có giá trị chẵn trên cây nhị phân (`HienThiNutChan`)
- **Bài tập 5:** Cài đặt thuật toán đếm số lượng nút có giá trị chẵn trên cây nhị phân (`DemNutChan`)
- **Bài tập 6:** Cài đặt thuật toán đếm số con của một nút bất kỳ trên cây nhị phân (`DemSoConCuaNut`)
- **Bài tập 7:** Cài đặt thuật toán hiển thị giá trị các nút trên cây con trái của cây nhị phân (`HienThiCayConTrai`)
- **Bài tập 8:** Cài đặt thuật toán duyệt cây nhị phân theo 3 thứ tự: Tiền thứ tự (`NLR`), Trung thứ tự (`LNR`) và Hậu thứ tự (`LRN`)

## Cách chạy
```
dotnet run --project Buoi04_Cay
```

## Kết quả chạy
```
============================================================
BUỔI 04 - BÀI TẬP ÁP DỤNG CHƯƠNG 6: CÂY NHỊ PHÂN (BÀI 1 - 8)
Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1
============================================================

Cấu trúc cây nhị phân mẫu:
          10
        /    \
       6      15
      / \    /  \
     3   8  12  20
        /
       7

=== Bài tập 1: Đếm số nút trên cây nhị phân ===
Tổng số nút trên cây nhị phân là: 8 nút

=== Bài tập 2: Tính tổng giá trị các nút trên cây nhị phân ===
Tổng giá trị tất cả các nút trên cây là: 81

=== Bài tập 3: Hiển thị giá trị các nút trên cây nhị phân ===
Các nút trên cây (duyệt theo thứ tự NLR): 10 6 3 8 7 15 12 20

=== Bài tập 4: Hiển thị giá trị các nút có giá trị chẵn ===
Các nút có giá trị chẵn trên cây: 10 6 8 12 20

=== Bài tập 5: Đếm số lượng nút có giá trị chẵn trên cây ===
Số lượng nút có giá trị chẵn trên cây là: 5 nút

=== Bài tập 6: Đếm số con của một nút trên cây nhị phân ===
Nút có giá trị 10: Có 2 con.
Nút có giá trị 8: Có 1 con.
Nút có giá trị 3: Có 0 con.
Nút có giá trị 99: Không tồn tại trên cây.

=== Bài tập 7: Hiển thị giá trị các nút trên cây con trái ===
Các nút thuộc cây con trái (gốc 6, duyệt NLR): 6 3 8 7

=== Bài tập 8: Duyệt cây nhị phân theo các thứ tự ===
- Tiền thứ tự (NLR - Node -> Left -> Right): 10 6 3 8 7 15 12 20
- Trung thứ tự (LNR - Left -> Node -> Right): 3 6 7 8 10 12 15 20
- Hậu thứ tự   (LRN - Left -> Right -> Node): 3 7 8 6 12 20 15 10

============================================================
HOÀN THÀNH TOÀN BỘ BÀI TẬP ÁP DỤNG CHƯƠNG 6 (BUỔI 04)!
============================================================
```
