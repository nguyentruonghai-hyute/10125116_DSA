using System;
using System.Collections.Generic;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("============================================================");
Console.WriteLine("BUỔI 04 - BÀI TẬP ÁP DỤNG CHƯƠNG 6: CÂY NHỊ PHÂN (BÀI 1 - 8)");
Console.WriteLine("Họ tên: Nguyễn Trường Hải - MSV: 10125116 - Lớp: 10125N.1");
Console.WriteLine("============================================================\n");

// Khởi tạo cây nhị phân mẫu:
//           10
//         /    \
//        6      15
//       / \    /  \
//      3   8  12  20
//         /
//        7
CayNhiPhan cay = new CayNhiPhan();
cay.TaoCayMau();

Console.WriteLine("Cấu trúc cây nhị phân mẫu:");
Console.WriteLine("          10");
Console.WriteLine("        /    \\");
Console.WriteLine("       6      15");
Console.WriteLine("      / \\    /  \\");
Console.WriteLine("     3   8  12  20");
Console.WriteLine("        /");
Console.WriteLine("       7\n");

Console.WriteLine("=== Bài tập 1: Đếm số nút trên cây nhị phân ===");
Console.WriteLine($"Tổng số nút trên cây nhị phân là: {cay.DemSoNut()} nút");

Console.WriteLine("\n=== Bài tập 2: Tính tổng giá trị các nút trên cây nhị phân ===");
Console.WriteLine($"Tổng giá trị tất cả các nút trên cây là: {cay.TinhTongGiaTri()}");

Console.WriteLine("\n=== Bài tập 3: Hiển thị giá trị các nút trên cây nhị phân ===");
Console.WriteLine($"Các nút trên cây (duyệt theo thứ tự NLR): {cay.HienThiCacNut()}");

Console.WriteLine("\n=== Bài tập 4: Hiển thị giá trị các nút có giá trị chẵn ===");
Console.WriteLine($"Các nút có giá trị chẵn trên cây: {cay.HienThiNutChan()}");

Console.WriteLine("\n=== Bài tập 5: Đếm số lượng nút có giá trị chẵn trên cây ===");
Console.WriteLine($"Số lượng nút có giá trị chẵn trên cây là: {cay.DemNutChan()} nút");

Console.WriteLine("\n=== Bài tập 6: Đếm số con của một nút trên cây nhị phân ===");
int[] nutCanKiemTra = { 10, 8, 3, 99 };
foreach (int giaTri in nutCanKiemTra)
{
    int soCon = cay.DemSoConCuaNut(giaTri);
    if (soCon == -1)
        Console.WriteLine($"Nút có giá trị {giaTri}: Không tồn tại trên cây.");
    else
        Console.WriteLine($"Nút có giá trị {giaTri}: Có {soCon} con.");
}

Console.WriteLine("\n=== Bài tập 7: Hiển thị giá trị các nút trên cây con trái ===");
Console.WriteLine($"Các nút thuộc cây con trái (gốc 6, duyệt NLR): {cay.HienThiCayConTrai()}");

Console.WriteLine("\n=== Bài tập 8: Duyệt cây nhị phân theo các thứ tự ===");
Console.WriteLine($"- Tiền thứ tự (NLR - Node -> Left -> Right): {cay.DuyetNLR()}");
Console.WriteLine($"- Trung thứ tự (LNR - Left -> Node -> Right): {cay.DuyetLNR()}");
Console.WriteLine($"- Hậu thứ tự   (LRN - Left -> Right -> Node): {cay.DuyetLRN()}");

Console.WriteLine("\n============================================================");
Console.WriteLine("HOÀN THÀNH TOÀN BỘ BÀI TẬP ÁP DỤNG CHƯƠNG 6 (BUỔI 04)!");
Console.WriteLine("============================================================");

// =========================================================================
// LỚP NÚT VÀ CÂY NHỊ PHÂN (MỤC 6.7.2 - BÀI TẬP 1 ĐẾN 8)
// =========================================================================
class TreeNode
{
    public int Data { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int data, TreeNode? left = null, TreeNode? right = null)
    {
        Data = data;
        Left = left;
        Right = right;
    }
}

class CayNhiPhan
{
    public TreeNode? Root { get; private set; }

