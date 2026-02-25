using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags.Factories
{
	// Token: 0x020007C2 RID: 1986
	[Token(Token = "0x20007C2")]
	public class MetaTagFactory<T> : IMetaTagFactory where T : AbstractTag, new()
	{
		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000096D8 File Offset: 0x000078D8
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091C")]
		public EventTagDic.Types.Tag Id
		{
			[Token(Token = "0x6002ECC")]
			[CompilerGenerated]
			get
			{
				return EventTagDic.Types.Tag.UnknownTag;
			}
			[Token(Token = "0x6002ECD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECE")]
		public MetaTagFactory(EventTagDic.Types.Tag id)
		{
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002ECF")]
		public AbstractTag Create(IGame game)
		{
			return null;
		}
	}
}
