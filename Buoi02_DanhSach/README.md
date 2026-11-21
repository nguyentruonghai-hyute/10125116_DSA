# Buổi 02 – Danh sách (Chương 4: Danh sách đặc & Danh sách liên kết)

Họ tên: Nguyễn Trường Hải · MSV: 10125116 · Lớp: 10125N.1

## Danh sách bài đã làm (Chương 4)
- **Phần 1 (Danh sách đặc – Array-based List):** Khởi tạo, thêm cuối, chèn tại vị trí `index`, xóa tại vị trí `index`, tìm kiếm tuyến tính và sắp xếp tăng dần.
- **Phần 2 (Danh sách liên kết đơn – Singly Linked List):** Thêm đầu (`AddFirst`), thêm cuối (`AddLast`), chèn sau nút (`InsertAfter`), xóa đầu/cuối/theo giá trị, tìm kiếm, đếm nút, đảo ngược danh sách (`Reverse`) và sắp xếp tăng dần (`Sort`).
- **Phần 3 (Danh sách liên kết kép & Danh sách liên kết vòng):** Duyệt xuôi (`Head -> Tail`), duyệt ngược (`Tail -> Head`), xóa nút trên DSLK kép và duyệt khép kín trên DSLK vòng.
- **Phần 4 (Bài toán ứng dụng DSLK đơn):** Quản lý danh sách sinh viên (thêm sinh viên, tìm kiếm theo Mã SV, lọc sinh viên đạt loại Giỏi `DiemTB >= 8.0`, sắp xếp theo điểm trung bình giảm dần).

## Cách chạy
```
dotnet run --project Buoi02_DanhSach
```

## Kết quả chạy
```
============================================================
BUỔI 02 - BÀI TẬP THỰC HÀNH CHƯƠNG 4: DANH SÁCH (LISTS)
Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1
============================================================

=== Phần 1: Danh sách đặc (Array-based List) ===
Danh sách ban đầu (5 phần tử): 15 42 8 27 63
Sau khi chèn 99 vào vị trí index = 2: 15 42 99 8 27 63
Sau khi xóa phần tử tại index = 3:   15 42 99 27 63
Tìm kiếm giá trị 27 -> tìm thấy tại vị trí index = 3
Danh sách sau khi sắp xếp tăng dần:  15 27 42 63 99

=== Phần 2: Danh sách liên kết đơn (Singly Linked List) ===
Sau khi thêm đầu (10) và thêm cuối (50): 10 -> 20 -> 30 -> 40 -> 50 -> null (Số nút: 5)
Sau khi chèn 35 vào sau nút 30:          10 -> 20 -> 30 -> 35 -> 40 -> 50 -> null
Sau khi xóa đầu, xóa cuối và xóa nút 35: 20 -> 30 -> 40 -> null
Tìm kiếm phần tử 30 trong danh sách:     True (Tìm thấy)
Danh sách sau khi đảo ngược (Reverse):   40 -> 30 -> 20 -> null
Danh sách sau khi sắp xếp tăng dần:      20 -> 30 -> 40 -> null

=== Phần 3: Danh sách liên kết kép & Danh sách liên kết vòng ===
[DSLK Kép] Duyệt xuôi (Head -> Tail):  100 <-> 200 <-> 300 <-> 400
[DSLK Kép] Duyệt ngược (Tail -> Head): 400 <-> 300 <-> 200 <-> 100
[DSLK Kép] Sau khi xóa nút 200:        100 <-> 300 <-> 400
[DSLK Vòng] Duyệt 1 vòng từ Head:      Node_A -> Node_B -> Node_C -> Node_D -> (quay lại Node_A)

=== Phần 4: Ứng dụng DSLK đơn - Quản lý danh sách Sinh viên ===
Danh sách sinh viên ban đầu:
   - 10125116 | Nguyễn Trường Hải    | Điểm TB: 8.65
   - 10125118 | Đào Minh Vũ          | Điểm TB: 7.80
   - 10125120 | Luyện Minh Hiếu      | Điểm TB: 9.10
   - 10125122 | Trần Văn Hiếu        | Điểm TB: 8.20
   - 10125124 | Hoàng Ngọc Quyền     | Điểm TB: 7.45

Tìm kiếm sinh viên mã '10125120': Tìm thấy -> 10125120 - Luyện Minh Hiếu (Điểm TB: 9.10)

Danh sách sinh viên đạt loại Giỏi (Điểm TB >= 8.0):
   - 10125116 | Nguyễn Trường Hải    | Điểm TB: 8.65
   - 10125120 | Luyện Minh Hiếu      | Điểm TB: 9.10
   - 10125122 | Trần Văn Hiếu        | Điểm TB: 8.20

Danh sách sinh viên sau khi sắp xếp Điểm TB giảm dần:
   - 10125120 | Luyện Minh Hiếu      | Điểm TB: 9.10
   - 10125116 | Nguyễn Trường Hải    | Điểm TB: 8.65
   - 10125122 | Trần Văn Hiếu        | Điểm TB: 8.20
   - 10125118 | Đào Minh Vũ          | Điểm TB: 7.80
   - 10125124 | Hoàng Ngọc Quyền     | Điểm TB: 7.45

============================================================
HOÀN THÀNH TOÀN BỘ BÀI TẬP CHƯƠNG 4 (BUỔI 02)!
============================================================
