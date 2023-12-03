using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDFWatermark
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btOpenfile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();

            //openFileDialogPDF.Multiselect = true;
            //openFileDialogPDF.Title = "请选择文件";
            //openFileDialogPDF.Filter = "所有 PDF 文件|*.pdf"; //设置要选择的文件的类型
            if (openFileDialogPDF.ShowDialog() == DialogResult.OK)
            {
                //System.IO.Path.GetFullPath(openFileDialogPDF.FileName);//绝对路径
                //System.IO.Path.GetExtension(openFileDialogPDF.FileName);//文件扩展名
                //System.IO.Path.GetFileNameWithoutExtension(openFileDialogPDF.FileName);//文件名没有扩展名
                //System.IO.Path.GetFileName(openFileDialogPDF.FileName);//得到文件名
                //System.IO.Path.GetDirectoryName(openFileDialogPDF.FileName);//得到路径

                // tbFilename.Text = openFileDialogPDF.FileName;//返回文件的完整路径
                // 清除 listbox 项目
                lbPdfFiles.Items.Clear();
                // 填充 listbox
                foreach (String file in openFileDialogPDF.FileNames)
                {                    
                    try
                    {
                        lbPdfFiles.Items.Add(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("文件打开错误！");
                    }
                }
            }
        }

        private void btMark_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            if (lbPdfFiles.Items.Count > 0)
            {
                foreach (String file in lbPdfFiles.Items)
                {
                    string outFile = System.IO.Path.GetDirectoryName(file) + "\\水印" + System.IO.Path.GetFileName(file);
                    bool convertIsok = add_watermark(file, outFile);
                    if (convertIsok)
                    {
                        msg += file + "\n";
                        //MessageBox.Show("PDF 水印添加成功！");
                    }
                }
                MessageBox.Show(msg + "已成功添加水印！");
            }
            else
            {
                MessageBox.Show("请选择需要添加水印的 PDF 文件！");
            }
        }

        //给单个文件添加水印
        //所有参数均为全路径文件名
        bool add_watermark(string srcPdf, string dstPdf)//, string imagepath)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.HQWatermark.Save(ms, Properties.Resources.HQWatermark.RawFormat);
                byte[] byteImage = new Byte[ms.Length];
                byteImage = ms.ToArray();

                // iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagepath);
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                PdfReader reader = new PdfReader(srcPdf);
                PdfStamper stamp = new PdfStamper(reader, new FileStream(dstPdf, FileMode.Create));


                PdfGState gs1 = new PdfGState();
                gs1.FillOpacity = 0.5f;// 透明度设置

                PdfContentByte page;
                float width = reader.GetPageSize(1).Width;
                float height = reader.GetPageSize(1).Height;

                //img.SetAbsolutePosition(img.ScaledWidth, img.ScaledHeight); // 坐标
                img.ScalePercent(30);//依照比例缩放
                img.SetAbsolutePosition((width - img.ScaledWidth) / 2, (height - img.ScaledHeight) / 2);
                //img.Rotation = -20;// 旋转 弧度
                //img.RotationDegrees = 45;// 旋转 角度
                // img.scaleAbsolute(200,100);//自定义大小            

                int num = reader.NumberOfPages;
                for (int i = 1; i <= num; ++i)
                {
                    // page = stamp.GetUnderContent(i); // 水印在之前文本下
                    page = stamp.GetOverContent(i); //水印在之前文本上

                    page.SetGState(gs1);
                    page.AddImage(img);

                    //img.SetAbsolutePosition(width - img.Width - margin, height - img.Height - margin);
                    //page.AddImage(img);
                }

                stamp.Close();
                reader.Close();

                return true;
            }
            catch(IOException ioex)
            {
                MessageBox.Show(srcPdf + "\n无法保存添加水印文件，可能是文件已经打开，请关闭！\n其它文件将继续添加水印！");
                return false;
            }
        }        
    }
}
