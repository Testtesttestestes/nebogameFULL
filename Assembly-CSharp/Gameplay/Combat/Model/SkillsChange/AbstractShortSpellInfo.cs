using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Combat.Model.SkillsChange
{
	// Token: 0x020009A2 RID: 2466
	[Token(Token = "0x20009A2")]
	public abstract class AbstractShortSpellInfo<T> : IShortSpellInfo, IDisposable where T : class
	{
		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06003AF2 RID: 15090
		[Token(Token = "0x17000BAD")]
		public abstract SpellKey SpellKey { [Token(Token = "0x6003AF2")] get; }

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06003AF3 RID: 15091
		[Token(Token = "0x17000BAE")]
		public abstract IList<EffectInfo> Effects { [Token(Token = "0x6003AF3")] get; }

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF4")]
		public void Dispose()
		{
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF5")]
		protected AbstractShortSpellInfo(T info)
		{
		}

		// Token: 0x04002091 RID: 8337
		[Token(Token = "0x4002091")]
		[FieldOffset(Offset = "0x0")]
		protected T _info;
	}
}
