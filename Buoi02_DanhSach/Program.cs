using System;
using System.Collections.Generic;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("============================================================");
Console.WriteLine("BUỔI 02 - BÀI TẬP THỰC HÀNH CHƯƠNG 4: DANH SÁCH (LISTS)");
Console.WriteLine("Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1");
Console.WriteLine("============================================================\n");

Console.WriteLine("=== Phần 1: Danh sách đặc (Array-based List) ===");
C4_Phan1_DanhSachDac();

Console.WriteLine("\n=== Phần 2: Danh sách liên kết đơn (Singly Linked List) ===");
C4_Phan2_DanhSachLienKetDon();

Console.WriteLine("\n=== Phần 3: Danh sách liên kết kép & Danh sách liên kết vòng ===");
C4_Phan3_DanhSachKepVaVong();

Console.WriteLine("\n=== Phần 4: Ứng dụng DSLK đơn - Quản lý danh sách Sinh viên ===");
C4_Phan4_QuanLySinhVien();

Console.WriteLine("\n============================================================");
Console.WriteLine("HOÀN THÀNH TOÀN BỘ BÀI TẬP CHƯƠNG 4 (BUỔI 02)!");
Console.WriteLine("============================================================");

// =========================================================================
// PHẦN 1: DANH SÁCH ĐẶC (ARRAY-BASED LIST)
// =========================================================================
static void C4_Phan1_DanhSachDac()
{
    DanhSachDac ds = new DanhSachDac(20);
    int[] khoiTao = { 15, 42, 8, 27, 63 };
    foreach (int x in khoiTao) ds.ThemCuoi(x);

    Console.WriteLine($"Danh sách ban đầu ({ds.Count} phần tử): {ds.HienThi()}");

    ds.ChenTaiViTri(2, 99);
    Console.WriteLine($"Sau khi chèn 99 vào vị trí index = 2: {ds.HienThi()}");

    ds.XoaTaiViTri(3);
    Console.WriteLine($"Sau khi xóa phần tử tại index = 3:   {ds.HienThi()}");

    int viTri = ds.TimKiem(27);
    Console.WriteLine($"Tìm kiếm giá trị 27 -> tìm thấy tại vị trí index = {viTri}");

    ds.SapXepTangDan();
    Console.WriteLine($"Danh sách sau khi sắp xếp tăng dần:  {ds.HienThi()}");
}

// =========================================================================
// PHẦN 2: DANH SÁCH LIÊN KẾT ĐƠN (SINGLY LINKED LIST)
// =========================================================================
static void C4_Phan2_DanhSachLienKetDon()
{
    SinglyLinkedList list = new SinglyLinkedList();
    list.AddLast(20);
    list.AddLast(30);
    list.AddLast(40);
    list.AddFirst(10);
    list.AddLast(50);

    Console.WriteLine($"Sau khi thêm đầu (10) và thêm cuối (50): {list.PrintList()} (Số nút: {list.Count()})");

    list.InsertAfter(30, 35);
    Console.WriteLine($"Sau khi chèn 35 vào sau nút 30:          {list.PrintList()}");

    list.RemoveFirst();
    list.RemoveLast();
    list.RemoveByValue(35);
    Console.WriteLine($"Sau khi xóa đầu, xóa cuối và xóa nút 35: {list.PrintList()}");

    bool timThay = list.Search(30);
    Console.WriteLine($"Tìm kiếm phần tử 30 trong danh sách:     {timThay} ({(timThay ? "Tìm thấy" : "Không thấy")})");

    list.Reverse();
    Console.WriteLine($"Danh sách sau khi đảo ngược (Reverse):   {list.PrintList()}");

    list.Sort();
    Console.WriteLine($"Danh sách sau khi sắp xếp tăng dần:      {list.PrintList()}");
}

// =========================================================================
// PHẦN 3: DANH SÁCH LIÊN KẾT KÉP & DANH SÁCH LIÊN KẾT VÒNG
// =========================================================================
static void C4_Phan3_DanhSachKepVaVong()
{
    DoublyLinkedList dList = new DoublyLinkedList();
    dList.AddLast(200);
    dList.AddLast(300);
    dList.AddFirst(100);
    dList.AddLast(400);

    Console.WriteLine($"[DSLK Kép] Duyệt xuôi (Head -> Tail):  {dList.PrintForward()}");
    Console.WriteLine($"[DSLK Kép] Duyệt ngược (Tail -> Head): {dList.PrintBackward()}");

    dList.RemoveByValue(200);
    Console.WriteLine($"[DSLK Kép] Sau khi xóa nút 200:        {dList.PrintForward()}");

    CircularLinkedList cList = new CircularLinkedList();
    cList.AddLast("Node_A");
    cList.AddLast("Node_B");
    cList.AddLast("Node_C");
    cList.AddLast("Node_D");
    Console.WriteLine($"[DSLK Vòng] Duyệt 1 vòng từ Head:      {cList.PrintCircular()}");
}

