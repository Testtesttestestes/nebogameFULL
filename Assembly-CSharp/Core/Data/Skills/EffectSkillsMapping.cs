using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D1 RID: 4305
	[Token(Token = "0x20010D1")]
	public static class EffectSkillsMapping
	{
		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700146E")]
		public static Dictionary<int, string> SkillsIndexNameDefinition
		{
			[Token(Token = "0x60064D8")]
			[Address(RVA = "0xB0BA", Offset = "0xB0BA", VA = "0xB0BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		public const string TURNS_DURATION_NAME = "duration";

		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		public const string TIME_DURATION__NAME = "time_durationSEC";

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		public const string MAX_STACK_SIZE_NAME = "maxStackSize";

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		public const string CASTER_SCALER_MULTIPLIER_NAME = "casterScaler";

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, string> _skillsIndexNameDefinition;
	}
}
