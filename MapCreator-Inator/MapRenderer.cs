using System;
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
		public const int NODES = 1 << 0;
		public const int DISTANCE = 1 << 1;

		private float max_length = 1 / 6f;

		private Mesh mesh;

		private int x_offset, y_offset;
		private float scale;

		public MapRenderer(Mesh mesh)
		{
			this.mesh = mesh;
			scale = 1f;
			x_offset = 0;
			y_offset = 0;
		}

		public void updateImage(Image to_modify, Color[] colormap, int gizmos, int dist)
		{
			int frame_size = to_modify.Width;
			if (frame_size <= 0) return;

			if ((frame_size - 1 + x_offset) / (frame_size * scale) >= 1) x_offset = (int)(frame_size * (scale - 1));
			if ((frame_size - 1 + y_offset) / (frame_size * scale) >= 1) y_offset = (int)(frame_size * (scale - 1));

			float factor = (mesh.getSize() - 1f) / (frame_size * scale);

			BitmapData data = ((Bitmap)to_modify).LockBits(new Rectangle(0, 0, to_modify.Width, to_modify.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
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
						Niy = mesh.getSize() * iy;
						z_00 = mesh.getVal(ix + Niy);
						z_10 = mesh.getVal(ix + 1 + Niy);
						z_01 = mesh.getVal(ix + Niy + mesh.getSize());
						z_11 = mesh.getVal(ix + 1 + Niy + mesh.getSize());
						dec_x = x - ix;
						dec_y = y - iy;
						z = z_00 * (1 - dec_x) * (1 - dec_y) + z_10 * dec_x * (1 - dec_y) + z_01 * (1 - dec_x) * dec_y + z_11 * dec_x * dec_y;

						index = (int)Math.Round(z * (colormap.Length - 1));
						ptr[(i * 3) + j * stride] = colormap[index].B;
						ptr[(i * 3) + j * stride + 1] = colormap[index].G;
						ptr[(i * 3) + j * stride + 2] = colormap[index].R;
					}
				}
			}
			((Bitmap)to_modify).UnlockBits(data);

			if ((gizmos & NODES) != 0)
			{
				using (Graphics gr = Graphics.FromImage(to_modify))
				{
					int start_i = (int)((x_offset + 2f) * (mesh.getSize() - 1f) / (scale * frame_size));
					int stop_i = (int)((frame_size + x_offset + 2f) * (mesh.getSize() - 1f) / (scale * frame_size)) + 1;
					int start_j = (int)((y_offset + 2f) * (mesh.getSize() - 1f) / (scale * frame_size));
					int stop_j = (int)((frame_size + y_offset + 2f) * (mesh.getSize() - 1f) / (scale * frame_size)) + 1;
					for (int i = start_i; i < stop_i; i++)
					{

						for (int j = start_j; j < stop_j; j++)
						{
							gr.FillRectangle(Brushes.Black, (int)(i * scale * frame_size / (mesh.getSize() - 1f) - x_offset - 2), (int)(j * scale * frame_size / (mesh.getSize() - 1f) - y_offset - 2), 4, 4);
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

		public float setScaleFixingPoint(float new_scale, int pos_x, int pos_y)
        {
			float ds = new_scale / scale;
			return changeScaleFixingPoint(ds, pos_x, pos_y);
        }
		public float changeScaleFixingPoint(float ds, int pos_x, int pos_y)
		{
			float c = ds;
			float temp_scale = scale * c;
			if (temp_scale < 1f)
			{
				temp_scale = 1f;
				c = temp_scale / scale;
				scale = temp_scale;
			}
			else if (temp_scale > Math.Pow(Math.E, 11))
			{
				temp_scale = (float)Math.Pow(Math.E, 11);
				c = temp_scale / scale;
				scale = temp_scale;
			}
			else
            {
				scale = temp_scale;
            }

			x_offset = (int)(c * (pos_x + x_offset) - pos_x);
			y_offset = (int)(c * (pos_y + y_offset) - pos_y);
			if (x_offset < 0) x_offset = 0;
			if (y_offset < 0) y_offset = 0;

			return scale;
		}
		public void changeOffset(int dx, int dy)
		{
			x_offset += dx;
			y_offset += dy;
			if (x_offset < 0) x_offset = 0;
			if (y_offset < 0) y_offset = 0;
		}
	}
}
