using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class BezierPath
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5623", Offset = "0x5623", VA = "0x5623")]
		public BezierPath()
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x5624", Offset = "0x5624", VA = "0x5624")]
		public void SetControlPoints(List<Vector2> newControlPoints)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x5625", Offset = "0x5625", VA = "0x5625")]
		public void SetControlPoints(Vector2[] newControlPoints)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x5626", Offset = "0x5626", VA = "0x5626")]
		public List<Vector2> GetControlPoints()
		{
			return null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5627", Offset = "0x5627", VA = "0x5627")]
		public void Interpolate(List<Vector2> segmentPoints, float scale)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x5628", Offset = "0x5628", VA = "0x5628")]
		public void SamplePoints(List<Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5629", Offset = "0x5629", VA = "0x5629")]
		public Vector2 CalculateBezierPoint(int curveIndex, float t)
		{
			return default(Vector2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x562A", Offset = "0x562A", VA = "0x562A")]
		public List<Vector2> GetDrawingPoints0()
		{
			return null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x562B", Offset = "0x562B", VA = "0x562B")]
		public List<Vector2> GetDrawingPoints1()
		{
			return null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x562C", Offset = "0x562C", VA = "0x562C")]
		public List<Vector2> GetDrawingPoints2()
		{
			return null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x562D", Offset = "0x562D", VA = "0x562D")]
		private List<Vector2> FindDrawingPoints(int curveIndex)
		{
			return null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x562E", Offset = "0x562E", VA = "0x562E")]
		private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector2> pointList, int insertionIndex)
		{
			return 0;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x562F", Offset = "0x562F", VA = "0x562F")]
		private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(Vector2);
		}

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x8")]
		public int SegmentsPerCurve;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0xC")]
		public float MINIMUM_SQR_DISTANCE;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x10")]
		public float DIVISION_THRESHOLD;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x14")]
		private List<Vector2> controlPoints;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x18")]
		private int curveCount;
	}
}
