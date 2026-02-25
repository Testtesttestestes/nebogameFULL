using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.SourceTags.Tags
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class UserSourceTag : AbstractTag
	{
		// Token: 0x06002EBA RID: 11962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x7F35", Offset = "0x7F35", VA = "0x7F35")]
		public UserSourceTag()
		{
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000919")]
		public override RepeatedField<string> TextTags
		{
			[Token(Token = "0x6002EBB")]
			[Address(RVA = "0x7F36", Offset = "0x7F36", VA = "0x7F36", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x1700091A")]
		public override uint Len
		{
			[Token(Token = "0x6002EBC")]
			[Address(RVA = "0x7F37", Offset = "0x7F37", VA = "0x7F37", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x7F38", Offset = "0x7F38", VA = "0x7F38", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x0400199C RID: 6556
		[Token(Token = "0x400199C")]
		public const string NICK = "user_game_nick";
	}
}
