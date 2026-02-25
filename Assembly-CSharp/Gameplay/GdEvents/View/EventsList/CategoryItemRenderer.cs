using System;
using System.Runtime.CompilerServices;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x2000733")]
	public class CategoryItemRenderer : MonoBehaviour
	{
		// Token: 0x06002BFC RID: 11260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x7C8C", Offset = "0x7C8C", VA = "0x7C8C")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085F")]
		public Action<GdEventData> Callback
		{
			[Token(Token = "0x6002BFD")]
			[Address(RVA = "0x7C8D", Offset = "0x7C8D", VA = "0x7C8D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BFE")]
			[Address(RVA = "0x7C8E", Offset = "0x7C8E", VA = "0x7C8E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x7C8F", Offset = "0x7C8F", VA = "0x7C8F")]
		public void SetData(AbstractGdEventCatData data)
		{
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x7C90", Offset = "0x7C90", VA = "0x7C90")]
		public CategoryItemRenderer()
		{
		}
	}
}
