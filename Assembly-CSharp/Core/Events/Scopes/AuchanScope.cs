using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FC9 RID: 4041
	[Token(Token = "0x2000FC9")]
	public class AuchanScope : AbstractEventBusScope
	{
		// Token: 0x06006097 RID: 24727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006097")]
		[Address(RVA = "0xACC3", Offset = "0xACC3", VA = "0xACC3", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006098")]
		[Address(RVA = "0xACC4", Offset = "0xACC4", VA = "0xACC4")]
		public AuchanScope()
		{
		}

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[FieldOffset(Offset = "0x8")]
		public Action<AuchanScope.AuchanEventArgs> AuchanBuyArtifactEvent;

		// Token: 0x02000FCA RID: 4042
		[Token(Token = "0x2000FCA")]
		public class AuchanEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001302 RID: 4866
			// (get) Token: 0x06006099 RID: 24729 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001302")]
			public ArtifactData ArtifactData
			{
				[Token(Token = "0x6006099")]
				[Address(RVA = "0xACC5", Offset = "0xACC5", VA = "0xACC5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600609A RID: 24730 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600609A")]
			[Address(RVA = "0xACC6", Offset = "0xACC6", VA = "0xACC6")]
			public AuchanEventArgs(IApp app, IGame game, ArtifactData artifactData)
			{
			}
		}
	}
}