// =========================================================================
// PHẦN 4: ỨNG DỤNG DSLK ĐƠN - QUẢN LÝ DANH SÁCH SINH VIÊN
// =========================================================================
static void C4_Phan4_QuanLySinhVien()
{
    DanhSachSinhVien dsSV = new DanhSachSinhVien();
    dsSV.ThemCuoi(new SinhVien("10125116", "Nguyễn Trường Hải", 8.65));
    dsSV.ThemCuoi(new SinhVien("10125118", "Đào Minh Vũ", 7.80));
    dsSV.ThemCuoi(new SinhVien("10125120", "Luyện Minh Hiếu", 9.10));
    dsSV.ThemCuoi(new SinhVien("10125122", "Trần Văn Hiếu", 8.20));
    dsSV.ThemCuoi(new SinhVien("10125124", "Hoàng Ngọc Quyền", 7.45));

    Console.WriteLine("Danh sách sinh viên ban đầu:");
    dsSV.InDanhSach();

    SinhVien? svTim = dsSV.TimTheoMa("10125120");
    if (svTim != null)
    {
        Console.WriteLine($"\nTìm kiếm sinh viên mã '10125120': Tìm thấy -> {svTim.MaSV} - {svTim.HoTen} (Điểm TB: {svTim.DiemTB:F2})");
    }

    Console.WriteLine("\nDanh sách sinh viên đạt loại Giỏi (Điểm TB >= 8.0):");
    dsSV.InSinhVienGioi(8.0);

    dsSV.SapXepTheoDiemGiamDan();
    Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp Điểm TB giảm dần:");
    dsSV.InDanhSach();
}

// =========================================================================
// CÁC LỚP CÀI ĐẶT CẤU TRÚC DỮ LIỆU DANH SÁCH (CHƯƠNG 4)
// =========================================================================

// 1. Danh sách đặc (Array-based List)
class DanhSachDac
{
    private int[] items;
    public int Count { get; private set; }

    public DanhSachDac(int capacity)
    {
        items = new int[capacity];
        Count = 0;
    }

    public void ThemCuoi(int giaTri)
    {
        if (Count >= items.Length) return;
        items[Count++] = giaTri;
    }

    public void ChenTaiViTri(int index, int giaTri)
    {
        if (index < 0 || index > Count || Count >= items.Length) return;
        for (int i = Count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
        items[index] = giaTri;
        Count++;
    }

    public void XoaTaiViTri(int index)
    {
        if (index < 0 || index >= Count) return;
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        Count--;
    }

    public int TimKiem(int giaTri)
    {
        for (int i = 0; i < Count; i++)
        {
            if (items[i] == giaTri) return i;
        }
        return -1;
    }

    public void SapXepTangDan()
    {
        for (int i = 0; i < Count - 1; i++)
        {
            for (int j = 0; j < Count - 1 - i; j++)
            {
                if (items[j] > items[j + 1])
                {
                    int tam = items[j];
                    items[j] = items[j + 1];
                    items[j + 1] = tam;
                }
            }
        }
    }

    public string HienThi()
    {
        int[] ketQua = new int[Count];
        Array.Copy(items, ketQua, Count);
        return string.Join(" ", ketQua);
    }
}

// 2. Danh sách liên kết đơn (Singly Linked List)
class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class SinglyLinkedList
{
    private Node? head;

    public void AddFirst(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node curr = head;
        while (curr.Next != null)
        {
            curr = curr.Next;
        }
        curr.Next = newNode;
    }

    public void InsertAfter(int targetValue, int newData)
    {
        Node? curr = head;
        while (curr != null && curr.Data != targetValue)
        {
            curr = curr.Next;
        }
        if (curr != null)
        {
            Node newNode = new Node(newData);
            newNode.Next = curr.Next;
            curr.Next = newNode;
        }
    }

    public void RemoveFirst()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }

    public void RemoveLast()
    {
        if (head == null) return;
        if (head.Next == null)
        {
            head = null;
            return;
        }
        Node curr = head;
        while (curr.Next != null && curr.Next.Next != null)
        {
            curr = curr.Next;
        }
        curr.Next = null;
    }

    public void RemoveByValue(int value)
    {
        if (head == null) return;
        if (head.Data == value)
        {
            head = head.Next;
            return;
        }
        Node curr = head;
        while (curr.Next != null && curr.Next.Data != value)
        {
            curr = curr.Next;
        }
        if (curr.Next != null)
        {
            curr.Next = curr.Next.Next;
        }
    }

    public bool Search(int value)
    {
        Node? curr = head;
        while (curr != null)
        {
            if (curr.Data == value) return true;
            curr = curr.Next;
        }
        return false;
    }

    public int Count()
    {
        int dem = 0;
        Node? curr = head;
        while (curr != null)
        {
            dem++;
            curr = curr.Next;
        }
        return dem;
    }

    public void Reverse()
    {
        Node? prev = null;
        Node? curr = head;
        while (curr != null)
        {
            Node? nextTemp = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = nextTemp;
        }
        head = prev;
    }

