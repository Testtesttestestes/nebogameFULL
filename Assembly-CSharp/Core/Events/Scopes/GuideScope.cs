using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001008 RID: 4104
	[Token(Token = "0x2001008")]
	public class GuideScope : AbstractEventBusScope
	{
		// Token: 0x06006148 RID: 24904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006148")]
		[Address(RVA = "0xAD73", Offset = "0xAD73", VA = "0xAD73", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006149")]
		[Address(RVA = "0xAD74", Offset = "0xAD74", VA = "0xAD74")]
		public GuideScope()
		{
		}

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0x8")]
		public Action<GuideScope.GuideEventArgs> GuideStepCompleteEvent;

		// Token: 0x02001009 RID: 4105
		[Token(Token = "0x2001009")]
		public class GuideEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001342 RID: 4930
			// (get) Token: 0x0600614A RID: 24906 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001342")]
			public GuideConfig Config
			{
				[Token(Token = "0x600614A")]
				[Address(RVA = "0xAD75", Offset = "0xAD75", VA = "0xAD75")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600614B RID: 24907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600614B")]
			[Address(RVA = "0xAD76", Offset = "0xAD76", VA = "0xAD76")]
			public GuideEventArgs(App app, IGame game, GuideConfig config)
			{
			}
		}
	}
}
