using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public abstract class ItemViewsHolder<Y> : AbstractItemViewsHolder where Y : MonoBehaviour
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		public override void CollectViews()
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089B")]
		protected ItemViewsHolder()
		{
		}

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x0")]
		protected Y _listElement;
	}
}
