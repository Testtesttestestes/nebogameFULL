using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.SourceTags.Tags
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	public class ClanSourceTag : AbstractTag
	{
		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000915")]
		public override RepeatedField<string> TextTags
		{
			[Token(Token = "0x6002EB3")]
			[Address(RVA = "0x7F2E", Offset = "0x7F2E", VA = "0x7F2E", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x17000916")]
		public override uint Len
		{
			[Token(Token = "0x6002EB4")]
			[Address(RVA = "0x7F2F", Offset = "0x7F2F", VA = "0x7F2F", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0x7F30", Offset = "0x7F30", VA = "0x7F30")]
		public ClanSourceTag()
		{
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x6002EB6")]
		[Address(RVA = "0x7F31", Offset = "0x7F31", VA = "0x7F31", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x04001999 RID: 6553
		[Token(Token = "0x4001999")]
		public const string TITLE = "clan_title";
	}
}
