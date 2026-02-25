using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Animations
{
	// Token: 0x0200127E RID: 4734
	[Token(Token = "0x200127E")]
	public interface IGameAnimation
	{
		// Token: 0x14000303 RID: 771
		// (add) Token: 0x06007091 RID: 28817
		// (remove) Token: 0x06007092 RID: 28818
		[Token(Token = "0x14000303")]
		event Action<IGameAnimation> ClickEvent;

		// Token: 0x14000304 RID: 772
		// (add) Token: 0x06007093 RID: 28819
		// (remove) Token: 0x06007094 RID: 28820
		[Token(Token = "0x14000304")]
		event Action<IGameAnimation> CompleteEvent;

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06007095 RID: 28821
		// (set) Token: 0x06007096 RID: 28822
		[Token(Token = "0x170016FC")]
		bool Interactable { [Token(Token = "0x6007095")] get; [Token(Token = "0x6007096")] set; }

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06007097 RID: 28823
		[Token(Token = "0x170016FD")]
		MonoBehaviour MonoBehaviour { [Token(Token = "0x6007097")] get; }

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06007098 RID: 28824
		// (set) Token: 0x06007099 RID: 28825
		[Token(Token = "0x170016FE")]
		int SortingLayerId { [Token(Token = "0x6007098")] get; [Token(Token = "0x6007099")] set; }

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600709A RID: 28826
		// (set) Token: 0x0600709B RID: 28827
		[Token(Token = "0x170016FF")]
		int SortingOrder { [Token(Token = "0x600709A")] get; [Token(Token = "0x600709B")] set; }

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x0600709C RID: 28828
		[Token(Token = "0x17001700")]
		bool Loop { [Token(Token = "0x600709C")] get; }

		// Token: 0x0600709D RID: 28829
		[Token(Token = "0x600709D")]
		void Play(bool loop);

		// Token: 0x0600709E RID: 28830
		[Token(Token = "0x600709E")]
		void Stop();

		// Token: 0x0600709F RID: 28831
		[Token(Token = "0x600709F")]
		void Play(string state, bool loop);

		// Token: 0x060070A0 RID: 28832
		[Token(Token = "0x60070A0")]
		void Pause();
	}
}
