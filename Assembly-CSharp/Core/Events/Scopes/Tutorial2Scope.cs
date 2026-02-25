using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.TutorialV2.Controller;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001034 RID: 4148
	[Token(Token = "0x2001034")]
	public class Tutorial2Scope : AbstractEventBusScope
	{
		// Token: 0x060061DD RID: 25053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061DD")]
		[Address(RVA = "0xAE08", Offset = "0xAE08", VA = "0xAE08", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061DE")]
		[Address(RVA = "0xAE09", Offset = "0xAE09", VA = "0xAE09")]
		public Tutorial2Scope()
		{
		}

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x8")]
		public Action<Tutorial2Scope.Tutorial2StepEventArgs> TutorialStepStartEvent;

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0xC")]
		public Action<Tutorial2Scope.Tutorial2StepEventArgs> TutorialStepFinishEvent;

		// Token: 0x02001035 RID: 4149
		[Token(Token = "0x2001035")]
		public class Tutorial2StepEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700139A RID: 5018
			// (get) Token: 0x060061DF RID: 25055 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700139A")]
			public string Stage
			{
				[Token(Token = "0x60061DF")]
				[Address(RVA = "0xAE0A", Offset = "0xAE0A", VA = "0xAE0A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700139B RID: 5019
			// (get) Token: 0x060061E0 RID: 25056 RVA: 0x000122A0 File Offset: 0x000104A0
			[Token(Token = "0x1700139B")]
			public int Step
			{
				[Token(Token = "0x60061E0")]
				[Address(RVA = "0xAE0B", Offset = "0xAE0B", VA = "0xAE0B")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x060061E1 RID: 25057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061E1")]
			[Address(RVA = "0xAE0C", Offset = "0xAE0C", VA = "0xAE0C")]
			public Tutorial2StepEventArgs(IApp app, IGame game, StepActionType stage, int step)
			{
			}

			// Token: 0x060061E2 RID: 25058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061E2")]
			[Address(RVA = "0xAE0D", Offset = "0xAE0D", VA = "0xAE0D")]
			public Tutorial2StepEventArgs(IApp app, IGame game, string stage, int step)
			{
			}
		}
	}
}
