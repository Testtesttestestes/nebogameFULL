using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D8D RID: 3469
	[Token(Token = "0x2000D8D")]
	internal class ArtifactData
	{
		// Token: 0x060054E5 RID: 21733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x1D19", Offset = "0x1D19", VA = "0x1D19")]
		public ArtifactData(int index, Antiq.Types.ArtifactsDic artifactDic)
		{
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054E6")]
		[Address(RVA = "0x1D1A", Offset = "0x1D1A", VA = "0x1D1A")]
		public RewardInfo[] GetEffectsRewards()
		{
			return null;
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E7")]
		[Address(RVA = "0x1D1B", Offset = "0x1D1B", VA = "0x1D1B")]
		public void AddEffects(IEnumerable<EffectData> value)
		{
		}

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<EffectData> _effects;

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[FieldOffset(Offset = "0xC")]
		public readonly Antiq.Types.ArtifactsDic ArtifactDic;

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[FieldOffset(Offset = "0x10")]
		public readonly ReadOnlyCollection<EffectData> Effects;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Index;
	}
}
