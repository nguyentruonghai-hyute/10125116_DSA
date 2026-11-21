# Buổi 03 – Stack và Queue (Bài tập áp dụng Chương 5)

Họ tên: Nguyễn Trường Hải · MSV: 10125116 · Lớp: 10125N.1

## Bài đã làm (Mục 5.5.2 – Trang 215–217)
- **Bài tập 1:** Kiểm tra tính đúng đắn của biểu thức toán học với các dấu ngoặc `()`, `[]`, `{}` bằng `Stack<char>`
- **Bài tập 2:** Mô phỏng lịch sử trình duyệt web (`Back` và `Forward`) sử dụng hai `Stack<string>`
- **Bài tập 3:** Mô phỏng quá trình thực thi chương trình (`Function Call Stack`) với thao tác `Call` và `Return`
- **Bài tập 4:** Mô phỏng hệ thống in ấn xử lý yêu cầu theo nguyên tắc FIFO bằng `Queue<PrintJob>`
- **Bài tập 5:** Mô phỏng đường truyền dữ liệu mạng bằng `Queue<DataPacket>` (có mô phỏng độ trễ và gửi lại gói tin khi gặp lỗi đường truyền)
- **Bài tập 6:** Mô phỏng quản lý hàng đợi khách hàng tại ngân hàng theo thứ tự đến (thông tin khách hàng, thời gian đến, loại dịch vụ và trạng thái hàng đợi)

## Cách chạy
```
dotnet run --project Buoi03_Stack_Queue
```

