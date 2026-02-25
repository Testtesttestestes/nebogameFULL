using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D90 RID: 3472
	[Token(Token = "0x2000D90")]
	internal class EffectData
	{
		// Token: 0x060054F1 RID: 21745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0xA297", Offset = "0xA297", VA = "0xA297")]
		public EffectData(Antiq.Types.EffectsDic effectsDic, ArtifactData artifact, ReadOnlyCollection<Antiq.Types.EffectsDic.Types.EffectStringValueDic> effectValueStrings)
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0xA298", Offset = "0xA298", VA = "0xA298")]
		public uint GetIntegerValue()
		{
			return 0U;
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0xA299", Offset = "0xA299", VA = "0xA299")]
		public string GetValue()
		{
			return null;
		}

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x8")]
		private readonly ReadOnlyCollection<Antiq.Types.EffectsDic.Types.EffectStringValueDic> _effectValueStrings;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0xC")]
		public readonly Antiq.Types.EffectsDic EffectsDic;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[FieldOffset(Offset = "0x10")]
		public readonly ArtifactData Artifact;
	}
}
