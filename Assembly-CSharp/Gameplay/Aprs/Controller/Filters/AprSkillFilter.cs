using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D78 RID: 3448
	[Token(Token = "0x2000D78")]
	public class AprSkillFilter : IAprFilter
	{
		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005483 RID: 21635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112D")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6005482")]
			[Address(RVA = "0xA238", Offset = "0xA238", VA = "0xA238", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005483")]
			[Address(RVA = "0xA239", Offset = "0xA239", VA = "0xA239", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x6005484")]
		[Address(RVA = "0xA23A", Offset = "0xA23A", VA = "0xA23A", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005485")]
		[Address(RVA = "0xA23B", Offset = "0xA23B", VA = "0xA23B")]
		public AprSkillFilter()
		{
		}
	}
}
