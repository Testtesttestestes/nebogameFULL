using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Utils
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public class MonoPointerClickHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		public event Action<PointerEventData> OnClickEvent
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1BAD", Offset = "0x1BAD", VA = "0x1BAD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x1BA8", Offset = "0x1BA8", VA = "0x1BA8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public event Action<PointerEventData> OnPointerDownEvent
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x5737", Offset = "0x5737", VA = "0x5737")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x5738", Offset = "0x5738", VA = "0x5738")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public event Action<PointerEventData> OnPointerEnterEvent
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x5739", Offset = "0x5739", VA = "0x5739")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x573A", Offset = "0x573A", VA = "0x573A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public event Action<PointerEventData> OnPointerExitEvent
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x573B", Offset = "0x573B", VA = "0x573B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x573C", Offset = "0x573C", VA = "0x573C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x573D", Offset = "0x573D", VA = "0x573D", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x573E", Offset = "0x573E", VA = "0x573E")]
		private void OnDestroy()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x573F", Offset = "0x573F", VA = "0x573F", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x5740", Offset = "0x5740", VA = "0x5740", Slot = "6")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x5741", Offset = "0x5741", VA = "0x5741", Slot = "7")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x5742", Offset = "0x5742", VA = "0x5742")]
		public MonoPointerClickHandler()
		{
		}
	}
}
