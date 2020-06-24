using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlikhohang.Models;

namespace Quanlikhohang.NghiepVu
{
    public static class Exporter
    {
        static TableProperties Bordered()
        {
            return new TableProperties()
            {
                TableBorders = new TableBorders
                (
                    new TopBorder()
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single)
                    },
                    new BottomBorder()
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single)
                    },
                    new LeftBorder()
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single)
                    },
                    new RightBorder()
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single)
                    },
                    new InsideHorizontalBorder()
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single)
                    },
                    new InsideVerticalBorder()
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single)
                    }
                )
            };
        }

        static TableCell QuickTableCell(string text)
        {
            return new TableCell(new Paragraph(new Run(new Text(text))));
        }

        static TableRow QuickTableRow(params string[] cellValues)
        {
            TableRow row = new TableRow();
            foreach (string cellValue in cellValues)
            {
                row.Append(QuickTableCell(cellValue));
            }
            return row;
        }
        
        public static void ExportToFile(Models.BienBanThanhLy bienBan, string filePath)
        {
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();

                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph p = body.AppendChild(new Paragraph());

                Run title = p.AppendChild(new Run());
                title.Append(new RunProperties()
                {
                    Bold = new Bold(),
                });
                title.AppendChild
                (
                    new Text("Biên bản thanh lý nguyên liệu")
                );

                Table table = new Table(Bordered());

                table.Append
                (
                    QuickTableRow
                    (
                        "STT", "Tên nguyên liệu", "Số lượng",
                        "Đơn vị", "Giá tiền trên một đơn vị thanh lý",
                        "Tổng tiền"
                    )
                );

                int i;
                double tongTien = 0;
                for (i = 0; i < bienBan.ChiTietBBTLs.Count; ++i)
                {
                    Models.ChiTietBBTL chiTiet = bienBan.ChiTietBBTLs.ElementAt(i);
                    table.Append
                    (
                        QuickTableRow
                        (
                            (i + 1).ToString(), chiTiet.NguyenLieu.TenNL, chiTiet.Gia.ToString("N0"),
                            chiTiet.SoLuong.ToString("N1"), chiTiet.NguyenLieu.TenDonVi, (chiTiet.Gia * chiTiet.SoLuong).ToString("N0")
                        )
                    );
                    tongTien += chiTiet.Gia * chiTiet.SoLuong;
                }

                table.Append(QuickTableRow("", "", "", "", "Tổng giá:", tongTien.ToString("N0")));

                body.AppendChild(table);

                body.Append
                (
                    new Paragraph
                    (
                        new Run
                        (
                            new Break(),
                            new Text
                            (
                                "Ngày lập: " + bienBan.NgayLap.GetValueOrDefault().ToString("dd/MM/yyyy")
                            ), new TabChar(), new TabChar(),
                            new Text
                            (
                                "Nhân viên ký xác nhận:"
                            ), new Break(), new Break(), new Break(), new Break(),
                            new TabChar(), new TabChar(), new TabChar(), new TabChar(),
                            new Text
                            (
                                bienBan.NhanVien.HoTen
                            )
                        )
                    )
                );
            }
        }
    }
}
