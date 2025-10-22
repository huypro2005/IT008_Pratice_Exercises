using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

public class Bai5
{
    public void Cau5()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng bất động sản: ");
        int SL = int.Parse(Console.ReadLine());
        DaiPhu daiPhu = new DaiPhu(SL);
        daiPhu.Nhap();
        bool run = true;
        while (run)
        {
            Console.WriteLine("1. Xuất danh sách bất động sản.");
            Console.WriteLine("2. Tổng giá các tài sản công ty.");
            Console.WriteLine("3. Danh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có \r\ndiện tích >60m2 và năm xây dựng >= 2019");
            Console.WriteLine("4. Tìm Kiếm");
            Console.Write("Nhập để chọn: ");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Xuất...................");
                    daiPhu.Xuat();
                    break;
                case 2:
                    Console.WriteLine($"Tổng tài sản công ty: {daiPhu.TongGiaBan()}");
                    break;
                case 3:
                    Dictionary<string, Dictionary<string, double>> conditions = new()
                    {
                        ["Khu Dat"] = new()
                        {
                            ["Dien Tich"] = 100.1
                        },
                        ["Nha Dat"] = new()
                        {
                            ["Dien Tich"] = 60.1,
                            ["Nam XD"] = 2019
                        }
                    };
                    List<KhuDat> khuDats = daiPhu.KhuDatTheoDieuKien(conditions, daiPhu.ListKhuDat);
                    DaiPhu daiPhu1 = new DaiPhu(khuDats.Count, khuDats);
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Thông tin tìm thấy: ");
                    daiPhu1.Xuat();
                    break;
                case 4:
                    Console.Write("Nhập địa điểm: ");
                    string vitri = Console.ReadLine();
                    Console.Write("Nhập Giá: ");
                    double gia = double.Parse(Console.ReadLine());
                    Console.Write("Nhập diện tích: ");
                    double dientich = double.Parse(Console.ReadLine());
                    Dictionary<string, Dictionary<string, double>> conditions1 = new()
                    {
                        ["Nha Dat"] = new()
                        {
                            ["Dien Tich"] = dientich,
                            ["Gia"] = gia
                        },
                        ["Chung Cu"] = new()
                        {
                            ["Dien Tich"] = dientich,
                            ["Gia"] = gia
                        }
                    };
                    List<KhuDat> khudats = daiPhu.KhuDatTheoDieuKien(conditions1, daiPhu.ListKhuDat, vitri);
                    DaiPhu daiPhu2 = new DaiPhu(khudats.Count, khudats);
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Thông tin tìm thấy: ");
                    daiPhu2.Xuat();
                    break;
                default:
                    run = false;
                    break;

            }
        }
        Console.ReadLine();

        


    }
}

