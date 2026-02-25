using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Test;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Dev
{
	// Token: 0x020010B1 RID: 4273
	[Token(Token = "0x20010B1")]
	public class DevMenuUnlocker : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000230 RID: 560
		// (add) Token: 0x06006330 RID: 25392 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006331 RID: 25393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000230")]
		public event Action DevMenuUnlockedEvent
		{
			[Token(Token = "0x6006330")]
			[Address(RVA = "0xAF3C", Offset = "0xAF3C", VA = "0xAF3C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006331")]
			[Address(RVA = "0xAF3D", Offset = "0xAF3D", VA = "0xAF3D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000231 RID: 561
		// (add) Token: 0x06006332 RID: 25394 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006333 RID: 25395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000231")]
		public event Action ClickedEvent
		{
			[Token(Token = "0x6006332")]
			[Address(RVA = "0xAF3E", Offset = "0xAF3E", VA = "0xAF3E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006333")]
			[Address(RVA = "0xAF3F", Offset = "0xAF3F", VA = "0xAF3F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006334")]
		[Address(RVA = "0xAF40", Offset = "0xAF40", VA = "0xAF40")]
		private void Awake()
		{
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006335")]
		[Address(RVA = "0xAF41", Offset = "0xAF41", VA = "0xAF41")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006336")]
		[Address(RVA = "0xAF42", Offset = "0xAF42", VA = "0xAF42")]
		private void ShowDevMenuByConsole()
		{
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006337")]
		[Address(RVA = "0xAF43", Offset = "0xAF43", VA = "0xAF43")]
		private void HideDevMenuByConsole()
		{
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006338")]
		[Address(RVA = "0xAF44", Offset = "0xAF44", VA = "0xAF44", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006339")]
		[Address(RVA = "0xAF45", Offset = "0xAF45", VA = "0xAF45")]
		private void Validate()
		{
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633A")]
		[Address(RVA = "0xAF46", Offset = "0xAF46", VA = "0xAF46")]
		public void Show()
		{
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633B")]
		[Address(RVA = "0xAF47", Offset = "0xAF47", VA = "0xAF47")]
		public void Hide()
		{
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633C")]
		[Address(RVA = "0xAF48", Offset = "0xAF48", VA = "0xAF48")]
		public DevMenuUnlocker()
		{
		}

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DevMenuWindow _devMenuWindow;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		public const float TIME_TO_UNLOCK = 3f;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		public const int NUM_CLICK_TO_UNLOCK = 10;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x1C")]
		private List<float> _clicks;
	}
}
