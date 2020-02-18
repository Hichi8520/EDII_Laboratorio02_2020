using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Text;

namespace Lab02_EDII.Models
{
	public class Tree
	{
		public Tree()
        {
			string path = @"C:\Users\hichi\Desktop\Test.txt";

			if (File.Exists(path))
			{
				File.Delete(path);
			}
			using (FileStream oFS = File.Create(path))
			{
				Byte[] myInfo = new UTF8Encoding(true).GetBytes("hola");
				oFS.Write(myInfo, 0, myInfo.Length);
			}
		}

		public void AddSoda(Soda NewSoda)
		{
			string path = @"C:\Users\hichi\Desktop\Test.txt";

			if (File.Exists(path))
			{
				File.Delete(path);
			}
			using (FileStream oFS = File.Create(path))
			{
				Byte[] myInfo = new UTF8Encoding(true).GetBytes("1||||||"+NewSoda.Name+","+NewSoda.Volume.ToString()+","+NewSoda.Volume+","+NewSoda.Price.ToString()+","+NewSoda.Factory);
				oFS.Write(myInfo, 0, myInfo.Length);
			}
		}
    }
}
