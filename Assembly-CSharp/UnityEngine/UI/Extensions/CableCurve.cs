using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[Serializable]
	public class CableCurve
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public bool regenPoints
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x5630", Offset = "0x5630", VA = "0x5630")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x5631", Offset = "0x5631", VA = "0x5631")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002508 File Offset: 0x00000708
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public Vector2 start
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x5632", Offset = "0x5632", VA = "0x5632")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x5633", Offset = "0x5633", VA = "0x5633")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public Vector2 end
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x5634", Offset = "0x5634", VA = "0x5634")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x5635", Offset = "0x5635", VA = "0x5635")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002538 File Offset: 0x00000738
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public float slack
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x5636", Offset = "0x5636", VA = "0x5636")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x5637", Offset = "0x5637", VA = "0x5637")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public int steps
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x5638", Offset = "0x5638", VA = "0x5638")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x5639", Offset = "0x5639", VA = "0x5639")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x1700002A")]
		public Vector2 midPoint
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x563A", Offset = "0x563A", VA = "0x563A")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x563B", Offset = "0x563B", VA = "0x563B")]
		public CableCurve()
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x563C", Offset = "0x563C", VA = "0x563C")]
		public CableCurve(Vector2[] inputPoints)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x563D", Offset = "0x563D", VA = "0x563D")]
		public CableCurve(CableCurve v)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x563E", Offset = "0x563E", VA = "0x563E")]
		public Vector2[] Points()
		{
			return null;
		}

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Vector2 m_start;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2 m_end;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_slack;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int m_steps;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_regen;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2[] emptyCurve;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2[] points;
	}
}