    public void TaoCayMau()
    {
        Root = new TreeNode(
            10,
            new TreeNode(6, new TreeNode(3), new TreeNode(8, new TreeNode(7), null)),
            new TreeNode(15, new TreeNode(12), new TreeNode(20))
        );
    }

    // Bài tập 1: Đếm số nút trên cây nhị phân
    public int DemSoNut() => DemSoNut(Root);
    private int DemSoNut(TreeNode? node)
    {
        if (node == null) return 0;
        return 1 + DemSoNut(node.Left) + DemSoNut(node.Right);
    }

    // Bài tập 2: Tính tổng giá trị các nút trên cây nhị phân
    public int TinhTongGiaTri() => TinhTongGiaTri(Root);
    private int TinhTongGiaTri(TreeNode? node)
    {
        if (node == null) return 0;
        return node.Data + TinhTongGiaTri(node.Left) + TinhTongGiaTri(node.Right);
    }

    // Bài tập 3: Hiển thị giá trị các nút trên cây nhị phân
    public string HienThiCacNut() => DuyetNLR();

    // Bài tập 4: Hiển thị giá trị các nút có giá trị chẵn trên cây nhị phân
    public string HienThiNutChan()
    {
        List<int> dsChan = new List<int>();
        ThuThapNutChan(Root, dsChan);
        return dsChan.Count > 0 ? string.Join(" ", dsChan) : "(Không có)";
    }
    private void ThuThapNutChan(TreeNode? node, List<int> ds)
    {
        if (node == null) return;
        if (node.Data % 2 == 0) ds.Add(node.Data);
        ThuThapNutChan(node.Left, ds);
        ThuThapNutChan(node.Right, ds);
    }

    // Bài tập 5: Đếm số lượng nút có giá trị chẵn trên cây nhị phân
    public int DemNutChan() => DemNutChan(Root);
    private int DemNutChan(TreeNode? node)
    {
        if (node == null) return 0;
        int hienTai = (node.Data % 2 == 0) ? 1 : 0;
        return hienTai + DemNutChan(node.Left) + DemNutChan(node.Right);
    }

    // Bài tập 6: Đếm số con của một nút trên cây nhị phân (-1 nếu không tìm thấy nút)
    public int DemSoConCuaNut(int giaTri)
    {
        TreeNode? target = TimNut(Root, giaTri);
        if (target == null) return -1;

        int soCon = 0;
        if (target.Left != null) soCon++;
        if (target.Right != null) soCon++;
        return soCon;
    }
    private TreeNode? TimNut(TreeNode? node, int giaTri)
    {
        if (node == null) return null;
        if (node.Data == giaTri) return node;
        return TimNut(node.Left, giaTri) ?? TimNut(node.Right, giaTri);
    }

    // Bài tập 7: Hiển thị giá trị các nút trên cây con trái của cây nhị phân
    public string HienThiCayConTrai()
    {
        if (Root == null || Root.Left == null) return "(Cây con trái rỗng)";
        List<int> ds = new List<int>();
        NLR(Root.Left, ds);
        return string.Join(" ", ds);
    }

    // Bài tập 8: Duyệt cây nhị phân theo các thứ tự NLR, LNR, LRN
    public string DuyetNLR()
    {
        List<int> ds = new List<int>();
        NLR(Root, ds);
        return string.Join(" ", ds);
    }
    private void NLR(TreeNode? node, List<int> ds)
    {
        if (node == null) return;
        ds.Add(node.Data);
        NLR(node.Left, ds);
        NLR(node.Right, ds);
    }

    public string DuyetLNR()
    {
        List<int> ds = new List<int>();
        LNR(Root, ds);
        return string.Join(" ", ds);
    }
    private void LNR(TreeNode? node, List<int> ds)
    {
        if (node == null) return;
        LNR(node.Left, ds);
        ds.Add(node.Data);
        LNR(node.Right, ds);
    }

    public string DuyetLRN()
    {
        List<int> ds = new List<int>();
        LRN(Root, ds);
        return string.Join(" ", ds);
    }
    private void LRN(TreeNode? node, List<int> ds)
    {
        if (node == null) return;
        LRN(node.Left, ds);
        LRN(node.Right, ds);
        ds.Add(node.Data);
    }
}
