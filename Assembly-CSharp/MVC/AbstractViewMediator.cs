using System;
using System.Runtime.CompilerServices;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using UnityEngine;

namespace MVC
{
	// Token: 0x02000E3E RID: 3646
	[Token(Token = "0x2000E3E")]
	public abstract class AbstractViewMediator<M, E, C, V> : IDisposable, IViewMediator where M : AbstractModel where E : AbstractMVCEvents where C : AbstractController where V : Component
	{
		// Token: 0x06005959 RID: 22873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005959")]
		public virtual void Dispose()
		{
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600595A")]
		public AbstractViewMediator(M model, E events, C controller)
		{
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600595C RID: 22876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001237")]
		public M Model
		{
			[Token(Token = "0x600595B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600595C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600595E RID: 22878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001238")]
		public virtual E Events
		{
			[Token(Token = "0x600595D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600595E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x0600595F RID: 22879 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005960 RID: 22880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001239")]
		public virtual C Controller
		{
			[Token(Token = "0x600595F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005962 RID: 22882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700123A")]
		public virtual V View
		{
			[Token(Token = "0x6005961")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005962")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005964 RID: 22884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700123B")]
		private AbstractModel Model
		{
			[Token(Token = "0x6005963")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005964")]
			set
			{
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005966 RID: 22886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700123C")]
		private AbstractMVCEvents Events
		{
			[Token(Token = "0x6005965")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005966")]
			set
			{
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005968 RID: 22888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700123D")]
		private AbstractController Controller
		{
			[Token(Token = "0x6005967")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005968")]
			set
			{
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06005969 RID: 22889 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600596A RID: 22890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700123E")]
		private Component View
		{
			[Token(Token = "0x6005969")]
			get
			{
				return null;
			}
			[Token(Token = "0x600596A")]
			set
			{
			}
		}
	}
}
