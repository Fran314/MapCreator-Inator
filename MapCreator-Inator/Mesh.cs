using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapCreator_Inator
{
	class Mesh
	{
		private int N;
		private float c;
		private float[] mesh;
		private OpenSimplexNoise noise;

		public Mesh(int N)
		{
			reset(N);
		}

		public void reset(int N)
		{
			this.N = N;
			c = this.N / 8f;
			mesh = new float[this.N * this.N];
		}

		public void randomize(int octaves, long seed)
		{
			if (octaves < 1) octaves = 1;
			noise = new OpenSimplexNoise(seed);
			double min = 2, max = -1;
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					double e = 0;
					double pow = 0.5, div = 2;
					for (int k = 0; k < octaves; k++)
					{
						pow *= 2;
						div /= 2;
						e += div * noise.eval01(i * pow * 5f / N, j * pow * 5f / N);
					}
					e = e / (2 - div);
					if (i < c)
					{
						e = Math.Min(e, e * i / c + (1 - i / c) * 0.45f);
					}
					else if (i > N - c)
					{
						e = Math.Min(e, e * (N - i) / c + (1 - (N - i) / c) * 0.45f);
					}
					if (j < c)
					{
						e = Math.Min(e, e * j / c + (1 - j / c) * 0.45f);
					}
					else if (j > N - c)
					{
						e = Math.Min(e, e * (N - j) / c + (1 - (N - j) / c) * 0.45f);
					}

					if (e > max) max = e;
					if (e < min) min = e;

					mesh[i + N * j] = (float)e;
				}
			}
		}
		public void setVal(int pos, float val)
		{
			mesh[pos] = val;
		}
		public void increaseVal(int pos, float dv)
        {
			mesh[pos] += dv;
			if (mesh[pos] < 0) mesh[pos] = 0;
			else if (mesh[pos] > 1) mesh[pos] = 1;
		}
		public float[] getMesh()
		{
			return mesh;
		}
		public float getVal(int pos)
		{
			return mesh[pos];
		}
		public int getSize()
		{
			return N;
		}
	}
}
