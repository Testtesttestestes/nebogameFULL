using System;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Utils
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class BackTime : IComparable
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1CA5", Offset = "0x1CA5", VA = "0x1CA5")]
		public BackTime(float value = 0f)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002880 File Offset: 0x00000A80
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public float Backtime
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x1BC0", Offset = "0x1BC0", VA = "0x1BC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2197", Offset = "0x2197", VA = "0x2197")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x1700005A")]
		public float OriginalValue
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x56C7", Offset = "0x56C7", VA = "0x56C7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x56C8", Offset = "0x56C8", VA = "0x56C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x56C9", Offset = "0x56C9", VA = "0x56C9", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x56CA", Offset = "0x56CA", VA = "0x56CA")]
		public static bool operator >([NotNull] BackTime lt, [NotNull] BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x56CB", Offset = "0x56CB", VA = "0x56CB")]
		public static bool operator <(BackTime lt, BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x56CC", Offset = "0x56CC", VA = "0x56CC")]
		public static bool operator >=([NotNull] BackTime lt, [NotNull] BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x56CD", Offset = "0x56CD", VA = "0x56CD")]
		public static bool operator <=(BackTime lt, BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x8")]
		private float _originalValue;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0xC")]
		private float _backtime;
	}
}
