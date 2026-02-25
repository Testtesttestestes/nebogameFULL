using System;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Effect
{
	// Token: 0x020010EC RID: 4332
	[Token(Token = "0x20010EC")]
	public class EffectDescription : AbstractEffectDescription
	{
		// Token: 0x06006548 RID: 25928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006548")]
		[Address(RVA = "0xB114", Offset = "0xB114", VA = "0xB114")]
		public EffectDescription(string sourceText, EffectData[] effects, Skills userSkills)
		{
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006549")]
		[Address(RVA = "0xB115", Offset = "0xB115", VA = "0xB115", Slot = "7")]
		protected override string FormatUserSkillValue(long validValue, long rawValue)
		{
			return null;
		}
	}
}