    public void Sort()
    {
        if (head == null) return;
        for (Node? i = head; i != null; i = i.Next)
        {
            for (Node? j = i.Next; j != null; j = j.Next)
            {
                if (i.Data > j.Data)
                {
                    int tam = i.Data;
                    i.Data = j.Data;
                    j.Data = tam;
                }
            }
        }
    }

    public string PrintList()
    {
        List<int> ds = new List<int>();
        Node? curr = head;
        while (curr != null)
        {
            ds.Add(curr.Data);
            curr = curr.Next;
        }
        return ds.Count > 0 ? string.Join(" -> ", ds) + " -> null" : "null";
    }
}

// 3a. Danh sách liên kết kép (Doubly Linked List)
class DNode
{
    public int Data { get; set; }
    public DNode? Prev { get; set; }
    public DNode? Next { get; set; }

    public DNode(int data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }
}

class DoublyLinkedList
{
    private DNode? head;
    private DNode? tail;

    public void AddFirst(int data)
    {
        DNode newNode = new DNode(data);
        if (head == null)
        {
            head = tail = newNode;
            return;
        }
        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }

    public void AddLast(int data)
    {
        DNode newNode = new DNode(data);
        if (tail == null)
        {
            head = tail = newNode;
            return;
        }
        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    public void RemoveByValue(int value)
    {
        DNode? curr = head;
        while (curr != null && curr.Data != value)
        {
            curr = curr.Next;
        }
        if (curr == null) return;

        if (curr.Prev != null) curr.Prev.Next = curr.Next;
        else head = curr.Next;

        if (curr.Next != null) curr.Next.Prev = curr.Prev;
        else tail = curr.Prev;
    }

    public string PrintForward()
    {
        List<int> ds = new List<int>();
        DNode? curr = head;
        while (curr != null)
        {
            ds.Add(curr.Data);
            curr = curr.Next;
        }
        return string.Join(" <-> ", ds);
    }

    public string PrintBackward()
    {
        List<int> ds = new List<int>();
        DNode? curr = tail;
        while (curr != null)
        {
            ds.Add(curr.Data);
            curr = curr.Prev;
        }
        return string.Join(" <-> ", ds);
    }
}

// 3b. Danh sách liên kết vòng (Circular Linked List)
class CNode
{
    public string Data { get; set; }
    public CNode? Next { get; set; }

    public CNode(string data)
    {
        Data = data;
        Next = null;
    }
}

class CircularLinkedList
{
    private CNode? head;

    public void AddLast(string data)
    {
        CNode newNode = new CNode(data);
        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }
        CNode curr = head;
        while (curr.Next != null && curr.Next != head)
        {
            curr = curr.Next;
        }
        curr.Next = newNode;
        newNode.Next = head;
    }

    public string PrintCircular()
    {
        if (head == null) return "(Trống)";
        List<string> ds = new List<string>();
        CNode? curr = head;
        do
        {
            ds.Add(curr!.Data);
            curr = curr.Next;
        } while (curr != null && curr != head);

        return $"{string.Join(" -> ", ds)} -> (quay lại {head.Data})";
    }
}

// 4. Ứng dụng DSLK đơn quản lý Sinh viên
record SinhVien(string MaSV, string HoTen, double DiemTB);

class SvNode
{
    public SinhVien Data { get; set; }
    public SvNode? Next { get; set; }

    public SvNode(SinhVien data)
    {
        Data = data;
        Next = null;
    }
}

class DanhSachSinhVien
{
    private SvNode? head;

    public void ThemCuoi(SinhVien sv)
    {
        SvNode newNode = new SvNode(sv);
        if (head == null)
        {
            head = newNode;
            return;
        }
        SvNode curr = head;
        while (curr.Next != null)
        {
            curr = curr.Next;
        }
        curr.Next = newNode;
    }

    public SinhVien? TimTheoMa(string maSV)
    {
        SvNode? curr = head;
        while (curr != null)
        {
            if (curr.Data.MaSV == maSV) return curr.Data;
            curr = curr.Next;
        }
        return null;
    }

    public void InSinhVienGioi(double nguongDiem)
    {
        SvNode? curr = head;
        while (curr != null)
        {
            if (curr.Data.DiemTB >= nguongDiem)
            {
                Console.WriteLine($"   - {curr.Data.MaSV} | {curr.Data.HoTen,-20} | Điểm TB: {curr.Data.DiemTB:F2}");
            }
            curr = curr.Next;
        }
    }

    public void SapXepTheoDiemGiamDan()
    {
        for (SvNode? i = head; i != null; i = i.Next)
        {
            for (SvNode? j = i.Next; j != null; j = j.Next)
            {
                if (i.Data.DiemTB < j.Data.DiemTB)
                {
                    SinhVien tam = i.Data;
                    i.Data = j.Data;
                    j.Data = tam;
                }
            }
        }
    }

    public void InDanhSach()
    {
        SvNode? curr = head;
        while (curr != null)
        {
            Console.WriteLine($"   - {curr.Data.MaSV} | {curr.Data.HoTen,-20} | Điểm TB: {curr.Data.DiemTB:F2}");
            curr = curr.Next;
        }
    }
}
