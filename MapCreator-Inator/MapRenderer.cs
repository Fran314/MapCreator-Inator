﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapCreator_Inator
{
    class MapRenderer
	{
		public const int NODES = 1 << 0,
						DISTANCE = 1 << 1;

		private float max_length = 1 / 6f;

		private Color[] height_colormap, political_colormap;
		private Mesh map;

		public MapRenderer(Mesh map)
		{
			this.map = map;

			initializeColormaps();
		}

		public Bitmap drawHeightMap(float scale, int x_offset, int y_offset, int frame_size)
        {
			Bitmap to_return = new Bitmap(frame_size, frame_size, PixelFormat.Format24bppRgb);

			float factor = (map.getSize() - 1f) / (frame_size * scale);

			BitmapData data = to_return.LockBits(new Rectangle(0, 0, frame_size, frame_size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			int stride = data.Stride;
			float x, y, z_00, z_10, z_01, z_11, dec_x, dec_y, z;
			int ix, iy, Niy, index;
			unsafe
			{
				byte* ptr = (byte*)data.Scan0;
				for (int i = 0; i < frame_size; i++)
				{
					x = (i + x_offset) * factor;
					ix = (int)x;
					for (int j = 0; j < frame_size; j++)
					{
						y = (j + y_offset) * factor;

						iy = (int)y;
						Niy = map.getSize() * iy;
						z_00 = map.getVal(ix + Niy);
						z_10 = map.getVal(ix + 1 + Niy);
						z_01 = map.getVal(ix + Niy + map.getSize());
						z_11 = map.getVal(ix + 1 + Niy + map.getSize());
						dec_x = x - ix;
						dec_y = y - iy;
						z = z_00 * (1 - dec_x) * (1 - dec_y) + z_10 * dec_x * (1 - dec_y) + z_01 * (1 - dec_x) * dec_y + z_11 * dec_x * dec_y;

						index = (int)Math.Round(z * (height_colormap.Length - 1));
						ptr[(i * 3) + j * stride] = height_colormap[index].B;
						ptr[(i * 3) + j * stride + 1] = height_colormap[index].G;
						ptr[(i * 3) + j * stride + 2] = height_colormap[index].R;
					}
				}
			}
			to_return.UnlockBits(data);
			return to_return;
		}
		public Bitmap drawPoliticalMap(float scale, int x_offset, int y_offset, int frame_size)
		{
			Bitmap to_return = new Bitmap(frame_size, frame_size, PixelFormat.Format24bppRgb);

			/*
			using (Graphics gr = Graphics.FromImage(to_return))
			{
				Pen pen = new Pen(Color.White, 5);
				for (int i = 0; i < 4*map.getSize(); i++)
					gr.DrawLine(pen, 0, 0, 10, 10);
			}
			*/

			float factor = (map.getSize() - 1f) / (frame_size * scale);

			BitmapData data = to_return.LockBits(new Rectangle(0, 0, frame_size, frame_size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			int stride = data.Stride;
			float x, y, z_00, z_10, z_01, z_11, dec_x, dec_y, z;
			int ix, iy, Niy, index;
			unsafe
			{
				byte* ptr = (byte*)data.Scan0;
				for (int i = 0; i < frame_size; i++)
				{
					x = (i + x_offset) * factor;
					ix = (int)x;
					for (int j = 0; j < frame_size; j++)
					{
						y = (j + y_offset) * factor;

						iy = (int)y;
						Niy = map.getSize() * iy;
						z_00 = map.getVal(ix + Niy);
						z_10 = map.getVal(ix + 1 + Niy);
						z_01 = map.getVal(ix + Niy + map.getSize());
						z_11 = map.getVal(ix + 1 + Niy + map.getSize());
						dec_x = x - ix;
						dec_y = y - iy;
						z = z_00 * (1 - dec_x) * (1 - dec_y) + z_10 * dec_x * (1 - dec_y) + z_01 * (1 - dec_x) * dec_y + z_11 * dec_x * dec_y;

						index = (i * 3) + j * stride;
						if (z < 0.5)
						{
							ptr[index] = political_colormap[0].B;
							ptr[index + 1] = political_colormap[0].G;
							ptr[index + 2] = political_colormap[0].R;
						}
						else
                        {
							if(ptr[index] == 0)
							{
								ptr[index] = political_colormap[1].B;
								ptr[index + 1] = political_colormap[1].G;
								ptr[index + 2] = political_colormap[1].R;
							}
							else
							{
								ptr[index] = 0;
								ptr[index + 1] = 0;
								ptr[index + 2] = 0;
							}
                        }
					}
				}
			}
			to_return.UnlockBits(data);
			return to_return;
		}

		public void drawGizmos(Bitmap to_modify, float scale, int x_offset, int y_offset, int gizmos, int dist)
		{
			int frame_size = to_modify.Width;
			if ((gizmos & NODES) != 0)
			{
				using (Graphics gr = Graphics.FromImage(to_modify))
				{
					int start_i = (int)((x_offset + 2f) * (map.getSize() - 1f) / (scale * frame_size));
					int stop_i = (int)((frame_size + x_offset + 2f) * (map.getSize() - 1f) / (scale * frame_size)) + 1;
					int start_j = (int)((y_offset + 2f) * (map.getSize() - 1f) / (scale * frame_size));
					int stop_j = (int)((frame_size + y_offset + 2f) * (map.getSize() - 1f) / (scale * frame_size)) + 1;
					for (int i = start_i; i < stop_i; i++)
					{

						for (int j = start_j; j < stop_j; j++)
						{
							gr.FillRectangle(Brushes.Black, (int)(i * scale * frame_size / (map.getSize() - 1f) - x_offset - 2), (int)(j * scale * frame_size / (map.getSize() - 1f) - y_offset - 2), 2, 2);
						}
					}
				}
			}

			if ((gizmos & DISTANCE) != 0)
			{
				int i = (int)Math.Floor(Math.Log10(max_length * (float)dist / scale));
				int multiplier = 1;
				if (scale * 5 * Math.Pow(10, i) / dist < max_length)
				{
					multiplier = 5;
				}
				else if (scale * 2 * Math.Pow(10, i) / dist < max_length)
				{
					multiplier = 2;
				}

				int actual_len = (int)Math.Round(scale * frame_size * multiplier * Math.Pow(10, i) / dist);
				string to_write = "";
				if (i >= 0) to_write = (multiplier * Math.Pow(10, i)).ToString() + " km";
				else if (i >= -3) to_write = (multiplier * Math.Pow(10, i + 3)).ToString() + " m";
				else to_write = (multiplier * Math.Pow(10, i + 6)).ToString() + " mm";

				using (Graphics gr = Graphics.FromImage(to_modify))
				{
					gr.FillRectangle(Brushes.Black, (int)(frame_size * 0.02), (int)(frame_size * 0.98), actual_len, 4);
					gr.DrawString(to_write, SystemFonts.DefaultFont, Brushes.Black, (int)(frame_size * 0.02), (int)(frame_size * 0.98) - 14);
				}
			}
		}
	
		private void initializeColormaps()
        {
			height_colormap = new Color[256];
			for (int i = 0; i < 128; i++)
			{
				float t = i / 128f;
				height_colormap[i] = Color.FromArgb((int)(42 * (1f - t) + 94 * t), (int)(44 * (1f - t) + 79 * t), (int)(107 * (1f - t) + 162 * t));
			}
			for (int i = 128; i < 192; i++)
			{
				float t = (i - 128f) / (192f - 128f);
				height_colormap[i] = Color.FromArgb((int)(99 * (1f - t) + 246 * t), (int)(184 * (1f - t) + 250 * t), (int)(170 * (1f - t) + 174 * t));
			}
			for (int i = 192; i < 256; i++)
			{
				float t = (i - 192f) / (256f - 192f);
				height_colormap[i] = Color.FromArgb((int)(246 * (1f - t) + 221 * t), (int)(250 * (1f - t) + 75 * t), (int)(174 * (1f - t) + 74 * t));
			}

			political_colormap = new Color[2];
			political_colormap[0] = Color.DimGray;
			political_colormap[1] = Color.Gainsboro;
		}
	}
}
