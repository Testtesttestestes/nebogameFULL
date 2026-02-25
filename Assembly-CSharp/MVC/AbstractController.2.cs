using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MVC
{
	// Token: 0x02000E3A RID: 3642
	[Token(Token = "0x2000E3A")]
	public abstract class AbstractController<M, E> : AbstractController where M : AbstractModel where E : AbstractMVCEvents
	{
		// Token: 0x06005946 RID: 22854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005946")]
		public override void Dispose()
		{
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005947")]
		public AbstractController(M model, E events)
		{
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06005948 RID: 22856 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005949 RID: 22857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001232")]
		public virtual M Model
		{
			[Token(Token = "0x6005948")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005949")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600594A RID: 22858 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600594B RID: 22859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001233")]
		public virtual E Events
		{
			[Token(Token = "0x600594A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600594B")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