## Kết quả chạy
```
============================================================
BUỔI 03 - BÀI TẬP ÁP DỤNG CHƯƠNG 5: STACK & QUEUE (BÀI 1 - 6)
Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1
============================================================

=== Bài tập 1: Kiểm tra tính đúng đắn của biểu thức toán học ===
Biểu thức: {[5 + (1 + 2 * 4)] * (3 - 1)}    -> Hợp lệ (True)
Biểu thức: ((2 + 3) * [4 - 1]}              -> Sai cấu trúc ngoặc (False)
Biểu thức: ((5 + 2) * 3                     -> Sai cấu trúc ngoặc (False)
Biểu thức: 5 + 2) * 3                       -> Sai cấu trúc ngoặc (False)

=== Bài tập 2: Mô phỏng lịch sử trình duyệt web (Back / Forward) ===
[Khởi động] Trang hiện tại: https://utehy.edu.vn
[Truy cập]  -> https://utehy.edu.vn/tin-tuc (Back: 1, Forward: 0)
[Truy cập]  -> https://github.com/nguyentruonghai-hyute (Back: 2, Forward: 0)
[Truy cập]  -> https://github.com/nguyentruonghai-hyute/10125116_DSA (Back: 3, Forward: 0)
[Back]      <- Quay lại: https://github.com/nguyentruonghai-hyute (Back: 2, Forward: 1)
[Back]      <- Quay lại: https://utehy.edu.vn/tin-tuc (Back: 1, Forward: 2)
[Forward]   -> Chuyển tiếp: https://github.com/nguyentruonghai-hyute (Back: 2, Forward: 1)
[Truy cập]  -> https://learn.microsoft.com/dotnet/csharp (Back: 3, Forward: 0)
[Forward]   Không thể chuyển tiếp (Stack Forward rỗng).

=== Bài tập 3: Mô phỏng quá trình thực thi chương trình (Function Call Stack) ===
[CALL]   Gọi Main() | Tham số: args = [] | Trả về: Hệ điều hành (OS Exit)
[CALL]   Gọi TinhTongLuong() | Tham số: phongBan = "Kỹ thuật" | Trả về: Main() : dòng 15
[CALL]   Gọi LayDanhSachNV() | Tham số: phongBan = "Kỹ thuật" | Trả về: TinhTongLuong() : dòng 28
   --- Trạng thái Call Stack hiện tại (Đỉnh -> Đáy) ---
   | LayDanhSachNV()    | phongBan = "Kỹ thuật"      | Ret: TinhTongLuong() : dòng 28
   | TinhTongLuong()    | phongBan = "Kỹ thuật"      | Ret: Main() : dòng 15
   | Main()             | args = []                  | Ret: Hệ điều hành (OS Exit)
   -----------------------------------------------------
[RETURN] Kết thúc LayDanhSachNV() -> quay về TinhTongLuong() : dòng 28 (Còn 2 khung)
[CALL]   Gọi TinhThueTNCN() | Tham số: thuNhap = 15,000,000 | Trả về: TinhTongLuong() : dòng 32
[RETURN] Kết thúc TinhThueTNCN() -> quay về TinhTongLuong() : dòng 32 (Còn 2 khung)
[RETURN] Kết thúc TinhTongLuong() -> quay về Main() : dòng 15 (Còn 1 khung)
[RETURN] Kết thúc Main() -> quay về Hệ điều hành (OS Exit) (Còn 0 khung)

=== Bài tập 4: Mô phỏng hệ thống in ấn (FIFO Queue) ===
[Enqueue] Thêm lệnh in JOB-01: BaoCao_CTDLGT.pdf (12 trang)
[Enqueue] Thêm lệnh in JOB-02: DeCuong_OnTap.docx (5 trang)
[Enqueue] Thêm lệnh in JOB-03: BangDiem_10125N1.xlsx (2 trang)
   >> Hàng đợi chờ in hiện tại: JOB-01 (BaoCao_CTDLGT.pdf) <- JOB-02 (DeCuong_OnTap.docx) <- JOB-03 (BangDiem_10125N1.xlsx)
[Dequeue] Đang in xong JOB-01: BaoCao_CTDLGT.pdf (12 trang)
[Dequeue] Đang in xong JOB-02: DeCuong_OnTap.docx (5 trang)
[Enqueue] Thêm lệnh in JOB-04: Slide_Chuong5_StackQueue.pptx (24 trang)
   >> Hàng đợi chờ in hiện tại: JOB-03 (BangDiem_10125N1.xlsx) <- JOB-04 (Slide_Chuong5_StackQueue.pptx)
[Dequeue] Đang in xong JOB-03: BangDiem_10125N1.xlsx (2 trang)
[Dequeue] Đang in xong JOB-04: Slide_Chuong5_StackQueue.pptx (24 trang)
[Dequeue] Hàng đợi in trống, không có tài liệu chờ.

=== Bài tập 5: Mô phỏng đường truyền dữ liệu mạng ===
[Gửi]   Đưa gói PKT-01 (Header SYN, 64B, trễ 12ms) vào hàng đợi truyền.
[Gửi]   Đưa gói PKT-02 (User Auth Token, 256B, trễ 18ms) vào hàng đợi truyền.
[Gửi]   Đưa gói PKT-03 (Query Payload, 1024B, trễ 35ms) vào hàng đợi truyền.
[Gửi]   Đưa gói PKT-04 (Footer FIN, 64B, trễ 10ms) vào hàng đợi truyền.
   --- Bắt đầu xử lý gói tin theo thứ tự FIFO ---
[NHẬN]  Đã xử lý thành công gói PKT-01: "Header SYN" (64B, độ trễ 12ms)
[NHẬN]  Đã xử lý thành công gói PKT-02: "User Auth Token" (256B, độ trễ 18ms)
[LỖI]   Gói PKT-03 bị lỗi checksum trên đường truyền! Đưa vào cuối hàng đợi để gửi lại...
[NHẬN]  Đã xử lý thành công gói PKT-04: "Footer FIN" (64B, độ trễ 10ms)
[NHẬN]  Đã xử lý thành công gói PKT-03: "Query Payload" (1024B, độ trễ 35ms)

=== Bài tập 6: Mô phỏng quản lý hàng đợi tại Ngân hàng ===
[Khách đến] Số 101 - Nguyễn Trường Hải (08:30) | Dịch vụ: Mở thẻ sinh viên
[Khách đến] Số 102 - Đào Minh Vũ (08:32) | Dịch vụ: Nộp tiền mặt
[Khách đến] Số 103 - Luyện Minh Hiếu (08:35) | Dịch vụ: Chuyển khoản liên ngân hàng
[Khách đến] Số 104 - Trần Văn Hiếu (08:40) | Dịch vụ: Cấp lại mã PIN
   --- Trạng thái hàng đợi ngân hàng (Đang chờ: 4 khách) ---
   * STT 101 | Nguyễn Trường Hải  | Đến lúc: 08:30 | Mở thẻ sinh viên
   * STT 102 | Đào Minh Vũ        | Đến lúc: 08:32 | Nộp tiền mặt
   * STT 103 | Luyện Minh Hiếu    | Đến lúc: 08:35 | Chuyển khoản liên ngân hàng
   * STT 104 | Trần Văn Hiếu      | Đến lúc: 08:40 | Cấp lại mã PIN
   -------------------------------------------------------------
[Quầy số 1]  Mời khách số 101 (Nguyễn Trường Hải) vào giao dịch: Mở thẻ sinh viên
[Quầy số 2]  Mời khách số 102 (Đào Minh Vũ) vào giao dịch: Nộp tiền mặt
   --- Trạng thái hàng đợi ngân hàng (Đang chờ: 2 khách) ---
   * STT 103 | Luyện Minh Hiếu    | Đến lúc: 08:35 | Chuyển khoản liên ngân hàng
   * STT 104 | Trần Văn Hiếu      | Đến lúc: 08:40 | Cấp lại mã PIN
   -------------------------------------------------------------
[Quầy số 1]  Mời khách số 103 (Luyện Minh Hiếu) vào giao dịch: Chuyển khoản liên ngân hàng
[Quầy số 2]  Mời khách số 104 (Trần Văn Hiếu) vào giao dịch: Cấp lại mã PIN
[Quầy số 1]  Hiện không còn khách hàng nào đang chờ.

============================================================
HOÀN THÀNH TOÀN BỘ BÀI TẬP ÁP DỤNG CHƯƠNG 5 (BUỔI 03)!
============================================================
