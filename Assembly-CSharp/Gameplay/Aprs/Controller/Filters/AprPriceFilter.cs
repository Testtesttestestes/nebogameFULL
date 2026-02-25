using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D77 RID: 3447
	[Token(Token = "0x2000D77")]
	public class AprPriceFilter : IAprFilter
	{
		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600547F RID: 21631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112C")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x600547E")]
			[Address(RVA = "0xA234", Offset = "0xA234", VA = "0xA234", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600547F")]
			[Address(RVA = "0xA235", Offset = "0xA235", VA = "0xA235", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x6005480")]
		[Address(RVA = "0xA236", Offset = "0xA236", VA = "0xA236", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005481")]
		[Address(RVA = "0xA237", Offset = "0xA237", VA = "0xA237")]
		public AprPriceFilter()
		{
		}
	}
}
