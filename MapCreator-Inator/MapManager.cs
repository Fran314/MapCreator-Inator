using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapCreator_Inator
{
    class MapManager
	{
		public const int HEIGHTMAP = 0,
						POLITICALMAP = 1;

		private Mesh map;
        private MapRenderer renderer;

		private int x_offset, y_offset;
		private float scale;

		public MapManager(int N)
        {
            map = new Mesh(N);
            renderer = new MapRenderer(map);
			scale = 1f;
			x_offset = 0;
			y_offset = 0;
        }

		public void changeAtPos(float dv, int frame_size, int cursor_x, int cursor_y, float inner_radius, float radius)
		{
			int N = map.getSize();
			float pos_x = (cursor_x + x_offset) * (N-1) / (frame_size * scale);
			float pos_y = (cursor_y + y_offset) * (N-1) / (frame_size * scale);
			int start_x = Util.Clamp((int)(pos_x - radius)+1, 0, N-1), start_y = Util.Clamp((int)(pos_y - radius)+1, 0, N-1);
			int end_x = Util.Clamp((int)(pos_x + radius), 0, N-1), end_y = Util.Clamp((int)(pos_y + radius), 0, N-1);

			for (int i = start_x; i <= end_x; i++)
			{
				for (int j = start_y; j <= end_y; j++)
				{
					float dist = (float)Math.Sqrt((i - pos_x) * (i - pos_x) + (j - pos_y) * (j - pos_y));
					if (dist < inner_radius)
					{
						map.increaseVal(i + j * N, dv);
					}
					else if (dist < radius)
					{
						float factor = (radius - dist) / (radius - inner_radius);
						if (factor < 0f) factor = 0f;
						map.increaseVal(i + j * N, dv * factor);
					}
				}
            }
		}

		public void levelAtPos(float lerp, int frame_size, int cursor_x, int cursor_y, float inner_radius, float radius)
		{
			int N = map.getSize();
			float pos_x = (cursor_x + x_offset) * (N - 1) / (frame_size * scale);
			float pos_y = (cursor_y + y_offset) * (N - 1) / (frame_size * scale);
			int start_x = Util.Clamp((int)(pos_x - radius) + 1, 0, N - 1), start_y = Util.Clamp((int)(pos_y - radius) + 1, 0, N - 1);
			int end_x = Util.Clamp((int)(pos_x + radius), 0, N - 1), end_y = Util.Clamp((int)(pos_y + radius), 0, N - 1);

			float average = 0;
			for (int i = start_x; i <= end_x; i++)
			{
				for (int j = start_y; j <= end_y; j++)
				{
					float dist = (float)Math.Sqrt((i - pos_x) * (i - pos_x) + (j - pos_y) * (j - pos_y));
					if (dist < radius)
					{
						average += map.getVal(i + j * N);
					}
				}
			}
			average /= (float)Math.PI * radius * radius;
			for (int i = start_x; i <= end_x; i++)
			{
				for (int j = start_y; j <= end_y; j++)
				{
					float dist = (float)Math.Sqrt((i - pos_x) * (i - pos_x) + (j - pos_y) * (j - pos_y));
					if (dist < inner_radius)
					{
						map.increaseVal(i + j * N, (average - map.getVal(i + j*N)) * lerp);
					}
					else if (dist < radius)
					{
						float factor = (radius - dist) / (radius - inner_radius);
						if (factor < 0f) factor = 0f;
						map.increaseVal(i + j * N, (average - map.getVal(i + j * N)) * lerp * factor);
					}
				}
			}
		}

		public void resetMap(int N)
        {
			map.reset(N);
        }
        public long randomize(int octaves)
		{
			long seed = Guid.NewGuid().GetHashCode();
			map.randomize(octaves, seed);
			return seed;
		}
		public void randomize(int octaves, long seed)
        {
			map.randomize(octaves, seed);
        }
		public int getSize()
        {
			return map.getSize();
        }

		public Bitmap getImage(int frame_size, int map_type, int gizmos, int dist)
		{
			if (frame_size <= 0) return new Bitmap(1, 1);
			if ((frame_size - 1 + x_offset) / (frame_size * scale) >= 1) x_offset = (int)(frame_size * (scale - 1));
			if ((frame_size - 1 + y_offset) / (frame_size * scale) >= 1) y_offset = (int)(frame_size * (scale - 1));

			Bitmap new_image = null;
			switch (map_type)
			{
				case HEIGHTMAP:
					new_image = renderer.drawHeightMap(scale, x_offset, y_offset, frame_size);
					break;
				case POLITICALMAP:
					new_image = renderer.drawPoliticalMap(scale, x_offset, y_offset, frame_size);
					break;
			}

			renderer.drawGizmos(new_image, scale, x_offset, y_offset, gizmos, dist);
			return new_image;
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
		public void unhdOffset(bool is_hd)
        {
			if(is_hd)
            {
				x_offset *= 2;
				y_offset *= 2;
            }
			else
            {
				x_offset /= 2;
				y_offset /= 2;
            }
        }
		public float getScale()
        {
			return scale;
        }
	}
}
