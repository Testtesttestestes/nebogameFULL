using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D76 RID: 3446
	[Token(Token = "0x2000D76")]
	public class AprOtherFilter : IAprFilter
	{
		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600547B RID: 21627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112B")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x600547A")]
			[Address(RVA = "0xA230", Offset = "0xA230", VA = "0xA230", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600547B")]
			[Address(RVA = "0xA231", Offset = "0xA231", VA = "0xA231", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x600547C")]
		[Address(RVA = "0xA232", Offset = "0xA232", VA = "0xA232", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547D")]
		[Address(RVA = "0xA233", Offset = "0xA233", VA = "0xA233")]
		public AprOtherFilter()
		{
		}
	}
}
