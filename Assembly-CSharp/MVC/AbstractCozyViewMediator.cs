using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MVC
{
	// Token: 0x02000E3B RID: 3643
	[Token(Token = "0x2000E3B")]
	public abstract class AbstractCozyViewMediator<M, E, C, V> : AbstractViewMediator<M, E, C, V> where M : AbstractModel where E : AbstractMVCEvents where C : AbstractController where V : Component
	{
		// Token: 0x0600594C RID: 22860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600594C")]
		protected AbstractCozyViewMediator(M model, E events, C controller)
		{
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600594D")]
		protected AbstractCozyViewMediator(V view, M model, E events, C controller)
		{
		}

		// Token: 0x17001234 RID: 4660
		// (set) Token: 0x0600594E RID: 22862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001234")]
		public override E Events
		{
			[Token(Token = "0x600594E")]
			set
			{
			}
		}

		// Token: 0x17001235 RID: 4661
		// (set) Token: 0x0600594F RID: 22863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001235")]
		public override V View
		{
			[Token(Token = "0x600594F")]
			set
			{
			}
		}

		// Token: 0x06005950 RID: 22864
		[Token(Token = "0x6005950")]
		protected abstract void ResetEvents(E events);

		// Token: 0x06005951 RID: 22865
		[Token(Token = "0x6005951")]
		protected abstract void SetupEvents(E events);

		// Token: 0x06005952 RID: 22866
		[Token(Token = "0x6005952")]
		protected abstract void ResetView(V view);

		// Token: 0x06005953 RID: 22867
		[Token(Token = "0x6005953")]
		protected abstract void SetupView(V view);
	}
}
