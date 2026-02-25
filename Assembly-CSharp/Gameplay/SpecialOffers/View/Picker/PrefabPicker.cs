using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.SpecialOffers.View.Picker
{
	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20004FF")]
	public abstract class PrefabPicker<T> : MonoBehaviour
	{
		// Token: 0x14000136 RID: 310
		// (add) Token: 0x06001E85 RID: 7813 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001E86 RID: 7814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000136")]
		public event Action<T> SelectionChangedEvent
		{
			[Token(Token = "0x6001E85")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001E86")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001E87 RID: 7815
		[Token(Token = "0x6001E87")]
		public abstract void Init(IList<T> data);

		// Token: 0x06001E88 RID: 7816
		[Token(Token = "0x6001E88")]
		public abstract void ScrollTo(T item);

		// Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E89")]
		protected void SpinnerOnCurrentSelectedIndexChangedEvent(int index)
		{
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8A")]
		protected PrefabPicker()
		{
		}

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x0")]
		protected IList<T> _rawData;
	}
}
