using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UI
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	public class SelectedButton : MonoBehaviourWithStates<SelectedButton.SelectedButtonStates>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x140000CC RID: 204
		// (add) Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008AA RID: 2218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CC")]
		public event EventHandler<PointerEventData> ClickEvent
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x5C38", Offset = "0x5C38", VA = "0x5C38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x5C39", Offset = "0x5C39", VA = "0x5C39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		public bool Selected
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x5C3A", Offset = "0x5C3A", VA = "0x5C3A")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x5C3B", Offset = "0x5C3B", VA = "0x5C3B")]
			set
			{
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x5C3C", Offset = "0x5C3C", VA = "0x5C3C")]
		private void HandleSelectedChanged()
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x5C3D", Offset = "0x5C3D", VA = "0x5C3D", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x5C3E", Offset = "0x5C3E", VA = "0x5C3E")]
		public SelectedButton()
		{
		}

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x20")]
		private bool _selected;

		// Token: 0x02000112 RID: 274
		[Token(Token = "0x2000112")]
		public enum SelectedButtonStates
		{
			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			DEFAULT,
			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			SELECTED
		}
	}
}
