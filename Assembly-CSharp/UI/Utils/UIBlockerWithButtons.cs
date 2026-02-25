using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Utils
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	public class UIBlockerWithButtons : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x5C90", Offset = "0x5C90", VA = "0x5C90")]
		private void CheckClickPosition(Vector2 clickPosition)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x5C91", Offset = "0x5C91", VA = "0x5C91", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x5C92", Offset = "0x5C92", VA = "0x5C92")]
		public UIBlockerWithButtons()
		{
		}

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button[] _activeButtons;
	}
}
