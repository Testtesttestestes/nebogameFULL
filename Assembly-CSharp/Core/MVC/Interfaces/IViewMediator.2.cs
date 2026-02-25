using System;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Core.MVC.Interfaces
{
	// Token: 0x02000EC6 RID: 3782
	[Token(Token = "0x2000EC6")]
	public interface IViewMediator
	{
		// Token: 0x06005C18 RID: 23576
		[Token(Token = "0x6005C18")]
		void Dispose();

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06005C19 RID: 23577
		// (set) Token: 0x06005C1A RID: 23578
		[Token(Token = "0x170012B1")]
		AbstractModel Model { [Token(Token = "0x6005C19")] get; [Token(Token = "0x6005C1A")] set; }

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06005C1B RID: 23579
		// (set) Token: 0x06005C1C RID: 23580
		[Token(Token = "0x170012B2")]
		AbstractMVCEvents Events { [Token(Token = "0x6005C1B")] get; [Token(Token = "0x6005C1C")] set; }

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06005C1D RID: 23581
		// (set) Token: 0x06005C1E RID: 23582
		[Token(Token = "0x170012B3")]
		AbstractController Controller { [Token(Token = "0x6005C1D")] get; [Token(Token = "0x6005C1E")] set; }

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06005C1F RID: 23583
		// (set) Token: 0x06005C20 RID: 23584
		[Token(Token = "0x170012B4")]
		Component View { [Token(Token = "0x6005C1F")] get; [Token(Token = "0x6005C20")] set; }
	}
}
