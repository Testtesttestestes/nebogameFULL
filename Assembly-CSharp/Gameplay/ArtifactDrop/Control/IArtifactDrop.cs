using System;
using Core.Data;
using Gameplay.ArtifactDrop.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;

namespace Gameplay.ArtifactDrop.Control
{
	// Token: 0x02000CD1 RID: 3281
	[Token(Token = "0x2000CD1")]
	public interface IArtifactDrop
	{
		// Token: 0x06004FE4 RID: 20452
		[Token(Token = "0x6004FE4")]
		void Remove(DropTypes dropType);

		// Token: 0x06004FE5 RID: 20453
		[Token(Token = "0x6004FE5")]
		void Remove(ArtifactData[] artifacts);

		// Token: 0x06004FE6 RID: 20454
		[Token(Token = "0x6004FE6")]
		void Remove(ArtifactData artifact);

		// Token: 0x06004FE7 RID: 20455
		[Token(Token = "0x6004FE7")]
		void SetDrop(DropTypes dropType, params ArtifactInfo[] artifactInfo);

		// Token: 0x06004FE8 RID: 20456
		[Token(Token = "0x6004FE8")]
		bool TryGetDrop(DropTypes dropType, out ArtifactDropModel.ArtifactDrop drop);
	}
}
