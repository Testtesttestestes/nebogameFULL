using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D79 RID: 3449
	[Token(Token = "0x2000D79")]
	public class AprTitleFilter : IAprFilter
	{
		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005487 RID: 21639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112E")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6005486")]
			[Address(RVA = "0xA23C", Offset = "0xA23C", VA = "0xA23C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005487")]
			[Address(RVA = "0xA23D", Offset = "0xA23D", VA = "0xA23D", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x6005488")]
		[Address(RVA = "0xA23E", Offset = "0xA23E", VA = "0xA23E", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005489")]
		[Address(RVA = "0xA23F", Offset = "0xA23F", VA = "0xA23F")]
		public AprTitleFilter()
		{
		}
	}
}