public class DaiPhu
{   
    public int SL { get; set; }
    public List<KhuDat> ListKhuDat = new List<KhuDat>();
    public DaiPhu()
    {
        SL = 0;
    }
    public DaiPhu(int SL)
    {
        this.SL = SL;
    }
    public DaiPhu(int SL, List<KhuDat> KhuDats)
    {
        this.SL = SL;
        this.ListKhuDat = KhuDats;
    }
    public void Nhap()
    {
        Console.WriteLine("Chon De Nhap");
        Console.WriteLine("1. Nha Dat");
        Console.WriteLine("2. Chung Cu");
        Console.WriteLine("Khac. Khu Dat");
        int chon = 0;
        for (int i = 0; i< SL; i++)
        {
            Console.WriteLine("--------------");
            Console.Write("Nhập để chọn: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    NhaDat nhadat = new NhaDat();
                    nhadat.Nhap();
                    ListKhuDat.Add(nhadat);
                    break;
                case 2:
                    ChungCu chungcu = new ChungCu();
                    chungcu.Nhap();
                    ListKhuDat.Add(chungcu);
                    break;
                default:
                    KhuDat khuDat = new KhuDat();
                    khuDat.Nhap();
                    ListKhuDat.Add(khuDat);
                    break;
              
            }

        }

    }
    public void Xuat()
    {
        foreach (var item in ListKhuDat)
        {
            Console.WriteLine(item.GetType());
            item.Xuat();
            Console.WriteLine("------------------------");
        }
    }
    public double TongGiaBan()
    {
        double res = 0;
        ListKhuDat.ForEach((item) =>
        {
            res += item.giaBan;
        });
        return res;
    }
    public List<KhuDat> KhuDatTheoDieuKien(Dictionary<string, Dictionary<string, double>> conditions, List<KhuDat> khuDats, string vitri1 = "")
    {
        List<KhuDat> result = new List<KhuDat>();
        string vitri = vitri1;

        if (conditions.ContainsKey("Nha Dat"))
        {
            List<NhaDat> nhaDats = new List<NhaDat>(); 
            double dientich = 0;
            double gia = 0;
            int namXD = 0;
            Dictionary<string, double> NhaDatConditions = conditions["Nha Dat"];
            if (NhaDatConditions.ContainsKey("Dien Tich"))
            {
                dientich = NhaDatConditions["Dien Tich"];
            }
            if (NhaDatConditions.ContainsKey("Gia"))
            {
                gia = NhaDatConditions["Gia"];
            }
            if (NhaDatConditions.ContainsKey("Nam XD"))
            {
                namXD = (int)NhaDatConditions["Nam XD"];
            }
            nhaDats = khuDats
                .OfType<NhaDat>()
                .Where(nd =>
                (dientich == 0 || nd.dienTich >= dientich) &&
                (gia == 0 || nd.giaBan <= gia) &&
                (namXD == 0 || nd.namXayDung >= namXD) &&
                (vitri == "" || nd.viTri.ToLower() == vitri.ToLower())
                ).ToList();
            nhaDats.ForEach(item => result.Add(item));
        }
        if (conditions.ContainsKey("Chung Cu"))
        {
            List<ChungCu> chungCus = new List<ChungCu>();
            Dictionary<string, double> NhaDatConditions = conditions["Chung Cu"];
            double dientich = 0;
            double gia = 0;
            if (NhaDatConditions.ContainsKey("Dien Tich"))
            {
                dientich = NhaDatConditions["Dien Tich"];
            }
            if (NhaDatConditions.ContainsKey("Gia"))
            {
                gia = NhaDatConditions["Gia"];
            }
            chungCus = khuDats
                .OfType<ChungCu>()
                .Where(nd =>
                (dientich == 0 || nd.dienTich >= dientich) &&
                (gia == 0 || nd.giaBan <= gia) &&
                (vitri == "" || nd.viTri.ToLower() == vitri.ToLower())
                ).ToList();
            chungCus.ForEach(item =>
            {
                result.Add(item);
            });
        }
        if (conditions.ContainsKey("Khu Dat"))
        {
            List<KhuDat> khuDats1 = new List<KhuDat>();
            Dictionary<string, double> NhaDatConditions = conditions["Khu Dat"];
            double dientich = 0;
            double gia = 0;
            if (NhaDatConditions.ContainsKey("Dien Tich"))
            {
                dientich = NhaDatConditions["Dien Tich"];
            }
            if (NhaDatConditions.ContainsKey("Gia"))
            {
                gia = NhaDatConditions["Gia"];
            }
            khuDats1 = khuDats
                .Where(x => x.GetType() == typeof(KhuDat))
                .Where(nd =>
                (dientich == 0 || nd.dienTich >= dientich) &&
                (gia == 0 || nd.giaBan <= gia) &&
                (vitri == "" || nd.viTri.ToLower() == vitri.ToLower())
                ).ToList();
            khuDats1.ForEach(item => result.Add(item));
        }
        return result;
        
    }
}


public class KhuDat
{
    public double dienTich { get; set; }
    public double giaBan { get; set; }
    public string viTri { get; set; }
    public KhuDat(double dienTich, double giaBan, string viTri)
    {
        this.dienTich = dienTich;
        this.giaBan = giaBan;
        this.viTri = viTri;
    }
    public KhuDat() { }
    virtual public void Nhap()
    {
        Console.Write("Nhập diện tích: ");
        dienTich = double.Parse(Console.ReadLine());
        Console.Write("Nhập giá bán: ");
        giaBan = double.Parse(Console.ReadLine());
        Console.Write("Nhập vị trí: ");
        viTri = Console.ReadLine();
    }
    virtual public void Xuat()
    {
        Console.WriteLine($"Diện tích: {dienTich}");
        Console.WriteLine($"Giá bán: {giaBan}");
        Console.WriteLine($"Vị trí: {viTri}");
    }
}

public class NhaDat : KhuDat
{
    public int namXayDung { get; set; }
    public int soTang { get; set; }
    public NhaDat(double dienTich, double giaBan, string viTri, int namXayDung, int soTang)
        : base(dienTich, giaBan, viTri)
    {
        this.namXayDung = namXayDung;
        this.soTang = soTang;
    }
    public NhaDat() { }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập năm xây dựng: ");
        namXayDung = int.Parse(Console.ReadLine());
        Console.Write("Nhập số tầng: ");
        soTang = int.Parse(Console.ReadLine());
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Năm xây dựng: {namXayDung}");
        Console.WriteLine($"Số tầng: {soTang}");
    }
}

public class ChungCu : KhuDat
{
    public int tang { get; set; }
    public ChungCu(double dienTich, double giaBan, string viTri, int tang)
        : base(dienTich, giaBan, viTri)
    {
        this.tang = tang;
    }
    public ChungCu() { }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập tầng: ");
        tang = int.Parse(Console.ReadLine());
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Tầng: {tang}");
    }
}