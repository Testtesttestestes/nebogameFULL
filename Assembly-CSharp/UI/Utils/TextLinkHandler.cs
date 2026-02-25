using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Utils
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class TextLinkHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x140000D0 RID: 208
		// (add) Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D0")]
		public event EventHandler<TMP_LinkInfo> LinkClickEvent
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x5C8A", Offset = "0x5C8A", VA = "0x5C8A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x5C8B", Offset = "0x5C8B", VA = "0x5C8B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x5C8C", Offset = "0x5C8C", VA = "0x5C8C")]
		public TextMeshProUGUI GetTextField()
		{
			return null;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x5C8D", Offset = "0x5C8D", VA = "0x5C8D", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x5C8E", Offset = "0x5C8E", VA = "0x5C8E", Slot = "5")]
		protected virtual void Handle(TMP_LinkInfo linkInfo)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x5C8F", Offset = "0x5C8F", VA = "0x5C8F")]
		public TextLinkHandler()
		{
		}

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x10")]
		private TextMeshProUGUI _textField;
	}
}
