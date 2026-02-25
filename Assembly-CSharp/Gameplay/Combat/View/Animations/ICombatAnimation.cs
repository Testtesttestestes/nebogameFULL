using System;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000984 RID: 2436
	[Token(Token = "0x2000984")]
	public interface ICombatAnimation : IDisposable
	{
		// Token: 0x1400018D RID: 397
		// (add) Token: 0x06003A21 RID: 14881
		// (remove) Token: 0x06003A22 RID: 14882
		[Token(Token = "0x1400018D")]
		event Action<CombatAnimation.IContent> OnAnimExecuteEvent;

		// Token: 0x06003A23 RID: 14883
		[Token(Token = "0x6003A23")]
		OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path);

		// Token: 0x06003A24 RID: 14884
		[Token(Token = "0x6003A24")]
		void Append(string path, bool isLeft);

		// Token: 0x06003A25 RID: 14885
		[Token(Token = "0x6003A25")]
		void Append(CombatAnimation.IContent content);

		// Token: 0x06003A26 RID: 14886
		[Token(Token = "0x6003A26")]
		void CancelLoad();

		// Token: 0x06003A27 RID: 14887
		[Token(Token = "0x6003A27")]
		void Stop();

		// Token: 0x06003A28 RID: 14888
		[Token(Token = "0x6003A28")]
		void Reset();
	}
}
