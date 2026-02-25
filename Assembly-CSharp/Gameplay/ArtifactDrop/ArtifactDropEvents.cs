using System;
using Core.Data;
using Gameplay.ArtifactDrop.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.ArtifactDrop
{
	// Token: 0x02000CC6 RID: 3270
	[Token(Token = "0x2000CC6")]
	public class ArtifactDropEvents : AbstractMVCEvents
	{
		// Token: 0x06004F9F RID: 20383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9F")]
		[Address(RVA = "0x9DB8", Offset = "0x9DB8", VA = "0x9DB8")]
		public ArtifactDropEvents()
		{
		}

		// Token: 0x04002B5D RID: 11101
		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0x14")]
		public Action<ArtifactDropModel.ArtifactDrop> OnReadyDropEvent;

		// Token: 0x04002B5E RID: 11102
		[Token(Token = "0x4002B5E")]
		[FieldOffset(Offset = "0x18")]
		public Action<DropTypes> OnDropRemoveEvent;

		// Token: 0x04002B5F RID: 11103
		[Token(Token = "0x4002B5F")]
		[FieldOffset(Offset = "0x1C")]
		public Action<DropTypes, ArtifactData> OnArtifactDropRemoveEvent;

		// Token: 0x04002B60 RID: 11104
		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x20")]
		public Action<DropTypes, ArtifactData[]> OnArtifactDropAddEvent;
	}
}
