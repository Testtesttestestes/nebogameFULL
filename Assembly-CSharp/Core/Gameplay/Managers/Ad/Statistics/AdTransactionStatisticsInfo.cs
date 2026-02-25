using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Ad.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Statistics
{
	// Token: 0x020011F9 RID: 4601
	[Token(Token = "0x20011F9")]
	public class AdTransactionStatisticsInfo
	{
		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06006D47 RID: 27975 RVA: 0x00014130 File Offset: 0x00012330
		// (set) Token: 0x06006D48 RID: 27976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163A")]
		public double WatchedTime
		{
			[Token(Token = "0x6006D47")]
			[Address(RVA = "0xB82F", Offset = "0xB82F", VA = "0xB82F")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6006D48")]
			[Address(RVA = "0xB830", Offset = "0xB830", VA = "0xB830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x00014148 File Offset: 0x00012348
		// (set) Token: 0x06006D4A RID: 27978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163B")]
		public double CloseTime
		{
			[Token(Token = "0x6006D49")]
			[Address(RVA = "0xB831", Offset = "0xB831", VA = "0xB831")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6006D4A")]
			[Address(RVA = "0xB832", Offset = "0xB832", VA = "0xB832")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4B")]
		[Address(RVA = "0xB833", Offset = "0xB833", VA = "0xB833")]
		public AdTransactionStatisticsInfo(AdTransaction transaction)
		{
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4C")]
		[Address(RVA = "0xB834", Offset = "0xB834", VA = "0xB834")]
		public void MarkAsWatched()
		{
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4D")]
		[Address(RVA = "0xB835", Offset = "0xB835", VA = "0xB835")]
		public void MarkAsClosed()
		{
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x00014160 File Offset: 0x00012360
		[Token(Token = "0x1700163C")]
		public int? CallbackDelaySec
		{
			[Token(Token = "0x6006D4E")]
			[Address(RVA = "0xB836", Offset = "0xB836", VA = "0xB836")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x00014178 File Offset: 0x00012378
		[Token(Token = "0x1700163D")]
		public int? TransactionLifeDurationSec
		{
			[Token(Token = "0x6006D4F")]
			[Address(RVA = "0xB837", Offset = "0xB837", VA = "0xB837")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003930 RID: 14640
		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x8")]
		public readonly string TransactionId;

		// Token: 0x04003931 RID: 14641
		[Token(Token = "0x4003931")]
		[FieldOffset(Offset = "0x10")]
		public readonly double CreateTime;

		// Token: 0x04003932 RID: 14642
		[Token(Token = "0x4003932")]
		[FieldOffset(Offset = "0x18")]
		public readonly uint OptionId;
	}
}
