using Microsoft.VisualBasic.ApplicationServices;
using OOP;
using OOP.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public interface IObserver
{
    void Update(Notification notification);
}
[Serializable]
public class Notification
{
    public string TieuDe { get; set; }
    public string NguoiDung { get; set; }
    public DateTime ThoiGian { get; set; }
    public string NoiDung { get; set; }

    public Notification(string tieuDe, string nguoiDung, DateTime thoiGian, string noiDung)
    {
        TieuDe = tieuDe;
        NguoiDung = nguoiDung;
        ThoiGian = thoiGian;
        NoiDung = noiDung;
    }
}