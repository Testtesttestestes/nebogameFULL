using System;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Model;
using Il2CppDummyDll;

namespace Gameplay.Assistants
{
	// Token: 0x02000CA4 RID: 3236
	[Token(Token = "0x2000CA4")]
	public abstract class Assistant<TModel> : BaseAssistant where TModel : BaseAssistantModel
	{
		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FEF")]
		public virtual TModel Model
		{
			[Token(Token = "0x6004EB7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB8")]
		protected Assistant()
		{
		}
	}
}
