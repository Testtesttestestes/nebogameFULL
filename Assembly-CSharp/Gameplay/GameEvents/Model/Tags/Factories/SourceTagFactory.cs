using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Factories
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	public class SourceTagFactory<T> : ISourceTagFactory where T : AbstractTag, new()
	{
		// Token: 0x06002ED0 RID: 11984 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002ED0")]
		public AbstractTag Create()
		{
			return null;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED1")]
		public SourceTagFactory()
		{
		}
	}
}
