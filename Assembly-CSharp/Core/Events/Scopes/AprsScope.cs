using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FC7 RID: 4039
	[Token(Token = "0x2000FC7")]
	public class AprsScope : AbstractEventBusScope
	{
		// Token: 0x06006093 RID: 24723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006093")]
		[Address(RVA = "0xACBF", Offset = "0xACBF", VA = "0xACBF", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006094")]
		[Address(RVA = "0xACC0", Offset = "0xACC0", VA = "0xACC0")]
		public AprsScope()
		{
		}

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[FieldOffset(Offset = "0x8")]
		public Action<AprsScope.AprsEventArgs> BuyAprEvent;

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[FieldOffset(Offset = "0xC")]
		public Action<AprsScope.AprsEventArgs> NewAprEvent;

		// Token: 0x02000FC8 RID: 4040
		[Token(Token = "0x2000FC8")]
		public class AprsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001301 RID: 4865
			// (get) Token: 0x06006095 RID: 24725 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001301")]
			public AprData AprData
			{
				[Token(Token = "0x6006095")]
				[Address(RVA = "0xACC1", Offset = "0xACC1", VA = "0xACC1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006096 RID: 24726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006096")]
			[Address(RVA = "0xACC2", Offset = "0xACC2", VA = "0xACC2")]
			public AprsEventArgs(App app, IGame game, AprData aprData)
			{
			}
		}
	}
}
