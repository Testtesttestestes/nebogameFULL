using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	public class LocaleTag_50 : AbstractTag
	{
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x17000903")]
		private int StartIndexInStringParams
		{
			[Token(Token = "0x6002E85")]
			[Address(RVA = "0x7F00", Offset = "0x7F00", VA = "0x7F00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x17000904")]
		private int LenInStringParams
		{
			[Token(Token = "0x6002E86")]
			[Address(RVA = "0x7F01", Offset = "0x7F01", VA = "0x7F01")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x6002E87")]
		[Address(RVA = "0x7F02", Offset = "0x7F02", VA = "0x7F02", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x7F03", Offset = "0x7F03", VA = "0x7F03")]
		public LocaleTag_50()
		{
		}

		// Token: 0x0400197D RID: 6525
		[Token(Token = "0x400197D")]
		public const string TEXT_CONTENT = "string";
	}
}
