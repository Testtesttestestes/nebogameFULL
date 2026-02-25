using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	public class GuideTargetResolveEventProvider : MonoBehaviour, IGuideTargetResolveEventProvider
	{
		// Token: 0x1400012D RID: 301
		// (add) Token: 0x06001A78 RID: 6776 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001A79 RID: 6777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012D")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x6001A78")]
			[Address(RVA = "0x6C0F", Offset = "0x6C0F", VA = "0x6C0F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001A79")]
			[Address(RVA = "0x6C10", Offset = "0x6C10", VA = "0x6C10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x6C11", Offset = "0x6C11", VA = "0x6C11")]
		public void Invoke()
		{
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x6C12", Offset = "0x6C12", VA = "0x6C12")]
		public GuideTargetResolveEventProvider()
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x6C13", Offset = "0x6C13", VA = "0x6C13", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}
	}
}
