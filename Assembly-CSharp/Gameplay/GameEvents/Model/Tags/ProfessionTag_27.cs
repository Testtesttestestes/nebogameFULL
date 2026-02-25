using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x20007AF")]
	public class ProfessionTag_27 : AbstractTag
	{
		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x17000909")]
		public uint ProfessionId
		{
			[Token(Token = "0x6002E94")]
			[Address(RVA = "0x7F0F", Offset = "0x7F0F", VA = "0x7F0F")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x1700090A")]
		public uint ProfessionLevel
		{
			[Token(Token = "0x6002E95")]
			[Address(RVA = "0x7F10", Offset = "0x7F10", VA = "0x7F10")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x7F11", Offset = "0x7F11", VA = "0x7F11", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E97")]
		[Address(RVA = "0x7F12", Offset = "0x7F12", VA = "0x7F12")]
		public ProfessionTag_27()
		{
		}

		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		public const string PROFESSION_TITLE = "profession_title";

		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		public const string PROFESSION_LEVEL = "profession_level";
	}
}
